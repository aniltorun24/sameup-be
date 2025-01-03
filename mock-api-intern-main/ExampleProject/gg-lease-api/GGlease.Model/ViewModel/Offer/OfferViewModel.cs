namespace GGlease.Model.ViewModel
{
    public class OfferViewModel
    {
        public decimal MonthlyPaymentValue { get; set; }
        public decimal TotalPaymentValue { get; set; }
        public decimal EquipmentValue { get; set; }
        public decimal Payment {get;set;}
        public MaturityOptionModel MaturityOption {get;set;}
        public bool IsAccepted { get; set; }
        public BasicModel FinancialCompany {get; set;}
        public CurrencyModel Currency {get;set;}
    }
}