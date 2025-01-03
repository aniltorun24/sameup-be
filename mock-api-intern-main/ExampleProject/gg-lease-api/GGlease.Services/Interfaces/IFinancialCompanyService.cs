using GGlease.Model.DB;
using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IFinancialCompanyService
    {
        Task<ValidatedModel> CreateAsync(FinancialCompanyCreateModel financialCompanyCreateModel);
        Task<ValidatedModel> UpdateAsync(FinancialCompanyUpdateModel financialCompanyUpdateModel);
        Task<ValidatedModel> ToggleIsActiveAsync(int id);
        Task<ValidatedModel<PagedDataModel<FinancialCompanyModel>>> GetAllAsync(SearchModel model);
        Task<ValidatedModel<PagedDataModel<FinancialCompanyByConversionModel>>> GetAllByConversionsAsync(SearchModel model);
    }
}