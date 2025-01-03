using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpPost("create")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerOperation(null, "User, Admin")]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserDetailModel), 200)]
        public async Task<IActionResult> Create([FromBody] UserCreateModel model)
        {
            var user = await userService.CreateAsync(model);

            if (!user.Success)
                return BadRequest(user.Error);

            return Ok(user.Data);
        }

        [AllowAnonymous]
        [HttpPost("activate")]
        [SwaggerOperationGuest]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserPasswordResetModel), 200)]
        public async Task<IActionResult> Activate([FromBody] UserPasswordResetModel model)
        {
            var user = await userService.ActivateAsync(model);

            if (!user.Success)
                return BadRequest(user.Error);

            return Ok(user.Data);
        }

        [AllowAnonymous]
        [HttpPost("forgot-password")]
        [SwaggerOperationGuest(captcha: true)]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserPasswordResetRequestModel), 200)]
        public async Task<IActionResult> ForgotPassword([FromBody] UserPasswordResetRequestModel model)
        {
            await userService.ResetPasswordRequestAsync(model);

            //if (user.Fail)
            //    return BadRequest(user.Error);

            return Ok(model);
        }

        [AllowAnonymous]
        [HttpPost("reset-password")]
        [SwaggerOperationGuest]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserPasswordResetModel), 200)]
        public async Task<IActionResult> ResetPassword([FromBody] UserPasswordResetModel model)
        {
            var user = await userService.ResetPasswordAsync(model);

            if (!user.Success)
                return BadRequest(user.Error);

            return Ok(user.Data);
        }

        [HttpPost("change-password")]
        [SwaggerOperationAnyUser]
        [ProducesResponseType(typeof(ErrorModel), 400)]
        [ProducesResponseType(typeof(UserPasswordChangeModel), 200)]
        public async Task<IActionResult> ChangePassword([FromBody] UserPasswordChangeModel model)
        {
            var user = await userService.ChangePasswordAsync(model);

            if (!user.Success)
                return BadRequest(user.Error);

            return Ok(user.Data);
        }
    }
}
