using GGlease.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGlease.Data.Configurations
{
    internal class EquipmentGroupConfiguration : IEntityTypeConfiguration<EquipmentGroup>
    {
        public void Configure(EntityTypeBuilder<EquipmentGroup> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.HasData(GetEquipmentGroups());
        }

        private EquipmentGroup[] GetEquipmentGroups()
        {
            return new[]
            {
                new EquipmentGroup(){Rank=0,Id=1, 	Name="KARAYOLU TAŞITLARI"},
                new EquipmentGroup(){Rank=0,Id=2, 	Name="HAVAYOLU ULAŞIM ARAÇLARI"},
                new EquipmentGroup(){Rank=0,Id=3, 	Name="GEMİLER VE SUDA YÜZEN TAŞIT VE ARAÇLAR"},
                new EquipmentGroup(){Rank=0,Id=4, 	Name="DEMİRYOLU ULAŞIM ARAÇLARI"},
                new EquipmentGroup(){Rank=0,Id=5, 	Name="İŞ VE İNŞAAT MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=6, 	Name="SAĞLIK SEKTÖRÜ VE ESTETİK EKİPMANLARI"},
                new EquipmentGroup(){Rank=0,Id=7, 	Name="METAL İŞLEME MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=8, 	Name="TEKSTİL MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=9, 	Name="ELEKTRONİK VE OPTİK CİHAZLAR"},
                new EquipmentGroup(){Rank=0,Id=10, 	Name="BİLGİ İŞLEM VE BÜRO SİSTEMLERİ"},
                new EquipmentGroup(){Rank=0,Id=11, 	Name="GAYRİMENKUL"},
                new EquipmentGroup(){Rank=0,Id=12, 	Name="PLASTİK İŞLEME MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=13, 	Name="TURİZM EKİPMANLARI"},
                new EquipmentGroup(){Rank=0,Id=14, 	Name="MATBAACILIK VE KAĞIT İŞLEME MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=15, 	Name="TARIM VE HAYVANCILIK MAKİNELERİ"},
                new EquipmentGroup(){Rank=0,Id=16, 	Name="YENİLENEBİLİR KAYNAKLI ELEKTRİK ENERJİSİ ÜRETİM EKİPMANLARI"},
                new EquipmentGroup(){Rank=0,Id=17, 	Name="YENİLENEMEZ KAYNAKLI ELEKTRİK ENERJİSİ ÜRETİM EKİPMANLARI"},
                new EquipmentGroup(){Rank=0,Id=18, 	Name="ENERJİ VERİMLİLİĞİ EKİPMANLARI"},
                new EquipmentGroup(){Rank=0,Id=9999, Name="DİĞER MAKİNE VE EKİPMANLAR"}
            };
        }
    }
}
