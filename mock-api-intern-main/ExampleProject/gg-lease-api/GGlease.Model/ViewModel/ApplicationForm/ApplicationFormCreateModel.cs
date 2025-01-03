
namespace GGlease.Model.ViewModel
{
    public class ApplicationFormCreateModel
    {
        public int? EquipmentSellerCompanyId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string VKN { get; set; } = null!;
        public string Company { get; set;} = null!;

        public string? Description { get; set; }
        public string? SellerCompanyOther { get; set; } = null!;

        public OfferCalculatorRequestModel? CalculationParameters { get; set; }
        public ICollection<OfferApplicationFormCreateModel>? Offers { get; set; }
    }
}