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
    public partial class Frm_ThemNhanhLoaiSP : Form
    {
        private IQLLoaiSpServices _iqLLoaiSpServices;
        public delegate void ADDLoaiSP(string s);
        public ADDLoaiSP Themlsp;
        public Frm_ThemNhanhLoaiSP()
        {
            InitializeComponent();
            _iqLLoaiSpServices = new QLLoaiSpServices();
            LoadLSPCha();
        }
        private void LoadLSPCha()
        {
            foreach(var x in _iqLLoaiSpServices.GetAll().Where(c=> c.MaLoaiSpcha == null).ToList())
            {
                cmb_lspcha.Items.Add(x.Ten);
            }
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iqLLoaiSpServices.GetAll().Count; i++)
            {
                string ma = _iqLLoaiSpServices.GetAll()[i].Ma;
                string so = ma.Substring(3);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "LSP00" + (max + 1);
            return s;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            LoaiSp lsp = new LoaiSp();
            lsp.Ten = tbx_ten.Text;
            lsp.Ma = MaTuSinh();
            if(cmb_lspcha.Text == "")
            {
                lsp.MaLoaiSpcha = null;
            }
            else
            {
                lsp.MaLoaiSpcha = _iqLLoaiSpServices.GetAll().First(c => c.Ten == cmb_lspcha.Text).Id;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                    MessageBox.Show(_iqLLoaiSpServices.Add(lsp));
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            cmb_lspcha.SelectedIndex = 0;
            Themlsp(tbx_ten.Text);
            this.Close();
        }
    }
}
