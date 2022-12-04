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
    public class NsxRepository : IClassCRUDRepo<Nsx>
    {
        private FpolyDBContext _dbContext;
        public NsxRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.Nsxes.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
           return _dbContext.Nsxes.ToList();
        }

        public Nsx GetbyId(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.DiaChi = obj.DiaChi;
           tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
