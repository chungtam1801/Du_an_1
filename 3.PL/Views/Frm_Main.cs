using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace _3.PL.Views
{
    public partial class Frm_Main : Form
    {
        private Form activeForm;
        public Frm_Main()
        {
            InitializeComponent();
            pnl_Nav.Height = btn_banHang.Height;
            pnl_Nav.Top = btn_banHang.Top;
            pnl_Nav.Left = btn_banHang.Left;
            btn_banHang.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_banHang_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_banHang.Height;
            pnl_Nav.Top = btn_banHang.Top;
            pnl_Nav.Left = btn_banHang.Left;
            btn_banHang.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "BÁN HÀNG";
            OpenChildForm(new Frm_BanHang(), sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_sanpham.Height;
            pnl_Nav.Top = btn_sanpham.Top;
            pnl_Nav.Left = btn_sanpham.Left;
            btn_sanpham.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "SẢN PHẨM";
            OpenChildForm(new Frm_ChiTietSanPham(), sender);

        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_hoadon.Height;
            pnl_Nav.Top = btn_hoadon.Top;
            pnl_Nav.Left = btn_hoadon.Left;
            btn_hoadon.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "HÓA ĐƠN";

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_nhanvien.Height;
            pnl_Nav.Top = btn_nhanvien.Top;
            pnl_Nav.Left = btn_nhanvien.Left;
            btn_nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "NHÂN VIÊN";
            OpenChildForm(new Frm_NhanVien(), sender);


        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            pnl_Nav.Height = btn_khachhang.Height;
            pnl_Nav.Top = btn_khachhang.Top;
            pnl_Nav.Left = btn_khachhang.Left;
            btn_khachhang.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "KHÁCH HÀNG";
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_desktop.Controls.Add(childForm);
            this.pnl_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_banHang_Leave(object sender, EventArgs e)
        {
            btn_banHang.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_sanpham_Leave(object sender, EventArgs e)
        {
            btn_sanpham.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_hoadon_Leave(object sender, EventArgs e)
        {
            btn_hoadon.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_nhanvien_Leave(object sender, EventArgs e)
        {
            btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_khachhang_Leave(object sender, EventArgs e)
        {
            btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
