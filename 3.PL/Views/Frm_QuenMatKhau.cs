using _1.DAL.DomainClass;
using _1.DAL.Context;
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
using System.Web;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace _3.PL.Views
{
    public partial class Frm_QuenMatKhau : Form
    {
            QLNhanVienServices nv = new QLNhanVienServices();
            private void btn_Thoat_Click(object sender, EventArgs e)
            {
                this.Close();
                //Application.Exit();
            }
            bool validateForm()
            {
                
                if (txt_SDT.Text.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống sđt. Vui lòng nhập đầy đủ!");
                    return false;
                }
                if (txt_NPass.Text.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống mật khẩu mới. Vui lòng nhập đầy đủ!");
                    return false;
                }
                return true;
            }

        private void btn_CNMK_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            if (nv.checkTT( txt_SDT.Text.Trim(), txt_NPass.Text.Trim()))
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
