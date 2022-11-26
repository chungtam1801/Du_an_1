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
    public partial class Frm_DangNhap : Form
    {
        private IQLNhanVienServices _inhanVienServices;
        public Frm_DangNhap()
        {
            InitializeComponent();
            _inhanVienServices = new QLNhanVienServices();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.tb_taikhoan.Text == "" || this.tb_matkhau.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập tài khoản ! ");
            }
            else
            {
                NhanVien nv = new NhanVien();
                if (this.tb_taikhoan.Text == nv.Ma)
                    if (this.tb_matkhau.Text == nv.MatKhau)
                    {
                        this.Hide();
                        Frm_Main main = new Frm_Main();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                    }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                }
            }

            this.tb_taikhoan.Focus();
        }

        private void bt_dangnhap_Click_1(object sender, EventArgs e)
        {
            if (this.tb_taikhoan.Text == "" || this.tb_matkhau.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập tài khoản ! ");
            }
            else
            {
                NhanVien nv = new NhanVien();
                if (this.tb_taikhoan.Text == nv.Ma)
                    if (this.tb_matkhau.Text == nv.MatKhau)
                    {
                        this.Hide();
                        Frm_Main main = new Frm_Main();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                    }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                }
            }

            this.tb_taikhoan.Focus();
        }
    }
}
