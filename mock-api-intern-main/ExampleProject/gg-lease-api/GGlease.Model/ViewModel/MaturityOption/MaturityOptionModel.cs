using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class MaturityOptionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public int Rank { get; set; } = 0;
    }
}