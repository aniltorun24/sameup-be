using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class RateProfile : Profile
    {
        public RateProfile()
        {
            CreateMap<ViewModel.RateCreateModel, DB.Rate>();
            CreateMap<DB.Rate, ViewModel.RateCreateModel>();
            CreateMap<DB.Rate,ViewModel.RateViewModel>();
        }
    }
}