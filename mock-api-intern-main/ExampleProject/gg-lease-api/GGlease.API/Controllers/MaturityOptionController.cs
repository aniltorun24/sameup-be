using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GGlease.API.Controllers;

[ApiController]
[Route("maturity-option")]
public class MaturityOptionController : ControllerBase
{
    private readonly IMaturityOptionService _maturityOptionService;

    public MaturityOptionController(IMaturityOptionService maturityOptionService)
    {
        _maturityOptionService = maturityOptionService;
    }

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<MaturityOptionModel>>), 200)]
    public async Task<IActionResult> GetMaturityOptionsAsync()
    {
        var result = await _maturityOptionService.GetMaturityOptionsAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }
}