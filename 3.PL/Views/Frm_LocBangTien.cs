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
    public partial class Frm_LocBangTien : Form
    {
        public Frm_BanHang frmParent { get; set; }
        public Frm_LocBangTien()
        {
            InitializeComponent();
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
            frmParent.LocBangTien(Convert.ToDecimal(tbx_Min.Text),Convert.ToDecimal(tbx_Max.Text));
        }
    }
}
