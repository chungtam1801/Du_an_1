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
    public class QuyDoiDiemRepository : IQuyDoiDiemRepository
    {
        private FpolyDBContext _dbContext;
        public QuyDoiDiemRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(QuyDoiDiem obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.QuyDoiDiems.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(QuyDoiDiem obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.QuyDoiDiems.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<QuyDoiDiem> GetAll()
        {
            return _dbContext.QuyDoiDiems.ToList();
        }

        public QuyDoiDiem GetbyId(QuyDoiDiem id)
        {
            throw new NotImplementedException();
        }

        public bool Update(QuyDoiDiem obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.QuyDoiDiems.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.SoDiem=obj.SoDiem;
            tempobj.TiLeTichDiem=obj.TiLeTichDiem;
            tempobj.TiLeTieuDiem=obj.TiLeTieuDiem;
            tempobj.TrangThai=obj.TrangThai;
           
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
