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
        //private NhanVien loginAccount;
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
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên đăng nhập tài khoản !!";
                txt_TenDangNhap.Focus();
                return false;
            }
            else if (txt_Ten.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên tài khoản !!";
                txt_Ten.Focus();
                return false;
            }
            else if (txt_SDT.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập SĐT !!";
                txt_SDT.Focus();
                return false;
            }
            else if (txt_MatKhau.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txt_MatKhau.Focus();
                return false;
            }
            else if (txt_MatKhauMoi.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txt_MatKhauMoi.Focus();
                return false;
            }
            else if (txt_NhapLai.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txt_NhapLai.Focus();
                return false;
            }
            else if (txt_MatKhauMoi.Text != txt_NhapLai.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txt_NhapLai.Focus();
                txt_NhapLai.SelectAll();
                return false;
            }
            return true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            if (KiemTra())
            {
                try
                {
                    NhanVien nv = new NhanVien();
                    //SqlConnection conn = new SqlConnection();
                    //conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "SP_Update_Pass";
                    //cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txt_TenDangNhap.Text;
                    //cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txt_MatKhau.Text;
                    //cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txt_MatKhauMoi.Text;
                    //cmd.Connection = conn;
                    //conn.Open();
                    //SqlDataReader dr;
                    //dr = cmd.ExecuteReader();
                    //dr.Read();
                    if (nv.MatKhau == "") //dr.GetInt32(0)== 1
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                        lblShowInfor.Text = nv.MatKhau;    // dr.GetString(1);
                        txt_NhapLai.Text = "";
                        txt_MatKhau.Text = "";
                        txt_MatKhauMoi.Text = "";
                        txt_MatKhau.Focus();
                    }
                    else
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = nv.MatKhau;         //dr.GetString(1);
                        txt_MatKhau.Focus();
                        txt_MatKhau.SelectAll();
                    }
                    //dr.Close();
                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
