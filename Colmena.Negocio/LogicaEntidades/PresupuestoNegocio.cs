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
    public class PresupuestoNegocio : LogicaNegocio<Presupuesto>
    {
        PresupuestoConeccion coneccion = new PresupuestoConeccion();
        public override void Delete(Presupuesto obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Insert(Presupuesto obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Presupuesto obj)
        {
            throw new NotImplementedException();
        }
    }
}
