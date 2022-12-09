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
    public class KhuyenMaiRepository : IClassCRUDRepo<KhuyenMai>
    {
        private FpolyDBContext _dbContext;
        public KhuyenMaiRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhuyenMai obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.KhuyenMais.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhuyenMais.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhuyenMai> GetAll()
        {
           return _dbContext.KhuyenMais.ToList();
        }

        public KhuyenMai GetbyId(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(KhuyenMai obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.GiaTri=obj.GiaTri;
            tempobj.NgayBd=obj.NgayBd;
            tempobj.NgayKt=obj.NgayKt;
            tempobj.IdSp = obj.IdSp;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
