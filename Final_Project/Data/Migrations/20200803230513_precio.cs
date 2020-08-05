using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class precio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Productos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");
        }
    }
}
