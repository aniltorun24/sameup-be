using System.Diagnostics;
using AutoMapper;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class FinancialCompanyService : IFinancialCompanyService
    {
        private readonly DataContext _dataContext;
        private readonly IRateService _rateService;
        private readonly IMapper _mapper;

        public FinancialCompanyService(IMapper mapper, DataContext dataContext, IRateService rateService)
        {
            _dataContext = dataContext;
            _rateService = rateService;
            _mapper = mapper;
        }

        public async Task<ValidatedModel<PagedDataModel<FinancialCompanyModel>>> GetAllAsync(SearchModel model)
        {
            var itemCount = await _dataContext.FinancialCompanies.CountAsync();
            var financialCompanies = await _dataContext.FinancialCompanies
                .Where(x=>x.IsActive)
                .Include(cmp=>cmp.Rates.Where(rate=>rate.IsActive))
                .Skip(model.RowIndex)
                .Take(model.PageSize)
                .ToListAsync();
            
            var result = _mapper.Map<IEnumerable<FinancialCompanyModel>>(financialCompanies);

            var obj = new PagedDataModel<FinancialCompanyModel>
            {
                Data = result,
                PageNo = model.PageNo,
                PageSize = model.PageSize,
                ItemCount = itemCount
            };

            return new ValidatedModel<PagedDataModel<FinancialCompanyModel>>(obj);
        }
        public async Task<ValidatedModel<PagedDataModel<FinancialCompanyByConversionModel>>> GetAllByConversionsAsync(SearchModel model)
        {
            var itemCount = await _dataContext.FinancialCompanies.CountAsync();
            var financialCompanies = await _dataContext.FinancialCompanies
                .Where(x=>x.IsActive)
                .Include(cmp=>cmp.Offers)
                .OrderByDescending(x=>x.Offers.Count(x=>x.IsAccepted))
                .AsNoTracking()
                .Skip(model.RowIndex)
                .Take(model.PageSize)
                .ToListAsync();

            var result = financialCompanies.Select(x=>new FinancialCompanyByConversionModel{
                Id=x.Id,
                IsActive = x.IsActive,
                Name = x.Name,
                TotalConversions = x.Offers.Count(x=>x.IsAccepted),
                TotalView = x.Offers.Count
            }).ToList();

            var obj = new PagedDataModel<FinancialCompanyByConversionModel>
            {
                Data = result,
                PageNo = model.PageNo,
                PageSize = model.PageSize,
                ItemCount = itemCount
            };

            return new ValidatedModel<PagedDataModel<FinancialCompanyByConversionModel>>(obj);
        }
        public async Task<ValidatedModel> CreateAsync(FinancialCompanyCreateModel financialCompanyCreateModel)
        {
            FinancialCompany result = null;
            try
            {
                result = _mapper.Map<FinancialCompanyCreateModel,FinancialCompany>(financialCompanyCreateModel);
            
            }
            catch(Exception ex){
                Debug.WriteLine(ex);
            }
            await _dataContext.FinancialCompanies.AddAsync(result);
            await _dataContext.SaveChangesAsync();
            return new ValidatedModel();
        }

        public async Task<ValidatedModel> UpdateAsync(FinancialCompanyUpdateModel financialCompanyUpdateModel)
        {
            var financialCompany = await _dataContext.FinancialCompanies.Where(x => x.Id == financialCompanyUpdateModel.Id)
                .Include(x=>x.Rates.Where(rate=>rate.IsActive))
                .FirstOrDefaultAsync();
            if (financialCompany == null) return new ValidatedModel("İşlem başarısız.");

            foreach (var rate in financialCompany.Rates)
            {
                rate.IsActive = false;
            }

            foreach (var rateWillBeAppend in financialCompanyUpdateModel.Rates)
            {
                var rate = _mapper.Map<RateCreateModel,Rate>(rateWillBeAppend);
                financialCompany.Rates.Add(rate);
            }
            financialCompany.Name = financialCompanyUpdateModel.Name;
            financialCompany.UpdatedOn = DateTime.UtcNow;
            await _dataContext.SaveChangesAsync();
            return new ValidatedModel();
        }

        public async Task<ValidatedModel> ToggleIsActiveAsync(int id)
        {
            var financialCompany = await _dataContext.FinancialCompanies
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (financialCompany == null) return new ValidatedModel("İşlem başarısız");

            financialCompany.IsActive = !financialCompany.IsActive;
            await _dataContext.SaveChangesAsync();

            return new ValidatedModel();
        }
    }
}