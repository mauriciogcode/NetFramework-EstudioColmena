using System.Data;

namespace Colmena.Datos
{
    public abstract class Connection<T> : IConnection<T>
    {
        public abstract void Delete(T obj);

        public abstract DataTable GetAll();

        public abstract void GetById();

        public abstract void Insert(T obj);

        public abstract void Update(T obj);
    }
}