using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class Carr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApellidoCliente",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitud",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitud",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreOrden",
                table: "DATA",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "DATA",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApellidoCliente",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "NombreOrden",
                table: "DATA");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "DATA");
        }
    }
}
