using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILichSuTichDiemRepository
    {
        bool Add(LichSuTichDiem obj);
        bool Update(LichSuTichDiem obj);
        bool Delete(LichSuTichDiem obj);
        LichSuTichDiem GetbyId(LichSuTichDiem id);
        List<LichSuTichDiem> GetAll();
    }
}
