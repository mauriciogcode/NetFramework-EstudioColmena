using Colmena.Datos.ConeccionEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.Datos.QuerysConectios.Utils;

namespace Colmena.Negocio.LogicaEntidades.Utils
{
    public class ComboNegocio
    {
        public DataTable GetProjects()
        {
            ComboQuery oCombo = new ComboQuery();
            return oCombo.GetProjects();
        }

        public DataTable GetUsers()
        {
            ComboQuery oCombo = new ComboQuery();
            return oCombo.GetUsers();
        }
    }
}
