using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;


namespace _2.BUS.IServices
{
    public interface IQLChiTietKhuyenMaiServices
    {
        string Add(ChiTietKhuyenMai obj);
        string Update(ChiTietKhuyenMai obj);
        string Delete(ChiTietKhuyenMai obj);
        List<ChiTietKhuyenMai> GetAll();
        ChiTietKhuyenMai GetByID(Guid id);
    }
}
