using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLChiTietSpServices
    {
        string Add(ChiTietSp obj);
        string Update(ChiTietSp obj);
        string Delete(ChiTietSp obj);
        List<ChiTietSp> GetAll();
        ChiTietSp GetByID(Guid id);
    }
}
