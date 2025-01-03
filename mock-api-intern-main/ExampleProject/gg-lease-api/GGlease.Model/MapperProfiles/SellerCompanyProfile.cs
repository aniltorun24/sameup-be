using AutoMapper;
using GGlease.Model.ViewModel;

namespace GGlease.Model.MapperProfiles
{
    public class SellerCompanyProfile : Profile
    {
        public SellerCompanyProfile()
        {
            CreateMap<DB.SellerCompany, ViewModel.SellerCompanyListModel>()
                .ForMember(dest => dest.EquipmentGroups,
                    opt => opt.MapFrom(x =>
                        x.SellerCompanyEquipments
                            .GroupBy(y => y.Equipment.EquipmentGroupId)
                            .Select(x => new {
                                equipmentGroup = x.First().Equipment.EquipmentGroup,
                                equipmentGroupCount = x.Count()
                            })
                            .Select(group => new EquipmentGroupCountModel()
                            {
                                    Id = group.equipmentGroup.Id,
                                    Name = group.equipmentGroup.Name,
                                    Count = group.equipmentGroupCount,
                                    Rank = group.equipmentGroup.Rank
                            })
                            .OrderBy(x => x.Rank)
                            .ToList()
                ));

            CreateMap<DB.SellerCompany, ViewModel.SellerCompanyDetailModel>();
            CreateMap<DB.SellerCompany, ViewModel.BasicModel>();
            CreateMap<DB.SellerCompany, ViewModel.BasicModel[]>();
            CreateMap<ViewModel.SellerCompanyCreateModel, DB.SellerCompany>();
            CreateMap<ViewModel.SellerCompanyUpdateModel, DB.SellerCompany>();
        }
    }
}