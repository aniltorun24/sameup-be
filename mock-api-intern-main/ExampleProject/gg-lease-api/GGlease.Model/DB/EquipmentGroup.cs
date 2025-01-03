using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class EquipmentGroup : BaseEntity
    {
        public EquipmentGroup()
        {
            Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
        public virtual ICollection<Equipment> Equipments {get;set;}
    }
}