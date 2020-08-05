using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class Productsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DataProductos",
                table: "DataProductos");

            migrationBuilder.RenameTable(
                name: "DataProductos",
                newName: "Productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "DataProductos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataProductos",
                table: "DataProductos",
                column: "Id");
        }
    }
}
