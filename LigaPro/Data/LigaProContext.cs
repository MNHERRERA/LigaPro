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
                }
            );
        }


    }

}
