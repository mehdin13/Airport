using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class mostafa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tbl_Links");

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Hotel", new DateTime(2021, 2, 23, 1, 38, 29, 900, DateTimeKind.Local).AddTicks(6083), new DateTime(2021, 2, 23, 1, 38, 29, 903, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Restaurant", new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4344), new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Tour", new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4477), new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Shop", new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4500), new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Institute", new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4519), new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.InsertData(
                table: "Tbl_Category",
                columns: new[] { "CategoryId", "CategoryName", "CategoryType", "DateCreate", "Icon", "IsDelete", "LastUpdateDate" },
                values: new object[,]
                {
                    { 6, "Cofeeshop", 6, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4543), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4545) },
                    { 7, "Parking", 7, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4562), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4565) },
                    { 8, "Animal", 8, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4653), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4656) },
                    { 9, "Cargo", 9, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4677), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4680) },
                    { 10, "Clearance", 10, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4698), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4701) },
                    { 11, "Padcast", 11, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4717), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4720) },
                    { 12, "News", 12, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4736), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4739) },
                    { 13, "Tutorial", 13, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4756), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4759) },
                    { 14, "Application", 14, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4779), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4782) },
                    { 15, "Article", 15, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4798), "1", false, new DateTime(2021, 2, 23, 1, 38, 29, 904, DateTimeKind.Local).AddTicks(4801) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tbl_Links",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Place", new DateTime(2021, 2, 7, 1, 46, 25, 781, DateTimeKind.Local).AddTicks(9526), new DateTime(2021, 2, 7, 1, 46, 25, 785, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Link", new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4217), new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Animal", new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4566), new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Cargo", new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4592), new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "DateCreate", "LastUpdateDate" },
                values: new object[] { "Clearence", new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4614), new DateTime(2021, 2, 7, 1, 46, 25, 786, DateTimeKind.Local).AddTicks(4617) });
        }
    }
}
