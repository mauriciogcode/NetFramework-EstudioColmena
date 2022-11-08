using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos
{
    public class ClienteConeccion : Connection<Cliente>
    {
        ColmenaConnection connection = new ColmenaConnection();

        public override void Delete(Cliente obj)
        {
            try
            {
                string sqlSentencia = "sp_CLIENTE_DELETE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@ID", SqlDbType.NVarChar).Value = obj.Documento;

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
                string sqlSentencia = $"select IdCliente, documento as 'D.N.I', Apellido +', '+ Nombre as 'Apellido y Nombre',Barrio,Calle + ' N° ' + Altura as 'Domicilio',Piso + ' - ' + Depto as 'Piso-Departamento',Email as 'Correo Electronico',Ocupacion,Telefono from cliente";
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

        public override void Insert(Cliente obj)
        {
            try
            {
                string sqlSentencia = "sp_CLIENTE_INSERT";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@DOCUMENTO", SqlDbType.NVarChar).Value = obj.Documento;
                sqlComm.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = obj.Apellido;
                sqlComm.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.Nombre;
                sqlComm.Parameters.Add("@BARRIO", SqlDbType.NVarChar).Value = obj.Barrio;
                sqlComm.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = obj.Calle;
                sqlComm.Parameters.Add("@ALTURA", SqlDbType.NVarChar).Value = obj.Altura;
                sqlComm.Parameters.Add("@PISO", SqlDbType.NVarChar).Value = obj.Piso;
                sqlComm.Parameters.Add("@DEPTO", SqlDbType.NVarChar).Value = obj.Depto;
                sqlComm.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = obj.Email;
                sqlComm.Parameters.Add("@OCUPACION", SqlDbType.NVarChar).Value = obj.Ocupacion;
                sqlComm.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = obj.Telefono;

                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Cliente obj)
        {
            try
            {
                string sqlSentencia = "sp_CLIENTE_UPDATE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@DOCUMENTO", SqlDbType.NVarChar).Value = obj.Documento;
                sqlComm.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = obj.Apellido;
                sqlComm.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.Nombre;
                sqlComm.Parameters.Add("@BARRIO", SqlDbType.NVarChar).Value = obj.Barrio;
                sqlComm.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = obj.Calle;
                sqlComm.Parameters.Add("@ALTURA", SqlDbType.NVarChar).Value = obj.Altura;
                sqlComm.Parameters.Add("@PISO", SqlDbType.NVarChar).Value = obj.Piso;
                sqlComm.Parameters.Add("@DEPTO", SqlDbType.NVarChar).Value = obj.Depto;
                sqlComm.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = obj.Email;
                sqlComm.Parameters.Add("@OCUPACION", SqlDbType.NVarChar).Value = obj.Ocupacion;
                sqlComm.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = obj.Telefono;
                sqlComm.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdCliente;

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
