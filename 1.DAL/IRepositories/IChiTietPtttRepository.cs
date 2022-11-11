using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietPtttRepository
    {
        bool Add(ChiTietPttt obj);
        bool Update(ChiTietPttt obj);
        bool Delete(ChiTietPttt obj);
       ChiTietPttt GetbyId(ChiTietPttt id);
        List<ChiTietPttt> GetAll();
    }
}
