using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class Currency: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Rank { get; set; } = 0;
    }
}