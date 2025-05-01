using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LigaPro.Migrations
{
    /// <inheritdoc />
    public partial class Jugadpres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jugador",
                columns: new[] { "JugadorId", "Asistencias", "EquipoId", "Goles", "Nombre", "NumeroCamiseta", "Posicion", "Sueldo" },
                values: new object[,]
                {
                    { 1, 0, 1, 15, "Carlos Sánchez", 0, "Delantero", 0m },
                    { 2, 0, 1, 10, "Javier Pérez", 0, "Delantero", 0m },
                    { 3, 0, 2, 20, "Luis González", 0, "Delantero", 0m },
                    { 4, 0, 2, 12, "Fernando Díaz", 0, "Delantero", 0m },
                    { 5, 0, 3, 8, "José Martínez", 0, "Delantero", 0m },
                    { 6, 0, 3, 5, "Miguel Silva", 0, "Delantero", 0m },
                    { 7, 0, 4, 16, "Juan Pérez", 0, "Delantero", 0m },
                    { 8, 0, 4, 10, "Ricardo López", 0, "Delantero", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jugador",
                keyColumn: "JugadorId",
                keyValue: 8);
        }
    }
}
