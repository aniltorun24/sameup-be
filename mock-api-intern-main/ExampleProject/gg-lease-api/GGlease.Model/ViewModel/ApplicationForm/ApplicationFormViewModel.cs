namespace GGlease.Model.ViewModel
{
    public class ApplicationFormViewModel 
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string VKN { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string? Description { get; set; }
        public string? SellerCompanyOther { get; set; } = null!;
        public BasicModel SellerCompany { get; set; }
        public BasicModel Equipment { get; set; }
        public BasicModel EquipmentGroup { get; set; }
        public virtual ICollection<OfferViewModel>? Offers { get; set; } = null;
    }
}