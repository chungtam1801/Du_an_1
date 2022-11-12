using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
   public interface IPhuongThucThanhToanRepository
    {
        bool Add(PhuongThucThanhToan obj);
        bool Update(PhuongThucThanhToan obj);
        bool Delete(PhuongThucThanhToan obj);
      PhuongThucThanhToan GetbyId(PhuongThucThanhToan id);
        List<PhuongThucThanhToan> GetAll();
    }
}
