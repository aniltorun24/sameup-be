using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    internal class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.HasData(GetCurrencies());
        }

        private Currency[] GetCurrencies()
        {
            return new[]
            {
                new Currency{Rank=1, Id=1, Name="TL"},
                new Currency{Rank=2, Id=2, Name="USD"},
                new Currency{Rank=3, Id=3, Name="EUR"},
            };
        }
    }
}