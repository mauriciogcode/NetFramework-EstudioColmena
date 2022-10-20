using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class LoginConeccion : Connection<Login>
    {
        public override void Delete(Login obj)
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

        public override void Insert(Login obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Login obj)
        {
            throw new NotImplementedException();
        }
    }
}
