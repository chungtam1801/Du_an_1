using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienServices
    {
        string Add(NhanVien obj);
        string Update(NhanVien obj);
        string Delete(NhanVien obj);
        List<NhanVien> GetAll();
        List<NhanVien> GetAll(int hd);
        List<ViewQLNhanVien> GetAllView();
        NhanVien GetByID(Guid id);
    }
}
