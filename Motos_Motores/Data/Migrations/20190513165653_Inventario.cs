using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Data.Migrations
{
    public partial class Inventario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_IdProducto",
                table: "Inventarios",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_Productos_IdProducto",
                table: "Inventarios",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_Productos_IdProducto",
                table: "Inventarios");

            migrationBuilder.DropIndex(
                name: "IX_Inventarios_IdProducto",
                table: "Inventarios");
        }
    }
}
