using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class CuentaConeccion : Connection<Cuenta>
    {
        public override void Delete(Cuenta obj)
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

        public override void Insert(Cuenta obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Cuenta obj)
        {
            throw new NotImplementedException();
        }
    }
}
