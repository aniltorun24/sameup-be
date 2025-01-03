using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGlease.Data.Migrations
{
    public partial class equipmentValueAddedToOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EquipmentValue",
                table: "Offers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "12 Ay");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "24 Ay");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "36 Ay");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "36+ Ay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentValue",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "12");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "24");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "36");

            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "36+");
        }
    }
}
