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
    public class NhanVienRepository : INhanVienRepository
    {
        private FpolyDBContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public NhanVien GetbyId(NhanVien id)
        {
            throw new NotImplementedException();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem=obj.TenDem;
            tempobj.Ho=obj.Ho;
            tempobj.GioiTinh=obj.GioiTinh;
            tempobj.NgaySinh=obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt=obj.Sdt;
            tempobj.MatKhau=obj.MatKhau;
            tempobj.TrangThai=obj.TrangThai;
          
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
