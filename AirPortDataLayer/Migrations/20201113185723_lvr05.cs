using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Gallery_Tbl_AirPlane_AirPlaneId",
                table: "Tbl_Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Gallery_AirPlaneId",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "AirPlaneId",
                table: "Tbl_Gallery");

            migrationBuilder.RenameColumn(
                name: "PlaceAdress",
                table: "Tbl_Place",
                newName: "PlaceAddress");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceAddress",
                table: "Tbl_Place",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceAddress",
                table: "Tbl_Place",
                column: "PlaceAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_Adress_PlaceAddress",
                table: "Tbl_Place",
                column: "PlaceAddress",
                principalTable: "Tbl_Adress",
                principalColumn: "AdressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_Adress_PlaceAddress",
                table: "Tbl_Place");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Place_PlaceAddress",
                table: "Tbl_Place");

            migrationBuilder.RenameColumn(
                name: "PlaceAddress",
                table: "Tbl_Place",
                newName: "PlaceAdress");

            migrationBuilder.AlterColumn<string>(
                name: "PlaceAdress",
                table: "Tbl_Place",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AirPlaneId",
                table: "Tbl_Gallery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_AirPlaneId",
                table: "Tbl_Gallery",
                column: "AirPlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Gallery_Tbl_AirPlane_AirPlaneId",
                table: "Tbl_Gallery",
                column: "AirPlaneId",
                principalTable: "Tbl_AirPlane",
                principalColumn: "AirPlaneId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
