using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLChiTietHoaDonServices
    {
        string Add(ChiTietHoaDon obj);
        string Update(ChiTietHoaDon obj);
        string Delete(ChiTietHoaDon obj);
        List<ChiTietHoaDon> GetAll();
        ChiTietHoaDon GetByID(Guid id);
    }
}
