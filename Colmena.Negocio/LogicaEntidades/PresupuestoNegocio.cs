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
    public class PresupuestoNegocio 
    {
        PresupuestoConeccion coneccion = new PresupuestoConeccion();
        
        public DataTable GetCliente()
        {
            try
            {
                return coneccion.GetClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetProyecto()
        {
            try
            {
                return coneccion.GetProyecto();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Insert(Presupuesto presupuesto)
        {
            try
            {
                coneccion.Insert(presupuesto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
