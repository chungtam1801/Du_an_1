using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLKhuyenMaiServices
    {
        string Add(KhuyenMai obj);
        string Update(KhuyenMai obj);
        string Delete(KhuyenMai obj);
        List<KhuyenMai> GetAll();
        KhuyenMai GetByID(Guid id);
    }
}
