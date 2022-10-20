using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades
{
    public class IVA
    {
        public int IdIVA { get; set; }
        public string CategoriaIVA { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public string CondicionIVA { get; set; }

    }
}
