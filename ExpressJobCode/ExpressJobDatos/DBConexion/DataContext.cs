using ExpressJobDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.DBConexion
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuario {get; set;}

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Trabajador> Trabajador { get; set; }

        public DbSet<Consumidor> Consumidor { get; set; }
    }
}
