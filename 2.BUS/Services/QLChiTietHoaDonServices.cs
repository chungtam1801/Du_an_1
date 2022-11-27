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
    public class QLChiTietHoaDonServices : IQLChiTietHoaDonServices
    {
        private IClassCRUDRepo<ChiTietHoaDon> _iChiTietHoaDonRepository;
        private IQLChiTietSpServices _iQLChiTietSpServices;
        private IClassCRUDRepo<HoaDon> _iHoaDonRepository;
        public QLChiTietHoaDonServices()
        {
            _iChiTietHoaDonRepository = new ChiTietHoaDonRepository();
            _iQLChiTietSpServices = new QLChiTietSpServices();
            _iHoaDonRepository = new HoaDonRepository();
        }
        public string Add(ChiTietHoaDon obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietHoaDon obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietHoaDon> GetAll()
        {
            return _iChiTietHoaDonRepository.GetAll();
        }

        public List<ViewQLChiTietHoaDon> GetAllView(Guid IdHD)
        {
            var lstView = new List<ViewQLChiTietHoaDon>();
            lstView = (from a in _iQLChiTietSpServices.GetAllView()
                       join b in _iChiTietHoaDonRepository.GetAll().Where(c=>c.IdHd==IdHD) on a.Id equals b.IdCtsp
                       select new ViewQLChiTietHoaDon()
                       {
                           Ma = a.Ma,
                           Ten = a.Ten,
                           Nsx = a.Nsx,
                           MauSac = a.MauSac,
                           LoaiSp = a.LoaiSp,
                           KichThuoc = a.KichThuoc,
                           ChatLieu = a.ChatLieu,
                           SoLuong = b.SoLuong,
                           Id = b.Id
                       }).ToList();
            return lstView;
        }

        public ChiTietHoaDon GetByID(Guid id)
        {
            return _iChiTietHoaDonRepository.GetbyId(id);
        }

        public string Update(ChiTietHoaDon obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
