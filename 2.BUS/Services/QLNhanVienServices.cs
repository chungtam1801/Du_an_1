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
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private IClassCRUDRepo<NhanVien> _iNhanVienRepository;
        private FpolyDBContext _FpolyDB;
        private List<NhanVien> _NhanVienList;
        private IClassCRUDRepo<ChucVu> _iChucVuRepository;
        public QLNhanVienServices()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _iChucVuRepository= new ChucVuRepository();
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
            //_NhanVienList = _FpolyDB.NhanViens.ToList();
            return _iNhanVienRepository.GetAll();
        }
        public NhanVien GetByID(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<ViewQLNhanVien> GetAllView()
        {
            List<ViewQLNhanVien> lstnvcv = new List<ViewQLNhanVien>();
            lstnvcv = (from nv in _iNhanVienRepository.GetAll()
                       join cv in _iChucVuRepository.GetAll() on nv.IdCv equals cv.Id
                       select new ViewQLNhanVien()
                       {
                           Id = nv.Id,
                           Ma = nv.Ma,
                           Ho= nv.Ho,
                           TenDem = nv.TenDem,
                           Ten = nv.Ten,
                           HoVaTen = string.Concat(nv.Ho, " ", nv.TenDem, " ", nv.Ten),
                           IdCv= cv.Id,
                           TenCv = cv.Ten,
                           GioiTinh = nv.GioiTinh,
                           NgaySinh= nv.NgaySinh,
                           Sdt = nv.Sdt,
                           MatKhau = nv.MatKhau,
                           DiaChi= nv.DiaChi,
                           TrangThai = nv.TrangThai
                       }).ToList();
            return lstnvcv;
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
