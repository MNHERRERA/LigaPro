using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LigaPro.Migrations
{
    /// <inheritdoc />
    public partial class dos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 1,
                column: "Descripcion",
                value: "Equipo de Guayaquil conocido como Barcelona SC.");

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 2,
                columns: new[] { "Descripcion", "PartidosEmpatados", "PartidosGanados", "PartidosPerdidos" },
                values: new object[] { "Equipo de Quito conocido como Liga Deportiva Universitaria.", 2, 4, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 1,
                column: "Descripcion",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipo",
                keyColumn: "EquipoId",
                keyValue: 2,
                columns: new[] { "Descripcion", "PartidosEmpatados", "PartidosGanados", "PartidosPerdidos" },
                values: new object[] { null, 5, 3, 3 });

            migrationBuilder.InsertData(
                table: "Equipo",
                columns: new[] { "EquipoId", "Descripcion", "LogoUrl", "Nombre", "PartidosEmpatados", "PartidosGanados", "PartidosJugados", "PartidosPerdidos" },
                values: new object[,]
                {
                    { 3, null, "/Logos/emele.png", "Emelec", 5, 3, 0, 3 },
                    { 4, null, "/Logos/auca.png", "Aucas", 5, 3, 0, 3 }
                });
        }
    }
}
