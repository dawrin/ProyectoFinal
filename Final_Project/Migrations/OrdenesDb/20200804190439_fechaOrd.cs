using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations.OrdenesDb
{
    public partial class fechaOrd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FechaCliente",
                table: "Orden",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCliente",
                table: "Orden");
        }
    }
}
