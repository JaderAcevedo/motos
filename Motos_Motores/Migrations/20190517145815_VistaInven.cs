using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Migrations
{
    public partial class VistaInven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Compras",
                table: "Inventarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ventas",
                table: "Inventarios",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Compras",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "Ventas",
                table: "Inventarios");
        }
    }
}
