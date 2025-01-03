using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class EquipmentGroupDetailModel
    {
        public int GroupId { get; set; }
        public virtual ICollection<int> EquipmentIds {get; set;} = null!;
    }
}