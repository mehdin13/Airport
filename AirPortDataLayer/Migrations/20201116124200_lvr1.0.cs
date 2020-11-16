using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId1",
                table: "Tbl_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Request_Tbl_type_TypeId2",
                table: "Tbl_Request");

            migrationBuilder.DropTable(
                name: "Tbl_type");

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
                name: "TypeId1",
                table: "Tbl_Request");

            migrationBuilder.DropColumn(
                name: "TypeId2",
                table: "Tbl_Request");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Tbl_Weather",
                newName: "Temperature");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "Tbl_Weather",
                newName: "CityId");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "Tbl_Weather",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId1",
                table: "Tbl_Request",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId2",
                table: "Tbl_Request",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_type",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_type", x => x.TypeId);
                });

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
        }
    }
}
