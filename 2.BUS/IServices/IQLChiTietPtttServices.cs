using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;


namespace _2.BUS.IServices
{
    public interface IQLChiTietPtttServices
    {
        string Add(ChiTietPttt obj);
        string Update(ChiTietPttt obj);
        string Delete(ChiTietPttt obj);
        List<ChiTietPttt> GetAll();
        ChiTietPttt GetByID(Guid id);
    }
}
