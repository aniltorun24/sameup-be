using GGlease.Model.DB.Generic;

namespace GGlease.Model.DB
{
    public class Offer : BaseEntity
    {
        public int Id { get; set; }
        public bool IsAccepted { get; set; } = false;
        public decimal Payment { get; set; } // for Peşinat.
        public decimal EquipmentValue {get; set;}
        public decimal MonthlyPaymentValue { get; set; }
        public decimal TotalPaymentValue { get; set; }
        public decimal RateValue { get; set; }
        public int FinancialCompanyId { get; set; }
        public virtual FinancialCompany FinancialCompany { get; set; } = null!;

        public int MaturityOptionId { get; set; }
        public virtual MaturityOption MaturityOption { get; set; } = null!;

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; } = null!;

        public int ApplicationFormId { get; set; }
        public virtual ApplicationForm ApplicationForm { get; set; } = null!;
    }
}