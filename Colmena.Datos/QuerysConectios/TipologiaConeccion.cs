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
    public class TipologiaConeccion : Connection<Tipologia>
    {

        ColmenaConnection connection = new ColmenaConnection();
        public override void Delete(Tipologia obj)
        {
            try
            {
                string sqlSentencia = "sp_TIPOLOGIA_DELETE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdTipologia;

                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override DataTable GetAll()
        {
            try
            {
                string sqlSentencia = $"select * from v_TIPOLOGIA";
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

        public override void GetById()
        {
            throw new NotImplementedException();
        }

        public override void Insert(Tipologia obj)
        {
            try
            {
                string sqlSentencia = "sp_TIPOLOGIA_CREATE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@TIPO", SqlDbType.NVarChar).Value = obj.Tipo;
                sqlComm.Parameters.Add("@CARACTERISTICAS", SqlDbType.NVarChar).Value = obj.Caracteristicas;
               
                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Tipologia obj)
        {
            try
            {
                string sqlSentencia = "sp_TIPOLOGIA_UPDATE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@TIPO", SqlDbType.NVarChar).Value = obj.Tipo;
                sqlComm.Parameters.Add("@CARACTERISTICAS", SqlDbType.NVarChar).Value = obj.Caracteristicas;
                sqlComm.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdTipologia;

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
