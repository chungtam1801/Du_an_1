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
        }
        public HoaDon CreateHD(int trangthai)
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
            hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
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
        public string Chot(Guid idPTTT,HoaDon hoaDon,KhachHang khachHang,decimal tienKhachDua,decimal tienkhachcandua,int trangThai,decimal? tienShip,int diemSD)
        {
            ChiTietPttt chiTietPttt1 = _CRUDChiTietPTTT.GetAll().FirstOrDefault(c => c.IdPttt == idPTTT && c.IdHd == hoaDon.Id);
            if (chiTietPttt1 == null)
            {
                ChiTietPttt chiTietPttt = new ChiTietPttt();
                chiTietPttt.IdPttt = idPTTT;
                chiTietPttt.IdHd = hoaDon.Id;
                chiTietPttt.Ma = ClassSP.AutoID("PTTT", _CRUDChiTietPTTT.GetAll().Count);
                if(diemSD>0)
                {
                    TruDiem(hoaDon, khachHang, diemSD);
                }
                chiTietPttt.TienKhachDua = tienKhachDua;
                _CRUDChiTietPTTT.Add(chiTietPttt);
                //Sua
                if (tienKhachDua >= tienkhachcandua)
                {
                    if (CheckPTTTDiem(hoaDon))
                    {
                        CongDiem(hoaDon, khachHang);
                    }
                    if (trangThai == 0)
                    {
                        hoaDon.NgayThanhToan = DateTime.Now;
                        hoaDon.TrangThai = 1;
                    }
                    else if (trangThai == 3)
                    {
                        hoaDon.NgayShip = DateTime.Now;
                        hoaDon.TrangThai = 4;
                        hoaDon.TienShip = tienShip;
                    }
                    if (_CRUDHoaDon.Update(hoaDon)) return "Thanh toán hoàn tất";
                    else return "Thanh toán thất bại";
                }
                else return "Hóa đơn vẫn chưa được trả hết";
            }
            else
            {
                if (diemSD > 0)
                {
                    TruDiem(hoaDon, khachHang, diemSD);
                }
                chiTietPttt1.TienKhachDua += tienKhachDua;
                _CRUDChiTietPTTT.Update(chiTietPttt1);
                if (tienKhachDua >= tienkhachcandua)
                {
                    if(CheckPTTTDiem(hoaDon))
                    {
                        CongDiem(hoaDon, khachHang);
                    }    
                    if (trangThai == 0)
                    {
                        hoaDon.NgayThanhToan = DateTime.Now;
                        hoaDon.TrangThai = 1;
                    }
                    else if (trangThai == 3)
                    {
                        hoaDon.NgayShip = DateTime.Now;
                        hoaDon.TrangThai = 4;
                        hoaDon.TienShip = tienShip;
                    }
                    if (_CRUDHoaDon.Update(hoaDon)) return "Thanh toán hoàn tất";
                    else return "Thanh toán thất bại";
                }
                else return "Hóa đơn vẫn chưa được trả hết";
            }    
        }
        public decimal? SumTienKhachDua(Guid idHD)
        {
            return _CRUDChiTietPTTT.GetAll().Where(c => c.IdHd == idHD).Sum(d => d.TienKhachDua);
        }
        public decimal? SumTienHang(Guid idHD)
        {
            return _CRUDChiTietHD.GetAll().Where(c => c.IdHd == idHD).Sum(d => d.SoLuong * d.DonGia);
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
        public void UpdateChiTietHD(Guid idCTHD,int soLuong)
        {
            ChiTietHoaDon chiTietHoaDon = _CRUDChiTietHD.GetAll().First(c => c.Id == idCTHD);
            ChiTietSp chiTietSp = _CRUDChiTietSP.GetAll().First(c => c.Id == chiTietHoaDon.IdCtsp);
            chiTietHoaDon.SoLuong = soLuong;
            chiTietSp.SoLuongTon-=soLuong;
            _CRUDChiTietHD.Update(chiTietHoaDon);
            _CRUDChiTietSP.Update(chiTietSp);
        }
        public string UpdateTrangThaiHD(HoaDon hoaDon,int trangThai)
        {
            hoaDon.TrangThai = trangThai;
            if (_CRUDHoaDon.Update(hoaDon)) return "Cập nhật trạng thái thành công";
            else return "Cập nhật trạng thái thất bại";
        }
        public bool CheckHDThanhToan(HoaDon hoaDon)
        {
            if (_CRUDChiTietPTTT.GetAll().FirstOrDefault(c => c.IdHd == hoaDon.Id) == null)
            {
                return false;
            }
            else return true;
        }
        //Quy doi diem
        public void CongDiem(HoaDon hoaDon,KhachHang khachHang)
        {
                QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai == 1);
                if (qdd != null && khachHang != null && hoaDon != null)
                {
                    LichSuTichDiem lichSuTichDiem = new LichSuTichDiem();
                    lichSuTichDiem.IdQuyDoiDiem = qdd.Id;
                    lichSuTichDiem.IdHd = hoaDon.Id;
                    lichSuTichDiem.Diem = Convert.ToInt32(SumTienHang(hoaDon.Id) / qdd.TiLeTichDiem);
                    khachHang.DiemTich += lichSuTichDiem.Diem;
                    _CRUDKhachHang.Update(khachHang);
                    _CRUDLSTD.Add(lichSuTichDiem);
                }       
        }
        public void TruDiem(HoaDon hoaDon,KhachHang khachHang,int diemSD)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai == 1);
            if (qdd != null && khachHang != null && hoaDon != null)
            {
                LichSuTichDiem lichSuTichDiem = new LichSuTichDiem();
                lichSuTichDiem.IdQuyDoiDiem = qdd.Id;
                lichSuTichDiem.IdHd = hoaDon.Id;
                lichSuTichDiem.Diem = -diemSD;
                khachHang.DiemTich -= diemSD;
                ChiTietPttt chiTietPttt = new ChiTietPttt();
                _CRUDKhachHang.Update(khachHang);
                _CRUDLSTD.Add(lichSuTichDiem);
            }
        }
        public bool CheckPTTTDiem(HoaDon hoaDon)
        {
            return _CRUDChiTietPTTT.GetAll().FirstOrDefault(c => c.IdHd == hoaDon.Id && _CRUDPTTT.GetbyId(c.IdPttt).Ten == "Điểm") == null;
        }
        public decimal QuyDoiDiem(int diem)
        {
            QuyDoiDiem qdd = _CRUDQDD.GetAll().FirstOrDefault(p => p.TrangThai == 1);
            if (qdd != null)
            {
                return diem * qdd.TiLeTieuDiem;
            }
            else return 0;
        }
    }
}
