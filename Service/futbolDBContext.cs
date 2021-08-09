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

        public DbSet<FutbolDBEquipos> FutbolDBEquipos { get; set; }
        public DbSet<FutbolDBJugadoras> FutbolDBJugadoras { get; set; }

    }
}
