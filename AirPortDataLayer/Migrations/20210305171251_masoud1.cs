using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class masoud1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdressLocationY",
                table: "Tbl_Adress",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "AdressLocationX",
                table: "Tbl_Adress",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "AdressLocationR",
                table: "Tbl_Adress",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "AdressLocationY",
                table: "Tbl_Adress",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AdressLocationX",
                table: "Tbl_Adress",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AdressLocationR",
                table: "Tbl_Adress",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 644, DateTimeKind.Local).AddTicks(8554), new DateTime(2021, 3, 3, 16, 51, 55, 647, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(36), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(186), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(212), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(232), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(258), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(277), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(297), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(317), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(339), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(359), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(378), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(398), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(425), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(458), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(536), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(622), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(649), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(669), new DateTime(2021, 3, 3, 16, 51, 55, 649, DateTimeKind.Local).AddTicks(671) });
        }
    }
}
