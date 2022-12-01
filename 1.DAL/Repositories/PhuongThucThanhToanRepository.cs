using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class PhuongThucThanhToanRepository : IClassCRUDRepo<PhuongThucThanhToan>
    {
        private FpolyDBContext _dbContext;
        public PhuongThucThanhToanRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(PhuongThucThanhToan obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.PhuongThucThanhToans.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhuongThucThanhToan obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.PhuongThucThanhToans.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<PhuongThucThanhToan> GetAll()
        {
            return _dbContext.PhuongThucThanhToans.ToList();
        }

        public PhuongThucThanhToan GetbyId(Guid id)
        {
            return _dbContext.PhuongThucThanhToans.FirstOrDefault(c =>c.Id==id);
        }

        public bool Update(PhuongThucThanhToan obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.PhuongThucThanhToans.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.TrangThai=obj.TrangThai;
           
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
