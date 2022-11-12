using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;


namespace _2.BUS.IServices
{
    public interface IQLKichThuocServices
    {
        string Add(KichThuoc obj);
        string Update(KichThuoc obj);
        string Delete(KichThuoc obj);
        List<KichThuoc> GetAll();
        KichThuoc GetByID(Guid id);
    }
}
