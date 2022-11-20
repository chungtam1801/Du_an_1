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
using System.Drawing;

namespace _3.PL.Views
{
    public partial class Frm_BanHang : Form
    {
        private IQLHoaDonServices _iQLHoaDonServices;
        private IQLChiTietSpServices _iQLChiTietSpServices;
        private IQLNhanVienServices _iQLNhanVienServices;
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private HoaDon _hoaDon = new HoaDon();
        public Frm_BanHang()
        {
            InitializeComponent();
            _iQLChiTietSpServices = new QLChiTietSpServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLNhanVienServices = new QLNhanVienServices();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
            GetData(_iQLChiTietSpServices.GetAllView());
            //LoadDTG_SanPham(_iQLChiTietSpServices.GetAllView());
        }
        private void GetData(List<ViewQLChiTietSp> lstview)
        {
            ThongTinSanPham thongTinSanPham;
            foreach (var x in lstview)
            {
                thongTinSanPham = new ThongTinSanPham();
                MemoryStream ms = new MemoryStream(x.Anh);
                Bitmap bitmap = new Bitmap(ms);
                thongTinSanPham.Anh = bitmap;
                thongTinSanPham.Ten = x.Ten;
                thongTinSanPham.SoLuong = x.SoLuongTon.ToString();
                thongTinSanPham.GiaTien = x.GiaBan.ToString();
                thongTinSanPham.Id = x.Id.ToString();
                thongTinSanPham.Click += new System.EventHandler(UserContrel_Click);
                flp_SanPham.Controls.Add(thongTinSanPham);           
            }
        }
        private void UserContrel_Click(object sender, EventArgs e)
        {
            ThongTinSanPham obj = (ThongTinSanPham)sender;
            ChiTietSp temp = _iQLChiTietSpServices.GetAll().First(c => c.Id == new Guid(obj.Id));
            if (_iQLChiTietHoaDonServices.GetAll().Where(c => c.IdCtsp == temp.Id && c.IdHd == _hoaDon.Id).ToList().Count == 0)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.IdCtsp = temp.Id;
                chiTietHoaDon.IdHd = _hoaDon.Id;
                chiTietHoaDon.DonGia = temp.GiaBan;
                chiTietHoaDon.SoLuong = 1;
                _iQLChiTietHoaDonServices.Add(chiTietHoaDon);
            }
            else
            {
                ChiTietHoaDon chiTietHoaDon = _iQLChiTietHoaDonServices.GetAll().First(c => c.IdCtsp == temp.Id && c.IdHd == _hoaDon.Id);
                chiTietHoaDon.SoLuong++;
                _iQLChiTietHoaDonServices.Update(chiTietHoaDon);
            }
            tbx_TongTien.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == _hoaDon.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
            LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        }
        private void LoadDTG_ChiTietHD(List<ViewQLChiTietHoaDon> lstView)
        {
            dtg_ChiTietHD.Rows.Clear();
            dtg_ChiTietHD.ColumnCount = 8;
            dtg_ChiTietHD.Columns[0].Name = "Ma";
            dtg_ChiTietHD.Columns[1].Name = "Ten";
            dtg_ChiTietHD.Columns[2].Name = "Nsx";
            dtg_ChiTietHD.Columns[3].Name = "Mau Sac";
            dtg_ChiTietHD.Columns[4].Name = "LoaiSp";
            dtg_ChiTietHD.Columns[5].Name = "Kich Thuoc";
            dtg_ChiTietHD.Columns[6].Name = "Chat Lieu";
            dtg_ChiTietHD.Columns[7].Name = "So Luong";
            foreach (ViewQLChiTietHoaDon x in lstView)
            {
                dtg_ChiTietHD.Rows.Add(x.Ma, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.SoLuong);
            }
        }
        private void LoadDTG_HoaDon(List<HoaDon> lstHD)
        {
            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.ColumnCount = 4;
            dtg_HoaDon.Columns[0].Name = "Ma";
            dtg_HoaDon.Columns[1].Name = "Nhan vien";
            dtg_HoaDon.Columns[2].Name = "Ngay Tao";
            dtg_HoaDon.Columns[3].Name = "Ngay Thanh Toan";
            foreach (HoaDon hoaDon in lstHD)
            {
                dtg_HoaDon.Rows.Add(hoaDon.Ma, _iQLNhanVienServices.GetAll().First(c => c.Id == hoaDon.IdNv).Ten, hoaDon.NgayTao, hoaDon.TrangThai == 1 ? hoaDon.NgayThanhToan : "");
            }
        }

