using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
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
    public partial class Frm_ThemNhanhSP : Form
    {
        private IQLSanPhamServices _iqLSanPhamServices;
        public delegate void ADDSP(string sp);
        public ADDSP Themsp;
        public Frm_ThemNhanhSP()
        {
            InitializeComponent();
            _iqLSanPhamServices = new QLSanPhamServices();

        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for(int i = 0; i < _iqLSanPhamServices.GetAll().Count; i++)
            {
                string ma = _iqLSanPhamServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "SP00" + (max + 1);
            return s;
        }
        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                SanPham sanPham = new SanPham();
                sanPham.Ten = tbx_tensp.Text;
                sanPham.Ma = MaTuSinh();
                MessageBox.Show(_iqLSanPhamServices.Add(sanPham));
            }
        }
        private void btn_boqua_Click_1(object sender, EventArgs e)
        {
            Themsp(tbx_tensp.Text);
            this.Close();
        }
    }
}
