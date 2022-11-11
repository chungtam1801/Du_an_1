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
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
           return _dbContext.ChucVus.ToList();
        }

        public ChucVu GetbyId(ChucVu id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
          tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
