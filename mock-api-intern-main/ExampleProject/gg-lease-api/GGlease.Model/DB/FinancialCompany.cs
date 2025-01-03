using GGlease.Model.DB.Generic;
using GGlease.Model.ViewModel;

namespace GGlease.Model.DB
{
    public class FinancialCompany : BaseEntity
    {
        public FinancialCompany()
        {
            Rates = new HashSet<Rate>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}