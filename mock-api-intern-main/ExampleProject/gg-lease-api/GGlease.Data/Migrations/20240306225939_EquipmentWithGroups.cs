using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGlease.Data.Migrations
{
    public partial class EquipmentWithGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccepted",
                table: "Offers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentGroupId",
                table: "Equipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EquipmentGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentGroups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EquipmentGroups",
                columns: new[] { "Id", "CreatedOn", "Name", "Rank", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KARAYOLU TAŞITLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HAVAYOLU ULAŞIM ARAÇLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GEMİLER VE SUDA YÜZEN TAŞIT VE ARAÇLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DEMİRYOLU ULAŞIM ARAÇLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İŞ VE İNŞAAT MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAĞLIK SEKTÖRÜ VE ESTETİK EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "METAL İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEKSTİL MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELEKTRONİK VE OPTİK CİHAZLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BİLGİ İŞLEM VE BÜRO SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GAYRİMENKUL", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PLASTİK İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TURİZM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MATBAACILIK VE KAĞIT İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TARIM VE HAYVANCILIK MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YENİLENEBİLİR KAYNAKLI ELEKTRİK ENERJİSİ ÜRETİM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YENİLENEMEZ KAYNAKLI ELEKTRİK ENERJİSİ ÜRETİM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENERJİ VERİMLİLİĞİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DİĞER MAKİNE VE EKİPMANLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedOn", "EquipmentGroupId", "Name", "Rank", "UpdatedOn" },
                values: new object[,]
                {
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "KURU YÜK GEMİSİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TANKER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "YOLCU GEMİLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "YAT (MOTORYAT YA DA YELKENLİ)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "DENİZYOLU TAŞITI BAKIM ONARIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "LOKOMOTİF", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "VAGON", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "DEMİRYOLU TAŞITI BAKIM ONARIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KAZICI YÜKLEYİCİ ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "YÜKLEYİCİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "EKSKAVATÖR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "FORKLİFT VE İSTİFLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "VİNÇ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "TANI VE TEDAVİ CİHAZLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "DİŞÇİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "ESTETİK EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "TIBBİ LABORATUAR EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "HASTANE EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "GÖZ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "VETERİNER EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "CNC METAL İŞLEME TAKIM TEZGAHLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "UNIVERSAL METAL İŞLEME  TAKIM TEZGAHLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "MÜCEVHER KUYUM İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL İPLİK MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL DOKUMA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL ÖRME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL BOYA BASKI APRE MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL KONFEKSİYON MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "TEKSTİL NAKIŞ MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "GÜVENLİK SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "HABERLEŞME EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "SES VE GÖRÜNTÜ SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "AYDINLATMA VE IŞIK SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "RADYO VE TV YAYINCILIK EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "OFİS BİLGİ İŞLEM MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "BİLGİ TEKNOLOJİSİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "BİLGİSAYAR YAZILIM", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "FABRİKA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "MAĞAZA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "TARLA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "ARSA", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "İŞYERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedOn", "EquipmentGroupId", "Name", "Rank", "UpdatedOn" },
                values: new object[,]
                {
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "PLASTİK ENJEKSİYON MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "OTEL MOBİLYA VE DONANIMLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "RESTORAN MUTFAK DONANIMLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "ÇAMAŞIRHANE KURU TEMİZLEME DONANIMLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "SPOR SALONU EKİPMANLARI ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "LİFT (TELESKİ/TELESİYEJ) SİSTEM VE EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "MATBAA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "KAĞIT İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "FOTOĞRAF BASKI EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "KOPYALAMA ÇOĞALTMA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "BİÇERDÖVER VE HASAT MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "TRAKTÖR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "PAMUK TOPLAMA MAKİNESİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "HASAT MAKİNELERİ ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "EKİM DİKİM MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "TOPRAK İŞLEME EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "ZİRAİ İLAÇLAMA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "GÜBRE HAZIRLAMA DAĞITMA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "BALYA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "YEM ÜRETİM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "HAYVANCILIK EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "HİDROELEKTRİK SANTRALİ(HES)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "RÜZGAR ENERJİ SANTRALİ(RES)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "GÜNEŞ ENERJİ SANTRALİ(GES)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "HİBRİT (RES+GES) SİSTEMLER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "JEOTERMAL ENERJİ SANTRALİ(JES)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "BİYOKÜTLE (Biyogaz, katı atık, atık ısı, pirolitik yağ vb) Elektrik Santralleri", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "KÖMÜR (Kömür, linyit, Taşkömürü) KAYNAKLI E.S.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "PETROL KAYNAKLI E.S.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "DOĞALGAZ KAYNAKLI E.S.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "NÜKLEER E.S.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "ENERJİ VERİMLİLİĞİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "GIDA İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "DERİ İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "CAM VE SERAMİK İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "AĞAÇ (AHŞAP) İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "KİMYA SEKTÖRÜ MAKİNE VE EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ELEKTRONİK KOMPONENT ÜRETİM MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "MADEN İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "MERMER İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "PAKETLEME VE AMBALAJLAMA MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ENERJİ ÜRETİM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedOn", "EquipmentGroupId", "Name", "Rank", "UpdatedOn" },
                values: new object[,]
                {
                    { 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ELEKTRİK TEKNOLOJİSİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "JENERATÖR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ISITMA, SOĞUTMA VE HAVALANDIRMA SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ÇEVRE SAĞLIĞI VE DOĞA BİLİMLERİ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "MOBİLYA DEKORASYON VE YAPI ELEMENLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "AKIŞKAN VE GAZ ÜRETİM KONTROL DAĞITIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "PETROL VE DOĞALGAZ İŞLEME DAĞITIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "ÖLÇME VE TEST MAKİNE VE EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "FOTOĞRAFÇILIK VE SİNEMATOGRAFİK EKİPMANLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "SİLAH SEKTÖRÜ EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARAYOLU TAŞITLARI (BİNEK)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARAYOLU TAŞITLARI (HAFİF TİCARİ)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARAYOLU TAŞITLARI (AĞIR TİCARİ)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARAYOLU TAŞITLARI (ÖZEL AMAÇLI)", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KARA TAŞITLARI BAKIM ONARIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "UÇAK", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "HELİKOPTER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "HAVA TAŞITLARI BAKIM ONARIM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "UÇAK SİMÜLATÖRÜ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "DİĞER KARAYOLU TAŞITLARI VE YAN EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "DİĞER HAVAYOLU TAŞITLARI VE YAN EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "DİĞER DENİZYOLU TAŞITLARI ve YAN EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "DİĞER DEMİRYOLU TAŞITLARI ve YAN EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "DİĞER İŞ VE İNŞAAT MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10005, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "DİĞER SAĞLIK SEKTÖRÜ CİHAZ ve EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10006, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "DİĞER METAL İŞLEME TEZGAHLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "DİĞER TEKSTİL MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10008, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "DİĞER ELEKTRONİK VE OPTİK CİHAZLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10009, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "DİĞER BİLGİ İŞLEM VE BÜRO SİSTEMLERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10010, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "DİĞER PLASTİK KAUÇUK İŞLEME MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10011, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "DİĞER TURİZM EKİPMANLARI", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10012, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "DİĞER BASKI ÖNCESİ VE SONRASI EKİPMANLAR", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10013, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "DİĞER TARIM MAKİNELERİ", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10014, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "DİĞER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10015, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "DİĞER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10016, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "DİĞER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10018, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "DİĞER GAYRIMENKUL", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "EquipmentId", "SellerCompanyId" },
                values: new object[,]
                {
                    { 871, 149, 9999 },
                    { 872, 148, 9999 },
                    { 873, 147, 9999 },
                    { 874, 146, 9999 },
                    { 875, 145, 9999 },
                    { 876, 144, 9999 },
                    { 877, 143, 9999 },
                    { 878, 142, 9999 },
                    { 879, 141, 9999 },
                    { 880, 140, 9999 },
                    { 881, 139, 9999 },
                    { 882, 138, 9999 },
                    { 883, 137, 9999 },
                    { 884, 136, 9999 },
                    { 885, 135, 9999 },
                    { 886, 134, 9999 },
                    { 887, 133, 9999 },
                    { 888, 132, 9999 },
                    { 889, 131, 9999 },
                    { 890, 130, 9999 },
                    { 891, 129, 9999 },
                    { 892, 128, 9999 },
                    { 893, 127, 9999 },
                    { 894, 126, 9999 },
                    { 895, 125, 9999 },
                    { 896, 124, 9999 },
                    { 897, 123, 9999 },
                    { 898, 122, 9999 },
                    { 899, 121, 9999 },
                    { 900, 10016, 9999 },
                    { 901, 118, 9999 },
                    { 902, 10015, 9999 },
                    { 903, 115, 9999 },
                    { 904, 114, 9999 },
                    { 905, 113, 9999 },
                    { 906, 112, 9999 },
                    { 907, 10014, 9999 },
                    { 908, 109, 9999 },
                    { 909, 108, 9999 },
                    { 910, 107, 9999 },
                    { 911, 106, 9999 },
                    { 912, 105, 9999 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "EquipmentId", "SellerCompanyId" },
                values: new object[,]
                {
                    { 913, 104, 9999 },
                    { 914, 10013, 9999 },
                    { 915, 101, 9999 },
                    { 916, 100, 9999 },
                    { 917, 99, 9999 },
                    { 918, 98, 9999 },
                    { 919, 97, 9999 },
                    { 920, 96, 9999 },
                    { 921, 95, 9999 },
                    { 922, 94, 9999 },
                    { 923, 93, 9999 },
                    { 924, 92, 9999 },
                    { 925, 91, 9999 },
                    { 926, 10012, 9999 },
                    { 927, 88, 9999 },
                    { 928, 87, 9999 },
                    { 929, 86, 9999 },
                    { 930, 85, 9999 },
                    { 931, 10011, 9999 },
                    { 932, 82, 9999 },
                    { 933, 81, 9999 },
                    { 934, 80, 9999 },
                    { 935, 79, 9999 },
                    { 936, 78, 9999 },
                    { 937, 10010, 9999 },
                    { 938, 75, 9999 },
                    { 939, 10018, 9999 },
                    { 940, 72, 9999 },
                    { 941, 71, 9999 },
                    { 942, 70, 9999 },
                    { 943, 69, 9999 },
                    { 944, 68, 9999 },
                    { 945, 10009, 9999 },
                    { 946, 65, 9999 },
                    { 947, 64, 9999 },
                    { 948, 63, 9999 },
                    { 949, 10008, 9999 },
                    { 950, 60, 9999 },
                    { 951, 59, 9999 },
                    { 952, 58, 9999 },
                    { 953, 57, 9999 },
                    { 954, 56, 9999 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "EquipmentId", "SellerCompanyId" },
                values: new object[,]
                {
                    { 955, 10007, 9999 },
                    { 956, 53, 9999 },
                    { 957, 52, 9999 },
                    { 958, 51, 9999 },
                    { 959, 50, 9999 },
                    { 960, 49, 9999 },
                    { 961, 48, 9999 },
                    { 962, 10006, 9999 },
                    { 963, 45, 9999 },
                    { 964, 44, 9999 },
                    { 965, 43, 9999 },
                    { 966, 10005, 9999 },
                    { 967, 40, 9999 },
                    { 968, 39, 9999 },
                    { 969, 38, 9999 },
                    { 970, 37, 9999 },
                    { 971, 36, 9999 },
                    { 972, 35, 9999 },
                    { 973, 34, 9999 },
                    { 974, 10004, 9999 },
                    { 975, 31, 9999 },
                    { 976, 30, 9999 },
                    { 977, 29, 9999 },
                    { 978, 28, 9999 },
                    { 979, 27, 9999 },
                    { 980, 10003, 9999 },
                    { 981, 24, 9999 },
                    { 982, 23, 9999 },
                    { 983, 22, 9999 },
                    { 984, 10002, 9999 },
                    { 985, 19, 9999 },
                    { 986, 18, 9999 },
                    { 987, 17, 9999 },
                    { 988, 16, 9999 },
                    { 989, 15, 9999 },
                    { 990, 10001, 9999 },
                    { 995, 10000, 9999 }
                });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10017,
                columns: new[] { "CreatedOn", "EquipmentGroupId", "Name", "Rank", "UpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999, "DİĞER", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EquipmentGroupId",
                table: "Equipments",
                column: "EquipmentGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipmentGroups_EquipmentGroupId",
                table: "Equipments",
                column: "EquipmentGroupId",
                principalTable: "EquipmentGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipmentGroups_EquipmentGroupId",
                table: "Equipments");

            migrationBuilder.DropTable(
                name: "EquipmentGroups");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_EquipmentGroupId",
                table: "Equipments");

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "EquipmentSellerCompanies",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10004);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10005);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10006);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10007);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10008);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10009);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10010);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10011);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10012);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10013);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10014);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10015);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10016);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10017);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10018);

            migrationBuilder.DropColumn(
                name: "EquipmentGroupId",
                table: "Equipments");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccepted",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedOn", "Name", "Rank", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İŞ VE İNŞAAT MAKİNELERİ", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "METAL İŞLEME MAKİNELERİ", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PLASTİK İŞLEME MAKİNELERİ", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEKSTİL MAKİNELERİ", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TARIM VE HAYVANCILIK MAKİNELERİ", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAĞLIK SEKTÖRÜ VE ESTETİK EKİPMANLARI", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELEKTRONİK VE OPTİK CİHAZLAR", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BİLGİ İŞLEM VE BÜRO SİSTEMLERİ", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YENİLENEBİLİR KAYNAKLI ELEKTRİK ENERJİSİ ÜRETİM EKİPMANLARI", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DİĞER MAKİNE VE EKİPMANLAR", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2. EL MAKİNE", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DİĞER", 99999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "CreatedOn", "EquipmentId", "SellerCompanyId", "UpdatedOn" },
                values: new object[,]
                {
                    { 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1005, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1006, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1008, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1009, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1010, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1011, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 9999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
