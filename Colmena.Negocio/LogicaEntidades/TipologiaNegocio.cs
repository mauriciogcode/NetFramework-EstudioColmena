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
    public class TipologiaNegocio : LogicaNegocio<Tipologia>
    {
        TipologiaConeccion tipologia = new TipologiaConeccion();
        public override void Delete(Tipologia obj)
        {
            try
            {
                tipologia.Delete(obj);
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
                return tipologia.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Insert(Tipologia obj)
        {
            try
            {
                tipologia.Insert(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Update(Tipologia obj)
        {
            try
            {
                tipologia.Update(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
