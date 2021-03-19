using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class masood101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Advertizment");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Tbl_City",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 747, DateTimeKind.Local).AddTicks(7963), new DateTime(2021, 3, 17, 17, 39, 18, 750, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7335), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7482), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7509), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7530), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7555), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7576), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7596), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7655), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7678), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7698), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7719), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7738), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7759), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7780), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7800), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7820), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7842), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7862), new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.InsertData(
                table: "Tbl_Category",
                columns: new[] { "CategoryId", "CategoryName", "CategoryType", "DateCreate", "Icon", "IsDelete", "LastUpdateDate" },
                values: new object[,]
                {
                    { 20, "PetKeeping", 20, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7881), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7884) },
                    { 21, "PetPlay", 21, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7902), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7904) },
                    { 22, "PetVet", 22, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7922), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7924) },
                    { 23, "PetCleaning", 23, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7942), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7944) },
                    { 24, "PetBuying", 24, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7961), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(7964) },
                    { 25, "PetFeeding", 25, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(8020), "1", false, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(8023) }
                });

            migrationBuilder.InsertData(
                table: "Tbl_TypeDetail",
                columns: new[] { "TypeDetailId", "DateCreate", "IsDelete", "LastUpdateDate", "TypeDetailName" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1370), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1372), "Padcast" },
                    { 5, new DateTime(2021, 3, 17, 17, 39, 18, 751, DateTimeKind.Local).AddTicks(9551), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(23), "Airline" },
                    { 6, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1038), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1057), "Airport" },
                    { 7, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1103), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1107), "Airplane" },
                    { 8, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1127), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1130), "Flight" },
                    { 9, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1148), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1151), "Book" },
                    { 10, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1173), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1176), "Video" },
                    { 11, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1195), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1197), "Magazain" },
                    { 12, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1217), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1220), "Aviation" },
                    { 13, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1239), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1241), "Hotel" },
                    { 14, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1262), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1265), "Resturant" },
                    { 15, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1285), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1287), "Shop" },
                    { 16, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1306), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1309), "Tour" },
                    { 24, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1456), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1458), "Institute" },
                    { 23, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1435), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1437), "clearance" },
                    { 22, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1412), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1414), "Cargo" },
                    { 18, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1328), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1330), "Cofeeshop" },
                    { 19, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1349), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1351), "News" },
                    { 21, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1391), false, new DateTime(2021, 3, 17, 17, 39, 18, 752, DateTimeKind.Local).AddTicks(1393), "Animal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tbl_TypeDetail",
                keyColumn: "TypeDetailId",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Tbl_City");

            migrationBuilder.CreateTable(
                name: "Tbl_Advertizment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Advertizment", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 402, DateTimeKind.Local).AddTicks(2688), new DateTime(2021, 3, 5, 20, 42, 51, 405, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7688), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7842), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7868), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7890), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7918), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7940), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7962), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7984), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8060), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8087), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8108), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8129), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8150), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8171), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8192), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8213), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8236), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8257), new DateTime(2021, 3, 5, 20, 42, 51, 406, DateTimeKind.Local).AddTicks(8260) });
        }
    }
}
