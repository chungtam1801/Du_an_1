using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLKhachHangServices
    {
        string Add(KhachHang obj);
        string Update(KhachHang obj);
        string Delete(KhachHang obj);
        List<KhachHang> GetAll();
        KhachHang GetByID(Guid id);
    }
}
