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
    public class LichSuTichDiemRepository : IClassCRUDRepo<LichSuTichDiem>
    {
        private FpolyDBContext _dbContext;
        public LichSuTichDiemRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public bool Add(LichSuTichDiem obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.LichSuTichDiems.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LichSuTichDiem obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.LichSuTichDiems.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<LichSuTichDiem> GetAll()
        {
            return _dbContext.LichSuTichDiems.ToList();
        }

        public LichSuTichDiem GetbyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(LichSuTichDiem obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.LichSuTichDiems.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Diem = obj.Diem;
            tempobj.TrangThai=obj.TrangThai;
           
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
