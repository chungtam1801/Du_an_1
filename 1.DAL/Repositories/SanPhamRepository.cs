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
    public class SanPhamRepository : IClassCRUDRepo<SanPham>
    {
        private FpolyDBContext _dbContext;
        public SanPhamRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
           return _dbContext.SanPhams.ToList();
        }

        public SanPham GetbyId(Guid  id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.MoTa=obj.MoTa;
            tempobj.TrangThai=obj.TrangThai;
         
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
