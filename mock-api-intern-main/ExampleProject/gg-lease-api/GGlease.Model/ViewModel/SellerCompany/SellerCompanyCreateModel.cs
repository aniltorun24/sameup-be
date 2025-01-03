namespace GGlease.Model.ViewModel
{
    public class SellerCompanyCreateModel
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public List<int> EquipmentIds { get; set; } = null!;
    }
}