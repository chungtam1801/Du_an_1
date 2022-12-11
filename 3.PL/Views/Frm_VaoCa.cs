using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _2.BUS.IServices;
using _2.BUS.Services;
using _1.DAL.DomainClass;

namespace _3.PL.Views
{
    public partial class Frm_VaoCa : Form
    {
        public Frm_Main frm_Main { get; set; }
        private IQLGiaoCaServices _iQLGiaoCaServices;
        private IQLNhanVienServices _iQLNhanVienServices;
        private DateTime _thoigian;
        public NhanVien _nhanVien { get; set; }
        public Frm_VaoCa(NhanVien nv)
        {
            InitializeComponent();
            _iQLGiaoCaServices = new QLGiaoCaServices();
            _iQLNhanVienServices = new QLNhanVienServices();
            this.TopMost = true;
            this.BringToFront();
            tbx_lydochenhlech.Enabled = false;
            lbl_nhanvien.Text = nv.Ma;
            lbl_giovaoca.Text = Convert.ToString(DateTime.Now);
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

            if (_iQLGiaoCaServices.GetAll().Count == 0)
            {
                lbl_tongtien.Text = "0";
            }
            else
            {
                List<GiaoCa> ca = _iQLGiaoCaServices.GetAll().OrderByDescending(c => c.ThoiGianKetCa).ToList();
                if (ca[0].IdNguoiGiaoCa != null)
                {
                    _thoigian = Convert.ToDateTime(ca[0].ThoiGianKetCa);
                    if (DateTime.Now.Day == _thoigian.Day)
                    {
                        string tien = string.Format("{0:0,00}", ca[0].TienCuoiCa);
                        lbl_tongtiencatruoc.Text = tien;
                        tbx_lydochenhlech.Enabled = true;
                    }
                    else
                    {
                        lbl_tongtiencatruoc.Text = "000";
                    }
                }
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (lbl_tongtien.Text == "000")
            {
                MessageBox.Show("Chưa nhập tiền vào ca");
            }
            else if (lbl_tongtiencatruoc.Text != lbl_tongtien.Text && String.IsNullOrEmpty(tbx_lydochenhlech.Text) == true && DateTime.Now.Day == _thoigian.Day)
            {
                MessageBox.Show("Có tiền chênh lệch đầu ca với tiền ca trước, nhập lý do");
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn muốn vào ca?", "", MessageBoxButtons.OKCancel))
                {
                    GiaoCa giaoca = new GiaoCa();
                    giaoca.IdNguoiNhanCa = _iQLNhanVienServices.GetAll().First(c => c.Ma == lbl_nhanvien.Text).Id;
                    giaoca.TienDauca = Convert.ToDecimal(lbl_tongtien.Text);
                    giaoca.ThoiGianVaoCa = Convert.ToDateTime(lbl_giovaoca.Text);
                    giaoca.GhiChu = tbx_lydochenhlech.Text;
                    giaoca.TrangThai = 0;
                    MessageBox.Show(_iQLGiaoCaServices.Add(giaoca), "Thông báo");
                    frm_Main.lbl_tientaiquay.Text = lbl_tongtien.Text;
                    this.Close();
                }
            }
        }

        private void tbx_sl500_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl500.Text))
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

        private void tbx_ttien500_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien200_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien100_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien50_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien20_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien10_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien5_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien2_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

        private void tbx_ttien1_TextChanged(object sender, EventArgs e)
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
            lbl_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }
    }
}