        private void dtg_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _hoaDon = _iQLHoaDonServices.GetAll().First(c => c.Ma == dtg_HoaDon.CurrentRow.Cells[0].Value.ToString());
            tbx_MaHD.Text = _hoaDon.Ma;
            tbx_NgayTao.Text = _hoaDon.NgayTao.ToString();
            if (_hoaDon.TrangThai == 1)
            {
                tbx_NgayThanhToan.Text = _hoaDon.NgayThanhToan.ToString();
            }
            else
            {
                tbx_NgayThanhToan.Text = "";
            }
            tbx_TongTien.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == _hoaDon.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
            LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            if (_iQLHoaDonServices.GetAll().Count == 0)
            {
                hoaDon.Ma = "HD1";
            }
            else
            {
                hoaDon.Ma = "HD" + (_iQLHoaDonServices.GetAll().Count + 1);
            }
            hoaDon.IdNv =
            hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
            hoaDon.NgayTao = DateTime.Now;
            tbx_MaHD.Text = hoaDon.Ma;
            tbx_NgayTao.Text = hoaDon.NgayTao.ToString();
            _iQLHoaDonServices.Add(hoaDon);
            _hoaDon = hoaDon;
            LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            _hoaDon.NgayThanhToan = DateTime.Now;
            _iQLHoaDonServices.Update(_hoaDon);
            LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        }

        private void tbx_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            tbx_TienTraKhach.Text = (Convert.ToInt32(tbx_TienKhachDua.Text) - Convert.ToInt32(tbx_TongTien.Text)).ToString();
        }
        //private void LoadDTG_SanPham(List<ViewQLChiTietSp> lstSP)
        //{
        //    dtg_SanPham.Rows.Clear();
        //    dtg_SanPham.ColumnCount = 11;
        //    dtg_SanPham.Columns[0].Name = "Ma";
        //    dtg_SanPham.Columns[1].Name = "Ten";
        //    dtg_SanPham.Columns[2].Name = "Nsx";
        //    dtg_SanPham.Columns[3].Name = "Mau Sac";
        //    dtg_SanPham.Columns[4].Name = "LoaiSP";
        //    dtg_SanPham.Columns[5].Name = "Kich Thuoc";
        //    dtg_SanPham.Columns[6].Name = "Chat Lieu";
        //    dtg_SanPham.Columns[7].Name = "Mo Ta";
        //    dtg_SanPham.Columns[8].Name = "So Luong Ton";
        //    dtg_SanPham.Columns[9].Name = "Gia";
        //    dtg_SanPham.Columns[10].Name = "Id";
        //    dtg_SanPham.Columns[10].Visible = false;
        //    foreach (ViewQLChiTietSp sp in lstSP)
        //    {
        //        dtg_SanPham.Rows.Add(sp.Ma, sp.Ten, sp.Nsx, sp.MauSac, sp.LoaiSp, sp.KichThuoc, sp.ChatLieu, sp.MoTa, sp.SoLuongTon, sp.Gia, sp.Id);
        //    }
        //}

        //private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    _hoaDon = _iQLHoaDonServices.GetAll().First(c => c.Ma == dtg_HoaDon.CurrentRow.Cells[0].Value.ToString());
        //    tbx_MaHD.Text = _hoaDon.Ma;
        //    tbx_NgayTao.Text = _hoaDon.NgayTao.ToString();
        //    if (_hoaDon.TrangThai == 1)
        //    {
        //        tbx_NgayThanhToan.Text = _hoaDon.NgayThanhToan.ToString();
        //    }
        //    else
        //    {
        //        tbx_NgayThanhToan.Text = "";
        //    }
        //    tbx_TongTien.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == _hoaDon.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
        //    LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        //}

        //private void dtg_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ChiTietSp temp = _iQLChiTietSpServices.GetAll().First(c => c.Id == new Guid(dtg_SanPham.CurrentRow.Cells[10].Value.ToString()));
        //    if (_iQLChiTietHoaDonServices.GetAll().Where(c => c.IdCtsp == temp.Id && c.IdHd == _hoaDon.Id).ToList().Count == 0)
        //    {
        //        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
        //        chiTietHoaDon.IdCtsp = temp.Id;
        //        chiTietHoaDon.IdHd = _hoaDon.Id;
        //        chiTietHoaDon.DonGia = temp.GiaBan;
        //        chiTietHoaDon.SoLuong = 1;
        //        _iQLChiTietHoaDonServices.Add(chiTietHoaDon);
        //    }
        //    else
        //    {
        //        ChiTietHoaDon chiTietHoaDon = _iQLChiTietHoaDonServices.GetAll().First(c => c.IdCtsp == temp.Id && c.IdHd == _hoaDon.Id);
        //        chiTietHoaDon.SoLuong++;
        //        _iQLChiTietHoaDonServices.Update(chiTietHoaDon);
        //    }
        //    tbx_tongtienhang.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == _hoaDon.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
        //    LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        //}

        //private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        //{
        //    HoaDon hoaDon = new HoaDon();
        //    if (_iQLHoaDonServices.GetAll().Count == 0)
        //    {
        //        hoaDon.Ma = "HD1";
        //    }
        //    else
        //    {
        //        hoaDon.Ma = "HD" + (_iQLHoaDonServices.GetAll().Count + 1);
        //    }
        //    hoaDon.IdNv =
        //    hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
        //    hoaDon.NgayTao = DateTime.Now;
        //    hoaDon.NgayThanhToan = DateTime.Now;
        //    hoaDon.TrangThai = 0;
        //    tbx_mahoadon.Text = hoaDon.Ma;
        //    tbx_datetimehtai.Text = hoaDon.NgayTao.ToString();
        //    tbx_tongtienhang.Text = "0";
        //    _iQLHoaDonServices.Add(hoaDon);
        //    _hoaDon = hoaDon;
        //    LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        //}

        //private void btn_ThanhToan_Click(object sender, EventArgs e)
        //{
        //    _hoaDon.NgayThanhToan = DateTime.Now;
        //    _hoaDon.TrangThai = 1;
        //    _iQLHoaDonServices.Update(_hoaDon);
        //    LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        //}

        //private void tbx_TienKhachDua_TextChanged(object sender, EventArgs e)
        //{
        //    tbx_TienThoi.Text = (Convert.ToInt32(tbx_TienKhachDua.Text) - Convert.ToInt32(tbx_TongTien.Text)).ToString();
        //}
    }
}
