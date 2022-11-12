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
    public class MauSacRepository : IMauSacRepository
    {
        private FpolyDBContext _dbContext;
        public MauSacRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }

        public MauSac GetbyId(MauSac id)
        {
            throw new NotImplementedException();
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TrangThai = obj.TrangThai;
            
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
