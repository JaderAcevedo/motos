using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Data.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Producto",
                table: "Venta");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Venta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdProducto",
                table: "Venta",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Productos_IdProducto",
                table: "Venta",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Productos_IdProducto",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_IdProducto",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Venta");

            migrationBuilder.AddColumn<string>(
                name: "Producto",
                table: "Venta",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
