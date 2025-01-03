using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class Rate: BaseEntity
    {
        public int Id { get; set; }
        public decimal RateValue { get; set; }
        public int FinancialCompanyId { get; set; }
        public virtual FinancialCompany FinancialCompany { get; set; } = null!;
        public int MaturityOptionId { get; set; }
        public virtual MaturityOption MaturityOption { get; set; } = null!;
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}