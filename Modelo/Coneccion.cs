using System.Data.SqlClient;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    public abstract class Coneccion
    {
        private readonly string connectionString;
        public Coneccion()
        {
            //connectionString = "Server = DESKTOP-EU2DK6D;DataBase=EstudioColmena; integrated security =true";
           // connectionString = "Server = DANIELA\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true"; 
            //connectionString = "Server = TECWARE\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";

            connectionString = "Server = localhost\\SQLEXPRESS;DataBase=EstudioColmena; integrated security =true";
        }
        protected SqlConnection GetConnection()
        {

            return new SqlConnection(connectionString);

        }
    }


}

