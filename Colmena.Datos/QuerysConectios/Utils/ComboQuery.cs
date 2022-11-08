using System.Data.SqlClient;
using System.Data;
using System;

namespace Colmena.Datos.QuerysConectios.Utils
{
    public class ComboQuery
    {
        ColmenaConnection connection = new ColmenaConnection();

        public DataTable GetProjects()
        {
            try
            {
                string sqlSentencia = $"select * from PROYECTO";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

                sqlCnn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlComm;
                dataAdapter.Fill(ds);


                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUsers()
        {
            try
            {
                string sqlSentencia = $"SELECT Usuario, Nombre, Apellido, IdUsuario FROM dbo.Login";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

                sqlCnn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sqlComm;
                dataAdapter.Fill(ds);


                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}