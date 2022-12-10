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
    public partial class Frm_ThongKe : Form
    {
        private IQLHoaDonServices _qLHoaDonServices;
        public Frm_ThongKe()
        {
            InitializeComponent();
            _qLHoaDonServices = new QLHoaDonServices();
            //lb_tongdonhang.Text = ;
            lb_thanhcong.Text = _qLHoaDonServices.GetAll().Count(p => p.TrangThai == 1).ToString();
            lb_bihuy.Text = _qLHoaDonServices.GetAll().Count(p => p.TrangThai == 2).ToString();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
