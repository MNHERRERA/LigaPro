using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaPro.Models;

namespace LigaPro.Data
{
    public class LigaProContext : DbContext
    {
        public LigaProContext (DbContextOptions<LigaProContext> options)
            : base(options)
        {
        }

        public DbSet<LigaPro.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<LigaPro.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Equipo> Equipos { get; set; }  // <-- Aquí está tabla Equipos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aquí debes agregar el código de seed:
             modelBuilder.Entity<Jugador>()
        .         Property(j => j.Sueldo)
                 .HasPrecision(18, 2);

            modelBuilder.Entity<Equipo>().HasData(
                new Equipo
                {
                    EquipoId = 1,
                    Nombre = "BSC",
                    PartidosGanados = 3,
                    PartidosEmpatados = 5,
                    PartidosPerdidos = 3,
                    LogoUrl = "/Logos/bsc.jpeg",
                    Descripcion = "Equipo de Guayaquil conocido como Barcelona SC."
                },
                new Equipo
                {
                    EquipoId = 2,
                    Nombre = "LDU",
                    PartidosGanados = 4,
                    PartidosEmpatados = 2,
                    PartidosPerdidos = 2,
                    LogoUrl = "/Logos/ldu.png",
                    Descripcion = "Equipo de Quito conocido como Liga Deportiva Universitaria."
                },
                 new Equipo
                 {
                     EquipoId = 3,
                     Nombre = "Emelec",
                     PartidosGanados = 1,
                     PartidosEmpatados = 3,
                     PartidosPerdidos = 4,
                     LogoUrl = "/Logos/emele.png", // Ruta al logo de Emel
                     Descripcion = "Equipo de Guayaquil, conocido como Emel. Club con una historia reciente en el fútbol ecuatoriano."
                 },
                new Equipo
                {
                    EquipoId = 4,
                    Nombre = "Aucas",
                    PartidosGanados = 5,
                    PartidosEmpatados = 2,
                    PartidosPerdidos = 3,
                    LogoUrl = "/Logos/auca.png", // Ruta al logo de Aucas
                    Descripcion = "Equipo de Quito, conocido como Aucas, uno de los equipos históricos del fútbol ecuatoriano."
                }
            );
            // Semilla para jugadores, si tienes jugadores en tu base de datos
            modelBuilder.Entity<Jugador>().HasData(
                new Jugador
                {
                    JugadorId = 1,
                    Nombre = "Carlos Sánchez",
                    Goles = 15,
                    Posicion = "Delantero",
                    EquipoId = 1  // Se asocia al equipo BSC
                },
                new Jugador
                {
                    JugadorId = 2,
                    Nombre = "Javier Pérez",
                    Goles = 10,
                    Posicion = "Delantero",
                    EquipoId = 1  // Se asocia al equipo BSC
                },
                new Jugador
                {
                    JugadorId = 3,
                    Nombre = "Luis González",
                    Goles = 20,
                    Posicion = "Delantero",
                    EquipoId = 2  // Se asocia al equipo LDU
                },
                new Jugador
                {
                    JugadorId = 4,
                    Nombre = "Fernando Díaz",
                    Goles = 12,
                    Posicion = "Delantero",
                    EquipoId = 2  // Se asocia al equipo LDU
                },
                // Semilla para los jugadores de Emel y Aucas
                new Jugador
                {
                    JugadorId = 5,
                    Nombre = "José Martínez",
                    Goles = 8,
                    Posicion = "Delantero",
                    EquipoId = 3  // Se asocia al equipo Emel
                },
                new Jugador
                {
                    JugadorId = 6,
                    Nombre = "Miguel Silva",
                    Goles = 5,
                    Posicion = "Delantero",
                    EquipoId = 3  // Se asocia al equipo Emel
                },
                new Jugador
                {
                    JugadorId = 7,
                    Nombre = "Juan Pérez",
                    Goles = 16,
                    Posicion = "Delantero",
                    EquipoId = 4  // Se asocia al equipo Aucas
                },
                new Jugador
                {
                    JugadorId = 8,
                    Nombre = "Ricardo López",
                    Goles = 10,
                    Posicion = "Delantero",
                    EquipoId = 4  // Se asocia al equipo Aucas
                }
            );
        }


    }

}
