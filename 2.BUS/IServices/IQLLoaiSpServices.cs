using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLLoaiSpServices
    {
        string Add(LoaiSp obj);
        string Update(LoaiSp obj);
        string Delete(LoaiSp obj);
        List<LoaiSp> GetAll();
        LoaiSp GetByID(Guid id);
    }
}
