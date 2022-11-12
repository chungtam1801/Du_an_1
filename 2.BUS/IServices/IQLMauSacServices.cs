using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLMauSacServices
    {
        string Add(MauSac obj);
        string Update(MauSac obj);
        string Delete(MauSac obj);
        List<MauSac> GetAll();
        MauSac GetByID(Guid id);
    }
}
