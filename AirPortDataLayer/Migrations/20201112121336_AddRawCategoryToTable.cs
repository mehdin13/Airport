using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPortDataLayer.Migrations
{
    public partial class AddRawCategoryToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Tbl_TypeDetail VALUES('Test1','','','')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
