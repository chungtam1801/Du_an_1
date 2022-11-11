using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSpRepository
    {
        bool Add(ChiTietSp obj);
        bool Update(ChiTietSp obj);
        bool Delete(ChiTietSp obj);
      ChiTietSp GetbyId(ChiTietSp id);
        List<ChiTietSp> GetAll();
    }
}
