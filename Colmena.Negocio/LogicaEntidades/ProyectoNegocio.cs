using Colmena.Datos.ConeccionEntidades;
using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio.LogicaEntidades
{
    public class ProyectoNegocio : LogicaNegocio<Proyecto>
    {
        ProyectoConeccion proyecto = new ProyectoConeccion();
        public override void Delete(Proyecto obj)
        {
            try
            {
                proyecto.Delete(obj);
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
                return proyecto.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Insert(Proyecto obj)
        {
            try
            {
                proyecto.Insert(obj);
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
                proyecto.Update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
