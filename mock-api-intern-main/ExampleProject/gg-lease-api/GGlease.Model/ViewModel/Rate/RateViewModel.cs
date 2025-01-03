namespace GGlease.Model.ViewModel
{
    public class RateViewModel
    {
        public int Id{get;set;}
        public int CurrencyId { get; set; }
        public int MaturityOptionId { get; set; }
        public decimal RateValue { get; set; }
        public bool IsActive { get; set; } = true;
    }
}