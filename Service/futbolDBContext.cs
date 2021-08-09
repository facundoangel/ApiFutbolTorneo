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


            modelBuilder.Entity<FutbolDBEquipos>().HasData(new FutbolDBEquipos[] { 
                equipo1,
                equipo2,
                equipo3,
                equipo4,
                equipo5,
                equipo6

            });


            //AGREGO DATOS INICIALES A LA TABLA DE JUGADORAS
            //JUGADORAS DE ARSENAL
            var jugadora1 = new FutbolDBJugadoras() { id = 1, dni = 40640921, nombre = "Carla", apellido = "Suarez", equipojugando = "Arsenal" };
            var jugadora2 = new FutbolDBJugadoras() { id = 2, dni = 41640822, nombre = "Martina", apellido = "Gutierrez", equipojugando = "Arsenal" };
            var jugadora3 = new FutbolDBJugadoras() { id = 3, dni = 42680923, nombre = "Marta", apellido = "Souza", equipojugando = "Arsenal" };
            var jugadora4 = new FutbolDBJugadoras() { id = 4, dni = 43640924, nombre = "Natalia", apellido = "Perez", equipojugando = "Arsenal" };
            var jugadora5 = new FutbolDBJugadoras() { id = 5, dni = 44640925, nombre = "Rocio", apellido = "Alvarez", equipojugando = "Arsenal" };
            var jugadora6 = new FutbolDBJugadoras() { id = 6, dni = 45640926, nombre = "Micaela", apellido = "Fole", equipojugando = "Arsenal" };
            var jugadora7 = new FutbolDBJugadoras() { id = 7, dni = 46640927, nombre = "Antonela", apellido = "Gonzalez", equipojugando = "Arsenal" };
            var jugadora8 = new FutbolDBJugadoras() { id = 8, dni = 47640928, nombre = "Beatriz", apellido = "Ramirez", equipojugando = "Arsenal" };
            var jugadora9 = new FutbolDBJugadoras() { id = 9, dni = 48640929, nombre = "Gabriela", apellido = "Jacinto", equipojugando = "Arsenal" };
            var jugadora10 = new FutbolDBJugadoras() { id = 10, dni = 49640928, nombre = "Tamara", apellido = "Suarez", equipojugando = "Arsenal" };
            var jugadora11 = new FutbolDBJugadoras() { id = 11, dni = 41040929, nombre = "Belen", apellido = "Martinez", equipojugando = "Arsenal" };
            

            //JUGADORAS DE INDEPENDIENTE
            var jugadora12 = new FutbolDBJugadoras() { id = 12, dni = 41140922, nombre = "Marina", apellido = "Perez", equipojugando = "Independiente" };
            var jugadora13 = new FutbolDBJugadoras() { id = 13, dni = 94120923, nombre = "Martina", apellido = "Alvarez", equipojugando = "Independiente" };
            var jugadora14 = new FutbolDBJugadoras() { id = 14, dni = 41340924, nombre = "Eugenia", apellido = "Souza", equipojugando = "Independiente" };
            var jugadora15 = new FutbolDBJugadoras() { id = 15, dni = 41440925, nombre = "Oriana", apellido = "Gonzalez", equipojugando = "Independiente" };
            var jugadora16 = new FutbolDBJugadoras() { id = 16, dni = 41540926, nombre = "Marina", apellido = "Alvarez", equipojugando = "Independiente" };
            var jugadora17 = new FutbolDBJugadoras() { id = 17, dni = 41640977, nombre = "Marta", apellido = "Angel", equipojugando = "Independiente" };
            var jugadora18 = new FutbolDBJugadoras() { id = 18, dni = 41740928, nombre = "Romina", apellido = "Maritini", equipojugando = "Independiente" };
            var jugadora19 = new FutbolDBJugadoras() { id = 19, dni = 41940929, nombre = "Juliana", apellido = "Capelletti", equipojugando = "Independiente" };

            //JUGADORAS DE BANFIELD
            var jugadora20 = new FutbolDBJugadoras() { id = 20, dni = 42040928, nombre = "Martina", apellido = "Suarez", equipojugando = "Banfield" };
            var jugadora21 = new FutbolDBJugadoras() { id = 21, dni = 42140929, nombre = "Cecilia", apellido = "Gutierrez", equipojugando = "Banfield" };
            var jugadora22 = new FutbolDBJugadoras() { id = 22, dni = 42240921, nombre = "Marta", apellido = "Espinonza", equipojugando = "Banfield" };
            var jugadora23 = new FutbolDBJugadoras() { id = 23, dni = 42340922, nombre = "Julie", apellido = "Tarantini", equipojugando = "Banfield" };
            var jugadora24 = new FutbolDBJugadoras() { id = 24, dni = 42440923, nombre = "Rocio", apellido = "Alvarez", equipojugando = "Banfield" };
            var jugadora25 = new FutbolDBJugadoras() { id = 25, dni = 42540924, nombre = "Micaela", apellido = "Fole", equipojugando = "Banfield" };
            var jugadora26 = new FutbolDBJugadoras() { id = 26, dni = 42640965, nombre = "Antonela", apellido = "Gonzalez", equipojugando = "Banfield" };
            var jugadora27 = new FutbolDBJugadoras() { id = 27, dni = 42740926, nombre = "Abril", apellido = "Ramirez", equipojugando = "Banfield" };
            var jugadora28 = new FutbolDBJugadoras() { id = 28, dni = 42840927, nombre = "Gabriela", apellido = "Jacinto", equipojugando = "Banfield" };
            var jugadora29 = new FutbolDBJugadoras() { id = 29, dni = 42940928, nombre = "Tamara", apellido = "Suarez", equipojugando = "Banfield" };
            var jugadora30 = new FutbolDBJugadoras() { id = 30, dni = 43040929, nombre = "Belen", apellido = "Martinez", equipojugando = "Banfield" };
            var jugadora31 = new FutbolDBJugadoras() { id = 31, dni = 43140900, nombre = "Violeta", apellido = "Espinoza", equipojugando = "Banfield" };

           
            //JUGADORAS DE RACING
            var jugadora32 = new FutbolDBJugadoras() { id = 32, dni = 43240921, nombre = "Catalina", apellido = "Godoy", equipojugando = "Racing" };
            var jugadora33 = new FutbolDBJugadoras() { id = 33, dni = 43340922, nombre = "Martina", apellido = "Perez", equipojugando = "Racing" };
            var jugadora34 = new FutbolDBJugadoras() { id = 34, dni = 34640923, nombre = "Marta", apellido = "Alvarez", equipojugando = "Racing" };
            var jugadora35 = new FutbolDBJugadoras() { id = 35, dni = 43540924, nombre = "Natalia", apellido = "Perez", equipojugando = "Racing" };
            var jugadora36 = new FutbolDBJugadoras() { id = 36, dni = 43640925, nombre = "Guadalupe", apellido = "Garcia", equipojugando = "Racing" };
            var jugadora37 = new FutbolDBJugadoras() { id = 37, dni = 43740926, nombre = "Oriana", apellido = "Fole", equipojugando = "Racing" };
            var jugadora38 = new FutbolDBJugadoras() { id = 38, dni = 43840927, nombre = "Mariana", apellido = "Gonzalez", equipojugando = "Racing" };
            var jugadora39 = new FutbolDBJugadoras() { id = 39, dni = 43940928, nombre = "Patricia", apellido = "Naupari", equipojugando = "Racing" };
            var jugadora40 = new FutbolDBJugadoras() { id = 40, dni = 44040929, nombre = "Nicole", apellido = "Jacinto", equipojugando = "Racing" };
            

            //JUGADORAS DE RIVER
            var jugadora41 = new FutbolDBJugadoras() { id = 41, dni = 44140920, nombre = "Carla", apellido = "Suarez", equipojugando = "River" };
            var jugadora42 = new FutbolDBJugadoras() { id = 42, dni = 44240920, nombre = "Martina", apellido = "Gutierrez", equipojugando = "River" };
            var jugadora43 = new FutbolDBJugadoras() { id = 43, dni = 44340920, nombre = "Marta", apellido = "Souza", equipojugando = "River" };
            var jugadora44 = new FutbolDBJugadoras() { id = 44, dni = 44440921, nombre = "Natalia", apellido = "Perez", equipojugando = "River" };
            var jugadora45 = new FutbolDBJugadoras() { id = 45, dni = 44540922, nombre = "Rocio", apellido = "Alvarez", equipojugando = "River" };
            var jugadora46 = new FutbolDBJugadoras() { id = 46, dni = 44640923, nombre = "Micaela", apellido = "Fole", equipojugando = "River" };
            var jugadora47 = new FutbolDBJugadoras() { id = 47, dni = 44740924, nombre = "Antonela", apellido = "Gonzalez", equipojugando = "River" };
            var jugadora48 = new FutbolDBJugadoras() { id = 48, dni = 44840925, nombre = "Diana", apellido = "Ramirez", equipojugando = "River" };
            var jugadora49 = new FutbolDBJugadoras() { id = 49, dni = 44940927, nombre = "Gabriela", apellido = "Jacinto", equipojugando = "River" };
            var jugadora50 = new FutbolDBJugadoras() { id = 50, dni = 45040956, nombre = "Tamara", apellido = "Suarez", equipojugando = "River" };
            var jugadora51 = new FutbolDBJugadoras() { id = 51, dni = 45140929, nombre = "Belen", apellido = "Martinez", equipojugando = "River" };


            modelBuilder.Entity<FutbolDBJugadoras>().HasData(new FutbolDBJugadoras[] {
                jugadora1,
                jugadora2,
                jugadora3,
                jugadora4,
                jugadora5,
                jugadora6,
                jugadora7,
                jugadora8,
                jugadora9,
                jugadora10,
                jugadora11,
                jugadora12,
                jugadora13,
                jugadora14,
                jugadora15,
                jugadora16,
                jugadora17,
                jugadora18,
                jugadora19,
                jugadora20,
                jugadora21,
                jugadora22,
                jugadora23,
                jugadora25,
                jugadora26,
                jugadora27,
                jugadora28,
                jugadora29,
                jugadora30,
                jugadora31,
                jugadora32,
                jugadora33,
                jugadora34,
                jugadora35,
                jugadora36,
                jugadora37,
                jugadora38,
                jugadora39,
                jugadora41,
                jugadora42,
                jugadora43,
                jugadora44,
                jugadora45,
                jugadora46,
                jugadora47,
                jugadora48,
                jugadora49,
                jugadora50,
                jugadora51

            });


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<FutbolDBEquipos> FutbolDBEquipos { get; set; }
        public DbSet<FutbolDBJugadoras> FutbolDBJugadoras { get; set; }


    }
}
