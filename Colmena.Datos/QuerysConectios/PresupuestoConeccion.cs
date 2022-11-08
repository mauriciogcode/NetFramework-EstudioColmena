using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class PresupuestoConeccion
    {
        ColmenaConnection connection = new ColmenaConnection();
        public DataTable GetClientes()
        {
            try
            {
                string sqlSentencia = "select * from v_ClientePresupuesto";
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
        public DataTable GetProyecto()
        {
            try
            {
                string sqlSentencia = "select * from v_ProyectoPresupuesto";
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
        public void Insert(Presupuesto presupuesto)
        {
            try
            {
                string sqlSentencia = "sp_INSERT_PRESUPUESTO";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@TOTAL", SqlDbType.Int).Value = presupuesto.TotalNeto;
                sqlComm.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = presupuesto.FechaDeCreacion;
                

                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
