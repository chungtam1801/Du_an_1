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
    public partial class Frm_QLGiaoCa : Form
    {
        private IQLGiaoCaServices _iqLGiaoCaServices;
        private IQLNhanVienServices _iqNhanVienServices;
        private Guid _id;
        public Frm_QLGiaoCa()
        {
            InitializeComponent();
            _iqLGiaoCaServices = new QLGiaoCaServices();
            _iqNhanVienServices = new QLNhanVienServices();
            LoadData();
            LoadTrangThai();
        }
        private void LoadTrangThai()
        {
            cmb_trangthai.Items.Clear();
            cmb_trangthai.Items.Add("Chờ xác nhận");
            cmb_trangthai.Items.Add("Đã xác nhận");
            cmb_trangthai.Items.Add("Không xác nhận");
            cmb_trangthai.SelectedIndex = -1;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrd_dsca.Rows.Clear();
            dgrd_dsca.ColumnCount = 8;
            dgrd_dsca.Columns[0].Name = "STT";
            dgrd_dsca.Columns[0].Width = 50;
            dgrd_dsca.Columns[1].Name = "ID";
            dgrd_dsca.Columns[1].Visible = false;
            dgrd_dsca.Columns[2].Name = "Thời gian vào";
            dgrd_dsca.Columns[3].Name = "Người trực ca";
            dgrd_dsca.Columns[4].Name = "Người giao ca";
            dgrd_dsca.Columns[5].Name = "Doanh thu";
            dgrd_dsca.Columns[6].Name = "Ghi chú";
            dgrd_dsca.Columns[7].Name = "Trạng thái";
            foreach(var x in _iqLGiaoCaServices.GetAll())
            {
                string ten =_iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ten;
                string ho = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ho;
                string dem =_iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).TenDem;
                string ten1 = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiGiaoCa).Ten;
                string ho1 = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiGiaoCa).Ho;
                string dem1 = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiGiaoCa).TenDem;
                dgrd_dsca.Rows.Add(stt++, x.Id, x.ThoiGianVaoCa, ho + " " + dem + " " + ten, ho1 + " " + dem1 + " " + ten1,x.Tongtienhang, x.GhiChu, x.TrangThai == 0 ? "Chờ xác nhận" : (x.TrangThai == 1 ? "Đã xác nhận":"Không được xác nhận"));
            }
        }

        private void dgrd_dsca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0 || rowIndex < _iqLGiaoCaServices.GetAll().Count)
            {
                GiaoCa ca = _iqLGiaoCaServices.GetAll().First(c=> c.Id == Guid.Parse(dgrd_dsca.Rows[rowIndex].Cells[1].Value.ToString()));
                _id = ca.Id;
                tbx_giovao.Text = ca.ThoiGianVaoCa.ToString();
                tbx_gioket.Text = ca.ThoiGianKetCa.ToString();
                tbx_nvtruc.Text = dgrd_dsca.Rows[rowIndex].Cells[3].Value.ToString();
                tbx_nvgiaoca.Text = dgrd_dsca.Rows[rowIndex].Cells[4].Value.ToString();
                tbx_tiendauca.Text = ca.TienDauca.ToString();
                tbx_tienmat.Text = string.Format("{0:0,00}",ca.TienMat);
                tbx_tiennganhang.Text = string.Format("{0:0,00}",ca.NganHang);
                tbx_tiensddiem.Text = string.Format("{0:0,00}",ca.TienSDDiem);
                tbx_doanhthu.Text = string.Format("{0:0,00}",ca.Tongtienhang);
                tbx_tongtienmat.Text = string.Format("{0:0,00}",ca.TongTienMat);
                tbx_tientaiquay.Text = string.Format("{0:0,00}",ca.TienCuoiCa);
                tbx_tienphatsinh.Text = String.Format("{0:0,00}",(ca.TienCuoiCa - ca.TongTienMat));
                tbx_lydophatsinh.Text = ca.GhiChu.ToString();
                if(ca.TrangThai == 0)
                {
                    cmb_trangthai.Text = "Chờ xác nhận";
                }else if(ca.TrangThai == 1)
                {
                    cmb_trangthai.Text = "Đã xác nhận";
                }
                else
                {
                    cmb_trangthai.Text = "Không được xác nhận";
                }
            }
            else
            {
                MessageBox.Show("Ngoài vùng dữ liệu");
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            GiaoCa giaoca = new GiaoCa();
            if(cmb_trangthai.Text == "Chờ xác nhận")
            {
                giaoca.TrangThai = 0;
            }else if (cmb_trangthai.Text == "Đã xác nhận")
            {
                giaoca.TrangThai = 1;
            }else if(cmb_trangthai.Text == "Không được xác nhận")
            {
                giaoca.TrangThai = 2;
            }
            if(DialogResult.Yes == MessageBox.Show("Bạn muốn lưu?"))
            {
                MessageBox.Show(_iqLGiaoCaServices.Update(giaoca), "Lưu thành công");
            }
        }
    }
}
