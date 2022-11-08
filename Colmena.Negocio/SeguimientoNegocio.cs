using Colmena.Datos.ConeccionEntidades;
using Colmena.Datos.QuerysConectios;
using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio
{
    public class SeguimientoNegocio
    {
        public DataTable GetAll()
        {
            SeguimientoQuery oSeguimiento = new SeguimientoQuery();
            return oSeguimiento.GetAll();
        }

        public void Insert(Seguimiento obe)
        {
            SeguimientoQuery oSeguimiento = new SeguimientoQuery();
            oSeguimiento.Insert(obe);

        }


        public void Update(Seguimiento obe)
        {
            SeguimientoQuery oSeguimiento = new SeguimientoQuery();
            oSeguimiento.Update(obe);


        }
    }
}
