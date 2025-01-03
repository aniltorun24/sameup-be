namespace GGlease.Model.ViewModel
{
    public class FinancialCompanyUpdateModel
    {
        public int Id { get; set; }
        public string? Name {get; set;}
        public RateCreateModel[] Rates { get; set; } = null!;
    }
}