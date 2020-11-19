using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.Modelo
{
    public class Direccion
    {
        public int DireccionId { get; set; }

        public string Calle { get; set; }

        public string CalleColindancia { get; set; }

        public string Colonia { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterno { get; set; }


    }
}
