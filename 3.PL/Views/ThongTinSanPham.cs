using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class ThongTinSanPham : UserControl
    {
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        public ViewQLChiTietSp chiTietSP { get; set; }
        public ThongTinSanPham(ViewQLChiTietSp sp)
        {
            InitializeComponent();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            MemoryStream ms = new MemoryStream(sp.Anh);
            Bitmap bitmap = new Bitmap(ms);
            ptb_Anh.BackgroundImage = bitmap;
            lbl_Ten.Text = sp.Ten;
            lbl_SoLuong.Text = sp.SoLuongTon.ToString();
            lbl_GiaTien.Text = sp.GiaBan.ToString();
            ChiTietSanPham("Màu sắc: " + sp.MauSac + "\nKích thước: " + sp.KichThuoc);
            chiTietSP = sp;

        }
        private void ChiTietSanPham(string x)
        {
            tlt_ChiTiet.SetToolTip(this, x);
            tlt_ChiTiet.SetToolTip(ptb_Anh, x);
        }
        //public Image Anh 
        //{ 
        //    get => _anh;
        //    set { _anh = value; ptb_Anh.BackgroundImage = value; }
        //}
        //public string Ten 
        //{ 
        //    get => _ten;
        //    set { _ten = value; lbl_Ten.Text = value; }
        //}
        //public string GiaTien 
        //{ 
        //    get => _giaTien;
        //    set { _giaTien = value; lbl_GiaTien.Text = value; }
        //}
        //public string SoLuong 
        //{ 
        //    get => _soLuong;
        //    set { _soLuong = value; lbl_SoLuong.Text = value; }
        //}
        private void ThongTinSanPham_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }
        private void ThongTinSanPham_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ptb_Anh_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void ptb_Anh_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
