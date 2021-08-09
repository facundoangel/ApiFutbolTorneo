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
            options.SetInitializer<FutbolDBContext>(new UniDBInitializer<FutbolDBContext>());
        }

        public DbSet<FutbolDBEquipos> FutbolDBEquipos { get; set; }
        public DbSet<FutbolDBJugadoras> FutbolDBJugadoras { get; set; }


        private class UniDBInitializer<T> : DropCreateDatabaseAlways<FutbolDBContext>
        {

            protected override void Seed(FutbolDBContext context)
            {

                IList<Student> students = new List<Student>();

                students.Add(new Student()
                {
                    FirstMidName = "Andrew",
                    LastName = "Peters",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                });

                students.Add(new Student()
                {
                    FirstMidName = "Brice",
                    LastName = "Lambson",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                });

                students.Add(new Student()
                {
                    FirstMidName = "Rowan",
                    LastName = "Miller",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                });

                foreach (Student student in students)
                    context.Students.Add(student);
                base.Seed(context);
            }
        }

    }
}
