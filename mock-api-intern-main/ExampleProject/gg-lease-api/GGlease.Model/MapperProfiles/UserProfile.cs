using AutoMapper;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;

namespace GGlease.Model.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDetailModel>();
        }
    }
}
