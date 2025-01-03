using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers;

[ApiController]
[Route("offer")]
public class OfferController : ControllerBase
{
    private readonly IOfferService _offerService;

    public OfferController(IOfferService offerService)
    {
        _offerService = offerService;
    }

    [HttpPost]
    [AllowAnonymous]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<OfferGuestViewModel>>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> RetrieveOffers([FromBody] OfferCalculatorRequestModel calculatorRequestModel)
    {
        var result = await _offerService.RetrieveOffersForGuestAsync(calculatorRequestModel);
        return Ok(result);
    }
}