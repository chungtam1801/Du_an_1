using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
   public interface INsxRepository
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        Nsx GetbyId(Nsx id);
        List<Nsx> GetAll();
    }
}
