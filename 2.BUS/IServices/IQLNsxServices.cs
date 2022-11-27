using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLNsxServices
    {
        string Add(Nsx obj);
        string Update(Nsx obj);
        string Delete(Nsx obj);
        List<Nsx> GetAll();
        List<Nsx> GetAll(string s);
        Nsx GetByID(Guid id);
    }
}
