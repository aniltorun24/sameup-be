using AutoMapper;

namespace GGlease.Model.MapperProfiles
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<DB.Currency, ViewModel.CurrencyModel>();
        }
    }
}