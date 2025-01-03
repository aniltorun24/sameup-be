using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class MaturityOption : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public int Rank { get; set; } = 0;
    }
}