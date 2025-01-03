using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class CurrencyModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
    }
}