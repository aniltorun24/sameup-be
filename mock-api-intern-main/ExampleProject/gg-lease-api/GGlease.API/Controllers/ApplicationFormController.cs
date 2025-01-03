using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers;

[ApiController]
[Route("application-form")]
public class ApplicationFormController : ControllerBase
{
    private readonly IApplicationFormService _applicationFormService;

    public ApplicationFormController(IApplicationFormService applicationFormService)
    {
        _applicationFormService = applicationFormService;
    }

    [HttpPost]
    [Route("all")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<PagedDataModel<ApplicationFormViewModel>>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> GetAll([FromBody] SearchModel model)
    {
        var result = await _applicationFormService.AllAsync(model);    
        return Ok(result);
    }

    [HttpPost]
    [AllowAnonymous]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [Route("apply")]
    public async Task<IActionResult> Create(ApplicationFormCreateModel applicationFormCreateModel)
    {
        var result = await _applicationFormService.CreateAsync(applicationFormCreateModel);
        if (!result.Success)
            return BadRequest(result.Error);

        return Ok();
    }
}