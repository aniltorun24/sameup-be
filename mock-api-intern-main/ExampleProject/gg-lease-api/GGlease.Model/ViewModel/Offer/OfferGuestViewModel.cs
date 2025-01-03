namespace GGlease.Model.ViewModel
{
    public class OfferGuestViewModel
    {
        public BasicModel FinancialCompany { get; set; } = null!;
        public decimal MonthlyPaymentValue { get; set; }
        public decimal TotalPaymentValue { get; set; }
        public bool IsAccepted{get;set;} = false;
    }
}