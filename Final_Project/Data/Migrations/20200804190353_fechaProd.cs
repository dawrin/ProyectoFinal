using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class fechaProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FechaCliente",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCliente",
                table: "Productos");
        }
    }
}
