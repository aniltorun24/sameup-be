using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class SellerCompany : BaseEntity
    {
        public SellerCompany()
        {
            SellerCompanyEquipments = new HashSet<EquipmentSellerCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public bool IsActive {get; set;} = true;

        public virtual ICollection<EquipmentSellerCompany> SellerCompanyEquipments { get; set; }
    }
}