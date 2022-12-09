using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQLKhuyenMaiServices
    {
        string Add(KhuyenMai obj);
        string Update(KhuyenMai obj);
        string Delete(KhuyenMai obj);
        List<KhuyenMai> GetAll();
        List<ViewQLKhuyenMai> GetAllView();
        KhuyenMai GetByID(Guid id);
    }
}
