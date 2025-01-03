using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GGlease.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        private readonly IAuthService authService;

        public LogoutController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpGet]
        [SwaggerOperationAnyUser]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            authService.RemoveToken();

            return Ok();
        }
    }
}
