using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class mostafa109 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gallery",
                table: "Tbl_Article",
                newName: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Article_GalleryId",
                table: "Tbl_Article",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Article_Tbl_Gallery_GalleryId",
                table: "Tbl_Article",
                column: "GalleryId",
                principalTable: "Tbl_Gallery",
                principalColumn: "GalleryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Article_Tbl_Gallery_GalleryId",
                table: "Tbl_Article");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Article_GalleryId",
                table: "Tbl_Article");

            migrationBuilder.RenameColumn(
                name: "GalleryId",
                table: "Tbl_Article",
                newName: "Gallery");
        }
    }
}
