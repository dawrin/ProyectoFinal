using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApellidoCliente",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitud",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitud",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreOrden",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Productos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrdenesModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(nullable: true),
                    NombreOrden = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    NombreCliente = table.Column<string>(nullable: true),
                    ApellidoCliente = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenesModel");

            migrationBuilder.DropColumn(
                name: "ApellidoCliente",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "NombreOrden",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Productos");
        }
    }
}
