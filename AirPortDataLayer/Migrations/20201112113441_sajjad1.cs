using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class sajjad1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightToDo",
                columns: table => new
                {
                    FlightToDoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IsDon = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightToDo", x => x.FlightToDoId);
                    table.ForeignKey(
                        name: "FK_FlightToDo_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CustomerFlight",
                columns: table => new
                {
                    CustomerFlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CustomerFlight", x => x.CustomerFlightId);
                    table.ForeignKey(
                        name: "FK_Tbl_CustomerFlight_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_CustomerFlight_Tbl_Flight_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Tbl_Flight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Links", x => x.LinkId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_RequestType",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_RequestType", x => x.RequestId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_type",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: false),
                    TypeIcon = table.Column<string>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_type", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Weather",
                columns: table => new
                {
                    WeatherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Weather", x => x.WeatherId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Entertainment",
                columns: table => new
                {
                    EntertainmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LinkId = table.Column<int>(nullable: false),
                    LinkIdsId = table.Column<int>(nullable: true),
                    Gallery = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Entertainment", x => x.EntertainmentId);
                    table.ForeignKey(
                        name: "FK_Tbl_Entertainment_Tbl_Gallery_Gallery",
                        column: x => x.Gallery,
                        principalTable: "Tbl_Gallery",
                        principalColumn: "GalleryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Entertainment_Tbl_Links_LinkIdsId",
                        column: x => x.LinkIdsId,
                        principalTable: "Tbl_Links",
                        principalColumn: "LinkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Request",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    requestsid = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Request", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Tbl_Request_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Request_Tbl_RequestType_requestsid",
                        column: x => x.requestsid,
                        principalTable: "Tbl_RequestType",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightToDo_CustomerId",
                table: "FlightToDo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CustomerFlight_CustomerId",
                table: "Tbl_CustomerFlight",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CustomerFlight_FlightId",
                table: "Tbl_CustomerFlight",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_Gallery",
                table: "Tbl_Entertainment",
                column: "Gallery");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_LinkIdsId",
                table: "Tbl_Entertainment",
                column: "LinkIdsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_CustomerId",
                table: "Tbl_Request",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_requestsid",
                table: "Tbl_Request",
                column: "requestsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightToDo");

            migrationBuilder.DropTable(
                name: "Tbl_CustomerFlight");

            migrationBuilder.DropTable(
                name: "Tbl_Entertainment");

            migrationBuilder.DropTable(
                name: "Tbl_Request");

            migrationBuilder.DropTable(
                name: "Tbl_type");

            migrationBuilder.DropTable(
                name: "Tbl_Weather");

            migrationBuilder.DropTable(
                name: "Tbl_Links");

            migrationBuilder.DropTable(
                name: "Tbl_RequestType");
        }
    }
}
