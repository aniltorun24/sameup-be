using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class FinancialCompanyModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<RateViewModel> Rates { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}