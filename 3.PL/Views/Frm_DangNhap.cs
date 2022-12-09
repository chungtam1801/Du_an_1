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
            tb_taikhoan.Text = "NV001";
            tb_matkhau.Text = "123456";
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
                NhanVien nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.Ma == tb_taikhoan.Text && c.MatKhau == tb_matkhau.Text);
                if (nv != null)
                {
                    this.Hide();
                    Frm_Main main = new Frm_Main();
                    main.nv = nv;
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                }
                //else
                //{
                //    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                //}
            }

            this.tb_taikhoan.Focus();
        }

        private void bt_dangnhap_Click_1(object sender, EventArgs e)
        {
            if (tb_taikhoan.Text == "" || tb_matkhau.Text == "")
            {
                MessageBox.Show("Các trường không được để trống");
            }
            else
            {
                    NhanVien nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.Ma == tb_taikhoan.Text && c.MatKhau == tb_matkhau.Text);
                    if (nv != null)
                    {
                        this.Hide();
                        Frm_Main main = new Frm_Main();
                        main.nv = nv;
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }

                this.tb_taikhoan.Focus();

            }

            private void lb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Frm_QuenMatKhau qmk = new Frm_QuenMatKhau();
                qmk.ShowDialog();
            }

            private void Frm_DangNhap_Load(object sender, EventArgs e)
            {

            }
        }
    }
