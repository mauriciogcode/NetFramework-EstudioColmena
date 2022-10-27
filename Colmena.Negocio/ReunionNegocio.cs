using Colmena.Datos.ConeccionEntidades;
using Colmena.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio
{
    public class ReunionNegocio
    {
        public DataTable GetAll()
        {
            ReunionQuery oReunion = new ReunionQuery();
            return oReunion.GetAll();
        }

        public DataTable GetByDate(Reunion obe)
        {


            ReunionQuery oReunion = new ReunionQuery();
            return oReunion.GetByDate(obe);
        }

        public void Insert(Reunion obe)
        {
            ReunionQuery oReunion = new ReunionQuery();
            oReunion.Insert(obe);

        }

        public void Delete(Reunion obe)
        {
            ReunionQuery oReunion = new ReunionQuery();
            oReunion.Delete(obe);


        }

        public void Update(Reunion obe)
        {
            ReunionQuery oReunion = new ReunionQuery();
            oReunion.Update(obe);


        }

    }
}
