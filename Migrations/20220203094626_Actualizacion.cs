using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiempo.Migrations
{
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecipitacionAcumulada",
                table: "Tiempo",
                newName: "Precipitacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Precipitacion",
                table: "Tiempo",
                newName: "PrecipitacionAcumulada");
        }
    }
}
