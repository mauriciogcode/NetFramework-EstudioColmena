using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class DepartamentoConeccion : Connection<Departamento>
    {
        public override void Delete(Departamento obj)
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

        public override void Insert(Departamento obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Departamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
