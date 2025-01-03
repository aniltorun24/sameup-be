using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface ICurrencyService
    {
        Task<ValidatedModel<IEnumerable<CurrencyModel>>> GetCurrenciesAsync();
        Task<ValidatedModel<CurrencyModel>> GetByIdAsync(int id);
    }
}