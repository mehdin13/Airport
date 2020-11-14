using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Gallery_Tbl_AirPort_AirPortId",
                table: "Tbl_Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Gallery_AirPortId",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "AirPortId",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Tbl_AirPort");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirPortId",
                table: "Tbl_Gallery",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Tbl_AirPort",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_AirPortId",
                table: "Tbl_Gallery",
                column: "AirPortId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Gallery_Tbl_AirPort_AirPortId",
                table: "Tbl_Gallery",
                column: "AirPortId",
                principalTable: "Tbl_AirPort",
                principalColumn: "AirPortId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
