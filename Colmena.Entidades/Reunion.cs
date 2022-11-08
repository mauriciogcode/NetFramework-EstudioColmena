using System;
using System.Data;

namespace Colmena.Entidades
{
    public class Reunion
    {
        public int IdReunion { get; set; }
        public DateTime FechaReunion { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public int Hora { get; set; }

        public string Estado { get; set; }
        public int IdAsesor { get; set; }
        public int IdProyecto { get; set; }
    }
}
