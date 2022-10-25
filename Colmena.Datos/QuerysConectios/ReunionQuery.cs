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
    public class ReunionQuery : Connection<Reunion>
    {
        ColmenaConnection connection = new ColmenaConnection();

        public override  void Delete(Reunion obe)
        {
            try
            {
                string sqlSentencia = $"DELETE FROM Reunion WHERE IdReunion = {obe.IdReunion}";



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
                      @"SELECT
                    dbo.Reunion.IdReunion,
                    dbo.Reunion.FechaReunion,
                    dbo.Reunion.FechaDeCreacion,
                    dbo.Reunion.Estado,
                    dbo.Proyecto.IdProyecto,
                    dbo.Proyecto.NombreDeProyecto,
                    dbo.Login.IdUsuario,
                    dbo.Login.Usuario
               FROM dbo.Reunion
               INNER JOIN dbo.Proyecto ON dbo.Reunion.IdProyecto = dbo.Proyecto.IdProyecto
               INNER JOIN dbo.Login ON dbo.Reunion.IdUsuario = dbo.Login.IdUsuario
               ORDER BY FechaReunion ASC";

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

        public override void GetById()
        {

        }

        public override void Insert(Reunion obe)
        {
            try
            {

                string sqlSentencia = $"INSERT INTO [dbo].[Reunion] " +
                                      $"VALUES('{obe.FechaReunion.ToString("yyyy-MM-dd")}', GETDATE(), 1, '{obe.Estado}', {obe.IdAsesor}, {obe.IdProyecto})";


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

        public override void Update(Reunion obe)
        {
            try
            {

                string sqlSentencia = $"UPDATE Reunion" +
                                        $" SET FechaReunion = {obe.FechaReunion.ToString("yyyy-MM-dd")}" +
                                        $" ,Estado = '{obe.Estado}'" +
                                        $" ,IdUsuario = {obe.IdAsesor}" +
                                        $" ,IdProyecto = {obe.IdProyecto}" +
                                        $" WHERE IdReunion = {obe.IdReunion}";

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

        public DataTable GetByDate(Reunion obe)
        {
            try
            {
                string sqlSentencia =
                    $" SELECT   dbo.Reunion.IdReunion, " +
                    $" dbo.Reunion.FechaReunion, " +
                    $" dbo.Reunion.FechaDeCreacion," +
                    $" dbo.Reunion.Estado," +
                    $" dbo.Proyecto.NombreDeProyecto," +
                    $" dbo.Login.Usuario " +
                    $" FROM dbo.Reunion " +
                    $" INNER JOIN dbo.Proyecto ON dbo.Reunion.IdProyecto = dbo.Proyecto.IdProyecto " +
                    $" INNER JOIN dbo.Login ON dbo.Reunion.IdUsuario = dbo.Login.IdUsuario " +
                    $" WHERE FechaReunion BETWEEN '{obe.FechaReunion.AddDays(-1).ToString("yyyy-MM-dd")}' and '{obe.FechaReunion.AddDays(1).ToString("yyyy-MM-dd")}' " +
                    $" ORDER BY FechaReunion ASC ";



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

