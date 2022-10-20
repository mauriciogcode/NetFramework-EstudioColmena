using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class PresupuestoConeccion : Connection<Presupuesto>
    {
        public override void Delete(Presupuesto obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetById()
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
