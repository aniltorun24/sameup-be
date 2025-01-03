using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGlease.Data;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class CurrencyService : ICurrencyService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public CurrencyService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ValidatedModel<IEnumerable<CurrencyModel>>> GetCurrenciesAsync()
        {
            var list = await _dataContext.Currencies
                .ProjectTo<CurrencyModel>(_mapper.ConfigurationProvider)
                .OrderBy(x=>x.Rank)
                .ToListAsync();

            return new ValidatedModel<IEnumerable<CurrencyModel>>(list);
        }

        public async Task<ValidatedModel<CurrencyModel>> GetByIdAsync(int id)
        {
            var currency = await _dataContext.Currencies
                .Where(x => x.Id == id)
                .ProjectTo<CurrencyModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

            if (currency == null) return new ValidatedModel<CurrencyModel>("Kayıt bulunamadı.");

            return new ValidatedModel<CurrencyModel>(currency);
        }
    }
}