using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories._Generics
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(int id);
        T Add(T obj);
        T Update(T obj);
        bool Delete(int id);
        bool Delete(T obj);
    }
}
