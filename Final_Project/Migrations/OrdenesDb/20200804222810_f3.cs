using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations.OrdenesDb
{
    public partial class f3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoSlider",
                table: "Orden",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoSlider",
                table: "Orden");
        }
    }
}
