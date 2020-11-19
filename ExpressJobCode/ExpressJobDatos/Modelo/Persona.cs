using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.Modelo
{
  
    public abstract class Persona
    {

        public int PersonaId { get; set; }
        public string Nombre { get; set; }

        public string ApellidoMaterno { get; set; }

        public string ApellidoPaterno { get; set; }

        public string TelefonoMovil { get; set; }

        public byte[] Fotografia { get; set; }

        public virtual Direccion Direccion { get; set; }




    }
}
