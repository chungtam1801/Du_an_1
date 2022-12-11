using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.ViewModels;
using _2.BUS.IServices;
using _2.BUS.Services;


namespace _2.BUS.Services
{
    public class BanHangServices
    {
        private IQLChiTietSpServices _iQLChiTietSpServices;
        private IClassCRUDRepo<HoaDon> _CRUDHoaDon;
        private IClassCRUDRepo<ChiTietPttt> _CRUDChiTietPTTT;
        private IClassCRUDRepo<ChiTietHoaDon> _CRUDChiTietHD;
        private IClassCRUDRepo<ChiTietSp> _CRUDChiTietSP;
        private IClassCRUDRepo<PhuongThucThanhToan> _CRUDPTTT;
        private IClassCRUDRepo<KhachHang> _CRUDKhachHang;
        private IClassCRUDRepo<LichSuTichDiem> _CRUDLSTD;
        private IClassCRUDRepo<QuyDoiDiem> _CRUDQDD;
        private IClassCRUDRepo<NhanVien> _CRUDNhanVien;
        public BanHangServices()
        {
            _iQLChiTietSpServices = new QLChiTietSpServices();
            _CRUDHoaDon = new HoaDonRepository();
            _CRUDChiTietPTTT = new ChiTietPtttRepository();
            _CRUDChiTietHD = new ChiTietHoaDonRepository();
            _CRUDChiTietSP = new ChiTietSpRepository();
            _CRUDPTTT = new PhuongThucThanhToanRepository();
            _CRUDKhachHang = new KhachHangRepository();
            _CRUDLSTD = new LichSuTichDiemRepository();
            _CRUDQDD = new QuyDoiDiemRepository();
            _CRUDNhanVien = new NhanVienRepository();
        }
        public HoaDon CreateHD(int trangthai,NhanVien nhanVien)
        {
            HoaDon hoaDon = new HoaDon();
            if (_CRUDHoaDon.GetAll().Count == 0)
            {
                hoaDon.Ma = "HD1";
            }
            else
            {
                hoaDon.Ma = "HD" + (_CRUDHoaDon.GetAll().Count + 1);
            }
            hoaDon.IdNv = nhanVien.Id;
            hoaDon.Ma = ClassSP.AutoID("HD", _CRUDHoaDon.GetAll().Count);
            hoaDon.NgayTao = DateTime.Now;
            hoaDon.TrangThai = trangthai;
            _CRUDHoaDon.Add(hoaDon);
            return hoaDon;
        }
        public KhachHang GetKhachHang(string sdt)
        {
            return _CRUDKhachHang.GetAll().FirstOrDefault(c => c.Sdt == sdt);
        }
        public string Chot(HoaDon hoaDon,KhachHang khachHang,decimal tienKhachDua,decimal tienCK,int trangThai,decimal? tienShip,int diemCong,int diemSD,string diachi)
        {
            CongDiem(hoaDon, khachHang,diemCong);
            if(tienKhachDua >0)
            {
                ChiTietPttt chiTietPttt = new ChiTietPttt();
                chiTietPttt.IdPttt = _CRUDPTTT.GetAll().FirstOrDefault(c => c.Ten == "Tiền mặt").Id;
                chiTietPttt.IdHd = hoaDon.Id;
                chiTietPttt.Ma = ClassSP.AutoID("PTTT", _CRUDChiTietPTTT.GetAll().Count);
                chiTietPttt.TienKhachDua = tienKhachDua;
                _CRUDChiTietPTTT.Add(chiTietPttt);
            }
            if (tienCK > 0)
            {
                ChiTietPttt chiTietPttt = new ChiTietPttt();
                chiTietPttt.IdPttt = _CRUDPTTT.GetAll().FirstOrDefault(c => c.Ten == "Chuyển khoản").Id;
                chiTietPttt.IdHd = hoaDon.Id;
                chiTietPttt.Ma = ClassSP.AutoID("PTTT", _CRUDChiTietPTTT.GetAll().Count);
                chiTietPttt.TienKhachDua = tienCK;
                _CRUDChiTietPTTT.Add(chiTietPttt);
            }
            if (diemSD > 0)
            {
                TruDiem(hoaDon, khachHang, diemSD);
            }           
            if (trangThai == 0)
            {
                if(khachHang!=null) hoaDon.IdKh = khachHang.Id;
                hoaDon.NgayThanhToan = DateTime.Now;
                hoaDon.TrangThai = 1;
            }
            else if (trangThai == 3)
            {
                if (khachHang != null) hoaDon.IdKh = khachHang.Id;
                hoaDon.DiaChi = diachi;
                hoaDon.NgayShip = DateTime.Now;
                hoaDon.TrangThai = 4;
                hoaDon.TienShip = tienShip;
            }
            if (_CRUDHoaDon.Update(hoaDon)) return "Thanh toán hoàn tất";
            else return "Thanh toán thất bại";
            //}
            //else
            //{
            //    if (diemSD > 0)
            //    {
            //        TruDiem(hoaDon, khachHang, diemSD);
            //    }
            //    chiTietPttt1.TienKhachDua += tienKhachDua;
            //    _CRUDChiTietPTTT.Update(chiTietPttt1);
            //    if (tienKhachDua >= tienkhachcandua)
            //    {
            //        if(CheckPTTTDiem(hoaDon))
            //        {
            //            CongDiem(hoaDon, khachHang);
            //        }    
            //        if (trangThai == 0)
            //        {
            //            hoaDon.NgayThanhToan = DateTime.Now;
            //            hoaDon.TrangThai = 1;
            //        }
            //        else if (trangThai == 3)
            //        {
            //            hoaDon.NgayShip = DateTime.Now;
            //            hoaDon.TrangThai = 4;
            //            hoaDon.TienShip = tienShip;
            //        }
            //        if (_CRUDHoaDon.Update(hoaDon)) return "Thanh toán hoàn tất";
            //        else return "Thanh toán thất bại";
            //    }
            //    else return "Hóa đơn vẫn chưa được trả hết";
            //}    
        }
        public decimal? SumTienKhachDua(Guid idHD)
        {
            return _CRUDChiTietPTTT.GetAll().Where(c => c.IdHd == idHD).Sum(d => d.TienKhachDua);
        }
        public decimal? SumTienHang(Guid idHD)
        {
            return _CRUDChiTietHD.GetAll().Where(c => c.IdHd == idHD).Sum(d => d.SoLuong * d.DonGia);
        }
        public List<ViewQLHoaDon> GetAllHDV()
        {
            var lst = new List<ViewQLHoaDon>();
            lst = (from a in _CRUDHoaDon.GetAll()
                   join b in _CRUDNhanVien.GetAll() on a.IdNv equals b.Id
                   select new ViewQLHoaDon()
                   {
                       Id = a.Id,
                       MaNV = b.Ma,
                       Ma = a.Ma,
                       NgayTao = a.NgayTao,
                       NgayThanhToan = a.NgayThanhToan,
                       NgayGiaoHang = a.NgayShip,
                       NgayNhanHang = a.NgayNhan,
                       GiamGia = a.GiamGia,
                       TongTien = SumTienHang(a.Id),
                       TrangThai = a.TrangThai == 0?"Chờ thanh toán":a.TrangThai == 1?"Đã thanh toán":a.TrangThai == 2?"Hủy thanh toán":a.TrangThai==3?"Chờ giao hàng":a.TrangThai==4?"Đang giao hàng":a.TrangThai==5?"Đã giao hàng":a.TrangThai==6?"Hủy giao hàng":""
                   }).ToList();
            return lst;
        }
        public List<HoaDon> GetAllHD()
        {
            return _CRUDHoaDon.GetAll();
        }
        //public List<ChiTietHoaDon> GetAllChiTietHD()
        //{
        //    return _CRUDChiTietHD.GetAll();
        //}
        public List<PhuongThucThanhToan> GetAllPTTT()
        {
            return _CRUDPTTT.GetAll();
        }
        public List<ViewQLChiTietHoaDon> GetAllChiTietHDV(Guid IdHD)
        {
            var lstView = new List<ViewQLChiTietHoaDon>();
            lstView = (from a in _iQLChiTietSpServices.GetAllView()
                       join b in _CRUDChiTietHD.GetAll().Where(c => c.IdHd == IdHD) on a.Id equals b.IdCtsp
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
                           Id = b.Id,
                           DonGia = b.DonGia,
                           TongTien = b.DonGia*b.SoLuong
                       }).ToList();
            return lstView;
        }
        public void AddChiTietHD(ChiTietSp chiTietSp,HoaDon hoaDon)
        {
            if (_CRUDChiTietHD.GetAll().Where(c => c.IdCtsp == chiTietSp.Id && c.IdHd == hoaDon.Id).ToList().Count == 0)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.IdCtsp = chiTietSp.Id;
                chiTietHoaDon.IdHd = hoaDon.Id;
                chiTietHoaDon.DonGia = chiTietSp.GiaBan;
                chiTietHoaDon.SoLuong = 1;
                _CRUDChiTietHD.Add(chiTietHoaDon);
            }
            else
            {
                ChiTietHoaDon chiTietHoaDon = _CRUDChiTietHD.GetAll().First(c => c.IdCtsp == chiTietSp.Id && c.IdHd == hoaDon.Id);
                chiTietHoaDon.SoLuong++;
                _CRUDChiTietHD.Update(chiTietHoaDon);
            }
            chiTietSp.SoLuongTon--;
            _CRUDChiTietSP.Update(chiTietSp);
        }
        public string UpdateTrangThaiHD(HoaDon hoaDon,int trangThai)
        {
            if(trangThai == 2 || trangThai == 6)
            {
                DeleteALLChiTietHD(hoaDon.Id);
            }
            hoaDon.TrangThai = trangThai;
            if (_CRUDHoaDon.Update(hoaDon)) return "Cập nhật trạng thái thành công";
            else return "Cập nhật trạng thái thất bại";
        }
        //Quy doi diem
        public void CongDiem(HoaDon hoaDon,KhachHang khachHang,int diem)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai > 0);
            if (qdd != null && khachHang != null && hoaDon != null)
            {
                LichSuTichDiem lichSuTichDiem = new LichSuTichDiem();
                lichSuTichDiem.IdQuyDoiDiem = qdd.Id;
                lichSuTichDiem.IdHd = hoaDon.Id;
                lichSuTichDiem.IdKh = khachHang.Id;
                lichSuTichDiem.Diem = diem;
                lichSuTichDiem.IdKh = khachHang.Id;
                khachHang.DiemTich += diem;
                _CRUDKhachHang.Update(khachHang);
                _CRUDLSTD.Add(lichSuTichDiem);
            }       
        }
        public void TruDiem(HoaDon hoaDon,KhachHang khachHang,int diemSD)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai > 0);
            if (qdd != null && khachHang != null && hoaDon != null)
            {
                LichSuTichDiem lichSuTichDiem = new LichSuTichDiem();
                lichSuTichDiem.IdQuyDoiDiem = qdd.Id;
                lichSuTichDiem.IdHd = hoaDon.Id;
                lichSuTichDiem.Diem = -diemSD;
                lichSuTichDiem.IdKh = khachHang.Id;
                khachHang.DiemTich -= diemSD;
                lichSuTichDiem.IdKh = khachHang.Id;
                _CRUDKhachHang.Update(khachHang);
                _CRUDLSTD.Add(lichSuTichDiem);
            }
        }
        public decimal QuyDoiDiemThanhTien(int diem)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai > 0);
            if (qdd != null)
            {
                return diem * qdd.TiLeTieuDiem;
            }
            else return 0;
        }
        public int QuyDoiTienThanhDiem(decimal tien)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai > 0);
            if (qdd != null)
            {
                return Convert.ToInt32(tien / qdd.TiLeTichDiem);
            }
            else return 0;
        }
        public int? GetTrangThaiQuyDoiDiem()
        {
            return _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai > 0).TrangThai;
        }
        public decimal? TienThucTe(Guid idHD)
        {
            return SumTienHang(idHD) - _CRUDLSTD.GetAll().Where(c => c.IdHd == idHD && c.Diem > 0).Sum(c => c.Diem * _CRUDQDD.GetAll().First(x=>x.Id==c.IdQuyDoiDiem).TiLeTieuDiem);
        }
        //Quan ly chi tiet hoa don
        public void UpdateSoLuongChiTietHD(Guid idCTHD, int soLuong)
        {
            ChiTietHoaDon chiTietHoaDon = _CRUDChiTietHD.GetAll().First(c => c.Id == idCTHD);
            ChiTietSp chiTietSp = _CRUDChiTietSP.GetAll().First(c => c.Id == chiTietHoaDon.IdCtsp);
            int? soluongdu = chiTietHoaDon.SoLuong - soLuong;
            chiTietHoaDon.SoLuong = soLuong;
            chiTietSp.SoLuongTon += soluongdu;
            _CRUDChiTietSP.Update(chiTietSp);
            _CRUDChiTietHD.Update(chiTietHoaDon);
        }
        public void DeleteChiTietHD(Guid idCTHD)
        {
            ChiTietHoaDon chiTietHoaDon = _CRUDChiTietHD.GetAll().First(c => c.Id == idCTHD);
            ChiTietSp chiTietSp = _CRUDChiTietSP.GetAll().First(c => c.Id == chiTietHoaDon.IdCtsp);
            chiTietSp.SoLuongTon += chiTietHoaDon.SoLuong;
            _CRUDChiTietSP.Update(chiTietSp);
            _CRUDChiTietHD.Delete(chiTietHoaDon);
        }
        public void DeleteALLChiTietHD(Guid idHD)
        {
            List<ChiTietHoaDon> lst = _CRUDChiTietHD.GetAll().Where(c => c.IdHd == idHD).ToList();
            foreach(var x in lst)
            {
                ChiTietSp chiTietSp = _CRUDChiTietSP.GetAll().First(c => c.Id == x.IdCtsp);
                chiTietSp.SoLuongTon += x.SoLuong;
                _CRUDChiTietSP.Update(chiTietSp);
                _CRUDChiTietHD.Delete(x);
            }          
        }
        public KhachHang GetKHById(Guid? idkh)
        {
            return _CRUDKhachHang.GetbyId(idkh);
        }
    }
}
