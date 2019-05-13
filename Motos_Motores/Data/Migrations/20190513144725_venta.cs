using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Data.Migrations
{
    public partial class venta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockProducto",
                table: "Productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockProducto",
                table: "Productos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
