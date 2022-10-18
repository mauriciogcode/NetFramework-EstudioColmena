using Colmena.Entidades.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Colmena.Entidades.Controlador
{
    class ClienteMetodos : Modelo.ColmenaConeccion
    {

        #region Consultas

        public DataTable Consultar()
        {
            string sqlStr = "select IdCliente, Apellido + ', ' + Nombre[Apellido y Nombre] ,Telefono, " +
                    "+ Calle + ', ' + Altura[Calle y Altura],Piso,Departamento,Provincia,Localidad,Email + " +
                    "from[EstudioColmena].[dbo].[Cliente]";
            //var c = AbrirConexion();


            //********************************************************
            var da = new SqlDataAdapter(sqlStr, GetConnection());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
            //*****************************************************
        }
        public DataSet Consultar1(string idCliente)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            try
            {
                //string sqlStr = "select * from Alumnos where legajo like '" + legajo + "'";
                /*string sqlStr = "select IdCliente, Apellido + ', ' + Nombre[Apellido y Nombre] ,Telefono, " +
                    "+ Calle + ', ' + Altura[Calle y Altura],Piso,Departamento,Provincia,Localidad,Email + " +
                    "from[EstudioColmena].[dbo].[Cliente]";*/
                string sqlStr = "select * from [EstudioColmena].[dbo].[Cliente] where = '" + idCliente + "'";
                //var c = AbrirConexion();
                var da = new SqlDataAdapter(sqlStr, GetConnection());
                ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables["[EstudioColmena].[dbo].[Cliente]"];

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return ds;
            }
        }

        public DataRow CargaCampos(string idCLiente)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            DataRow dr;

            string sqlStr = "select * from [EstudioColmena].[dbo].[Cliente] where = '" + idCLiente + "'";

            var da = new SqlDataAdapter(sqlStr, GetConnection());
            ds = new DataSet();
            da.Fill(ds);

            dr = ds.Tables[0].Rows[0];

            return dr;
        }

        //public DataTable cargarCombo()
        //{

        //    string sqlStr = "select legajo, apellido + ', ' + nombre as ApeNom from Alumnos order by apenom";
        //    //var c = AbrirConexion();

        //    //********************************************************
        //    var da = new SqlDataAdapter(sqlStr, GetConnection());
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    DataTable dt = ds.Tables[0];

        //    return dt;
        //    //*****************************************************
        //}

        #endregion


        #region Datos

        public void CrearCliente(Cliente cl)
        {
            try
            {
                //var c = AbrirConexion();

                //var sel = "set dateformat dmy INSERT INTO Alumnos(Legajo, Apellido, Nombre, Fechanacimiento,cuota,ciudad) VALUES ('"
                //+ al.legajo + "','" + al.apellido + "','" + al.nombre + "','" + al.fecnac + "',"
                //+ al.cuota + ",'" + al.ciudad + "')";
                //SqlCommand com = new SqlCommand(sel, conectar());

                var sel = "set dateformat dmy INSERT INTO [EstudioColmena].[dbo].[Cliente](IdCliente,Nombre,Apellido," +
                    "Telefono,Ocupacion,Documento,Calle,Altura,Piso,Barrio,Departamento,Provincia,Localidad,Email)" +
                    "VALUES (@idCliente,@nombre,@apellido," +
                    "@telefono,@ocupacion,@documento,@calle,@altura,@piso,@barrio," +
                    "@departamento,@provincia,@localidad,@email)";


                SqlCommand com = new SqlCommand(sel, GetConnection());
                com.CommandType = CommandType.Text;
                com.CommandText = sel;
                com.Parameters.Add(new SqlParameter("@idCliente", cl.IdCliente));
                com.Parameters.Add(new SqlParameter("@apellido", cl.Apellido));
                com.Parameters.Add(new SqlParameter("@nombre", cl.Nombre));
                com.Parameters.Add(new SqlParameter("@telefono", cl.Telefono));
                com.Parameters.Add(new SqlParameter("@ocupacion", cl.Ocupacion));
                com.Parameters.Add(new SqlParameter("@documento", cl.Documento));
                com.Parameters.Add(new SqlParameter("@calle", cl.Calle));
                com.Parameters.Add(new SqlParameter("@altura", cl.Altura));
                com.Parameters.Add(new SqlParameter("@piso", cl.Piso));
                com.Parameters.Add(new SqlParameter("@barrio", cl.Barrio));
                com.Parameters.Add(new SqlParameter("@departamento", cl.Depto));
                com.Parameters.Add(new SqlParameter("@provincia", cl.IdProvincia));
                com.Parameters.Add(new SqlParameter("@localidad", cl.IdProvincia));
                com.Parameters.Add(new SqlParameter("@email", cl.Email));

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
        }
        //public void ModificarCliente(Modelo.Cliente cl)
        //{
        //    try
        //    {
        //        //var c = AbrirConexion();
        //        /*var sel = "set dateformat dmy UPDATE Alumnos set apellido = '" + al.apellido + "', nombre = '" +
        //             al.nombre + "', fecnacAlumno = '" + al.fecnac
        //             + "', cuota = " + al.cuota + ", dni= " + al.ciudad
        //             + " WHERE legajo = '" + al.legajo + "'";*/

        //        SqlCommand com = new SqlCommand(sel, GetConnection());

        //        com.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

        //    }

        //}
        public Boolean borrarAlumno(string legajo)
        {
            try
            {
                //var c = AbrirConexion();

                var sel = "delete from Alumnos where legajo = '" + legajo + "'";

                SqlCommand com = new SqlCommand(sel, GetConnection());

                var i = com.ExecuteNonQuery();
                if (i == 0) return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

        }

        #endregion
    }
}
