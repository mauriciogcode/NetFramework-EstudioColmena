using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades
{
    public class Cuenta
    {
        public int IdPrecio { get; set; }
        public decimal PrecioActual { get; set; }
        public string TipoDeComprobante { get; set; }
        public int IdIVA { get; set; }
        public int NroDeComprobante { get; set; }



    }
}
