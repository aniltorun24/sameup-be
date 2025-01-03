using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GGlease.API.Controllers;

[ApiController]
[Route("equipment")]
public class EquipmentController : ControllerBase
{
    private readonly IEquipmentService _equipmentService;

    public EquipmentController(IEquipmentService equipmentService)
    {
        _equipmentService = equipmentService;
    }

    [HttpGet("all")]
    [Authorize(Roles = "Admin")]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<Model.DB.EquipmentGroup>>), 200)]
    public async Task<IActionResult> GetEquipmentsAsync()
    {
        var result = await _equipmentService.GetEquipmentsAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }

    [HttpGet("guest-all/{id}")]
    [AllowAnonymous]
    [SwaggerOperationGuest(captcha: true)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<BasicModel>>), 200)]
    public async Task<IActionResult> GetEquipmentsGuestAsync(int id)
    {
        var result = await _equipmentService.GetEquipmentsByGroupIdGuestAsync(id);
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }

    [HttpGet("{equipmentId}/sellers")]
    [AllowAnonymous]
    [SwaggerOperationGuest(captcha: true)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<BasicModel>>), 200)]
    public async Task<IActionResult> GetSellersOfEquipmentAsync(int equipmentId)
    {
        var result = await _equipmentService.GetSellerCompaniesOfEquipmentAsync(equipmentId);
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }
}
