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

namespace _3.PL.Views
{
    public partial class ThongTinSanPham : UserControl
    {
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private Image _anh;
        private string _ten;
        private string _giaTien;
        private string _soLuong;
        private string id;
        public ThongTinSanPham()
        {
            InitializeComponent();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
        }

        public Image Anh 
        { 
            get => _anh;
            set { _anh = value; ptb_Anh.BackgroundImage = value; }
        }
        public string Ten 
        { 
            get => _ten;
            set { _ten = value; lbl_Ten.Text = value; }
        }
        public string GiaTien 
        { 
            get => _giaTien;
            set { _giaTien = value; lbl_GiaTien.Text = value; }
        }
        public string SoLuong 
        { 
            get => _soLuong;
            set { _soLuong = value; lbl_SoLuong.Text = value; }
        }
        public string Id { get => id; set => id = value; }
        private void ThongTinSanPham_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void ThongTinSanPham_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
