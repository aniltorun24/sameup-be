using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GGlease.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration configuration;

        public AuthService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
        }

        public UserDetailModel? CurrentUser => GetCurrentUser();

        public ValidatedModel<UserDetailModel> WriteToken(UserDetailModel user)
        {
            var key = configuration.GetValue<string>("Jwt:Key");
            var token = BuildToken(key, user);

            var context = httpContextAccessor.HttpContext;

            if (context == null)
                return new ValidatedModel<UserDetailModel>("Geçersiz işlem");

            context.Response.Cookies.Append("access-token", token, new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.None,
                Secure = true
            });

            context.Response.Headers["X-Access-Token"] = token;

            return new ValidatedModel<UserDetailModel>(user);
        }

        private static string BuildToken(string key, UserDetailModel user)
        {
            var claims = new[] {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, $"{user.Role}"),
                new Claim(ClaimTypes.NameIdentifier, $"{user.Id}"),
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(claims: claims, expires: DateTime.UtcNow.AddHours(1), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        private UserDetailModel? GetCurrentUser()
        {
            var user = httpContextAccessor.HttpContext?.User;
            var identity = user?.Identity;

            if (identity == null || !identity.IsAuthenticated) return null;

            var name = user?.FindFirst(ClaimTypes.Name)?.Value;
            var email = user?.FindFirst(ClaimTypes.Email)?.Value;
            var role = user?.FindFirst(ClaimTypes.Role)?.Value;
            var identifier = user?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (name == null || email == null || identifier == null)
                return null;

            if (!int.TryParse(identifier, out int id) || !Enum.TryParse<Model.Enums.UserRole>(role, out var userRole))
                return null;

            var result = new UserDetailModel
            {
                Id = id,
                Name = name,
                Email = email,
                Role = $"{userRole}",
            };

            return result;
        }

        public void RemoveToken()
        {

            var context = httpContextAccessor.HttpContext;

            if (context == null)
                return;

            context.Response.Cookies.Append("access-token", "", new CookieOptions
            {
                HttpOnly = true,
                Path = "/",
                SameSite = SameSiteMode.Strict,
                Expires = DateTimeOffset.Now.AddDays(-10)
            });
        }
    }
}
