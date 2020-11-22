using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class lvr11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_GalleryImage",
                table: "Tbl_GalleryImage");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Tbl_GalleryImage");

            migrationBuilder.DropColumn(
                name: "AirPlaneBrand",
                table: "Tbl_AirPlane");

            migrationBuilder.AddColumn<int>(
                name: "GalleryImageId",
                table: "Tbl_GalleryImage",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Tbl_DetailValue",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerIdTbl",
                table: "Tbl_CustomerFlight",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "AdressDetail",
                table: "Tbl_Adress",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "Descriptions",
                table: "FlightToDo",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "FlightToDo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_GalleryImage",
                table: "Tbl_GalleryImage",
                column: "GalleryImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailValue_DetailId",
                table: "Tbl_DetailValue",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightToDo_FlightId",
                table: "FlightToDo",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightToDo_Tbl_Flight_FlightId",
                table: "FlightToDo",
                column: "FlightId",
                principalTable: "Tbl_Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_DetailValue_Tbl_Detail_DetailId",
                table: "Tbl_DetailValue",
                column: "DetailId",
                principalTable: "Tbl_Detail",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightToDo_Tbl_Flight_FlightId",
                table: "FlightToDo");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_DetailValue_Tbl_Detail_DetailId",
                table: "Tbl_DetailValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_GalleryImage",
                table: "Tbl_GalleryImage");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_DetailValue_DetailId",
                table: "Tbl_DetailValue");

            migrationBuilder.DropIndex(
                name: "IX_FlightToDo_FlightId",
                table: "FlightToDo");

            migrationBuilder.DropColumn(
                name: "GalleryImageId",
                table: "Tbl_GalleryImage");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Tbl_DetailValue");

            migrationBuilder.DropColumn(
                name: "CustomerIdTbl",
                table: "Tbl_CustomerFlight");

            migrationBuilder.DropColumn(
                name: "Descriptions",
                table: "FlightToDo");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "FlightToDo");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Tbl_GalleryImage",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AirPlaneBrand",
                table: "Tbl_AirPlane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "AdressDetail",
                table: "Tbl_Adress",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_GalleryImage",
                table: "Tbl_GalleryImage",
                column: "ImageId");
        }
    }
}
