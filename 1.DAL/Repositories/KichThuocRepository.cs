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
    public class KichThuocRepository : IKichThuocRepository
    {
        private FpolyDBContext _dbContext;
        public KichThuocRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KichThuoc obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.KichThuocs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KichThuoc obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KichThuocs.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KichThuoc> GetAll()
        {
            return _dbContext.KichThuocs.ToList();
        }

        public KichThuoc GetbyId(KichThuoc id)
        {
            throw new NotImplementedException();
        }

        public bool Update(KichThuoc obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KichThuocs.FirstOrDefault(c => c.Id == obj.Id);
           tempobj.Ma=obj.Ma;
            tempobj.Size=obj.Size;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
