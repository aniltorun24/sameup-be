using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IRateService
    {
        Task<ValidatedModel> CreateBulkRateWithParameterAsync(RateCreateModel[] rates, Guid parameterId, int financialCompanyId);
    }
}