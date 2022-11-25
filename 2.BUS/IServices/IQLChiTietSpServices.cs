using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQLChiTietSpServices
    {
        string Add(ChiTietSp obj);
        string Update(ChiTietSp obj);
        string Delete(ChiTietSp obj);
        List<ChiTietSp> GetAll();
        List<ViewQLChiTietSp> GetAllView(string s);
        List<ViewQLChiTietSp> GetAllView();
        ChiTietSp GetByID(Guid id);
    }
}
