using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLQuyDoiDiemServices
    {
        string Add(QuyDoiDiem obj);
        string Update(QuyDoiDiem obj);
        string Delete(QuyDoiDiem obj);
        List<QuyDoiDiem> GetAll();
        QuyDoiDiem GetByID(Guid id);
    }
}
