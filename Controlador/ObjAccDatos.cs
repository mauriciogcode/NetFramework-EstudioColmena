using EstudioColmenaTrabajoPractico.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EstudioColmenaTrabajoPractico.Controlador
{
    public class ObjAccDatos : Modelo.Coneccion
    {

        //public void editProfile(int IdUsuario, string Usuario, string Contraseña, string Nombre, string Apellido, string Email)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "update Usuario set Usuario=@usuario, Contraseña=@contraseña, Nombre=@nombre, Apellido=@apellido, Email=@email where IdUsuario=@idusuario";
        //            command.Parameters.AddWithValue("@usuario", Usuario);
        //            command.Parameters.AddWithValue("@contraseña", Contraseña);
        //            command.Parameters.AddWithValue("@nombre", Nombre);
        //            command.Parameters.AddWithValue("@apellido", Apellido);
        //            command.Parameters.AddWithValue("@email", Email);
        //            command.Parameters.AddWithValue("@idusuario", IdUsuario);
        //            command.CommandType = CommandType.Text;
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public bool LoginDeUsuario(string Usuario, string Contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select*from Login where Usuario=@usuario and Contraseña =@contraseña";
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@contraseña", Contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Login.IdUsuario = reader.GetInt32(0);
                            Login.Usuario = reader.GetString(1);
                            Login.Contraseña = reader.GetString(2);
                            Login.Nombre = reader.GetString(5);
                            Login.Apellido = reader.GetString(6);
                            Login.NivelAcceso = reader.GetString(4);
                            Login.Email = reader.GetString(3);

                        }
                        return true;
                    }
                    else
                        return false;
                }

            }

        }


        public string RecuperarContraseña(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select*from Login where Usuario=@usuario or Email =@email";
                    command.Parameters.AddWithValue("@usuario", userRequesting);
                    command.Parameters.AddWithValue("@email", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string Usuario = reader.GetString(5) + ", " + reader.GetString(6);
                        string Email = reader.GetString(3);
                        string accountPassword = reader.GetString(2);

                        var mailService = new Modelo.SistemSoportEmail();
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
            }



        }




        public void AnyMethod()
        {
            if (Login.NivelAcceso == Posicion.Administrador)
            {
                //Codes
            }
            if (Login.NivelAcceso == Posicion.Arquitecto /*|| UserCache.Position == Positions.Compras || UserCache.Position == Positions.Arquitecto*/)
            {
                //Codes
            }
        }
    }

}

