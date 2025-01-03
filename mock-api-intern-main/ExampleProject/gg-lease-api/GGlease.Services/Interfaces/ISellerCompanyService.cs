using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface ISellerCompanyService
    {
        Task CreateAsync(SellerCompanyCreateModel sellerCompanyCreateModel);
        Task UpdateAsync(SellerCompanyUpdateModel sellerCompanyUpdateModel);
        Task<ValidatedModel<PagedDataModel<SellerCompanyListModel>>> GetAllAsync(SellerCompanySearchModel model);
        Task<ValidatedModel<SellerCompanyDetailModel>> GetDetailAsync(int id);
        Task DeleteAsync(int sellerCompanyId);
    }
}