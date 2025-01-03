using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GGlease.API.Controllers;

[ApiController]
[Route("currency")]
public class CurrencyController : ControllerBase
{
    private readonly ICurrencyService _currencyService;

    public CurrencyController(ICurrencyService currencyService)
    {
        _currencyService = currencyService;
    }

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<CurrencyModel>>), 200)]
    public async Task<IActionResult> GetCurrenciesAsync()
    {
        var result = await _currencyService.GetCurrenciesAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }
}