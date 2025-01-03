using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class EquipmentService : IEquipmentService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public EquipmentService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ValidatedModel<IEnumerable<EquipmentAdminListModel>>> GetEquipmentsAsync()
        {
            var equipments = await _dataContext.Equipments.Include(x => x.EquipmentGroup).ToListAsync();
            var equipmentsData = _mapper.Map<IEnumerable<EquipmentAdminListModel>>(equipments);
            return new ValidatedModel<IEnumerable<EquipmentAdminListModel>>(equipmentsData);
        }

        public async Task<ValidatedModel<IEnumerable<BasicModel>>> GetSellerCompaniesOfEquipmentAsync(int equipmentId)
        {
            var companies = await _dataContext.SellerCompanies
                .Include(x=>x.SellerCompanyEquipments)
                .Where(x=>x.SellerCompanyEquipments.Any(x=>x.EquipmentId==equipmentId) && x.IsActive)
                .Select(x=> new BasicModel {
                    Id = x.SellerCompanyEquipments.Where(x=>x.EquipmentId==equipmentId).First().Id,
                    Name=x.Name
                })
                .ToListAsync();
            
            return new ValidatedModel<IEnumerable<BasicModel>>(companies);
        }

        public async Task<ValidatedModel<IEnumerable<BasicModel>>> GetEquipmentsByGroupIdGuestAsync(int groupId)
        {
            var equipments = await _dataContext
                .Equipments
                .Where(x => x.EquipmentGroupId == groupId)
                .OrderBy(x => x.Rank)
                .ToListAsync();
            
            var equipmentsData = _mapper.Map<IEnumerable<BasicModel>>(equipments);

            return new ValidatedModel<IEnumerable<BasicModel>>(equipmentsData);
        }
    }
}