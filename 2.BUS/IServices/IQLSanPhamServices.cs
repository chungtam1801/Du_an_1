using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamServices
    {
        string Add(SanPham obj);
        string Update(SanPham obj);
        string Delete(SanPham obj);
        List<SanPham> GetAll();
        SanPham GetByID(Guid id);
    }
}
