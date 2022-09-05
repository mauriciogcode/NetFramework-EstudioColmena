using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public int IdLocalidad { get; set; }
    }
}
