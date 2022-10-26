using Colmena.Entidades;
using Colmena.Entidades.ServicioEmail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{

    public class LoginConeccion
    {
        ColmenaConnection connection = new ColmenaConnection();

        public void CrearUsuario(Entidades.Login obj)
        {

            try
            {
                string sqlSentencia = "sp_LOGIN_CREATE";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = obj.Usuario;
                sqlComm.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar).Value = obj.Contraseña;
                sqlComm.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = obj.Email;
                sqlComm.Parameters.Add("@NIVELACCESO", SqlDbType.NVarChar).Value = obj.NivelAcceso;
                sqlComm.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = obj.Nombre;
                sqlComm.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = obj.Apellido;


                sqlCnn.Open();

                var respuesta = sqlComm.ExecuteNonQuery();

                sqlCnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //public bool LoginUser(Login obj)
        //{
        //    return obj.;
        //}

        public bool LoginDeUsuario(Login obj)
        {
            try
            {
                string sqlSentencia = "select*from Login where Usuario='" + obj.Usuario + "' and Contraseña ='" + obj.Contraseña + "'";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.Text;
                sqlCnn.Open();
                SqlDataReader reader = sqlComm.ExecuteReader();


                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        obj.IdUsuario = reader.GetInt32(0);
                        obj.Usuario = reader.GetString(1);
                        obj.Contraseña = reader.GetString(2);
                        obj.Nombre = reader.GetString(5);
                        obj.Apellido = reader.GetString(6);
                        obj.NivelAcceso = reader.GetString(4);
                        obj.Email = reader.GetString(3);

                    }
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string RecuperarContraseña(Login obj)
        {
            try
            {
                string sqlSentencia = "select*from Login where Usuario='" + obj.Usuario + "' or Email ='" + obj.Email + "'";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = connection.GetConnection();
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.Text;
                sqlCnn.Open();
                SqlDataReader reader = sqlComm.ExecuteReader();


              

                if (reader.Read() == true)
                {
                    string Usuario = reader.GetString(5) + ", " + reader.GetString(6);
                    string Email = reader.GetString(3);
                    string accountPassword = reader.GetString(2);

                    var mailService = new SistemSoportEmail();
                    mailService.sendMail(
                        subject: "SISTEMA: Solicitud de Recuperación de Contraseña",
                        body: "Hola, " + Usuario + "\nUsted solicitó recuperar su contraseña.\n" +
                        "tu contraseña actual es: " + accountPassword,
                        recipientMail: new List<string> { Email }
                );

                    return "Hola, " + Usuario + "\nUsted solicitó recuperar su contraseña.\n" +
                    "\nPor favor, verifique la contraseña enviada a su correo electrónico: \n"
                    + Email + ", e intente ingresar nuevamente";


                }

                else
                    return "Lo siento, no tienes una cuenta con ese correo o nombre de usuario";


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }







}
