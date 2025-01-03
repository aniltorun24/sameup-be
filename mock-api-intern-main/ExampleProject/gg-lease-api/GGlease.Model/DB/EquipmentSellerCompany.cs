using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class EquipmentSellerCompany : BaseEntity
    {
        public int Id { get; set; }

        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; } = null!;

        public int SellerCompanyId { get; set; }
        public virtual SellerCompany SellerCompany { get; set; } = null!;

        public ICollection<ApplicationForm> ApplicationForms { get; set; } = null!;
    }
}