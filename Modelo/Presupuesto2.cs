using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades.Modelo
{
    class Presupuesto2
    {
        public string Cliente { get; set; }
        public string Proyecto { get; set; }
        public string Tipologia { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
    }
}
