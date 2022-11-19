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
        
        public Frm_DangNhap()
        {
            InitializeComponent();
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
                if (this.tb_taikhoan.Text == "abc")
                    if (this.tb_matkhau.Text == "123456")
                    {
                        this.Hide();
                        Frm_DangNhap dn = new Frm_DangNhap();
                        dn.ShowDialog();
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

        private void lb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            
        }
    }
}
