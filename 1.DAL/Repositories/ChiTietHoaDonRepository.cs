using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietHoaDonRepository : IClassCRUDRepo<ChiTietHoaDon>
    {
        private FpolyDBContext _dbContext;
        public ChiTietHoaDonRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietHoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();//Tự động zen khóa chính
                _dbContext.ChiTietHoaDons.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }           
        }

        public bool Delete(ChiTietHoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.ChiTietHoaDons.FirstOrDefault(c => c.Id == obj.Id);

                _dbContext.Remove(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }         
        }

        public List<ChiTietHoaDon> GetAll()
        {
            try
            {
                return _dbContext.ChiTietHoaDons.ToList();
            }
            catch
            {
                return null;
            }
        }

        public ChiTietHoaDon GetbyId(Guid? id)
        {
            try
            {
                return _dbContext.ChiTietHoaDons.FirstOrDefault(p => p.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public bool Update(ChiTietHoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                var tempobj = _dbContext.ChiTietHoaDons.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.DonGia = obj.DonGia;
                tempobj.SoLuong = obj.SoLuong;
                tempobj.TrangThai = obj.TrangThai;
                //Còn bao nhiêu thuộc tính làm tương tự
                _dbContext.Update(tempobj);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
