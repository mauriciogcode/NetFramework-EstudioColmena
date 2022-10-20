using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class LocalidadConeccion : Connection<Localidad>
    {
        public override void Delete(Localidad obj)
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

        public override void Insert(Localidad obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Localidad obj)
        {
            throw new NotImplementedException();
        }
    }
}
