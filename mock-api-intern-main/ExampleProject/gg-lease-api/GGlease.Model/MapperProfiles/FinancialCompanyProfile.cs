using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class FinancialCompanyProfile : Profile
    {
        public FinancialCompanyProfile()
        {
            CreateMap<ViewModel.FinancialCompanyCreateModel, DB.FinancialCompany>();
            CreateMap<DB.FinancialCompany, ViewModel.BasicModel>();
            CreateMap<DB.FinancialCompany, ViewModel.FinancialCompanyModel>();
            CreateMap<DB.FinancialCompany, ViewModel.FinancialCompanyModel>().ReverseMap();
            CreateMap<DB.FinancialCompany, ViewModel.FinancialCompanyCreateModel>().ReverseMap();
        }
    }
}