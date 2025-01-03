using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IApplicationFormService
    {
        Task<ValidatedModel<int>> CreateAsync(ApplicationFormCreateModel applicationFormCreateModel);
        Task<ValidatedModel<PagedDataModel<ApplicationFormViewModel>>> AllAsync(SearchModel model);
    }
}