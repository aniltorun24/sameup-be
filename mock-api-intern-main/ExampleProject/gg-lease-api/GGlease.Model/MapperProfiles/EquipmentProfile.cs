using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<DB.Equipment, ViewModel.EquipmentAdminListModel>();
            CreateMap<DB.Equipment, ViewModel.BasicModel>();
            CreateMap<DB.Equipment, ViewModel.BasicModelWithRank>();
            CreateMap<DB.EquipmentSellerCompany, ViewModel.EquipmentSellerCompanyViewModel>();
            CreateMap<DB.EquipmentSellerCompany, ViewModel.EquipmentGroupDetailModel>();
        }
    }
}