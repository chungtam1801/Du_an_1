using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLLichSuTichDiemServices
    {
        string Add(LichSuTichDiem obj);
        string Update(LichSuTichDiem obj);
        string Delete(LichSuTichDiem obj);
        List<LichSuTichDiem> GetAll();
        LichSuTichDiem GetByID(Guid id);
    }
}
