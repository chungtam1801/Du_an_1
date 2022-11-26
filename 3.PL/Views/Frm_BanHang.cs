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

namespace _3.PL.Views
{
    public partial class Frm_BanHang : Form
    {
        private IQLHoaDonServices _iQLHoaDonServices;
        private IQLChiTietSpServices _iQLChiTietSpServices;
        private IQLNhanVienServices _iQLNhanVienServices;
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private HoaDon _hoaDon;
        public Frm_BanHang()
        {
            InitializeComponent();
            _iQLChiTietSpServices = new QLChiTietSpServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLNhanVienServices = new QLNhanVienServices();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
            GetData(_iQLChiTietSpServices.GetAllView());
            Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();
            frm.FrmParent = this;
            OpenChildFrm(frm);
        }
        //Day anh len frm ban hang
        private void GetData(List<ViewQLChiTietSp> lstview)
        {
            flp_SanPham.Controls.Clear();
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
            if(_hoaDon==null)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.Ma = ClassSP.AutoID("HD", _iQLHoaDonServices.GetAll().Count);
                hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
                hoaDon.NgayTao = DateTime.Now;
                _iQLHoaDonServices.Add(hoaDon);
                //Sua
                Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();
                frm.HD = hoaDon;
                frm.FrmParent = this;
                OpenChildFrm(frm);
                //Sua
                _hoaDon = hoaDon;
                LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
            }
            ChiTietSp temp = _iQLChiTietSpServices.GetAll().First(c => c.Id == new Guid(obj.Id));
            if(temp.SoLuongTon>0)
            {
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
                temp.SoLuongTon--;
                _iQLChiTietSpServices.Update(temp);
                obj.lbl_SoLuong.Text = temp.SoLuongTon.ToString();
            } 
            else
            {
                MessageBox.Show("Sản phẩm hết hàng");
            }
            Frm_BanHangTaiQuay form = new Frm_BanHangTaiQuay();
            form.HD = _hoaDon;
            form.FrmParent = this;
            OpenChildFrm(form);
            LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        }
        private void LoadDTG_ChiTietHD(List<ViewQLChiTietHoaDon> lstView)
        {
            dtg_ChiTietHD.Rows.Clear();
            dtg_ChiTietHD.ColumnCount = 9;
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
            foreach (ViewQLChiTietHoaDon x in lstView)
            {
                dtg_ChiTietHD.Rows.Add(x.Ma, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.SoLuong, x.Id);
            }
        }
        public void LoadDTG_HoaDon(List<HoaDon> lstHD)
        {
            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.ColumnCount = 4;
            dtg_HoaDon.Columns[0].Name = "Ma";
            dtg_HoaDon.Columns[1].Name = "Nhan vien";
            dtg_HoaDon.Columns[2].Name = "Ngay Tao";
            dtg_HoaDon.Columns[3].Name = "Ngay Thanh Toan";
            foreach (HoaDon hoaDon in lstHD)
            {
                dtg_HoaDon.Rows.Add(hoaDon.Ma, _iQLNhanVienServices.GetAll().First(c => c.Id == hoaDon.IdNv).Ten, hoaDon.NgayTao, hoaDon.NgayThanhToan);
            }
        }

        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _hoaDon = _iQLHoaDonServices.GetAll().First(c => c.Ma == dtg_HoaDon.CurrentRow.Cells[0].Value.ToString());
            Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();
            frm.HD = _hoaDon;
            frm.FrmParent = this;
            OpenChildFrm(frm);
            LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
        }      
        //Sua
        private HoaDon CreateHD()
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
            hoaDon.IdNv = new Guid("35341215-8D86-4220-93D2-719BA3EF0616");
            hoaDon.Ma = ClassSP.AutoID("HD", _iQLHoaDonServices.GetAll().Count);
            hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
            hoaDon.NgayTao = DateTime.Now;
            _iQLHoaDonServices.Add(hoaDon);
            Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();           
            frm.HD = hoaDon;
            frm.FrmParent = this;
            OpenChildFrm(frm);
            return hoaDon;
        }
        private void OpenChildFrm(Form frm)
        {
            tsc_HoaDon.ContentPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tsc_HoaDon.ContentPanel.Controls.Add(frm);
            frm.Show();
        }
        private void tsb_BanHang_Click(object sender, EventArgs e)
        {
            Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();
            OpenChildFrm(frm);
        }
        private void tsb_DatHang_Click(object sender, EventArgs e)
        {
            Frm_DatHang frm = new Frm_DatHang();
            OpenChildFrm(frm);
        }

        private void dtg_ChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dtg_ChiTietHD.CurrentRow.Cells[8].Value != null)
            //{
            //    ChiTietHoaDon chiTietHoaDon = _iQLChiTietHoaDonServices.GetByID(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()));
            //    ChiTietSp chiTietSp = _iQLChiTietSpServices.GetAll().First(p => p.Id == chiTietHoaDon.IdCtsp);
            //    if (Convert.ToInt32(dtg_ChiTietHD.CurrentRow.Cells[7].Value) > 1)
            //    {
            //        chiTietHoaDon.SoLuong--;
            //    }
            //    else
            //    {
            //        _iQLChiTietHoaDonServices.Delete(chiTietHoaDon);
            //    }
            //    chiTietSp.SoLuongTon++;
            //    LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
            //    GetData(_iQLChiTietSpServices.GetAllView());
            //}          
        }
        //Sua
        private void dtg_ChiTietHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if (dtg_ChiTietHD.CurrentRow.Cells[8].Value != null)
                {
                    ChiTietHoaDon chiTietHoaDon = _iQLChiTietHoaDonServices.GetByID(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()));
                    ChiTietSp chiTietSp = _iQLChiTietSpServices.GetAll().First(p => p.Id == chiTietHoaDon.IdCtsp);
                    if (Convert.ToInt32(dtg_ChiTietHD.CurrentRow.Cells[7].Value) > 1)
                    {
                        chiTietHoaDon.SoLuong--;
                    }
                    else
                    {
                        _iQLChiTietHoaDonServices.Delete(chiTietHoaDon);
                    }
                    chiTietSp.SoLuongTon++;
                    LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
                    GetData(_iQLChiTietSpServices.GetAllView());
                }
            }
            else if(e.Button==MouseButtons.Right)
            {
                if (dtg_ChiTietHD.CurrentRow.Cells[8].Value != null)
                {
                    ChiTietHoaDon chiTietHoaDon = _iQLChiTietHoaDonServices.GetByID(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()));
                    ChiTietSp chiTietSp = _iQLChiTietSpServices.GetAll().First(p => p.Id == chiTietHoaDon.IdCtsp);
                    chiTietSp.SoLuongTon+=chiTietHoaDon.SoLuong;
                    _iQLChiTietHoaDonServices.Delete(chiTietHoaDon);                 
                    LoadDTG_ChiTietHD(_iQLChiTietHoaDonServices.GetAllView(_hoaDon.Id));
                    GetData(_iQLChiTietSpServices.GetAllView());
                }
            }
        }
        //private void btn_TaoHD_Click(object sender, EventArgs e)
        //{
        //    _hoaDon = CreateHD();
        //    LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        //}

        //private void btn_ThanhToan_Click(object sender, EventArgs e)
        //{
        //    if (_hoaDon == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn hóa đơn");
        //    }
        //    else if(_hoaDon.NgayThanhToan != null)
        //    {
        //        MessageBox.Show("Hóa đơn đã được thanh toán");
        //    }
        //    else if(dtg_ChiTietHD.RowCount<=1)
        //    {
        //        MessageBox.Show("Vui lòng chọn sản phẩm");
        //    }
        //    else
        //    {
        //        _hoaDon.NgayThanhToan = DateTime.Now;
        //        MessageBox.Show(_iQLHoaDonServices.Update(_hoaDon));
        //        LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        //    }    
        //} 
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
