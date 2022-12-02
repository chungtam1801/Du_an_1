using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class Frm_QuanLyThongTinCaNhan : Form
    {
        private NhanVien loginNhanVien;

        public NhanVien LoginNhanVien
        {
            get { return loginNhanVien; }
            set { loginNhanVien = value; ChangeAccount(loginNhanVien); }
        }
        public Frm_QuanLyThongTinCaNhan(NhanVien nv)
        {
            InitializeComponent();
        }
        void ChangeAccount(NhanVien nv)
        {
            txt_TenDangNhap.Text =LoginNhanVien.Ho+" "+LoginNhanVien.TenDem+" "+LoginNhanVien.Ten+"";
            txt_TenHienThi.Text = LoginNhanVien.Ten;
        }


    }
}
