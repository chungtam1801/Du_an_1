using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKichThuocRepository
    {
        bool Add(KichThuoc obj);
        bool Update(KichThuoc obj);
        bool Delete(KichThuoc obj);
       KichThuoc GetbyId(KichThuoc id);
        List<KichThuoc> GetAll();
    }
}
