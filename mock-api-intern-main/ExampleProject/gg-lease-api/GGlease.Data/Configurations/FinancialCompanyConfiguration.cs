using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    public class FinancialCompanyConfiguration : IEntityTypeConfiguration<FinancialCompany>
    {
        public void Configure(EntityTypeBuilder<FinancialCompany> builder)
        {
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Name).HasMaxLength(100);
        }
    }
}