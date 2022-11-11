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
    public class HoaDonRepository : IHoaDonRepository
    {
        private FpolyDBContext _dbContext;
        public HoaDonRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
           return _dbContext.HoaDons.ToList();
        }

        public HoaDon GetbyId(HoaDon id)
        {
            throw new NotImplementedException();
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma=obj.Ma;
            tempobj.NgayTao=obj.NgayTao;
          tempobj.NgayThanhToan=obj.NgayThanhToan;
            tempobj.GiamGia=obj.GiamGia;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
