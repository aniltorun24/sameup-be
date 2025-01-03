namespace GGlease.Model.ViewModel
{
  public class SellerCompanySearchModel : SearchModel
    {
        public SellerCompanySearchFilterModel? Filter { get; set; }
    }

    public class SellerCompanySearchFilterModel
    {
        public string? Name { get; set; }
    }
}
