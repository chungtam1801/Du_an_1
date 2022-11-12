using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiSpRepository
    {
        bool Add(LoaiSp obj);
        bool Update(LoaiSp obj);
        bool Delete(LoaiSp obj);
        LoaiSp GetbyId(LoaiSp id);
        List<LoaiSp> GetAll();
    }
}
