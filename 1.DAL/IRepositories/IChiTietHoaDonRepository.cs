using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
namespace _1.DAL.IRepositories
{
   public interface IChiTietHoaDonRepository
    {
        bool Add(ChiTietHoaDon obj);
        bool Update(ChiTietHoaDon obj);
        bool Delete(ChiTietHoaDon obj);
       ChiTietHoaDon GetbyId(ChiTietHoaDon id);
        List<ChiTietHoaDon> GetAll();
    }
}
