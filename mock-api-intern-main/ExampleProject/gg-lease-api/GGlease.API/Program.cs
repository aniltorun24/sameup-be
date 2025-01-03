using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using GGlease.Data;
using GGlease.Model.MapperProfiles;
using GGlease.API.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using GGlease.Services.Concrete;
using GGlease.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var debugMode = false;

#if DEBUG
debugMode = true;
#endif

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")
).EnableSensitiveDataLogging(debugMode));
builder.Services.AddAutoMapper(typeof(CurrencyProfile).Assembly);
builder.Services.AddControllers().AddJsonOptions(x => { x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });
builder.Services.AddCoreServices();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "",
        ValidAudience = "",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "GGLease API", Version = "v1" });
    option.EnableAnnotations();
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
builder.Services.AddCors();
var app = builder.Build();

var configuration = app.Services.GetRequiredService<IConfiguration>();
var swaggerEnabled = configuration.GetSection("UseSwagger").Get<bool>();
// Configure the HTTP request pipeline.
if (swaggerEnabled)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
    app.UseHttpsRedirection();


var origins = configuration.GetSection("Origins").Get<List<string>>();
if (origins != null && origins.Any())
    app.UseCors(c => c.WithOrigins(origins.ToArray()).AllowAnyMethod().AllowAnyHeader().AllowCredentials());
app.UseCookieAuthentication();
app.UseAuthentication();
app.RenewAccessTokenIfNeeded();
app.UseAuthorization();

app.MapControllers().RequireAuthorization();

app.Run();