using GGlease.Services.Interfaces;

namespace GGlease.API.Configurations
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseCookieAuthentication(this IApplicationBuilder app)
        {
            app.Use((context, next) =>
            {
                if (context.Request.Cookies.TryGetValue("access-token", out var token))
                {
                    context.Request.Headers.Authorization = $"Bearer {token}";
                }

                return next();
            });

            return app;
        }

        public static IApplicationBuilder RenewAccessTokenIfNeeded(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                var claim = context.User?.FindFirst("exp")?.Value;

                if (claim != null && long.TryParse(claim, out var seconds))
                {
                    var expirationDate = DateTimeOffset.FromUnixTimeSeconds(seconds);
                    var remainingTime = expirationDate - DateTimeOffset.UtcNow;

                    if (remainingTime.TotalMinutes < 5)
                    {
                        var authService = context.RequestServices.GetRequiredService<IAuthService>();

                        if (authService.CurrentUser != null)
                        {
                            authService.WriteToken(authService.CurrentUser);
                        }
                    }
                }

                await next();
            });

            return app;
        }

        public static IApplicationBuilder UseGlobalErrorHandling(this IApplicationBuilder app)
        {
            var logger = app.ApplicationServices.GetRequiredService<ILogger<Program>>();

            app.Use(async (context, next) =>
            {
                try
                {
                    await next();
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Unhandled Error Occured: {message}", ex.Message);

                    context.Response.Clear();
                    context.Response.StatusCode = 500;
                }
            });

            return app;
        }
    }
}
