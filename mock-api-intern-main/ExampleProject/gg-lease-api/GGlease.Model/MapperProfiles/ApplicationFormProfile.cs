using System.Globalization;
using AutoMapper;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;

namespace GGlease.Model.MapperProfiles
{
    public class ApplicationFormProfile : Profile
    {
        private static string FormatDecimal(decimal value)
        {
            return value.ToString("n2", CultureInfo.GetCultureInfo("tr-TR"));
        }

        public ApplicationFormProfile()
        {
            CreateMap<ViewModel.ApplicationFormCreateModel, DB.ApplicationForm>().ForMember(x => x.Offers, opt => opt.Ignore());
            CreateMap<DB.ApplicationForm, ViewModel.ApplicationFormViewModel>()
            .ForMember(x => x.SellerCompany, x => x.MapFrom(m => new BasicModel
            {
                Id = m.EquipmentSellerCompany.SellerCompanyId,
                Name = m.EquipmentSellerCompany.SellerCompany.Name
            }))
            .ForMember(x => x.Equipment, x => x.MapFrom(m => new BasicModel
            {
                Id = m.EquipmentSellerCompany.EquipmentId,
                Name = m.EquipmentSellerCompany.Equipment.Name
            }))
            .ForMember(x => x.EquipmentGroup, x => x.MapFrom(m => new BasicModel
            {
                Id = m.EquipmentSellerCompany.Equipment.EquipmentGroupId,
                Name = m.EquipmentSellerCompany.Equipment.EquipmentGroup.Name
            }));
            CreateMap<DB.Offer, ViewModel.OfferViewModel>();

            CreateMap<ApplicationForm, ViewModel.ApplicationFormAdminMailModel>()
                .ForMember(x => x.NameSurname, x => x.MapFrom(y => y.FullName ?? "-"))
                .ForMember(x => x.Email, x => x.MapFrom(y => y.Email ?? "-"))
                .ForMember(x => x.Phone, x => x.MapFrom(y => y.Phone ?? "-"))
                .ForMember(x => x.CompanyName, x => x.MapFrom(y => y.Company ?? "-"))
                .ForMember(x => x.CompanyVKN, x => x.MapFrom(y => y.VKN ?? "-"))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description ?? "-"))
                .ForMember(x => x.SellerCompany, x => x.MapFrom(y => y.EquipmentSellerCompany != null ? y.EquipmentSellerCompany.SellerCompany.Name + (!String.IsNullOrEmpty(y.SellerCompanyOther) ? " - " + y.SellerCompanyOther : "")   : "-" ))
                .ForMember(x => x.MainCategory, x => x.MapFrom(y => y.EquipmentSellerCompany != null ? y.EquipmentSellerCompany.Equipment.EquipmentGroup.Name : "-"))
                .ForMember(x => x.SubCategory, x => x.MapFrom(y => y.EquipmentSellerCompany != null ? y.EquipmentSellerCompany.Equipment.Name : "-"))
                .ForMember(x => x.OfferCompanyId, x => x.MapFrom(y => 
                    y.Offers != null && y.Offers.FirstOrDefault(x => x.IsAccepted == true) == null ? "-": 
                    "Özel Teklif - " + y.Offers!.First(x => x.IsAccepted == true).FinancialCompanyId.ToString())
                )
                .ForMember(x => x.OfferCompanyMaturityOption, x => x.MapFrom(y => y.Offers.FirstOrDefault(x => x.IsAccepted == true).MaturityOption.Name ?? "-"))
                .ForMember(x => x.OfferCompanyEquipmentValueWithCurrency, x => x.MapFrom(y =>
                    y.Offers != null && y.Offers.FirstOrDefault(x => x.IsAccepted) == null ? "-" : FormatDecimal(y.Offers!.First(x => x.IsAccepted).EquipmentValue) + " "+y.Offers!.First(x => x.IsAccepted).Currency.Name
                ))
                .ForMember(x => x.OfferCompanyMonthlyPaymentValueWithCurrency, x => x.MapFrom(y =>
                    y.Offers != null && y.Offers.FirstOrDefault(x => x.IsAccepted) == null ? "-" : FormatDecimal(y.Offers!.First(x => x.IsAccepted).MonthlyPaymentValue) + " "+y.Offers!.First(x => x.IsAccepted).Currency.Name
                ))
                .ForMember(x => x.OfferCompanyTotalPaymentValueWithCurrency, x => x.MapFrom(y =>
                    y.Offers != null && y.Offers.FirstOrDefault(x => x.IsAccepted) == null ? "-" : FormatDecimal(y.Offers!.First(x => x.IsAccepted).TotalPaymentValue) + " "+y.Offers!.First(x => x.IsAccepted).Currency.Name
                ))
                ;
        }
    }
}