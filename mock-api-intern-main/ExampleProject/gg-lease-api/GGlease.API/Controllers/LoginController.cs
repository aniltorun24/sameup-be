using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GGlease.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IAuthService authService;

        public LoginController(IUserService userService, IAuthService authService)
        {
            this.userService = userService;
            this.authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        [SwaggerOperationGuest(captcha: true)]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserDetailModel), 200)]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var user = await userService.LoginAsync(model);

            if (!user.Success)
                return BadRequest(user.Error);

            var token = authService.WriteToken(user.Data!);

            if (!token.Success)
                return BadRequest(token.Error);

            return Ok(user.Data);
        }
    }
}
