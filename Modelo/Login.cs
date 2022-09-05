using EstudioColmenaTrabajoPractico.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioColmenaTrabajoPractico
{
    public class Login 
    {
        
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static string Apellido { get; set; }
        public static string Nombre { get; set; }
        public static string NivelAcceso { get; set; }
        public static string Email { get; set; }

 
    }
}

