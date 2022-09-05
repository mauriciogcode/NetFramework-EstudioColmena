using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EstudioColmenaTrabajoPractico.Controlador;
using EstudioColmenaTrabajoPractico.Modelo;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    public class Operaciones
    {
        public List<Provincia> ObtenerProvincia()
        {
            List<Provincia> oListaProvincia = new List<Provincia>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerProvincia", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaProvincia.Add(new Provincia
                    {
                        CodigoProvincia = Convert.ToInt32(dr["CodigoProvincia"]),
                        Nombre = Convert.ToString(dr["Nombre"].ToString())
                    });

                }
                dr.Close();


            }

            return oListaProvincia;

        }

        public List<Departamento> ObtenerDepartamento(int CodigoProvincia)
        {
            List<Departamento> oListaDepartamento = new List<Departamento>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerDepartamento", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CodigoProvincia", CodigoProvincia);
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaDepartamento.Add(new Departamento
                    {
                        CodigoDepartamento = Convert.ToInt32(dr["CodigoDepartamento"]),
                        Nombre = Convert.ToString(dr["Nombre"].ToString())
                    });

                }
                dr.Close();


            }

            return oListaDepartamento;

        }

        public List<Localidad> ObtenerLocalidad(int CodigoDepartamento)
        {
            List<Localidad> oListaLocalidad = new List<Localidad>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerLocalidad", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CodigoDepartamento", CodigoDepartamento);
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaLocalidad.Add(new Localidad
                    {
                        CodigoLocalidad = Convert.ToInt32(dr["CodigoLocalidad"]),
                        Nombre = Convert.ToString(dr["Nombre"].ToString())
                    });

                }
                dr.Close();


            }

            return oListaLocalidad;

        }
    }
}

