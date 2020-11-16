using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_RequestType_requestsid",
                table: "Tbl_Request");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Request_requestsid",
                table: "Tbl_Request");

            migrationBuilder.DropColumn(
                name: "requestsid",
                table: "Tbl_Request");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "Tbl_Weather",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirportId",
                table: "Tbl_Weather",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Tbl_type",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId1",
                table: "Tbl_Request",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId2",
                table: "Tbl_Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Weather_AirportId",
                table: "Tbl_Weather",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_TypeId",
                table: "Tbl_Request",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_TypeId1",
                table: "Tbl_Request",
                column: "TypeId1",
                unique: true,
                filter: "[TypeId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_TypeId2",
                table: "Tbl_Request",
                column: "TypeId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Request_Tbl_RequestType_TypeId",
                table: "Tbl_Request",
                column: "TypeId",
                principalTable: "Tbl_RequestType",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId1",
                table: "Tbl_Request",
                column: "TypeId1",
                principalTable: "Tbl_type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId2",
                table: "Tbl_Request",
                column: "TypeId2",
                principalTable: "Tbl_type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Weather_Tbl_AirPort_AirportId",
                table: "Tbl_Weather",
                column: "AirportId",
                principalTable: "Tbl_AirPort",
                principalColumn: "AirPortId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_RequestType_TypeId",
                table: "Tbl_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId1",
                table: "Tbl_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId2",
                table: "Tbl_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Weather_Tbl_AirPort_AirportId",
                table: "Tbl_Weather");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Weather_AirportId",
                table: "Tbl_Weather");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Request_TypeId",
                table: "Tbl_Request");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Request_TypeId1",
                table: "Tbl_Request");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Request_TypeId2",
                table: "Tbl_Request");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "Tbl_Weather");

            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Tbl_Weather");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Tbl_type");

            migrationBuilder.DropColumn(
                name: "TypeId1",
                table: "Tbl_Request");

            migrationBuilder.DropColumn(
                name: "TypeId2",
                table: "Tbl_Request");

            migrationBuilder.AddColumn<int>(
                name: "requestsid",
                table: "Tbl_Request",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_requestsid",
                table: "Tbl_Request",
                column: "requestsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Request_Tbl_RequestType_requestsid",
                table: "Tbl_Request",
                column: "requestsid",
                principalTable: "Tbl_RequestType",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
