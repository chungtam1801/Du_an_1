using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IQuyDoiDiemRepository
    {
        bool Add(QuyDoiDiem obj);
        bool Update(QuyDoiDiem obj);
        bool Delete(QuyDoiDiem obj);
       QuyDoiDiem GetbyId(QuyDoiDiem id);
        List<QuyDoiDiem> GetAll();
    }
}
