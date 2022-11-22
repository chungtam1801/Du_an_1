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
    public partial class Frm_ThemNhanhKichThuoc : Form
    {
        private IQLKichThuocServices _iQLKichThuocServices;
        public Frm_ThemNhanhKichThuoc()
        {
            InitializeComponent();
            _iQLKichThuocServices = new QLKichThuocServices();
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iQLKichThuocServices.GetAll().Count; i++)
            {
                string ma = _iQLKichThuocServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "KT00" + (max + 1);
            return s;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            KichThuoc kichThuoc = new KichThuoc();
            kichThuoc.Size = tbx_ten.Text;
            kichThuoc.Ma = MaTuSinh();
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_iQLKichThuocServices.Add(kichThuoc));
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
