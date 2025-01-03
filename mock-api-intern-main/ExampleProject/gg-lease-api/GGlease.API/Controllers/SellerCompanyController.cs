using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers;

[ApiController]
[Route("seller-company")]
public class SellerCompanyController : ControllerBase
{
    private readonly ISellerCompanyService _sellerCompanyService;

    public SellerCompanyController(ISellerCompanyService sellerCompanyService)
    {
        _sellerCompanyService = sellerCompanyService;
    }

    [HttpPost]
    [Route("create")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> Create([FromBody] SellerCompanyCreateModel sellerCompanyCreateModel)
    {
        await _sellerCompanyService.CreateAsync(sellerCompanyCreateModel);
        return Ok();
    }

    [HttpPut]
    [Route("update")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> Update([FromBody] SellerCompanyUpdateModel sellerCompanyUpdateModel)
    {
        await _sellerCompanyService.UpdateAsync(sellerCompanyUpdateModel);
        return Ok();
    }

    [HttpPost]
    [Route("all")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<PagedDataModel<SellerCompanyListModel>>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> GetAll([FromBody] SellerCompanySearchModel model)
    {
        var result = await _sellerCompanyService.GetAllAsync(model);    
        return Ok(result);
    }

    [HttpGet]
    [Route("detail/{sellerCompanyId}")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<SellerCompanyDetailModel>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> GetDetail(int sellerCompanyId)
    {
        var result = await _sellerCompanyService.GetDetailAsync(sellerCompanyId);    
        return Ok(result);
    }

    [HttpDelete]
    [Route("{sellerCompanyId}")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> Delete(int sellerCompanyId)
    {
        await _sellerCompanyService.DeleteAsync(sellerCompanyId);
        return Ok();
    }
}