using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioColmenaTrabajoPractico.Controlador
{
    public class Localidad
    {
        public int CodigoLocalidad { get; set; }
        public string Nombre { get; set; }

        public int CodigoDepartamento { get; set; }
        public bool Activo { get; set; }
    }
}
