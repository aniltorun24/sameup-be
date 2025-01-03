namespace GGlease.Model.ViewModel
{
    public class FinancialCompanyCreateModel
    {
        public string? Name { get; set; }
        public RateCreateModel[] Rates { get; set; } = null!;
    }
}