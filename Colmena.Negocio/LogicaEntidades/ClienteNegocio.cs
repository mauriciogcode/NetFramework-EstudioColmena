using Colmena.Datos;
using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio.LogicaEntidades
{
    public class ClienteNegocio : LogicaNegocio<Cliente>
    {
        ClienteConeccion coneccion = new ClienteConeccion();

        public override void Delete(Cliente obj)
        {
            try
            {
                coneccion.Delete(obj);
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
                return coneccion.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Insert(Cliente obj)
        {
            try
            {
               coneccion.Insert(obj);
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
                coneccion.Update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
