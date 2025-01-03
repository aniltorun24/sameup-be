using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    internal class MaturityOptionConfiguration : IEntityTypeConfiguration<MaturityOption>
    {
        public void Configure(EntityTypeBuilder<MaturityOption> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.HasData(GetMaturityOptions());
        }

        private MaturityOption[] GetMaturityOptions()
        {
            return new[]
            {
                new MaturityOption{Id=1, Name="12 Ay", Rank=1, Value = 12},
                new MaturityOption{Id=2, Name="24 Ay", Rank=2, Value = 24},
                new MaturityOption{Id=3, Name="36 Ay", Rank=3, Value = 36},
                new MaturityOption{Id=4, Name="48 Ay", Rank=4, Value = 48}, // ??TODO: Fatihe sor??
            };
        }
    }
}