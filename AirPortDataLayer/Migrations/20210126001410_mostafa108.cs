using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class mostafa108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_AirPort_Airportid",
                table: "Tbl_Place");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_CustomerId",
                table: "Tbl_Place");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Tbl_Place",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Airportid",
                table: "Tbl_Place",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Tbl_Gallery",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Gallery = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Article", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FAQ",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQType = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FAQ", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Raiting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    detailid = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    CommentText = table.Column<string>(maxLength: 255, nullable: true),
                    Isactive = table.Column<bool>(nullable: false),
                    Isdelete = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Raiting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Raiting_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Raiting_Tbl_Detail_detailid",
                        column: x => x.detailid,
                        principalTable: "Tbl_Detail",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ArticleId",
                table: "Tbl_Gallery",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Raiting_CustomerId",
                table: "Tbl_Raiting",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Raiting_detailid",
                table: "Tbl_Raiting",
                column: "detailid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Gallery_Tbl_Article_ArticleId",
                table: "Tbl_Gallery",
                column: "ArticleId",
                principalTable: "Tbl_Article",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_AirPort_Airportid",
                table: "Tbl_Place",
                column: "Airportid",
                principalTable: "Tbl_AirPort",
                principalColumn: "AirPortId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_CustomerId",
                table: "Tbl_Place",
                column: "CustomerId",
                principalTable: "Tbl_Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Gallery_Tbl_Article_ArticleId",
                table: "Tbl_Gallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_AirPort_Airportid",
                table: "Tbl_Place");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_CustomerId",
                table: "Tbl_Place");

            migrationBuilder.DropTable(
                name: "Tbl_Article");

            migrationBuilder.DropTable(
                name: "Tbl_FAQ");

            migrationBuilder.DropTable(
                name: "Tbl_Raiting");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Gallery_ArticleId",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Tbl_Gallery");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Tbl_Place",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Airportid",
                table: "Tbl_Place",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_AirPort_Airportid",
                table: "Tbl_Place",
                column: "Airportid",
                principalTable: "Tbl_AirPort",
                principalColumn: "AirPortId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Place_Tbl_Customer_CustomerId",
                table: "Tbl_Place",
                column: "CustomerId",
                principalTable: "Tbl_Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
