using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IMaturityOptionService
    {
        Task<ValidatedModel<IEnumerable<MaturityOptionModel>>> GetMaturityOptionsAsync();
        Task<ValidatedModel<MaturityOptionModel>> GetByIdAsync(int id);
    }
}