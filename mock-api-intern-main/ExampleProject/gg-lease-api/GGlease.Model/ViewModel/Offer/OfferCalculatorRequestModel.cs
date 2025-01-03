namespace GGlease.Model.ViewModel
{
    public class OfferCalculatorRequestModel
    {
        public decimal AdvancePayment { get; set; } //Peşinat tutarı.
        public decimal EquipmentValue { get; set; } //Ekipman tutarı
        public int CurrencyId { get; set; } //Döviz cinsi
        public int MaturityOptionId { get; set; } //Vade
    }
}