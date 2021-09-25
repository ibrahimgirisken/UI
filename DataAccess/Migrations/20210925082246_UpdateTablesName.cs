using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateTablesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "BebejiProducts");

            migrationBuilder.RenameTable(
                name: "Descriptions",
                newName: "BebejiDescriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BebejiProducts",
                table: "BebejiProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BebejiDescriptions",
                table: "BebejiDescriptions",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BebejiProducts",
                table: "BebejiProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BebejiDescriptions",
                table: "BebejiDescriptions");

            migrationBuilder.RenameTable(
                name: "BebejiProducts",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "BebejiDescriptions",
                newName: "Descriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions",
                column: "Id");
        }
    }
}
