using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGlease.Data.Migrations
{
    public partial class MaturityOptionChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Value" },
                values: new object[] { "48 Ay", 48 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MaturityOptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Value" },
                values: new object[] { "36+ Ay", 36 });
        }
    }
}
