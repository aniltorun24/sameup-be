using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class ApplicationForm : BaseEntity
    {
        public ApplicationForm()
        {
            Offers = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string VKN { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string? Description { get; set; }
        public string? SellerCompanyOther { get; set; } = null!;
        public int? EquipmentSellerCompanyId { get; set; }
        public virtual EquipmentSellerCompany? EquipmentSellerCompany { get; set; } = null!;

        public virtual ICollection<Offer>? Offers { get; set; } = null;
    }
}