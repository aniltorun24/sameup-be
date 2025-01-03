
namespace GGlease.Model.ViewModel;

public class ApplicationFormAdminMailModel
{
  public string MainCategory { get; set; } = null!; // BİLGİ İŞLEM VE BÜRO SİSTEMLERİ
  public string SubCategory { get; set; } = null!; //BİLGİSAYAR YAZILIM
  public string SellerCompany { get; set; } = null!; // ABK TEKNİK İMALAT VE MÜH ÇÖZÜMLERİ LTD.ŞTİ
  public string NameSurname { get; set; } = null!; // Tarık Kılıçkaya
  public string Email { get; set; } = null!; // tarikkilickaya@sameup.co
  public string Phone { get; set; } = null!; // 5468531918;
  public string CompanyName { get; set; } = null!; // SameUp
  public string CompanyVKN { get; set; } = null!; // 1234567890
  public string Description { get; set; } = null!; // Test
  public string OfferCompanyId { get; set; } = null!; // Özel Teklif - ID (Burada finansal kuruluşun ID'sini göstermeliyiz.)
  public string OfferCompanyEquipmentValueWithCurrency { get; set; } = null!; // 15.000,00 USD
  public string OfferCompanyMonthlyPaymentValueWithCurrency { get; set; } = null!; // 499,67 USD
  public string OfferCompanyMaturityOption { get; set; } = null!; // 36 Ay
  public string OfferCompanyTotalPaymentValueWithCurrency { get; set; } = null!; // 17.998,27 USD
}
