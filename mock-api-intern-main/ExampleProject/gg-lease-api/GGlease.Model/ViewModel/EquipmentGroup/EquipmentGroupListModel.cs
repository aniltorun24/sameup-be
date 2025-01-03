using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class EquipmentGroupListModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<BasicModel> Equipments {get; set;} = null!;
    }
}