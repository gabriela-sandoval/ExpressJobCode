using ExpressJobDatos.Modelo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.Modelo
{
    public class Trabajador : Persona
    {
        public string TrabjadorId { get; set; }

        public string Descripción { get; set; }

        public string TelefonoFijo { get; set; }

        public TipoServicio TipoServicio { get; set; }

        public Municipio Municipio { get; set; }



    }
}
