using Colmena.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Negocio
{
    public abstract class LogicaNegocio<T> : INegocio<T>
    {
        public abstract void Delete(T obj);

        public abstract DataTable GetAll();

        public abstract void Insert(T obj);

        public abstract void Update(T obj);
    }
}
