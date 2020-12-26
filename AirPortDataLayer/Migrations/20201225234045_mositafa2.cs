using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class mositafa2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Tbl_Place",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "Tbl_Place",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
