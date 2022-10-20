using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Datos.ConeccionEntidades
{
    public class ReunionConeccion : Connection<Reunion>
    {
        public override void Delete(Reunion obj)
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

        public override void Insert(Reunion obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Reunion obj)
        {
            throw new NotImplementedException();
        }
    }
}
