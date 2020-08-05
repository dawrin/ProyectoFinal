using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class fechacar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FechaCliente",
                table: "DATA",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCliente",
                table: "DATA");
        }
    }
}
