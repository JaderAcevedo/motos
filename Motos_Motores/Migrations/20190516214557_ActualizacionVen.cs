using Microsoft.EntityFrameworkCore.Migrations;

namespace Motos_Motores.Migrations
{
    public partial class ActualizacionVen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Ventas",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cantidad",
                table: "Ventas",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
