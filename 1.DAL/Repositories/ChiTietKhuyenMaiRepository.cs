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
    public class ChiTietKhuyenMaiRepository : IClassCRUDRepo<ChiTietKhuyenMai>
    {
        private FpolyDBContext _dbContext;
        public ChiTietKhuyenMaiRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietKhuyenMai obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.ChiTietKhuyenMais.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietKhuyenMai obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietKhuyenMais.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietKhuyenMai> GetAll()
        {
            return _dbContext.ChiTietKhuyenMais.ToList();
        }

        public ChiTietKhuyenMai GetbyId(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietKhuyenMai obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietKhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
           tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
