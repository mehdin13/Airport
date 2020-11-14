using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Detail_Tbl_AirPlane_AirPlaneId",
                table: "Tbl_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Detail_Tbl_AirLine_AirlineId",
                table: "Tbl_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Detail_AirPlaneId",
                table: "Tbl_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Detail_AirlineId",
                table: "Tbl_Detail");

            migrationBuilder.DropColumn(
                name: "AirPlaneId",
                table: "Tbl_Detail");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Tbl_Detail");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Tbl_AirPort",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPort_DetailId",
                table: "Tbl_AirPort",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_DetailId",
                table: "Tbl_AirPort",
                column: "DetailId",
                principalTable: "Tbl_Detail",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_DetailId",
                table: "Tbl_AirPort");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_AirPort_DetailId",
                table: "Tbl_AirPort");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Tbl_AirPort");

            migrationBuilder.AddColumn<int>(
                name: "AirPlaneId",
                table: "Tbl_Detail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Tbl_Detail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Detail_AirPlaneId",
                table: "Tbl_Detail",
                column: "AirPlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Detail_AirlineId",
                table: "Tbl_Detail",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Detail_Tbl_AirPlane_AirPlaneId",
                table: "Tbl_Detail",
                column: "AirPlaneId",
                principalTable: "Tbl_AirPlane",
                principalColumn: "AirPlaneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Detail_Tbl_AirLine_AirlineId",
                table: "Tbl_Detail",
                column: "AirlineId",
                principalTable: "Tbl_AirLine",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
