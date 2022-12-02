using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLGiaoCaServices
    {
        string Add(GiaoCa obj);
        string Update(GiaoCa obj);
        string Delete(GiaoCa obj);
        List<GiaoCa> GetAll();
        GiaoCa GetByID(Guid id);
    }
}
