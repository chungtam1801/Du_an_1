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
    public class ChiTietPtttRepository : IChiTietPtttRepository
    {
        private FpolyDBContext _dbContext;
        public ChiTietPtttRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietPttt obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.ChiTietPttts.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietPttt obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietPttts.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietPttt> GetAll()
        {
           return _dbContext.ChiTietPttts.ToList();
        }

        public ChiTietPttt GetbyId(ChiTietPttt id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietPttt obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietPttts.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.TienKhachDua=obj.TienKhachDua;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
