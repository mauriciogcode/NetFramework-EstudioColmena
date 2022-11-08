using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }
        public int? IdProyecto { get; set; }
        public bool? Factibilidad { get; set; }
        public DateTime? DateFactibilidad { get; set; }
        public bool? Implantacion { get; set; }
        public DateTime? DateImplantacion { get; set; }
        public bool? Vistas { get; set; }
        public DateTime? DateVistas { get; set; }
        public bool? Municipal { get; set; }
        public DateTime? DateMunicipal { get; set; }
        public bool? Legajo { get; set; }
        public DateTime? DateLegajo { get; set; }
        public bool? Computo { get; set; }
        public DateTime? DateComputo { get; set; }
        public string Comentario { get; set; }


    }
}
