using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.Datos.ConeccionEntidades;
using System.Data;
using Colmena.Entidades;

namespace Colmena.Negocio.LogicaEntidades
{
    public class LoginNegocio 
    {
        LoginConeccion coneccion = new LoginConeccion();

        public bool LoginDeUsuario(Login obj)
        {
            try
            {
               
               return coneccion.LoginDeUsuario(obj);

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
                return coneccion.RecuperarContraseña(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CrearUsuario(Login obj)
        {
            try
            {
                coneccion.CrearUsuario(obj);
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }
        
}
}

