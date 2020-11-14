using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_PlaceCustomerId",
                table: "Tbl_Place");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Place_PlaceCustomerId",
                table: "Tbl_Place");

            migrationBuilder.DropColumn(
                name: "PlaceCustomerId",
                table: "Tbl_Place");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceCustomerId",
                table: "Tbl_Place",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceCustomerId",
                table: "Tbl_Place",
                column: "PlaceCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_PlaceCustomerId",
                table: "Tbl_Place",
                column: "PlaceCustomerId",
                principalTable: "Tbl_Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
