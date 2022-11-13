using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLPhuongThucThanhToanServices
    {
        string Add(PhuongThucThanhToan obj);
        string Update(PhuongThucThanhToan obj);
        string Delete(PhuongThucThanhToan obj);
        List<PhuongThucThanhToan> GetAll();
        PhuongThucThanhToan GetByID(Guid id);
    }
}
