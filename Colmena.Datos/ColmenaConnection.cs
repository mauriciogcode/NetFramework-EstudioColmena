using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos
{
    public class ColmenaConnection
    {
        private readonly string connectionString;

        public ColmenaConnection()
        {
            //connectionString = "Server = DESKTOP-EU2DK6D;DataBase=EstudioColmena; integrated security =true";
            // connectionString = "Server = DANIELA\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";
            //connectionString = "Server = TECWARE\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";

            connectionString = "Server = DESKTOP-R6ML4P4\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";
            //connectionString = "Server = DESKTOP-CBVPLVN\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";
        }
        public string GetConnection()
        {
            return connectionString;
        }
    }
}
