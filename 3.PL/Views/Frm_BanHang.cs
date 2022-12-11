using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System.IO;
using AForge.Video.DirectShow;
using System.Threading;
using ZXing;
using _3.PL.Utilities;

namespace _3.PL.Views
{
    public partial class Frm_BanHang : Form
    {
        private BanHangServices _banHangServices = new BanHangServices();
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private IQLChiTietSpServices _iQLChiTietSpServices;
        private IQLGiaoCaServices _iQLGiaoCaServices;
        private IQLHoaDonServices _iQLHoaDonServices;
        private KhachHang? _khachHang;
        private List<ThongTinSanPham> lstTTSP = new List<ThongTinSanPham>();
        private int _trangThaiBH = 0;
        private decimal _min=0;
        private decimal _max=0;
        private string _trangThaiHD = "Chờ thanh toán";
        private string _trangThaiDH = "Chờ giao hàng";
        public HoaDon? _hoaDon { get; set; }
        public NhanVien _nhanVien { get; set; }
        public Frm_Main frmmain { get; set; }
        public Frm_BanHang()
        {
            
            InitializeComponent();
            _iQLChiTietSpServices = new QLChiTietSpServices();
            _iQLGiaoCaServices = new QLGiaoCaServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            LoadDTG_HoaDon(_trangThaiHD);
            LoadDTG_DatHang(_trangThaiDH);
            GetData(_iQLChiTietSpServices.GetAllView());
            cbx_TrangThai.SelectedIndex = 0;
            cbx_THDatHang.SelectedIndex = 0;
            cbx_HTTT.SelectedIndex = 0;
        }
        private void GetData(List<ViewQLChiTietSp> lstview)
        {
            try
            {
                flp_SanPham.Controls.Clear();
                ThongTinSanPham thongTinSanPham;
                foreach (var x in lstview)
                {
                    thongTinSanPham = new ThongTinSanPham(x);
                    thongTinSanPham.Click += new System.EventHandler(UserContrel_Click);
                    lstTTSP.Add(thongTinSanPham);
                    flp_SanPham.Controls.Add(thongTinSanPham);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LocBangTien(decimal min,decimal max)
        {
            try
            {
                _min = min;
                _max = max;
                foreach (var x in lstTTSP.Where(c => c.chiTietSP.Ten.Contains(tbx_TimKiem.Text)))
                {
                    if (x.chiTietSP.GiaBan > min && x.chiTietSP.GiaBan < max)
                    {
                        x.Visible = true;
                    }
                    else
                    {
                        x.Visible = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private string LaydoanhthuNgay(decimal? x)
        {
            // Tổng doanh thu ngày
            // List ca được tạo trong ngày hôm nay với thời gian tăng dần
            List<GiaoCa> catrongngay = _iQLGiaoCaServices.GetAll().Where(c => Convert.ToDateTime(c.ThoiGianVaoCa).Day == DateTime.Now.Day).OrderBy(c => c.ThoiGianVaoCa).ToList();
            //Lấy thời gian vào của ca sớm nhất trong ngày
            DateTime thoigianvao = Convert.ToDateTime(catrongngay[0].ThoiGianVaoCa);
            // Lấy danh sách hóa đơn được tạo cho đến bây giờ
            _iQLHoaDonServices = new QLHoaDonServices();
            List<HoaDon> hoaDons = _iQLHoaDonServices.GetAll().Where(c => c.NgayTao > Convert.ToDateTime(thoigianvao) && c.NgayTao < DateTime.Now).ToList();
            // Hóa đơn đã thanh toán
            List<HoaDon> hoadontt = hoaDons.Where(c => c.TrangThai == 1 || c.TrangThai == 4).ToList();
            // Tính doanh thu theo ngày
            // Hóa đơn hủy
            List<HoaDon> hoadonhuy = hoaDons.Where(c => c.TrangThai == 2 || c.TrangThai == 6).ToList();
            if (hoadontt.Count > 0) x += hoadontt.Sum(c => _banHangServices.SumTienHang(c.Id));
            if (hoadonhuy.Count > 0) x -= hoadonhuy.Sum(c => _banHangServices.SumTienHang(c.Id));
            return x.ToString();
        }
        private string LaydoanhThuCa(decimal? x)
        {
            // Tổng doanh thu ca
            // Tìm ca được lưu gần nhất lưu 
            List<GiaoCa> ca = _iQLGiaoCaServices.GetAll().OrderByDescending(c => c.ThoiGianVaoCa).ToList();
            //Lấy thời gian vào ca gần nhất trong csdl
            DateTime thoigianvao = Convert.ToDateTime(ca[0].ThoiGianVaoCa);
            // Lấy danh sách hóa đơn được tạo trong ca
            _iQLHoaDonServices = new QLHoaDonServices();
            List<HoaDon> hoaDons = _iQLHoaDonServices.GetAll().Where(c => c.NgayTao > Convert.ToDateTime(thoigianvao) && c.NgayTao < DateTime.Now).ToList();
            // Hóa đơn đã thanh toán
            List<HoaDon> hoadontt = hoaDons.Where(c => c.TrangThai == 1 || c.TrangThai == 4).ToList();
            // Hóa đơn hủy
            List<HoaDon> hoadonhuy = hoaDons.Where(c => c.TrangThai == 2 || c.TrangThai == 6).ToList();
            if (hoadontt.Count > 0) x += hoadontt.Sum(c => _banHangServices.SumTienHang(c.Id));
            if (hoadonhuy.Count > 0) x -= hoadonhuy.Sum(c => _banHangServices.SumTienHang(c.Id));
            return x.ToString();
        }
        private void LoadThongTinHoaDon(HoaDon? hoaDon)
        {
            try
            {
                if (hoaDon == null)
                {
                    tbx_MaHD.Text = "";
                    tbx_TongTien.Text = "0";
                    tbx_TienKhachCD.Text = "0";
                    btn_Chot.Text = "Thanh toán";
                }
                else
                {
                    tbx_MaHD.Text = hoaDon.Ma;
                    tbx_TongTien.Text = _banHangServices.SumTienHang(hoaDon.Id).ToString();
                    tbx_TienKhachCD.Text = (_banHangServices.SumTienHang(hoaDon.Id) - _banHangServices.SumTienKhachDua(hoaDon.Id)).ToString();
                    tbx_DiemHD.Text = _banHangServices.QuyDoiTienThanhDiem(Convert.ToDecimal(tbx_TongTien.Text)).ToString();
                    if (_trangThaiBH < 3)
                    {
                        tbx_DiaChi.Text = "";
                        tbx_TienShip.Text = "";
                        tbx_TienShip.Enabled = false;
                        tbx_DiaChi.Enabled = false;
                    }
                    else
                    {
                        tbx_TienShip.Enabled = true;
                        tbx_DiaChi.Enabled = true;
                        if (hoaDon.TrangThai != 3)
                        {
                            if (hoaDon.IdKh != null)
                            {
                                KhachHang temp = _banHangServices.GetKHById(hoaDon.IdKh);
                                tbx_SDT.Text = temp.Sdt;
                                tbx_TenKH.Text = temp.Ho + " " + temp.TenDem + " " + temp.Ten;
                                tbx_Diem.Text = temp.DiemTich.ToString();
                            }
                        }
                    }
                    if (hoaDon.TrangThai == 4) btn_Chot.Text = "Đã giao hàng";
                    else if (hoaDon.TrangThai == 3) btn_Chot.Text = "Giao hàng";
                    else if (hoaDon.TrangThai < 3) btn_Chot.Text = "Thanh toán";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        private void LoadTBX_TienThua()
        {
            try
            {
                if (!Utility.CheckNumber(tbx_TienKhachDua.Text))
                {
                    MessageBox.Show("Tiền khách đưa ko hợp lệ");
                    tbx_TienKhachDua.Text = "0";
                }
                else if (!Utility.CheckNumber(tbx_TienCK.Text))
                {
                    MessageBox.Show("Tiền chuyển khoản ko hợp lệ");
                    tbx_TienCK.Text = "0";
                }
                else if (Utility.CheckNumber(tbx_TienKhachCD.Text))
                {
                    decimal tienThua = Convert.ToDecimal(tbx_TienKhachDua.Text) + Convert.ToDecimal(tbx_TienCK.Text) - Convert.ToDecimal(tbx_TienKhachCD.Text);
                    if (tienThua > 0)
                    {
                        tbx_TienThua.Text = tienThua.ToString();
                    }
                    else
                    {
                        tbx_TienThua.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        public void LoadDTG_ChiTietHD(List<ViewQLChiTietHoaDon> lstView)
        {
            try
            {
                dtg_ChiTietHD.Rows.Clear();
                dtg_ChiTietHD.ColumnCount = 11;
                dtg_ChiTietHD.Columns[0].Name = "Ma";
                dtg_ChiTietHD.Columns[1].Name = "Ten";
                dtg_ChiTietHD.Columns[2].Name = "Nsx";
                dtg_ChiTietHD.Columns[3].Name = "Mau Sac";
                dtg_ChiTietHD.Columns[4].Name = "LoaiSp";
                dtg_ChiTietHD.Columns[5].Name = "Kich Thuoc";
                dtg_ChiTietHD.Columns[6].Name = "Chat Lieu";
                dtg_ChiTietHD.Columns[7].Name = "So Luong";
                dtg_ChiTietHD.Columns[8].Name = "Id";
                dtg_ChiTietHD.Columns[8].Visible = false;
                dtg_ChiTietHD.Columns[9].Name = "Đơn giá";
                dtg_ChiTietHD.Columns[10].Name = "Tổng tiền";
                foreach (ViewQLChiTietHoaDon x in lstView)
                {
                    dtg_ChiTietHD.Rows.Add(x.Ma, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.SoLuong, x.Id, x.DonGia, x.TongTien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        public void Clear_Form()
        {
            try
            {
                _hoaDon = null;
                _khachHang = null;
                dtg_ChiTietHD.Rows.Clear();
                tbx_SDT.Text = "";
                tbx_TenKH.Text = "";
                tbx_Diem.Text = "";
                tbx_MaHD.Text = "";
                tbx_TongTien.Text = "0";
                tbx_TienKhachCD.Text = "0";
                tbx_DiemHD.Text = "";
                tbx_DiemSD.Text = "";
                tbx_DiemSD.Enabled = false;
                tbx_TienKhachDua.Text = "0";
                tbx_TienCK.Text = "0";
                tbx_TienThua.Text = "0";
                tbx_DiaChi.Text = "";
                tbx_TienShip.Text = "";
                tbx_GhiChu.Text = "";
                cbx_HTTT.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDTG_DatHang(string trangthai)
        {
            try
            {
                dtg_DatHang.Rows.Clear();
                dtg_DatHang.ColumnCount = 7;
                dtg_DatHang.Columns[0].Name = "Mã";
                dtg_DatHang.Columns[1].Name = "Nhân viên";
                dtg_DatHang.Columns[2].Name = "Ngày tạo";
                dtg_DatHang.Columns[3].Name = "Ngày giao hàng";
                dtg_DatHang.Columns[4].Name = "Ngày nhận hàng";
                dtg_DatHang.Columns[5].Name = "Tổng tiền";
                dtg_DatHang.Columns[6].Name = "Trạng thái";
                foreach (ViewQLHoaDon hoaDon in _banHangServices.GetAllHDV().Where(c => c.TrangThai == trangthai))
                {
                    dtg_DatHang.Rows.Add(hoaDon.Ma, hoaDon.MaNV, hoaDon.NgayTao, hoaDon.NgayGiaoHang, hoaDon.NgayNhanHang, hoaDon.TongTien, hoaDon.TrangThai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        public void LoadDTG_HoaDon(string trangthai)
        {
            try
            {
                dtg_HoaDon.Rows.Clear();
                dtg_HoaDon.ColumnCount = 6;
                dtg_HoaDon.Columns[0].Name = "Mã";
                dtg_HoaDon.Columns[1].Name = "Nhân viên";
                dtg_HoaDon.Columns[2].Name = "Ngày tạo";
                dtg_HoaDon.Columns[3].Name = "Ngay thanh toán";
                dtg_HoaDon.Columns[4].Name = "Tổng tiền";
                dtg_HoaDon.Columns[5].Name = "Trạng thái";
                foreach (ViewQLHoaDon hoaDon in _banHangServices.GetAllHDV().Where(c => c.TrangThai == trangthai))
                {
                    dtg_HoaDon.Rows.Add(hoaDon.Ma, hoaDon.MaNV, hoaDon.NgayTao, hoaDon.NgayThanhToan, hoaDon.TongTien, hoaDon.TrangThai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        #region pnl_SanPham
        private void UserContrel_Click(object sender, EventArgs e)
        {
            try
            {
                ThongTinSanPham obj = (ThongTinSanPham)sender;
                if (_hoaDon == null)
                {
                    _hoaDon = _banHangServices.CreateHD(_trangThaiBH, _nhanVien);
                    LoadDTG_HoaDon(_trangThaiHD);
                }
                if (!(_hoaDon.TrangThai == 1 || _hoaDon.TrangThai == 4 || _hoaDon.TrangThai == 5))
                {
                    ChiTietSp temp = _iQLChiTietSpServices.GetAll().First(c => c.Id == obj.chiTietSP.Id);
                    if (temp.SoLuongTon > 0)
                    {
                        _banHangServices.AddChiTietHD(temp, _hoaDon);
                        obj.lbl_SoLuong.Text = temp.SoLuongTon.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm hết hàng");
                    }
                    LoadThongTinHoaDon(_hoaDon);
                    LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                }
                else MessageBox.Show("Hóa đơn đã thanh toán");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                      
        }

        private void pic_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_LocBangTien.Text == "Clear")
                {
                    foreach (var x in lstTTSP.Where(c => c.chiTietSP.GiaBan >= _min && c.chiTietSP.GiaBan <= _max))
                    {
                        if (x.chiTietSP.Ten.Contains(tbx_TimKiem.Text))
                        {
                            x.Visible = true;
                        }
                        else
                        {
                            x.Visible = false;
                        }
                    }
                }
                else
                {
                    foreach (var x in lstTTSP)
                    {
                        if (x.chiTietSP.Ten.Contains(tbx_TimKiem.Text))
                        {
                            x.Visible = true;
                        }
                        else
                        {
                            x.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }              
        }
        private void btn_LocBangTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_LocBangTien.Text == "Clear")
                {
                    _min = 0;
                    _max = 0;
                    btn_LocBangTien.Text = "Lọc bằng tiền";
                    foreach (var x in lstTTSP.Where(c => c.chiTietSP.Ten.Contains(tbx_TimKiem.Text)))
                    {
                        x.Visible = true;
                    }
                }
                else
                {
                    Frm_LocBangTien frm_LocBangTien = new Frm_LocBangTien();
                    frm_LocBangTien.frmParent = this;
                    frm_LocBangTien.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        #endregion
        #region pnl_ThongTinHD
        private void cbx_HTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_HTTT.Text == "Tiền mặt")
                {
                    tbx_TienCK.Location = tbx_TienKhachDua.Location;
                    tbx_TienThua.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 10 * 4);
                    tbx_DiaChi.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 20 * 4);
                    tbx_TienShip.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 30 * 4);
                    tbx_GhiChu.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 40 * 4);
                    lbl_ChuyenKhoan.Location = lbl_Tien.Location;
                    lbl_TienThua.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 10 * 4);
                    lbl_DiaChi.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 20 * 4);
                    lbl_TienShip.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 30 * 4);
                    lbl_GhiChu.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 40 * 4);
                    tbx_TienKhachDua.Visible = true;
                    lbl_Tien.Visible = true;
                    tbx_TienCK.Visible = false;
                    tbx_TienCK.Text = "0";
                    lbl_ChuyenKhoan.Visible = false;
                }
                else if (cbx_HTTT.Text == "Chuyển khoản")
                {
                    tbx_TienCK.Location = tbx_TienKhachDua.Location;
                    tbx_TienThua.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 10 * 4);
                    tbx_DiaChi.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 20 * 4);
                    tbx_TienShip.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 30 * 4);
                    tbx_GhiChu.Location = new Point(tbx_TienCK.Location.X, tbx_TienCK.Location.Y + 40 * 4);
                    lbl_ChuyenKhoan.Location = lbl_Tien.Location;
                    lbl_TienThua.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 10 * 4);
                    lbl_DiaChi.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 20 * 4);
                    lbl_TienShip.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 30 * 4);
                    lbl_GhiChu.Location = new Point(lbl_ChuyenKhoan.Location.X, lbl_ChuyenKhoan.Location.Y + 40 * 4);
                    tbx_TienKhachDua.Visible = false;
                    lbl_Tien.Visible = false;
                    tbx_TienKhachDua.Text = "0";
                    tbx_TienCK.Visible = true;
                    lbl_ChuyenKhoan.Visible = true;
                }
                else if (cbx_HTTT.Text == "Tiền mặt và chuyển khoản")
                {
                    tbx_TienKhachDua.Visible = true;
                    lbl_Tien.Visible = true;
                    tbx_TienCK.Visible = true;
                    lbl_ChuyenKhoan.Visible = true;
                    tbx_TienCK.Location = new Point(tbx_TienKhachDua.Location.X, tbx_TienKhachDua.Location.Y + 10 * 4);
                    tbx_TienThua.Location = new Point(tbx_TienKhachDua.Location.X, tbx_TienKhachDua.Location.Y + 20 * 4);
                    tbx_DiaChi.Location = new Point(tbx_TienKhachDua.Location.X, tbx_TienKhachDua.Location.Y + 30 * 4);
                    tbx_TienShip.Location = new Point(tbx_TienKhachDua.Location.X, tbx_TienKhachDua.Location.Y + 40 * 4);
                    tbx_GhiChu.Location = new Point(tbx_TienKhachDua.Location.X, tbx_TienKhachDua.Location.Y + 50 * 4);
                    lbl_ChuyenKhoan.Location = new Point(lbl_Tien.Location.X, lbl_Tien.Location.Y + 10 * 4);
                    lbl_TienThua.Location = new Point(lbl_Tien.Location.X, lbl_Tien.Location.Y + 20 * 4);
                    lbl_DiaChi.Location = new Point(lbl_Tien.Location.X, lbl_Tien.Location.Y + 30 * 4);
                    lbl_TienShip.Location = new Point(lbl_Tien.Location.X, lbl_Tien.Location.Y + 40 * 4);
                    lbl_GhiChu.Location = new Point(lbl_Tien.Location.X, lbl_Tien.Location.Y + 50 * 4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void tbx_SDT_Leave(object sender, EventArgs e)
        {
            try
            {
                _khachHang = _banHangServices.GetKhachHang(tbx_SDT.Text);
                if (_khachHang != null)
                {
                    tbx_TenKH.Text = _khachHang.Ho + " " + _khachHang.TenDem + " " + _khachHang.Ten;
                    tbx_Diem.Text = _khachHang.DiemTich.ToString();
                    tbx_DiemSD.Enabled = true;
                    tbx_DiemSD.Text = "0";
                    tbx_ThanhTien.Text = "0";
                }
                else
                {
                    tbx_TenKH.Text = "";
                    tbx_Diem.Text = "";
                    tbx_DiemSD.Enabled = false;
                    tbx_DiemSD.Text = "";
                    tbx_ThanhTien.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private void tbx_TienCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) LoadTBX_TienThua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbx_TienKhachDua_Leave(object sender, EventArgs e)
        {
            try
            {
                LoadTBX_TienThua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private void tbx_TienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter) LoadTBX_TienThua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbx_TienCK_Leave(object sender, EventArgs e)
        {
            try
            {
                LoadTBX_TienThua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utility.CheckStringEmpty(tbx_GhiChu.Text))
                {
                    MessageBox.Show("Vui lòng điền ghi chú");
                }
                else
                {
                    if (_trangThaiBH < 3)
                    {
                        MessageBox.Show(_banHangServices.UpdateTrangThaiHD(_hoaDon, 2));
                        LoadDTG_HoaDon(_trangThaiHD);
                    }
                    else
                    {
                        MessageBox.Show(_banHangServices.UpdateTrangThaiHD(_hoaDon, 6));
                        LoadDTG_DatHang(_trangThaiDH);
                    }
                    frmmain.lbl_doanhthuca.Text = LaydoanhThuCa(Convert.ToDecimal(frmmain.lbl_doanhthuca.Text));
                    frmmain.lbl_doanhthungay.Text = LaydoanhthuNgay(Convert.ToDecimal(frmmain.lbl_doanhthungay.Text));
                    Clear_Form();
                    _iQLChiTietSpServices = new QLChiTietSpServices();
                    GetData(_iQLChiTietSpServices.GetAllView());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btn_Chot_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hoaDon == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn");
                }
                else if (_hoaDon.TrangThai == 1)
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán");
                }
                else if (_banHangServices.GetAllChiTietHDV(_hoaDon.Id).Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                }
                else if (Convert.ToInt32(tbx_TienKhachDua.Text) + Convert.ToInt32(tbx_TienCK.Text) < Convert.ToInt32(tbx_TienKhachCD.Text))
                {
                    MessageBox.Show("Tiền khách trả chưa đủ");
                }
                else if (!Utility.CheckStringEmpty(tbx_SDT.Text) && Utility.CheckStringEmpty(tbx_TenKH.Text))
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                }
                else if (_trangThaiBH >= 3 && _khachHang == null)
                {
                    MessageBox.Show("Cần khách hàng khi đặt hàng");
                }
                else if (_trangThaiBH >= 3 && Utility.CheckStringEmpty(tbx_DiaChi.Text))
                {
                    MessageBox.Show("Cần địa chỉ khi đặt hàng");
                }
                else if (btn_Chot.Text == "Đã giao hàng")
                {
                    MessageBox.Show(_banHangServices.UpdateTrangThaiHD(_hoaDon, 5));
                    LoadDTG_DatHang(_trangThaiDH);
                }
                else
                {
                    MessageBox.Show(_banHangServices.Chot(_hoaDon, _khachHang, tbx_TienKhachDua.Text == String.Empty ? 0 : Convert.ToDecimal(tbx_TienKhachDua.Text), tbx_TienCK.Text == String.Empty ? 0 : Convert.ToDecimal(tbx_TienCK.Text), _trangThaiBH, tbx_TienShip.Text == String.Empty ? 0 : Convert.ToDecimal(tbx_TienShip.Text), tbx_DiemHD.Text == String.Empty ? 0 : Convert.ToInt32(tbx_DiemHD.Text), tbx_DiemSD.Text == String.Empty ? 0 : Convert.ToInt32(tbx_DiemSD.Text), tbx_DiaChi.Text));
                    if (_trangThaiBH < 3)
                    {
                        LoadDTG_HoaDon(_trangThaiHD);
                    }
                    else
                    {
                        LoadDTG_DatHang(_trangThaiDH);
                    }
                    frmmain.lbl_doanhthuca.Text = LaydoanhThuCa(Convert.ToDecimal(frmmain.lbl_doanhthuca.Text));
                    frmmain.lbl_doanhthungay.Text = LaydoanhthuNgay(Convert.ToDecimal(frmmain.lbl_doanhthungay.Text));
                    Clear_Form();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void tbx_DiemSD_Leave(object sender, EventArgs e)
        {
            try
            {
                if (_khachHang != null)
                {
                    if (!Utility.CheckNumber(tbx_DiemSD.Text))
                    {
                        MessageBox.Show("Điểm sử dụng ko hợp lệ");
                        tbx_DiemSD.Text = "0";
                    }
                    else if (Convert.ToInt32(tbx_DiemSD.Text) > Convert.ToInt32(tbx_Diem.Text) + Convert.ToInt32(tbx_DiemHD.Text))
                    {
                        MessageBox.Show("Điểm khách hàng ko đủ");
                        tbx_DiemSD.Text = "0";
                    }
                    else
                    {
                        tbx_TienKhachCD.Text = (Convert.ToDecimal(tbx_TongTien.Text) - _banHangServices.QuyDoiDiemThanhTien(Convert.ToInt32(tbx_DiemSD.Text))).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                 
        }
        private void tbx_TongTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = dtg_HoaDon.CurrentRow;
                if (dataGridViewRow != null && _hoaDon != null)
                {
                    if (_trangThaiBH < 3)
                    {
                        if (_hoaDon.Ma == dataGridViewRow.Cells[0].Value.ToString())
                        {
                            dataGridViewRow.Cells[4].Value = tbx_TongTien.Text;
                        }
                    }
                    else
                    {
                        if (_hoaDon.Ma == dataGridViewRow.Cells[0].Value.ToString())
                        {
                            dataGridViewRow.Cells[5].Value = tbx_TongTien.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
        }
        private void tbx_DiemSD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Utility.CheckNumber(tbx_DiemSD.Text))
                {
                    tbx_ThanhTien.Text = _banHangServices.QuyDoiDiemThanhTien(Convert.ToInt32(tbx_DiemSD.Text)).ToString();
                    if (tbx_DiemSD.Text != "0")
                    {
                        if (_banHangServices.GetTrangThaiQuyDoiDiem() == 1)
                        {
                            tbx_DiemHD.Text = "0";
                        }
                        else
                        {
                            tbx_DiemHD.Text = _banHangServices.QuyDoiTienThanhDiem(Convert.ToDecimal(tbx_TongTien.Text)).ToString();
                        }
                    }
                    else
                    {
                        tbx_DiemHD.Text = _banHangServices.QuyDoiTienThanhDiem(Convert.ToDecimal(tbx_TongTien.Text)).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }
        #endregion
        #region pnl_BanHang
        private void pic_TaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                _hoaDon = _banHangServices.CreateHD(0, _nhanVien);
                _trangThaiBH = 0;
                LoadThongTinHoaDon(_hoaDon);
                LoadDTG_HoaDon(_trangThaiHD);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _trangThaiHD = cbx_TrangThai.Text;
                LoadDTG_HoaDon(_trangThaiHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtg_HoaDon.CurrentRow.Cells[0].Value != null)
                {
                    _trangThaiBH = 0;
                    _hoaDon = _banHangServices.GetAllHD().First(c => c.Ma == dtg_HoaDon.CurrentRow.Cells[0].Value.ToString());
                    LoadThongTinHoaDon(_hoaDon);
                    LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        #endregion
        #region pnl_DatHang
        private void pic_TaoDatHang_Click(object sender, EventArgs e)
        {
            try
            {
                _hoaDon = _banHangServices.CreateHD(3, _nhanVien);
                _trangThaiBH = 3;
                LoadThongTinHoaDon(_hoaDon);
                LoadDTG_DatHang(_trangThaiDH);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void cbx_THDatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _trangThaiDH = cbx_THDatHang.Text;
                LoadDTG_DatHang(_trangThaiDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        private void dtg_DatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtg_DatHang.CurrentRow.Cells[0].Value != null)
                {
                    _trangThaiBH = 3;
                    _hoaDon = _banHangServices.GetAllHD().First(c => c.Ma == dtg_DatHang.CurrentRow.Cells[0].Value.ToString());
                    LoadThongTinHoaDon(_hoaDon);
                    LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        #endregion
        #region pnl_GioHang
        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hoaDon != null)
                {
                    _banHangServices.DeleteALLChiTietHD(_hoaDon.Id);
                    LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                    _iQLChiTietSpServices = new QLChiTietSpServices();
                    GetData(_iQLChiTietSpServices.GetAllView());
                    LoadThongTinHoaDon(_hoaDon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        private void dtg_ChiTietHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_hoaDon.TrangThai == 1 || _hoaDon.TrangThai == 4 || _hoaDon.TrangThai == 5)
                {
                    _banHangServices.UpdateSoLuongChiTietHD(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()), Convert.ToInt32(dtg_ChiTietHD.CurrentRow.Cells[7].Value));
                    LoadThongTinHoaDon(_hoaDon);
                    //Sua
                    _iQLChiTietSpServices = new QLChiTietSpServices();
                    //
                    GetData(_iQLChiTietSpServices.GetAllView());
                }
                else MessageBox.Show("Hoá đơn đã thanh toán");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_ChiTietHD.CurrentRow != null)
                {
                    _banHangServices.DeleteChiTietHD(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()));
                    LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                    _iQLChiTietSpServices = new QLChiTietSpServices();
                    GetData(_iQLChiTietSpServices.GetAllView());
                    LoadThongTinHoaDon(_hoaDon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        private void btn_QR_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_QR frm_qr = new Frm_QR();
                frm_qr.frmPatents = this;
                frm_qr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        #endregion

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            try
            {
                tbx_MaNV.Text = _nhanVien.Ma;
                tbx_TenNV.Text = _nhanVien.Ten;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
