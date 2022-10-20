using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio.Interfaces
{
   public interface INegocio<T>
    {
        DataTable GetAll();
        void Delete(T obj);
        void Update(T obj);
        void Insert(T obj);

    }
}
