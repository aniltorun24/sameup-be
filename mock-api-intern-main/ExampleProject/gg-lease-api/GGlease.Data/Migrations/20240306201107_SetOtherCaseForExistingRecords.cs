using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGlease.Data.Migrations
{
    public partial class SetOtherCaseForExistingRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // backup ApplicationForms table
            migrationBuilder.Sql("SELECT * INTO [ApplicationForms_backup] FROM [ApplicationForms];");
            // backup EquipmentSellerCompanies table
            migrationBuilder.Sql("SELECT * INTO [EquipmentSellerCompanies_backup] FROM [EquipmentSellerCompanies];");

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedOn", "Name", "Rank", "UpdatedOn" },
                values: new object[] { 10017, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DİĞER", 99999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EquipmentSellerCompanies",
                columns: new[] { "Id", "EquipmentId", "SellerCompanyId" },
                values: new object[] { 999, 10017, 9999 });

            // Bütün girilen formlar artık diğer->diğer e bakacak.
            migrationBuilder.Sql("UPDATE ApplicationForms SET EquipmentSellerCompanyId = 999");
            
            // set SellerCompanyOther to 'Boş bırakıldı' if null.
            migrationBuilder.Sql("UPDATE ApplicationForms set SellerCompanyOther = 'Boş bırakıldı' where EquipmentSellerCompanyId = 999 and SellerCompanyOther is null;");
            migrationBuilder.Sql("UPDATE EquipmentSellerCompanies SET EquipmentId = 10017;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // should handle manually, with backup table.
        }
    }
}