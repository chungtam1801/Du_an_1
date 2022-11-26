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
    public class KhachHangRepository : IClassCRUDRepo<KhachHang>
    {
        private FpolyDBContext _dbContext;
        public KhachHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public KhachHang GetbyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem=obj.TenDem;
            tempobj.Ho=obj.Ho;
            tempobj.NgaySinh=obj.NgaySinh;
            tempobj.Sdt=obj.Sdt;
            tempobj.DiemTich=obj.DiemTich;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
