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
        private ThongKeServices _thongKeServices = new ThongKeServices();
        public Frm_ThongKe()
        {
            InitializeComponent();
            _qLHoaDonServices = new QLHoaDonServices();
            //lb_tongdonhang.Text = ;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                lb_tongdoanhthungay.Text = _thongKeServices.SumTienNgay().ToString();
                lb_tongdoanhthuthang.Text = _thongKeServices.SumTienThang().ToString();
                lb_tongdoanhthunam.Text = _thongKeServices.SumTienNam().ToString();
                lb_tongdonhang.Text = _thongKeServices.GetSoLuongHD().ToString();
                lb_thanhcong.Text = _thongKeServices.GetSoLuongHDThanhToan().ToString();
                lb_bihuy.Text = _thongKeServices.GetSoLuongHDHuy().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtn_thang_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtg_chitietdoanhthu.Rows.Clear();
                dtg_chitietdoanhthu.ColumnCount = 2;
                dtg_chitietdoanhthu.Columns[0].Name = "Tháng";
                dtg_chitietdoanhthu.Columns[1].Name = "Tổng tiền";
                foreach (var x in _thongKeServices.LoadDoanhThuThang())
                {
                    dtg_chitietdoanhthu.Rows.Add(x.Thang, x.TongTien);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rbtn_nam_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtg_chitietdoanhthu.Rows.Clear();
                dtg_chitietdoanhthu.ColumnCount = 2;
                dtg_chitietdoanhthu.Columns[0].Name = "Năm";
                dtg_chitietdoanhthu.Columns[1].Name = "Tổng tiền";
                foreach (var x in _thongKeServices.LoadDoanhThuNam())
                {
                    dtg_chitietdoanhthu.Rows.Add(x.Nam, x.TongTien);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rbtn_ngay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtg_chitietdoanhthu.Rows.Clear();
                dtg_chitietdoanhthu.ColumnCount = 2;
                dtg_chitietdoanhthu.Columns[0].Name = "Ngày";
                dtg_chitietdoanhthu.Columns[1].Name = "Tổng tiền";
                foreach (var x in _thongKeServices.LoadDoanhThuNgay())
                {
                    dtg_chitietdoanhthu.Rows.Add(x.Ngay, x.TongTien);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
    }
}
