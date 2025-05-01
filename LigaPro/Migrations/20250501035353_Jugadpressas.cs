using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LigaPro.Migrations
{
    /// <inheritdoc />
    public partial class Jugadpressas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 3,
                columns: new[] { "LogoUrl", "Nombre" },
                values: new object[] { "/Logos/emele.png", "Emelec" });

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 4,
                column: "LogoUrl",
                value: "/Logos/auca.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 3,
                columns: new[] { "LogoUrl", "Nombre" },
                values: new object[] { "/Logos/emel.png", "Emel" });

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 4,
                column: "LogoUrl",
                value: "/Logos/aucas.png");
        }
    }
}
