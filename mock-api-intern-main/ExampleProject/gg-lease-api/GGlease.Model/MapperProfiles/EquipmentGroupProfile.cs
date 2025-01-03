using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class EquipmentGroupProfile : Profile
    {
        public EquipmentGroupProfile()
        {
            CreateMap<DB.EquipmentGroup, ViewModel.BasicModel>();
            CreateMap<DB.EquipmentGroup, ViewModel.BasicModelWithRank>();
            CreateMap<DB.EquipmentGroup, ViewModel.EquipmentGroupListModel>()
                .ForMember(x => x.Equipments, opt => opt.MapFrom(x => x.Equipments.OrderBy(x => x.Rank).ToList()));
            CreateMap<DB.EquipmentGroup, ViewModel.EquipmentGroupAdminListModel>()
                .ForMember(x => x.Equipments, opt => opt.MapFrom(x => x.Equipments.OrderBy(x => x.Rank).ToList()));
        }
    }
}