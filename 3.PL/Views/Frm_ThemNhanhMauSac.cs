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
    public partial class Frm_ThemNhanhMauSac : Form
    {
        private IQLMauSacServices _iQLMauSacServices;
        public delegate void AddMauSac(string s);
        public AddMauSac Themms;
        public Frm_ThemNhanhMauSac()
        {
            InitializeComponent();
            _iQLMauSacServices = new QLMauSacServices();
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iQLMauSacServices.GetAll().Count; i++)
            {
                string ma = _iQLMauSacServices.GetAll()[i].Ma;
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
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(tbx_ten.Text != "")
            {
                MauSac mausac = new MauSac();
                mausac.Ten = tbx_ten.Text;
                mausac.Ma = MaTuSinh();
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iQLMauSacServices.Add(mausac));
                }
            }
            else MessageBox.Show("Bạn chưa nhập tên màu sắc");
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Themms(tbx_ten.Text);
            this.Close();
        }

        private void Frm_ThemNhanhMauSac_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Themms(tbx_ten.Text);
        }
    }
}
