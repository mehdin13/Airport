using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class sajjad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    BrandIcon = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true),
                    Icon = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FlightStatus",
                columns: table => new
                {
                    FlightStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightStatusType = table.Column<string>(maxLength: 255, nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FlightStatus", x => x.FlightStatusId);
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
                name: "Tbl_State",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(maxLength: 50, nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_State", x => x.StateId);
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
                name: "Tbl_TypeDetail",
                columns: table => new
                {
                    TypeDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDetailName = table.Column<string>(maxLength: 50, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TypeDetail", x => x.TypeDetailId);
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
                name: "Tbl_City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    CityStateId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Tbl_City_Tbl_State_CityStateId",
                        column: x => x.CityStateId,
                        principalTable: "Tbl_State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Feature",
                columns: table => new
                {
                    FeatrueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatrueName = table.Column<string>(maxLength: 50, nullable: false),
                    TypeDetailId = table.Column<int>(nullable: false),
                    FeatrueIcon = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Feature", x => x.FeatrueId);
                    table.ForeignKey(
                        name: "FK_Tbl_Feature_Tbl_TypeDetail_TypeDetailId",
                        column: x => x.TypeDetailId,
                        principalTable: "Tbl_TypeDetail",
                        principalColumn: "TypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Adress",
                columns: table => new
                {
                    AdressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdressDetail = table.Column<string>(maxLength: 256, nullable: false),
                    AdressLocationX = table.Column<double>(nullable: false),
                    AdressLocationY = table.Column<double>(nullable: false),
                    AdressLocationR = table.Column<double>(nullable: false),
                    AdressCityId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Adress", x => x.AdressId);
                    table.ForeignKey(
                        name: "FK_Tbl_Adress_Tbl_City_AdressCityId",
                        column: x => x.AdressCityId,
                        principalTable: "Tbl_City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetailValue",
                columns: table => new
                {
                    ValueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatrueId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DetailValue", x => x.ValueId);
                    table.ForeignKey(
                        name: "FK_Tbl_DetailValue_Tbl_Feature_FeatrueId",
                        column: x => x.FeatrueId,
                        principalTable: "Tbl_Feature",
                        principalColumn: "FeatrueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerAdress = table.Column<int>(nullable: false),
                    addressId = table.Column<int>(nullable: true),
                    CustomerBDate = table.Column<DateTime>(nullable: false),
                    CustomerSex = table.Column<bool>(nullable: false),
                    CustomerMobile = table.Column<string>(maxLength: 12, nullable: false),
                    CustomerProfileImage = table.Column<string>(nullable: true),
                    CustomerPassword = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    Isactive = table.Column<bool>(nullable: false),
                    Isdelete = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Tbl_Customer_Tbl_Adress_addressId",
                        column: x => x.addressId,
                        principalTable: "Tbl_Adress",
                        principalColumn: "AdressId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(maxLength: 15, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Tbl_User_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AirPort",
                columns: table => new
                {
                    AirPortId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirPortName = table.Column<string>(maxLength: 50, nullable: false),
                    AirPortAddressId = table.Column<int>(nullable: false),
                    MapImageUrl = table.Column<string>(nullable: true),
                    GalleryId = table.Column<int>(nullable: false),
                    AirPortCode = table.Column<int>(nullable: false),
                    AirAbbreviation = table.Column<string>(maxLength: 10, nullable: true),
                    Detail = table.Column<string>(maxLength: 255, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AirPort", x => x.AirPortId);
                    table.ForeignKey(
                        name: "FK_Tbl_AirPort_Tbl_Adress_AirPortAddressId",
                        column: x => x.AirPortAddressId,
                        principalTable: "Tbl_Adress",
                        principalColumn: "AdressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Terminal",
                columns: table => new
                {
                    TerminalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalName = table.Column<string>(maxLength: 50, nullable: true),
                    TerminalImage = table.Column<string>(nullable: true),
                    AirPortId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Terminal", x => x.TerminalId);
                    table.ForeignKey(
                        name: "FK_Tbl_Terminal_Tbl_AirPort_AirPortId",
                        column: x => x.AirPortId,
                        principalTable: "Tbl_AirPort",
                        principalColumn: "AirPortId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gate",
                columns: table => new
                {
                    GateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GetName = table.Column<string>(maxLength: 50, nullable: false),
                    GateTerminal = table.Column<string>(nullable: true),
                    terminalId = table.Column<int>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gate", x => x.GateId);
                    table.ForeignKey(
                        name: "FK_Tbl_Gate_Tbl_Terminal_terminalId",
                        column: x => x.terminalId,
                        principalTable: "Tbl_Terminal",
                        principalColumn: "TerminalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AirPlane",
                columns: table => new
                {
                    AirPlaneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirPlaneName = table.Column<string>(maxLength: 50, nullable: false),
                    AirPlaneBrand = table.Column<string>(nullable: false),
                    AirPlaneModel = table.Column<string>(nullable: false),
                    AirPlaneCode = table.Column<string>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    AirPlaneGalleryId = table.Column<int>(nullable: false),
                    DetailId = table.Column<int>(nullable: false),
                    AirlineId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AirPlane", x => x.AirPlaneId);
                    table.ForeignKey(
                        name: "FK_Tbl_AirPlane_Tbl_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Tbl_Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Flight",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightAirPlaneId = table.Column<int>(nullable: false),
                    AirPortId = table.Column<int>(nullable: false),
                    FlightTime = table.Column<DateTime>(nullable: false),
                    FlighttDate = table.Column<DateTime>(nullable: false),
                    FlightstatusId = table.Column<int>(nullable: false),
                    StartAirPortId = table.Column<int>(nullable: false),
                    FlightEndAirportId = table.Column<int>(nullable: false),
                    FlightGateId = table.Column<int>(nullable: false),
                    FlightStartTimeDate = table.Column<DateTime>(nullable: false),
                    FlightNumber = table.Column<int>(nullable: false),
                    FlightDelay = table.Column<DateTime>(nullable: false),
                    FlightEndTimeDate = table.Column<DateTime>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Flight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_AirPort_AirPortId",
                        column: x => x.AirPortId,
                        principalTable: "Tbl_AirPort",
                        principalColumn: "AirPortId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_AirPlane_FlightAirPlaneId",
                        column: x => x.FlightAirPlaneId,
                        principalTable: "Tbl_AirPlane",
                        principalColumn: "AirPlaneId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_AirPort_FlightEndAirportId",
                        column: x => x.FlightEndAirportId,
                        principalTable: "Tbl_AirPort",
                        principalColumn: "AirPortId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_FlightStatus_FlightstatusId",
                        column: x => x.FlightstatusId,
                        principalTable: "Tbl_FlightStatus",
                        principalColumn: "FlightStatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_Gate_FlightGateId",
                        column: x => x.FlightGateId,
                        principalTable: "Tbl_Gate",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Flight_Tbl_AirPort_StartAirPortId",
                        column: x => x.StartAirPortId,
                        principalTable: "Tbl_AirPort",
                        principalColumn: "AirPortId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    GalleryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryName = table.Column<string>(maxLength: 50, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    AirPlaneId = table.Column<int>(nullable: true),
                    AirPortId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.GalleryId);
                    table.ForeignKey(
                        name: "FK_Tbl_Gallery_Tbl_AirPlane_AirPlaneId",
                        column: x => x.AirPlaneId,
                        principalTable: "Tbl_AirPlane",
                        principalColumn: "AirPlaneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Gallery_Tbl_AirPort_AirPortId",
                        column: x => x.AirPortId,
                        principalTable: "Tbl_AirPort",
                        principalColumn: "AirPortId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CustomerFlight",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    CustomerFlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CustomerFlight", x => new { x.CustomerId, x.FlightId });
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
                name: "Tbl_GalleryImage",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    GalleryId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_GalleryImage", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Tbl_GalleryImage_Tbl_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Tbl_Gallery",
                        principalColumn: "GalleryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Detail",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDetailId = table.Column<int>(nullable: false),
                    DetailRating = table.Column<double>(nullable: false),
                    DetailValue = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    AirPlaneId = table.Column<int>(nullable: true),
                    AirlineId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Detail", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_Tbl_Detail_Tbl_AirPlane_AirPlaneId",
                        column: x => x.AirPlaneId,
                        principalTable: "Tbl_AirPlane",
                        principalColumn: "AirPlaneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Detail_Tbl_TypeDetail_TypeDetailId",
                        column: x => x.TypeDetailId,
                        principalTable: "Tbl_TypeDetail",
                        principalColumn: "TypeDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_AirLine",
                columns: table => new
                {
                    AirlineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(maxLength: 50, nullable: false),
                    AirlineDetailId = table.Column<int>(nullable: false),
                    AirlineLogo = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_AirLine", x => x.AirlineId);
                    table.ForeignKey(
                        name: "FK_Tbl_AirLine_Tbl_Detail_AirlineDetailId",
                        column: x => x.AirlineDetailId,
                        principalTable: "Tbl_Detail",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Place",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(maxLength: 50, nullable: false),
                    PlaceAdress = table.Column<string>(maxLength: 255, nullable: true),
                    PlaceCategoryId = table.Column<int>(nullable: false),
                    PlaceGalleryId = table.Column<int>(nullable: false),
                    PlaceDetailId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    PlaceIsactive = table.Column<bool>(nullable: false),
                    PlaceCustomerId = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Place", x => x.PlaceId);
                    table.ForeignKey(
                        name: "FK_Tbl_Place_Tbl_Category_PlaceCategoryId",
                        column: x => x.PlaceCategoryId,
                        principalTable: "Tbl_Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Place_Tbl_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Place_Tbl_Detail_PlaceDetailId",
                        column: x => x.PlaceDetailId,
                        principalTable: "Tbl_Detail",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Place_Tbl_Gallery_PlaceGalleryId",
                        column: x => x.PlaceGalleryId,
                        principalTable: "Tbl_Gallery",
                        principalColumn: "GalleryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tbl_Place_Tbl_Customer_PlaceCustomerId",
                        column: x => x.PlaceCustomerId,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.NoAction);
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
                    IsDelete = table.Column<bool>(nullable: false),
                    EntertainmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Links", x => x.LinkId);
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

            migrationBuilder.CreateIndex(
                name: "IX_FlightToDo_CustomerId",
                table: "FlightToDo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Adress_AdressCityId",
                table: "Tbl_Adress",
                column: "AdressCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirLine_AirlineDetailId",
                table: "Tbl_AirLine",
                column: "AirlineDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPlane_AirlineId",
                table: "Tbl_AirPlane",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPlane_BrandId",
                table: "Tbl_AirPlane",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPlane_DetailId",
                table: "Tbl_AirPlane",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPlane_AirPlaneGalleryId",
                table: "Tbl_AirPlane",
                column: "AirPlaneGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPort_AirPortAddressId",
                table: "Tbl_AirPort",
                column: "AirPortAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_AirPort_GalleryId",
                table: "Tbl_AirPort",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_City_CityStateId",
                table: "Tbl_City",
                column: "CityStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Customer_addressId",
                table: "Tbl_Customer",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CustomerFlight_FlightId",
                table: "Tbl_CustomerFlight",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Detail_AirPlaneId",
                table: "Tbl_Detail",
                column: "AirPlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Detail_AirlineId",
                table: "Tbl_Detail",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Detail_TypeDetailId",
                table: "Tbl_Detail",
                column: "TypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailValue_FeatrueId",
                table: "Tbl_DetailValue",
                column: "FeatrueId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_Gallery",
                table: "Tbl_Entertainment",
                column: "Gallery");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Entertainment_LinkIdsId",
                table: "Tbl_Entertainment",
                column: "LinkIdsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Feature_TypeDetailId",
                table: "Tbl_Feature",
                column: "TypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_AirPortId",
                table: "Tbl_Flight",
                column: "AirPortId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_FlightAirPlaneId",
                table: "Tbl_Flight",
                column: "FlightAirPlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_FlightEndAirportId",
                table: "Tbl_Flight",
                column: "FlightEndAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_FlightstatusId",
                table: "Tbl_Flight",
                column: "FlightstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_FlightGateId",
                table: "Tbl_Flight",
                column: "FlightGateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Flight_StartAirPortId",
                table: "Tbl_Flight",
                column: "StartAirPortId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_AirPlaneId",
                table: "Tbl_Gallery",
                column: "AirPlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_AirPortId",
                table: "Tbl_Gallery",
                column: "AirPortId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_GalleryImage_GalleryId",
                table: "Tbl_GalleryImage",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gate_terminalId",
                table: "Tbl_Gate",
                column: "terminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Links_EntertainmentId",
                table: "Tbl_Links",
                column: "EntertainmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceCategoryId",
                table: "Tbl_Place",
                column: "PlaceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_CustomerId",
                table: "Tbl_Place",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceDetailId",
                table: "Tbl_Place",
                column: "PlaceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceGalleryId",
                table: "Tbl_Place",
                column: "PlaceGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Place_PlaceCustomerId",
                table: "Tbl_Place",
                column: "PlaceCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_CustomerId",
                table: "Tbl_Request",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Request_requestsid",
                table: "Tbl_Request",
                column: "requestsid");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Terminal_AirPortId",
                table: "Tbl_Terminal",
                column: "AirPortId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_User_CustomerId",
                table: "Tbl_User",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Gallery_GalleryId",
                table: "Tbl_AirPort",
                column: "GalleryId",
                principalTable: "Tbl_Gallery",
                principalColumn: "GalleryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_Detail_DetailId",
                table: "Tbl_AirPlane",
                column: "DetailId",
                principalTable: "Tbl_Detail",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_AirLine_AirlineId",
                table: "Tbl_AirPlane",
                column: "AirlineId",
                principalTable: "Tbl_AirLine",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_Gallery_AirPlaneGalleryId",
                table: "Tbl_AirPlane",
                column: "AirPlaneGalleryId",
                principalTable: "Tbl_Gallery",
                principalColumn: "GalleryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Detail_Tbl_AirLine_AirlineId",
                table: "Tbl_Detail",
                column: "AirlineId",
                principalTable: "Tbl_AirLine",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Links_Tbl_Entertainment_EntertainmentId",
                table: "Tbl_Links",
                column: "EntertainmentId",
                principalTable: "Tbl_Entertainment",
                principalColumn: "EntertainmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Adress_Tbl_City_AdressCityId",
                table: "Tbl_Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirLine_Tbl_Detail_AirlineDetailId",
                table: "Tbl_AirLine");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_Detail_DetailId",
                table: "Tbl_AirPlane");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_AirLine_AirlineId",
                table: "Tbl_AirPlane");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_Brand_BrandId",
                table: "Tbl_AirPlane");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPlane_Tbl_Gallery_AirPlaneGalleryId",
                table: "Tbl_AirPlane");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Gallery_GalleryId",
                table: "Tbl_AirPort");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Gallery_Gallery",
                table: "Tbl_Entertainment");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Entertainment_Tbl_Links_LinkIdsId",
                table: "Tbl_Entertainment");

            migrationBuilder.DropTable(
                name: "FlightToDo");

            migrationBuilder.DropTable(
                name: "Tbl_CustomerFlight");

            migrationBuilder.DropTable(
                name: "Tbl_DetailValue");

            migrationBuilder.DropTable(
                name: "Tbl_GalleryImage");

            migrationBuilder.DropTable(
                name: "Tbl_Place");

            migrationBuilder.DropTable(
                name: "Tbl_Request");

            migrationBuilder.DropTable(
                name: "Tbl_type");

            migrationBuilder.DropTable(
                name: "Tbl_User");

            migrationBuilder.DropTable(
                name: "Tbl_Weather");

            migrationBuilder.DropTable(
                name: "Tbl_Flight");

            migrationBuilder.DropTable(
                name: "Tbl_Feature");

            migrationBuilder.DropTable(
                name: "Tbl_Category");

            migrationBuilder.DropTable(
                name: "Tbl_RequestType");

            migrationBuilder.DropTable(
                name: "Tbl_Customer");

            migrationBuilder.DropTable(
                name: "Tbl_FlightStatus");

            migrationBuilder.DropTable(
                name: "Tbl_Gate");

            migrationBuilder.DropTable(
                name: "Tbl_Terminal");

            migrationBuilder.DropTable(
                name: "Tbl_City");

            migrationBuilder.DropTable(
                name: "Tbl_State");

            migrationBuilder.DropTable(
                name: "Tbl_Detail");

            migrationBuilder.DropTable(
                name: "Tbl_TypeDetail");

            migrationBuilder.DropTable(
                name: "Tbl_AirLine");

            migrationBuilder.DropTable(
                name: "Tbl_Brand");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_AirPlane");

            migrationBuilder.DropTable(
                name: "Tbl_AirPort");

            migrationBuilder.DropTable(
                name: "Tbl_Adress");

            migrationBuilder.DropTable(
                name: "Tbl_Links");

            migrationBuilder.DropTable(
                name: "Tbl_Entertainment");
        }
    }
}
