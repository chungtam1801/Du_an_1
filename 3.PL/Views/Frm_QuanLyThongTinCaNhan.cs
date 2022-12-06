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
        QLNhanVienServices nv = new QLNhanVienServices();
        
        public Frm_QuanLyThongTinCaNhan() //NhanVien nv
        {
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        

        private void chb_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_HienThiMatKhau.Checked)
            {
               txt_MatKhau.PasswordChar = (char)0;
                txt_MatKhauMoi.PasswordChar = (char)0;
                txt_NhapLai.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
                txt_MatKhauMoi.PasswordChar = '*';
                txt_NhapLai.PasswordChar = '*';
            }
        }
        public bool KiemTra()
        {
            if (txt_TenDangNhap.Text == "")
            {
                
                MessageBox.Show ("Vui lòng nhập tên đăng nhập tài khoản !!");
                txt_TenDangNhap.Focus();
                return false;
            }
            else if (txt_Ten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !!");
               
                txt_Ten.Focus();
                return false;
            }
            else if (txt_SDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT !!");
                
                txt_SDT.Focus();
                return false;
            }
            else if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại !!");
                
                txt_MatKhau.Focus();
                return false;
            }
            else if (txt_MatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới !!");
                
                txt_MatKhauMoi.Focus();
                return false;
            }
            else if (txt_NhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu !!");
                
                txt_NhapLai.Focus();
                return false;
            }
            else if (txt_MatKhauMoi.Text != txt_NhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp !!");
                
                txt_NhapLai.Focus();
                txt_NhapLai.SelectAll();
                return false;
            }
            return true;
        }


        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            if (!KiemTra()) return;
            if (nv.checkTT(txt_SDT.Text.Trim(), txt_MatKhauMoi.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu đã được cập nhật.");
            }
            else
            {
                MessageBox.Show(string.Format(" Sdt bạn nhập không chính xác. Vui long kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
            }
        }
        
    }
}
