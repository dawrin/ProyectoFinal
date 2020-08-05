using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations.OrdenesDb
{
    public partial class Orden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    NombreOrden = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Orden", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orden");
        }
    }
}
