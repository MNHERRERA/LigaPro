using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LigaPro.Migrations
{
    /// <inheritdoc />
    public partial class SeedEquiposYJugadoresdsad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipo",
                columns: new[] { "EquipoId", "Descripcion", "LogoUrl", "Nombre", "PartidosEmpatados", "PartidosGanados", "PartidosJugados", "PartidosPerdidos" },
                values: new object[,]
                {
                    { 3, "Equipo de Guayaquil, conocido como Emel. Club con una historia reciente en el fútbol ecuatoriano.", "/Logos/emel.png", "Emel", 3, 1, 0, 4 },
                    { 4, "Equipo de Quito, conocido como Aucas, uno de los equipos históricos del fútbol ecuatoriano.", "/Logos/aucas.png", "Aucas", 2, 5, 0, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 4);
        }
    }
}
