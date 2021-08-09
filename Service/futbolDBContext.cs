using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using ApiFutbolTorneo.Entities;



namespace ApiFutbolTorneo.Service

{
    public class FutbolDBContext : DbContext
    {
        public FutbolDBContext(DbContextOptions<FutbolDBContext> options) : base(options)
        {
            
        }

        //INICIALIZÓ LA BASE DE DATOS CON UNOS CIERTOS REGISTROS POR DEFECTO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AGREGO DATOS INICIALES A LA TABLA DE EQUIPOS
            var equipo1 = new FutbolDBEquipos() { id = 1, equipo = "Arsenal", color = "celeste" };
            var equipo2 = new FutbolDBEquipos() { id = 2, equipo = "Independiente", color = "rojo" };
            var equipo3 = new FutbolDBEquipos() { id = 3, equipo = "Banfield", color = "verde y rojo" };
            var equipo4 = new FutbolDBEquipos() { id = 4, equipo = "Tigre", color = "rojo y azul" };
            var equipo5 = new FutbolDBEquipos() { id = 5, equipo = "Racing", color = "celeste y blanco" };
            var equipo6 = new FutbolDBEquipos() { id = 6, equipo = "River", color = "rojo y blanco" };
            var equipo7 = new FutbolDBEquipos() { id = 7, equipo = "Boca", color = "azul y amarrillo" };
            var equipo8 = new FutbolDBEquipos() { id = 8, equipo = "Porvenir", color = "blanco y negro" };
            var equipo9 = new FutbolDBEquipos() { id = 9, equipo = "Lanus", color = "Granate" };
            var equipo10 = new FutbolDBEquipos() { id = 10, equipo = "Ferro", color = "verde" };

            modelBuilder.Entity<FutbolDBEquipos>().HasData(new FutbolDBEquipos[] { 
                equipo1,
                equipo2,
                equipo3,
                equipo4,
                equipo5,
                equipo6,
                equipo7,
                equipo8,
                equipo9,
                equipo10,

            });

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<FutbolDBEquipos> FutbolDBEquipos { get; set; }
        public DbSet<FutbolDBJugadoras> FutbolDBJugadoras { get; set; }


    }
}
