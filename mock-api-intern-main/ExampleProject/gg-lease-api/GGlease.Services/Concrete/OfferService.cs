using AutoMapper;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class OfferService : IOfferService
    {
        private readonly DataContext _dataContext;
        private readonly ICalculatorService _calculatorService;
        private readonly ICurrencyService _currencyService;
        private readonly IMaturityOptionService _maturityOptionService;
        private readonly IMapper _mapper;

        public OfferService(DataContext dataContext, ICalculatorService calculatorService, ICurrencyService currencyService, IMaturityOptionService maturityOptionService, IMapper mapper)
        {
            _dataContext = dataContext;
            _calculatorService = calculatorService;
            _currencyService = currencyService;
            _maturityOptionService = maturityOptionService;
            _mapper = mapper;
        }

        public async Task<ValidatedModel<IEnumerable<OfferGuestViewModel>>> RetrieveOffersForGuestAsync(OfferCalculatorRequestModel requestModel)
        {
            var limit = 3; // max offer count limit
            var financialCompanies = await _dataContext.FinancialCompanies
                .Where(x => x.IsActive)
                .Include(x => x.Rates.Where(r => r.MaturityOptionId==requestModel.MaturityOptionId && r.CurrencyId==requestModel.CurrencyId && r.IsActive && r.RateValue != decimal.Zero))
                .ThenInclude(x=>x.MaturityOption)
                .ToListAsync();
            
            financialCompanies = financialCompanies.Where(x => x.Rates.Count > 0).ToList();

            ICollection<OfferGuestViewModel> offers = new List<OfferGuestViewModel>();
            
            foreach (var item in financialCompanies)
            {
                BasicModel financialCompany = new BasicModel { Id = item.Id, Name = item.Name };

                var rateValue = item.Rates.LastOrDefault();

                if (rateValue == null) continue;

                var calculationModel = new CalculatorCalculationRequestModel()
                {
                    EquipmentValue = requestModel.EquipmentValue,
                    MaturityOptionValue = rateValue.MaturityOption.Value,
                    PaymentValue = requestModel.AdvancePayment,
                    RateValue = rateValue.RateValue
                };

                CalculatorCalculationModel calculation = _calculatorService.CalculateByFormula(calculationModel);

                var offerView = new OfferGuestViewModel() 
                { 
                    FinancialCompany = financialCompany, 
                    MonthlyPaymentValue = calculation.MonthlyPaymentValue, 
                    TotalPaymentValue = calculation.TotalPaymentValue };

                offers.Add(offerView);
            }

            var result = offers.OrderBy(x => x.TotalPaymentValue).Take(limit);
            return new ValidatedModel<IEnumerable<OfferGuestViewModel>>(result);
        }
    }
}