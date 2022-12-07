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
    public partial class Frm_ThemNhanhChucVu : Form
    {
        private IQLChucVuServices _iqLChucVuServices ;
        public delegate void AddChucVu(string s);
        public AddChucVu ThemChucVu;
        public Frm_ThemNhanhChucVu()
        {
            InitializeComponent();
            _iqLChucVuServices = new QLChucVuServices();
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iqLChucVuServices.GetAll().Count; i++)
            {
                string ma = _iqLChucVuServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "CV00" + (max + 1);
            return s;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (tbx_ten.Text != "")
            {
                ChucVu cl = new ChucVu();
                cl.Ten = tbx_ten.Text;
                cl.Ma = MaTuSinh();
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLChucVuServices.Add(cl));
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên chuc vu");
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ThemChucVu(tbx_ten.Text);
            this.Close();
        }

        private void Frm_ThemNhanhChucVu_Load(object sender, EventArgs e)
        {

        }

        private void Frm_ThemNhanhChucVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemChucVu(tbx_ten.Text);
        }
    }
}
