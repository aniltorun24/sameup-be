using GGlease.Model.DB;

namespace GGlease.Model.ViewModel
{
    public class FinancialCompanyByConversionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;
        public int TotalConversions {get;set;}
        public int TotalView {get;set;}
    }
}