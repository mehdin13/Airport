using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class mostafa110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Gallery_Tbl_Article_ArticleId",
                table: "Tbl_Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Gallery_ArticleId",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Tbl_Gallery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Tbl_Gallery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ArticleId",
                table: "Tbl_Gallery",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Gallery_Tbl_Article_ArticleId",
                table: "Tbl_Gallery",
                column: "ArticleId",
                principalTable: "Tbl_Article",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
