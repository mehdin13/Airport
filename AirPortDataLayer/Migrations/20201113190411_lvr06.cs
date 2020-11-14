using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Links_LinkIdsId",
                table: "Tbl_Entertainment");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Links_Tbl_Entertainment_EntertainmentId",
                table: "Tbl_Links");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Links_EntertainmentId",
                table: "Tbl_Links");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Entertainment_LinkIdsId",
                table: "Tbl_Entertainment");

            migrationBuilder.DropColumn(
                name: "EntertainmentId",
                table: "Tbl_Links");

            migrationBuilder.DropColumn(
                name: "LinkIdsId",
                table: "Tbl_Entertainment");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_LinkId",
                table: "Tbl_Entertainment",
                column: "LinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Links_LinkId",
                table: "Tbl_Entertainment",
                column: "LinkId",
                principalTable: "Tbl_Links",
                principalColumn: "LinkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Links_LinkId",
                table: "Tbl_Entertainment");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Entertainment_LinkId",
                table: "Tbl_Entertainment");

            migrationBuilder.AddColumn<int>(
                name: "EntertainmentId",
                table: "Tbl_Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LinkIdsId",
                table: "Tbl_Entertainment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Links_EntertainmentId",
                table: "Tbl_Links",
                column: "EntertainmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_LinkIdsId",
                table: "Tbl_Entertainment",
                column: "LinkIdsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Links_LinkIdsId",
                table: "Tbl_Entertainment",
                column: "LinkIdsId",
                principalTable: "Tbl_Links",
                principalColumn: "LinkId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Links_Tbl_Entertainment_EntertainmentId",
                table: "Tbl_Links",
                column: "EntertainmentId",
                principalTable: "Tbl_Entertainment",
                principalColumn: "EntertainmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
