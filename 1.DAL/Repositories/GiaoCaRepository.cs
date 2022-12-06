using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;


namespace _1.DAL.Repositories
{
    public class GiaoCaRepository : IClassCRUDRepo<GiaoCa>
    {
        private FpolyDBContext _dbContext;
        public GiaoCaRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(GiaoCa obj)
        {
            //if (obj == null) return false;
            //obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            //_dbContext.GiaoCas.Add(obj);
            //_dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GiaoCa obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.GiaoCas.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GiaoCa> GetAll()
        {
            return _dbContext.GiaoCas.ToList();
        }

        public GiaoCa GetbyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public GiaoCa GetbyId(Guid? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(GiaoCa obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.GiaoCas.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdNguoiGiaoCa = obj.IdNguoiGiaoCa;
            tempobj.ThoiGianVaoCa = obj.ThoiGianVaoCa;
            tempobj.ThoiGianKetCa = obj.ThoiGianKetCa;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.TienCuoiCa = obj.TienCuoiCa;
            tempobj.TienDauca = obj.TienDauca;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.Tongtienhang = obj.Tongtienhang;
            tempobj.SoHoaDon = obj.SoHoaDon;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
