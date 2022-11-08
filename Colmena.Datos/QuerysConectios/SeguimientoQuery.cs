using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.QuerysConectios
{

    public class SeguimientoQuery : Connection<Seguimiento>
    {
        ColmenaConnection connection = new ColmenaConnection();
        public override void Update(Seguimiento obj)
        {
            try
            {

                string sqlSentencia = $"UPDATE[dbo].[Seguimiento]" +
                                      $"SET[IdProyecto] = {obj.IdProyecto}  " +
                                      $",[Factibilidad] = {obj.Factibilidad} " +
                                      ",[DateFactibilidad] =  GETDATE()" +
                                      $",[Implantacion] = {obj.Implantacion} " +
                                      ",[DateImplantacion] =  GETDATE()" +
                                      $",[Vistas] = {obj.Vistas} " +
                                      ",[DateVistas] =  GETDATE()" +
                                      $",[Municipal] = {obj.Municipal} " +
                                      ",[DateMunicipal] =  GETDATE()" +
                                      $",[Legajo] = {obj.Legajo} " +
                                      ",[DateLegajo] =  GETDATE()" +
                                      $",[Computo] = {obj.Computo} " +
                                      ",[DateComputo] =  GETDATE()" +
                                      $",[Comentario] = {obj.Comentario} " +
                                      $"WHERE IdSeguimiento = {obj.IdSeguimiento}";

                sqlSentencia = sqlSentencia.Replace("True", "1");
                sqlSentencia = sqlSentencia.Replace("False", "0");

                SqlConnection sqlCnn = new SqlConnection();

                sqlCnn.ConnectionString = connection.GetConnection();

                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

                sqlCnn.Open();

                var res = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public override void Delete(Seguimiento obj)
        {
            throw new NotImplementedException();
        }

        public override void GetById()
        {
            throw new NotImplementedException();
        }

        public override void Insert(Seguimiento obe)
        {

            try
            {

                string sqlSentencia =
                    "INSERT INTO [dbo].[Seguimiento]" +
                    $"VALUES({obe.IdProyecto}, {obe.Factibilidad}, GETDATE()," +
                    $" {obe.Implantacion}, GETDATE()," +
                    $" {obe.Vistas}, GETDATE()," +
                    $" {obe.Municipal}, GETDATE()," +
                    $" {obe.Legajo}, GETDATE()," +
                    $" {obe.Computo}, GETDATE()," +
                    $" 'Consultar')";

                sqlSentencia = sqlSentencia.Replace("True", "1");
                sqlSentencia = sqlSentencia.Replace("False", "0");

                SqlConnection sqlCnn = new SqlConnection();

                sqlCnn.ConnectionString = connection.GetConnection();

                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);

                sqlCnn.Open();

                var res = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {

            }


        }

        public override DataTable GetAll()
        {
            try
            {
                string sqlSentencia =
                    @"SELECT dbo.Proyecto.IdProyecto , 
                             dbo.Proyecto.Descripcion ,
                            dbo.Proyecto.NombreDeProyecto,
                            dbo.Seguimiento.IdSeguimiento,
                            dbo.Seguimiento.IdProyecto,
                            dbo.Seguimiento.Factibilidad,
                            dbo.Seguimiento.DateFactibilidad, 
                            dbo.Seguimiento.Implantacion,
                            dbo.Seguimiento.DateImplantacion,  
                            dbo.Seguimiento.Vistas,
                            dbo.Seguimiento.DateVistas,
                            dbo.Seguimiento.Municipal,
                            dbo.Seguimiento.DateMunicipal,
                            dbo.Seguimiento.Legajo, 
                            dbo.Seguimiento.DateLegajo,
                            dbo.Seguimiento.Computo,
                            dbo.Seguimiento.DateComputo,
                            dbo.Seguimiento.Comentario
                            FROM dbo.Proyecto 
                            LEFT OUTER JOIN dbo.Seguimiento 
                            ON dbo.Proyecto.IdProyecto = dbo.Seguimiento.IdProyecto";

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
            catch (Exception ex)
            {

                return null;
            }
        }
    }

}
