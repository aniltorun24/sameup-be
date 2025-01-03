using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class MaturityOptionProfile : Profile
    {
        public MaturityOptionProfile()
        {
            CreateMap<DB.MaturityOption, ViewModel.MaturityOptionModel>();
        }
    }
}