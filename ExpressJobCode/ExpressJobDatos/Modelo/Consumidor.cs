using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressJobDatos.Modelo
{
    public class Consumidor : Persona
    {
        public int ConsumidorId { get; set; }

        public string Alias { get; set; }
    }
}
