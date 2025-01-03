using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class SellerCompanyListModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public virtual ICollection<EquipmentGroupCountModel> EquipmentGroups { get; set; } = null!;
    }
}