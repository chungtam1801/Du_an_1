using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienServices
    {
        string Add(NhanVien obj);
        string Update(NhanVien obj);
        string Delete(NhanVien obj);
        List<NhanVien> GetAll();
        NhanVien GetByID(Guid id);
    }
}
