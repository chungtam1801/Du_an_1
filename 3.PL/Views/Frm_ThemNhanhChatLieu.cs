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
    public partial class Frm_ThemNhanhChatLieu : Form
    {
        private IQLChatLieuServices _iQLChatLieuServices;
        public delegate void AddChatLieu(string s);
        public AddChatLieu ThemChatLieu;
        public Frm_ThemNhanhChatLieu()
        {
            InitializeComponent();
            _iQLChatLieuServices = new QLChatLieuServices();
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iQLChatLieuServices.GetAll().Count; i++)
            {
                string ma = _iQLChatLieuServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "CL00" + (max + 1);
            return s;
        }
        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            try
            { 
            if(tbx_ten.Text != "")
            {
                ChatLieu cl = new ChatLieu();
                cl.Ten = tbx_ten.Text;
                cl.Ma = MaTuSinh();
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iQLChatLieuServices.Add(cl));
                }
            }else
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_boqua_Click_1(object sender, EventArgs e)
        {
            try
            {
            ThemChatLieu(tbx_ten.Text);
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_ThemNhanhChatLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemChatLieu(tbx_ten.Text);
        }
    }
}
