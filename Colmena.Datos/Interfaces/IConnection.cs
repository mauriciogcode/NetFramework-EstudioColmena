using System.Data;

namespace Colmena.Datos
{
    public interface IConnection<T>
    {
        DataTable GetAll();
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void GetById();

    }
}