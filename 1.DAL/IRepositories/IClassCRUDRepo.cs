using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IClassCRUDRepo<T>
    {
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        T GetbyId(Guid id);
        List<T> GetAll();
    }
}
