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
    public class ProyectoConeccion : Connection<Proyecto>
    {
        ColmenaConnection connection = new ColmenaConnection();
        public override void Delete(Proyecto obj)
        {

            try
            {
                string sqlSentencia = "sp_PROYECTO_DELETE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdProyecto;

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
                string sqlSentencia = $"select * from v_PROYECTO";
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

        public override void Insert(Proyecto obj)
        {
            try
            {
                string sqlSentencia = "sp_PROYECTO_CREATE"; 
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NombreDeProyecto;
                sqlComm.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = obj.Descripcion;
                sqlComm.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = obj.Cliente;
                sqlComm.Parameters.Add("@TERRENO", SqlDbType.NVarChar).Value = obj.Terreno;
                sqlComm.Parameters.Add("@SUPERFICIE", SqlDbType.NVarChar).Value = obj.Superficie;
                sqlComm.Parameters.Add("@NIVELES", SqlDbType.NVarChar).Value = obj.Niveles;
                sqlComm.Parameters.Add("@HABITACIONES", SqlDbType.NVarChar).Value = obj.Habitaciones;
                sqlComm.Parameters.Add("@BAÑO", SqlDbType.NVarChar).Value = obj.Baño;
                sqlComm.Parameters.Add("@ESTILO", SqlDbType.NVarChar).Value = obj.Estilo;
                sqlComm.Parameters.Add("@RECURSOS", SqlDbType.NVarChar).Value = obj.Recursos;
 
                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Proyecto obj)
        {
            try
            {
                string sqlSentencia = "sp_PROYECTO_UPDATE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.NombreDeProyecto;
                sqlComm.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = obj.Descripcion;
                sqlComm.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = obj.Cliente;
                sqlComm.Parameters.Add("@TERRENO", SqlDbType.NVarChar).Value = obj.Terreno;
                sqlComm.Parameters.Add("@SUPERFICIE", SqlDbType.NVarChar).Value = obj.Superficie;
                sqlComm.Parameters.Add("@NIVELES", SqlDbType.NVarChar).Value = obj.Niveles;
                sqlComm.Parameters.Add("@HABITACIONES", SqlDbType.NVarChar).Value = obj.Habitaciones;
                sqlComm.Parameters.Add("@BAÑO", SqlDbType.NVarChar).Value = obj.Baño;
                sqlComm.Parameters.Add("@ESTILO", SqlDbType.NVarChar).Value = obj.Estilo;
                sqlComm.Parameters.Add("@RECURSOS", SqlDbType.NVarChar).Value = obj.Recursos;
                sqlComm.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdProyecto;

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
