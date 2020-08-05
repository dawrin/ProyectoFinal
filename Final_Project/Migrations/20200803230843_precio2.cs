using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class precio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "DATA",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "DATA");
        }
    }
}
