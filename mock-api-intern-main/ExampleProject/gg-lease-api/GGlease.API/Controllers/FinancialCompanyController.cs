using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers;

[ApiController]
[Route("financial-company")]
public class FinancialCompanyController : ControllerBase
{
    private readonly IFinancialCompanyService _financialCompanyService;

    public FinancialCompanyController(IFinancialCompanyService financialCompanyService)
    {
        _financialCompanyService = financialCompanyService;
    }

    [HttpPost]
    [Route("all")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<PagedDataModel<FinancialCompanyModel>>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> GetAll([FromBody] SearchModel model)
    {
        var result = await _financialCompanyService.GetAllAsync(model);    
        return Ok(result);
    }

    [HttpPost]
    [Route("all-by-conversions")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(typeof(ValidatedModel<PagedDataModel<FinancialCompanyByConversionModel>>), 200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> GetAllByConversions([FromBody] SearchModel model)
    {
        var result = await _financialCompanyService.GetAllByConversionsAsync(model);    
        return Ok(result);
    }

    [HttpPost]
    [Route("create")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> Create([FromBody] FinancialCompanyCreateModel financialCompanyCreateModel)
    {
        await _financialCompanyService.CreateAsync(financialCompanyCreateModel);
        return Ok();
    }

    [HttpPut]
    [Route("update")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> Update([FromBody] FinancialCompanyUpdateModel financialCompanyUpdateModel)
    {
        await _financialCompanyService.UpdateAsync(financialCompanyUpdateModel);
        return Ok();
    }

    [HttpPut]
    [Route("toggle-status/{companyId}")]
    [Authorize(Roles = "Admin")]
    [SwaggerOperation(null, "Admin")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ErrorModel), 400)]
    public async Task<IActionResult> ToggleStatus(int companyId)
    {
        await _financialCompanyService.ToggleIsActiveAsync(companyId);
        return Ok();
    }
}