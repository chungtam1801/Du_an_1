﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _3.PL.Views
{
    public partial class Frm_QLVaoCa : Form
    {
        public Frm_QLVaoCa()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();
            tbx_nhanvien.Enabled = false;
            tbx_giovaoca.Enabled = false;
            tbx_giovaoca.Text = Convert.ToString(DateTime.Now);
            tbx_sl500.Text = "0";
            tbx_sl200.Text = "0";
            tbx_sl100.Text = "0";
            tbx_sl50.Text = "0";
            tbx_sl20.Text = "0";
            tbx_sl10.Text = "0";
            tbx_sl5.Text = "0";
            tbx_sl2.Text = "0";
            tbx_sl1.Text = "0";
            tbx_ttien500.Text = "0";
            tbx_ttien200.Text = "0";
            tbx_ttien100.Text = "0";
            tbx_ttien50.Text = "0";
            tbx_ttien20.Text = "0";
            tbx_ttien10.Text = "0";
            tbx_ttien5.Text = "0";
            tbx_ttien2.Text = "0";
            tbx_ttien1.Text = "0";
            tbx_tongtien.Enabled = true;
        }

        private void tbx_sl500_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbx_sl500.Text))
            {
                tbx_ttien500.Text = "0";
            }
            else
            {
                int thanhtien = 500000 * Convert.ToInt32(tbx_sl500.Text);
                tbx_ttien500.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl200_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl200.Text))
            {
                tbx_ttien200.Text = "0";
            }
            else
            {
                int thanhtien = 200000 * Convert.ToInt32(tbx_sl200.Text);
                tbx_ttien200.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl100_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl100.Text))
            {
                tbx_sl100.Text = "0";
            }
            else
            {
                int thanhtien = 100000 * Convert.ToInt32(tbx_sl100.Text);
                tbx_ttien100.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl50_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl50.Text))
            {
                tbx_ttien50.Text = "0";
            }
            else
            {
                int thanhtien = 50000 * Convert.ToInt32(tbx_sl50.Text);
                tbx_ttien50.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl20_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl20.Text))
            {
                tbx_ttien20.Text = "0";
            }
            else
            {
                int thanhtien = 20000 * Convert.ToInt32(tbx_sl20.Text);
                tbx_ttien20.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl10_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl10.Text))
            {
                tbx_ttien10.Text = "0";
            }
            else
            {
                int thanhtien = 10000 * Convert.ToInt32(tbx_sl10.Text);
                tbx_ttien10.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl5.Text))
            {
                tbx_ttien5.Text = "0";
            }
            else
            {
                int thanhtien = 5000 * Convert.ToInt32(tbx_sl5.Text);
                tbx_ttien5.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl2.Text))
            {
                tbx_ttien2.Text = "0";
            }
            else
            {
                int thanhtien = 2000 * Convert.ToInt32(tbx_sl2.Text);
                tbx_ttien2.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl1_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl1.Text))
            {
                tbx_ttien1.Text = "0";
            }
            else
            {
                int thanhtien = 1000 * Convert.ToInt32(tbx_sl1.Text);
                tbx_ttien1.Text = String.Format("{0:0,00}", thanhtien);
            }
        }       
        private void tbx_sl500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl200_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            int tt500 = 500000 * Convert.ToInt32(tbx_sl500.Text == "" ? 0 : tbx_sl500.Text);
            int tt200 = 200000 * Convert.ToInt32(tbx_sl200.Text == "" ? 0 : tbx_sl200.Text);
            int tt100 = 100000 * Convert.ToInt32(tbx_sl100.Text == "" ? 0 : tbx_sl100.Text);
            int tt50 = 50000 * Convert.ToInt32(tbx_sl50.Text == "" ? 0 : tbx_sl50.Text);
            int tt20 = 20000 * Convert.ToInt32(tbx_sl20.Text == "" ? 0 : tbx_sl20.Text);
            int tt10 = 10000 * Convert.ToInt32(tbx_sl10.Text == "" ? 0 : tbx_sl10.Text);
            int tt5 = 5000 * Convert.ToInt32(tbx_sl5.Text == "" ? 0 : tbx_sl5.Text);
            int tt2 = 2000 * Convert.ToInt32(tbx_sl2.Text == "" ? 0 : tbx_sl2.Text);
            int tt1 = 1000 * Convert.ToInt32(tbx_sl1.Text == "" ? 0 : tbx_sl1.Text);
            int tongtien = tt500 + tt200 + tt100 + tt50 + tt20 + tt10 + tt5 + tt2 + tt1;
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
