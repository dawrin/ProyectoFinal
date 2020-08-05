using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class f2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoSlider",
                table: "DATA",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoSlider",
                table: "DATA");
        }
    }
}
