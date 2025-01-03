using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class EquipmentGroupAdminListModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
        public virtual ICollection<BasicModelWithRank> Equipments {get; set;} = null!;
    }
}