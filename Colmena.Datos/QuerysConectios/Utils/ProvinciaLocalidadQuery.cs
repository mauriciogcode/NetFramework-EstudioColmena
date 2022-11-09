using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.QuerysConectios.Utils
{
    public class ProvinciaLocalidadQuery
    {
        ColmenaConnection connection = new ColmenaConnection();

        public DataTable GetProvincias()
        {
            List<Provincia> oListaProvincia = new List<Provincia>();
            string sqlSentencia = $"select * from Provincia";

            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = connection.GetConnection();

            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

            sqlCnn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);

            sqlCnn.Close();
            return ds.Tables[0];


        }

        public DataTable GetDepartamentos(int CodigoProvincia)
        {
            List<Departamento> oListaDepartamento = new List<Departamento>();
            string sqlSentencia = $"select * from Departamento WHERE CodigoProvincia = {CodigoProvincia}";

            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = connection.GetConnection();

            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

            sqlCnn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);

            sqlCnn.Close();
            return ds.Tables[0];





        }
    }

}
