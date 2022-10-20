using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class ProyectoConeccion : Connection<Proyecto>
    {
        public override void Delete(Proyecto obj)
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

        public override void Insert(Proyecto obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Proyecto obj)
        {
            throw new NotImplementedException();
        }
    }
}
