using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public string NombreDeProyecto { get; set; }
        public string Descripcion { get; set; }
        public string Cliente { get; set; }
        public string Terreno { get; set; }
        public string Superficie { get; set; }
        public string Niveles { get; set; }
        public string Habitaciones { get; set; }
        public string Baño { get; set; }
        public string Estilo { get; set; }
        public string Recursos { get; set; }

        public Proyecto() { }
    }
}
