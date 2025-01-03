using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    internal class SellerCompanyConfiguration : IEntityTypeConfiguration<SellerCompany>
    {
        public void Configure(EntityTypeBuilder<SellerCompany> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.ContactName).HasMaxLength(50);
            builder.Property(x => x.ContactPhone).HasMaxLength(50);
            builder.HasData(GetOtherSellerCompany());
        }

        private SellerCompany[] GetOtherSellerCompany()
        {
            return new[]
            {
                new SellerCompany{Id=9999,Name="DİĞER",IsActive=true, ContactName="OTHER", ContactPhone="0000000000", Email="info@gglease.com"}
            };
        }
    }
}