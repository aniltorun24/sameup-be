using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class EquipmentGroupService : IEquipmentGroupService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public EquipmentGroupService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ValidatedModel<IEnumerable<EquipmentGroupAdminListModel>>> GeAllAsync()
        {
            var equipmentGroups = await _dataContext.EquipmentGroups.Include(x => x.Equipments).OrderBy(x => x.Rank).ToListAsync();
            var equipmentData = _mapper.Map<IEnumerable<EquipmentGroupAdminListModel>>(equipmentGroups);
            return new ValidatedModel<IEnumerable<EquipmentGroupAdminListModel>>(equipmentData);
        }

        public async Task<ValidatedModel<IEnumerable<BasicModel>>> GetAllGuestAsync()
        {
            var equipmentGroups = await _dataContext
                .EquipmentGroups
                .Include(x => x.Equipments)
                .OrderBy(x => x.Rank)
                .ToListAsync();

            var equipmentData = _mapper.Map<IEnumerable<BasicModel>>(equipmentGroups);
            return new ValidatedModel<IEnumerable<BasicModel>>(equipmentData);
        }

        public async Task<ValidatedModel<IEnumerable<EquipmentGroupListModel>>> GetAllWithEquipmentsGuestAsync()
        {
            var equipmentGroups = await _dataContext
                .EquipmentGroups
                .Include(x => x.Equipments)
                .OrderBy(x => x.Rank)
                .ToListAsync();

            var equipmentData = _mapper.Map<IEnumerable<EquipmentGroupListModel>>(equipmentGroups);
            return new ValidatedModel<IEnumerable<EquipmentGroupListModel>>(equipmentData);
        }

        public async Task OrderRanksByNameAlphebetically()
        {
            var baseData = await _dataContext
                .Equipments
                .Include(x => x.EquipmentGroup)
                .ToListAsync();

            var data =
                baseData
                .GroupBy(x => x.EquipmentGroup)
                .SelectMany(x =>
                    x.OrderBy(x => x.Name)
                    .Select((x, index) =>
                    {
                        if (x.Id >= 9999)
                        {
                            return new
                            {
                                Id = x.Id,
                                Rank = x.Id
                            };
                        }

                        return new
                        {
                            Id = x.Id,
                            Rank = index
                        };
                    })
                    .ToList()
                ).ToList();

            foreach (var item in baseData)
            {
                var rankData = data.Find(x => x.Id == item.Id);
                if (rankData != null)
                {
                    item.Rank = rankData.Rank;
                }
            }

            await _dataContext.SaveChangesAsync();

            var equipmentGroups = await _dataContext.EquipmentGroups.OrderBy(x => x.Name).ToListAsync();
            var i = 0;
            foreach (var item in equipmentGroups)
            {
                if(item.Id >= 9999){
                    item.Rank = item.Id;
                } else {
                    item.Rank = i;
                }
                i++;
            }
            
            await _dataContext.SaveChangesAsync();
        }
    }
}