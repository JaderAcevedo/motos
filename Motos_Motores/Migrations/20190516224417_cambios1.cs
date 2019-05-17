using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Migrations
{
    public partial class cambios1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreProducto",
                table: "Inventarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreProducto",
                table: "Inventarios");
        }
    }
}
