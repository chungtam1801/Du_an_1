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
    public class LoaiSpRepository : IClassCRUDRepo<LoaiSp>
    {
        private FpolyDBContext _dbContext;
        public LoaiSpRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(LoaiSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.LoaiSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.LoaiSps.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<LoaiSp> GetAll()
        {
            return _dbContext.LoaiSps.ToList();
        }

        public LoaiSp GetbyId(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(LoaiSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.LoaiSps.FirstOrDefault(c => c.Id == obj.Id);
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
