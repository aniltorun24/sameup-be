using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGlease.Data.Migrations
{
    public partial class OtherCompanyFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SellerCompanies",
                columns: new[] { "Id", "ContactName", "ContactPhone", "CreatedOn", "Email", "IsActive", "Name", "UpdatedOn" },
                values: new object[] { 9999, "OTHER", "0000000000", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@gglease.com", true, "DİĞER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "EquipmentId", "SellerCompanyId" },
                values: new object[,]
                {
                    { 1000, 1, 9999 },
                    { 1001, 2, 9999 },
                    { 1002, 3, 9999 },
                    { 1003, 4, 9999 },
                    { 1004, 5, 9999 },
                    { 1005, 6, 9999 },
                    { 1006, 7, 9999 },
                    { 1007, 8, 9999 },
                    { 1008, 9, 9999 },
                    { 1009, 10, 9999 },
                    { 1010, 11, 9999 },
                    { 1011, 12, 9999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "SellerCompanies",
                keyColumn: "Id",
                keyValue: 9999);
        }
    }
}
