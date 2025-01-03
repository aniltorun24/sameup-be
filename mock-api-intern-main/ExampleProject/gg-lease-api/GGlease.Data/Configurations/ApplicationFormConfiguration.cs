using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    internal class ApplicationFormConfiguration : IEntityTypeConfiguration<ApplicationForm>
    {
        public void Configure(EntityTypeBuilder<ApplicationForm> builder)
        {
            builder.Property(x => x.Email).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(2500);
            builder.Property(x => x.FullName).HasMaxLength(50);
            builder.Property(x => x.Phone).HasMaxLength(30);
            builder.Property(x => x.SellerCompanyOther).HasMaxLength(100);
            builder.Property(x => x.VKN).HasMaxLength(30);

            builder
                .HasOne(x => x.EquipmentSellerCompany)
                .WithMany(x => x.ApplicationForms);

            builder
                .HasMany(x => x.Offers)
                .WithOne(x => x.ApplicationForm)
                .HasForeignKey(x => x.ApplicationFormId);
        }
    }
}