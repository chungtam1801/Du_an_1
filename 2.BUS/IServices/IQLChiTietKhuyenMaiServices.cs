using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQLChiTietKhuyenMaiServices
    {
        string Add(ChiTietKhuyenMai obj);
        string Update(ChiTietKhuyenMai obj);
        string Delete(ChiTietKhuyenMai obj);
        List<ChiTietKhuyenMai> GetAll();
        List<ViewQLKhuyenMai> GetAllView();
        ChiTietKhuyenMai GetByID(Guid id);
    }
}
