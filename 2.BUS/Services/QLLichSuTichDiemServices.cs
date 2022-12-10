using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLLichSuTichDiemServices : IQLLichSuTichDiemServices
    {
        private IClassCRUDRepo<LichSuTichDiem> _iLichSuTichDiemRepository;
        private IClassCRUDRepo<KhachHang> _iKhachHangRepository;
        private IClassCRUDRepo<HoaDon> _iHoaDonRepository;
        private IClassCRUDRepo<QuyDoiDiem> _iQuyDoiDiemRepository;
        public QLLichSuTichDiemServices()
        {
            _iLichSuTichDiemRepository = new LichSuTichDiemRepository();
            _iKhachHangRepository = new KhachHangRepository();
            _iHoaDonRepository = new HoaDonRepository();
            _iQuyDoiDiemRepository = new QuyDoiDiemRepository();
        }
        public string Add(LichSuTichDiem obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(LichSuTichDiem obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }
        //Lam them

        public List<LichSuTichDiem> GetAll()
        {
            return _iLichSuTichDiemRepository.GetAll(); 
        }
        public List<ViewQLLichSuTichDiem> GetAllView(Guid idKh)
        {
            var list = new List<ViewQLLichSuTichDiem>();
            list=(from a in _iLichSuTichDiemRepository.GetAll()
                  join b in _iKhachHangRepository.GetAll().Where(c=>c.Id==idKh) on a.IdKh equals b.Id
                  join c in _iHoaDonRepository.GetAll() on a.IdHd equals c.Id
                  join d in _iQuyDoiDiemRepository.GetAll() on a.IdQuyDoiDiem equals d.Id
                  select new ViewQLLichSuTichDiem()
                  {
                      Id=a.Id,
                      Ten=b.Ten,
                      Sdt=b.Sdt,
                      MaHD=c.Ma,
                      Diem=a.Diem,
                      NgayThayDoi=c.NgayThanhToan,
                      MaQuyDoiDiem=d.Id
                  }).ToList();
            return list;
        }

        public LichSuTichDiem GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(LichSuTichDiem obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
