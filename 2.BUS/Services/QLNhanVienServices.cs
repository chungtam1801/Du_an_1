using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _1.DAL.Context;
using _2.BUS.IServices;

namespace _2.BUS.Services
{
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private IClassCRUDRepo<NhanVien> _iNhanVienRepository;
        private FpolyDBContext _FpolyDB;
        private List<NhanVien> _NhanVienList;

        public QLNhanVienServices()
        {
            _iNhanVienRepository = new NhanVienRepository();
        }
        public string Add(NhanVien obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(NhanVien obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<NhanVien> GetAll()
        {
            _NhanVienList = _FpolyDB.NhanViens.ToList();
            return _iNhanVienRepository.GetAll();
        }

        public NhanVien GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(NhanVien obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
        public List<NhanVien> GetAll(int hd)
        {
            return _iNhanVienRepository.GetAll().Where(c => c.TrangThai == hd).ToList();

        }
        
        public bool checkTT( string sdt, string mk)
        {
            _NhanVienList = GetAll();
            var result = _NhanVienList.FirstOrDefault(p =>   p.Sdt == sdt ); 
            if (result == null)
            {
                return false;
            }
            else
            {
                result.MatKhau = mk;
                Update(result);
                return true;
            }
        }
    }
}
