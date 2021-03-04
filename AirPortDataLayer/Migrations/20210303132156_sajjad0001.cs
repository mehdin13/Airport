using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class sajjad0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_DetailId",
                table: "Tbl_AirPort");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "Tbl_AirPort",
                newName: "AirportDetailid");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_AirPort_DetailId",
                table: "Tbl_AirPort",
                newName: "IX_Tbl_AirPort_AirportDetailid");

            migrationBuilder.AlterColumn<int>(
                name: "AirportDetailid",
                table: "Tbl_AirPort",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_AirportDetailid",
                table: "Tbl_AirPort",
                column: "AirportDetailid",
                principalTable: "Tbl_Detail",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_AirportDetailid",
                table: "Tbl_AirPort");

            migrationBuilder.RenameColumn(
                name: "AirportDetailid",
                table: "Tbl_AirPort",
                newName: "DetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_AirPort_AirportDetailid",
                table: "Tbl_AirPort",
                newName: "IX_Tbl_AirPort_DetailId");

            migrationBuilder.AlterColumn<int>(
                name: "DetailId",
                table: "Tbl_AirPort",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 178, DateTimeKind.Local).AddTicks(4201), new DateTime(2021, 2, 23, 23, 32, 44, 182, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2342), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2473), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2495), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2514), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2537), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2605), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2626), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2646), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2666), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2685), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2704), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2722), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2741), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2759), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2780), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2799), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2820), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Tbl_Category",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "DateCreate", "LastUpdateDate" },
                values: new object[] { new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2838), new DateTime(2021, 2, 23, 23, 32, 44, 183, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_AirPort_Tbl_Detail_DetailId",
                table: "Tbl_AirPort",
                column: "DetailId",
                principalTable: "Tbl_Detail",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
