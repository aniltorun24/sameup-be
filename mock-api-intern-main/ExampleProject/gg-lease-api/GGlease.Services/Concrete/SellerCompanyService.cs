using AutoMapper;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Extensions;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class SellerCompanyService : ISellerCompanyService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public SellerCompanyService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task CreateAsync(SellerCompanyCreateModel sellerCompanyCreateModel)
        {
            var cmp = _mapper.Map<SellerCompany>(sellerCompanyCreateModel);
            await _dataContext.SellerCompanies.AddAsync(cmp);
            var result = await _dataContext.SaveChangesAsync();
            foreach (var equipmentId in sellerCompanyCreateModel.EquipmentIds)
            {
                var item = new EquipmentSellerCompany(){
                    EquipmentId = equipmentId,
                    SellerCompanyId = result
                };
                cmp.SellerCompanyEquipments.Add(item);
            }
            _dataContext.SellerCompanies.Update(cmp);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(SellerCompanyUpdateModel sellerCompanyUpdateModel)
        {
            var sellerCompany = await _dataContext.SellerCompanies
                .Where(x => x.Id == sellerCompanyUpdateModel.Id && x.IsActive)
                .Include(x=>x.SellerCompanyEquipments)
                .FirstOrDefaultAsync();
            if (sellerCompany == null) return;
            var equipments = new List<EquipmentSellerCompany>(sellerCompany.SellerCompanyEquipments);

            foreach (var item in equipments)
            {
                if(!sellerCompanyUpdateModel.EquipmentIds.Contains(item.EquipmentId))
                {
                    sellerCompany.SellerCompanyEquipments.Remove(item);
                }
            }
            _dataContext.SellerCompanies.Update(sellerCompany);
            foreach (var equipmentId in sellerCompanyUpdateModel.EquipmentIds)
            {
                if(sellerCompany.SellerCompanyEquipments.Any(x=>x.EquipmentId==equipmentId))
                    continue;
                var item = new EquipmentSellerCompany(){
                    EquipmentId = equipmentId,
                    SellerCompanyId = sellerCompany.Id
                };
                sellerCompany.SellerCompanyEquipments.Add(item);
            }
            
            sellerCompany.ContactName = sellerCompanyUpdateModel.ContactName;
            sellerCompany.ContactPhone = sellerCompanyUpdateModel.ContactPhone;
            sellerCompany.Email = sellerCompanyUpdateModel.Email;
            sellerCompany.Name = sellerCompanyUpdateModel.Name;

            _dataContext.SellerCompanies.Update(sellerCompany);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<ValidatedModel<PagedDataModel<SellerCompanyListModel>>> GetAllAsync(SellerCompanySearchModel model)
        {
            var sellerCompaniesQuery = 
                _dataContext.SellerCompanies
                .Where(x => x.IsActive)
                .WhereIf(model.Filter?.Name != null, x => x.Name.Contains(model.Filter!.Name!));
            
            var itemCount = await sellerCompaniesQuery.CountAsync();
            
            var data = await sellerCompaniesQuery
                .Paginate(model)
                .Include(cmp => cmp.SellerCompanyEquipments)
                .ThenInclude(x => x.Equipment)
                .ThenInclude(x=>x.EquipmentGroup)
                .AsNoTracking()
                .ToListAsync();

            var result = _mapper.Map<IEnumerable<SellerCompanyListModel>>(data);

            var obj = new PagedDataModel<SellerCompanyListModel>
            {
                Data = result,
                PageNo = model.PageNo,
                PageSize = model.PageSize,
                ItemCount = itemCount
            };

            return new ValidatedModel<PagedDataModel<SellerCompanyListModel>>(obj);
        }

        public async Task<ValidatedModel<SellerCompanyDetailModel>> GetDetailAsync(int id)
        {
            var data = await _dataContext.SellerCompanies
                .Include(cmp => cmp.SellerCompanyEquipments)
                .ThenInclude(x => x.Equipment)
                .Select(x => new SellerCompanyDetailModel(){
                    Id = x.Id,
                    ContactName = x.ContactName,
                    ContactPhone = x.ContactPhone,
                     Email = x.Email,
                     Name = x.Name,
                     EquipmentIds = x.SellerCompanyEquipments.Select(x=>x.EquipmentId).ToList()
                })
                .FirstAsync(x => x.Id == id);
            
            return new ValidatedModel<SellerCompanyDetailModel>(data);
        }

        public async Task DeleteAsync(int sellerCompanyId)
        {
            var sellerCompany = await _dataContext.SellerCompanies
                .Where(x => x.Id == sellerCompanyId  && x.IsActive)
                .FirstOrDefaultAsync();
            if (sellerCompany == null) return;
            sellerCompany.IsActive = false;
            _dataContext.SellerCompanies.Update(sellerCompany);
            await _dataContext.SaveChangesAsync();
        }
    }
}