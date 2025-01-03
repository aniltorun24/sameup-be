using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class EquipmentGroupCountModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
        public int Count {get; set;}
    }
}