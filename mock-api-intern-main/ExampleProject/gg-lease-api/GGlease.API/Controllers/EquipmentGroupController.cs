using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers;

[ApiController]
[Route("equipment-group")]
public class EquipmentGroupController : ControllerBase
{
    private readonly IEquipmentGroupService _equipmentGroupService;

    public EquipmentGroupController(IEquipmentGroupService equipmentGroupService)
    {
        _equipmentGroupService = equipmentGroupService;
    }

    [HttpGet("all")]
    [Authorize(Roles = "Admin")]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<Model.DB.EquipmentGroup>>), 200)]
    public async Task<IActionResult> GetEquipmentGroupsAsync()
    {
        var result = await _equipmentGroupService.GeAllAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }

    [HttpGet("guest-all")]
    [AllowAnonymous]
    [SwaggerOperationGuest(captcha: true)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<BasicModel>>), 200)]
    public async Task<IActionResult> GetEquipmentGroupsGuestAsync()
    {
        var result = await _equipmentGroupService.GetAllGuestAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }

    [HttpGet("guest-all-with-equipments")]
    [AllowAnonymous]
    [SwaggerOperationGuest(captcha: true)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    [ProducesResponseType(typeof(ValidatedModel<IEnumerable<EquipmentGroupListModel>>), 200)]
    public async Task<IActionResult> GetEquipmentGroupsWithEquipmentsGuestAsync()
    {
        var result = await _equipmentGroupService.GetAllWithEquipmentsGuestAsync();
        if (!result.Success)
        {
            return BadRequest(result.Error);
        }
        return Ok(result);
    }

    [HttpGet("update-ranks")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateRanks()
    {
        await _equipmentGroupService.OrderRanksByNameAlphebetically();    
        return Ok();
    }
}
