using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.Modelo
{
    public class Usuario
    {
        public int UsuairoId { get; set; }

        public string Contrasena { get; set; }

        public string CorreoElectronico { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
