using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class Equipment : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
        public int EquipmentGroupId {get; set;}
        public virtual EquipmentGroup EquipmentGroup { get; set; } = null!;
    }
}