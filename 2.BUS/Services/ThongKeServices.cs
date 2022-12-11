using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ThongKeServices
    {
        private IClassCRUDRepo<HoaDon> _CRUDHoaDon;
        private BanHangServices _banHangServices = new BanHangServices();
        public ThongKeServices()
        {
            _CRUDHoaDon = new HoaDonRepository();
        }
        public List<ViewQLThongKe> LoadDoanhThuNgay()
        {
            return (from a in _CRUDHoaDon.GetAll() where a.TrangThai == 1 || a.TrangThai == 4 || a.TrangThai == 5
             group a by Convert.ToDateTime(a.NgayThanhToan).Date.ToString("d") into g
             select new ViewQLThongKe()
             {
                 TongTien = g.Sum(c=>_banHangServices.TienThucTe(c.Id)),
                 Ngay = g.Key
             }).ToList();
        }
        public List<ViewQLThongKe> LoadDoanhThuThang()
        {
            return (from a in _CRUDHoaDon.GetAll()
                    where a.TrangThai == 1 || a.TrangThai == 4 || a.TrangThai == 5
                    group a by Convert.ToDateTime(a.NgayThanhToan).Date.ToString("MM/yyyy") into g
                    select new ViewQLThongKe()
                    {
                        TongTien = g.Sum(c => _banHangServices.TienThucTe(c.Id)),
                        Thang = g.Key
                    }).ToList();
        }
        public List<ViewQLThongKe> LoadDoanhThuNam()
        {
            return (from a in _CRUDHoaDon.GetAll()
                    where a.TrangThai == 1 || a.TrangThai == 4 || a.TrangThai == 5
                    group a by Convert.ToDateTime(a.NgayThanhToan).Date.ToString("yyyy") into g
                    select new ViewQLThongKe()
                    {
                        TongTien = g.Sum(c => _banHangServices.TienThucTe(c.Id)),
                        Nam = g.Key
                    }).ToList();
        }
        public decimal? SumTienNgay()
        {
            return (from a in _CRUDHoaDon.GetAll() where Convert.ToDateTime(a.NgayThanhToan).Date == DateTime.Now.Date || Convert.ToDateTime(a.NgayShip).Date == DateTime.Now.Date
                    select  new 
                    {
                        TongTien = _banHangServices.TienThucTe(a.Id)
                    }).Sum(c=>c.TongTien);
        }
        public decimal? SumTienThang()
        {
            return (from a in _CRUDHoaDon.GetAll()
                    where Convert.ToDateTime(a.NgayThanhToan).Month == DateTime.Now.Month || Convert.ToDateTime(a.NgayShip).Month == DateTime.Now.Month
                    select new
                    {
                        TongTien = _banHangServices.TienThucTe(a.Id)
                    }).Sum(c => c.TongTien);
        }
        public decimal? SumTienNam()
        {
            return (from a in _CRUDHoaDon.GetAll()
                    where Convert.ToDateTime(a.NgayThanhToan).Year == DateTime.Now.Year || Convert.ToDateTime(a.NgayShip).Year == DateTime.Now.Year
                    select new
                    {
                        TongTien = _banHangServices.TienThucTe(a.Id)
                    }).Sum(c => c.TongTien);
        }
        public int GetSoLuongHD()
        {
            return _CRUDHoaDon.GetAll().Count;
        }
        public int GetSoLuongHDThanhToan()
        {
            return _CRUDHoaDon.GetAll().Where(c => c.TrangThai == 1 || c.TrangThai == 4 || c.TrangThai == 5).ToList().Count;
        }
        public int GetSoLuongHDHuy()
        {
            return _CRUDHoaDon.GetAll().Where(c => c.TrangThai == 2 || c.TrangThai == 6).ToList().Count;
        }
    }
}
