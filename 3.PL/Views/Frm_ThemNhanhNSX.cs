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
    public partial class Frm_ThemNhanhNSX : Form
    {
        private IQLNsxServices _iqLNsxServices;
        public delegate void ADDNSX(string s);
        public ADDNSX Themnsx;
        public Frm_ThemNhanhNSX()
        {
            InitializeComponent();
            _iqLNsxServices = new QLNsxServices();
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iqLNsxServices.GetAll().Count; i++)
            {
                string ma = _iqLNsxServices.GetAll()[i].Ma;
                string so = ma.Substring(3);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "NSX00" + (max + 1);
            return s;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(tbx_ten.Text != "")
            {
                Nsx nsx = new Nsx();
                nsx.Ten = tbx_ten.Text;
                nsx.Ma = MaTuSinh();
                nsx.DiaChi = tbx_diachi.Text;
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLNsxServices.Add(nsx));
                }
            }
            else
            {
                MessageBox.Show("Tên Nhà sản xuất không được để trống");
            }
        }
        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Themnsx(tbx_ten.Text);
            this.Close();
        }

        private void Frm_ThemNhanhNSX_FormClosed(object sender, FormClosedEventArgs e)
        {
            Themnsx(tbx_ten.Text);
        }
    }
}
