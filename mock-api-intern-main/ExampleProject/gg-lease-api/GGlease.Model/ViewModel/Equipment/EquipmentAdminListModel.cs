namespace GGlease.Model.ViewModel
{
    public class EquipmentAdminListModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
        public BasicModel EquipmentGroup {get; set;}  = null!;
    }
}
