using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonServices
    {
        string Add(HoaDon obj);
        string Update(HoaDon obj);
        string Delete(HoaDon obj);
        List<HoaDon> GetAll();
        HoaDon GetByID(Guid id);
    }
}
