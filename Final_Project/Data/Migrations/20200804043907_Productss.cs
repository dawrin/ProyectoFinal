using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class Productss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenesModel",
                table: "OrdenesModel");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "DataProductos");

            migrationBuilder.RenameTable(
                name: "OrdenesModel",
                newName: "Ordenes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataProductos",
                table: "DataProductos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataProductos",
                table: "DataProductos");

            migrationBuilder.RenameTable(
                name: "Ordenes",
                newName: "OrdenesModel");

            migrationBuilder.RenameTable(
                name: "DataProductos",
                newName: "Productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenesModel",
                table: "OrdenesModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");
        }
    }
}
