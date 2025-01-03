using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;

namespace GGlease.Services.Concrete
{
    public class RateService : IRateService
    {
        private readonly DataContext _dataContext;

        public RateService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ValidatedModel> CreateBulkRateWithParameterAsync(RateCreateModel[] rates, Guid parameterId, int financialCompanyId)
        {
            List<Rate> newRates = new List<Rate>();
            foreach (var item in rates)
            {
                newRates.Add(new Rate()
                {
                    CurrencyId = item.CurrencyId,
                    MaturityOptionId = item.MaturityOptionId,
                    RateValue = item.RateValue,
                    FinancialCompanyId = financialCompanyId
                });
            }
            await _dataContext.Rates.AddRangeAsync(newRates);
            await _dataContext.SaveChangesAsync();

            return new ValidatedModel();
        }
    }
}