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
        private IQLChucVuServices _iqChucVuServices;
        private Guid _id;
        private GiaoCa giaoCa;
        public Frm_QLGiaoCa()
        {
            InitializeComponent();
            _iqLGiaoCaServices = new QLGiaoCaServices();
            _iqNhanVienServices = new QLNhanVienServices();
            _iqChucVuServices = new QLChucVuServices();
            LoadData();
            LoadTrangThai();
            LoadNhanVien();
        }
        private void LoadTrangThai()
        {
            cmb_trangthai.Items.Clear();
            cmb_trangthai.Items.Add("Chờ xác nhận");
            cmb_trangthai.Items.Add("Đã xác nhận");
            cmb_trangthai.Items.Add("Không xác nhận");
            cmb_trangthai.SelectedIndex = -1;
        }
        private void LoadNhanVien()
        {
            try
            {
                var listnv = (from a in _iqNhanVienServices.GetAll()
                              join b in _iqChucVuServices.GetAll().Where(c => c.Ten == "Nhân viên")
                              on a.IdCv equals b.Id
                              select a).ToList();
                cmb_nhvien.Items.Clear();
                foreach (var x in listnv)
                {
                    cmb_nhvien.Items.Add(x.Ho + " " + x.TenDem + " " + x.Ten);
                }
                cmb_nhvien.SelectedIndex = -1;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            try
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
                dgrd_dsca.Columns[4].Name = "Thời gian kết ca";
                dgrd_dsca.Columns[5].Name = "Doanh thu";
                dgrd_dsca.Columns[6].Name = "Ghi chú";
                dgrd_dsca.Columns[7].Name = "Trạng thái";
                foreach (var x in _iqLGiaoCaServices.GetAll().OrderByDescending(c => c.ThoiGianVaoCa))
                {
                    string ten = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ten;
                    string ho = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ho;
                    string dem = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).TenDem;

                    dgrd_dsca.Rows.Add(stt++, x.Id, x.ThoiGianVaoCa, ho + " " + dem + " " + ten, x.ThoiGianKetCa, x.Tongtienhang, x.GhiChu, x.TrangThai == 0 ? "Chờ xác nhận" : (x.TrangThai == 1 ? "Đã xác nhận" : "Không được xác nhận"));
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrd_dsca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0 && rowIndex < _iqLGiaoCaServices.GetAll().Count)
                {
                    GiaoCa ca = _iqLGiaoCaServices.GetAll().First(c => c.Id == Guid.Parse(dgrd_dsca.Rows[rowIndex].Cells[1].Value.ToString()));
                    _id = ca.Id;
                    lbl_giovao.Text = ca.ThoiGianVaoCa.ToString();
                    lbl_gioket.Text = ca.ThoiGianKetCa.ToString();
                    lbl_nvtruc.Text = dgrd_dsca.Rows[rowIndex].Cells[3].Value.ToString();
                    lbl_nvgiaoca.Text = ca.IdNguoiGiaoCa == null ? "" : dgrd_dsca.Rows[rowIndex].Cells[4].Value.ToString();
                    lbl_tmatdauca.Text = ca.TienDauca.ToString();
                    lbl_tonghoadon.Text = ca.SoHoaDon.ToString();
                    lbl_tienmat.Text = ca.Tienmat.ToString();
                    lbl_tiennganhang.Text = ca.Nganhang.ToString();
                    lbl_tiensddiem.Text = ca.TienSDDiem.ToString();
                    lbl_doanhthu.Text = ca.Tongtienhang.ToString();
                    lbl_tongtienmat.Text = ca.TongTienMat.ToString();
                    lbl_tientaiquay.Text = ca.TienCuoiCa.ToString();
                    lbl_tienphatsinh.Text = String.Format("0:0,00", ca.TienCuoiCa - ca.Tongtienhang);
                    lbl_lydophatsinh.Text = ca.GhiChu == null ? "0" : ca.GhiChu.ToString();
                    if (ca.TrangThai == 0)
                    {
                        cmb_trangthai.Text = "Chờ xác nhận";
                    }
                    else if (ca.TrangThai == 1)
                    {
                        cmb_trangthai.Text = "Đã xác nhận";
                    }
                    else if (ca.TrangThai == 2)
                    {
                        cmb_trangthai.Text = "Không được xác nhận";
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private GiaoCa GetDataFromGui()
        {
            GiaoCa giaoca = new GiaoCa();
            giaoca.Id = _id;
            giaoca.GhiChu = lbl_lydophatsinh.Text;
            giaoca.ThoiGianVaoCa = Convert.ToDateTime(lbl_giovao.Text);
            giaoca.TienDauca = Convert.ToDecimal(lbl_tmatdauca.Text);
            giaoca.TienCuoiCa = Convert.ToDecimal(lbl_tongtienmat.Text);
            giaoca.ThoiGianKetCa = Convert.ToDateTime(lbl_gioket.Text);
            giaoca.SoHoaDon = Convert.ToInt32(lbl_tonghoadon.Text);
            giaoca.Tongtienhang = Convert.ToDecimal(lbl_doanhthu.Text);
            giaoca.Tienmat = Convert.ToDecimal(lbl_tienmat.Text);
            giaoca.Nganhang = Convert.ToDecimal(lbl_tiennganhang.Text);
            giaoca.TienSDDiem = lbl_tiensddiem.Text == "" ? 0 : Convert.ToDecimal(lbl_tiensddiem.Text);
            giaoca.TongTienMat = Convert.ToDecimal(lbl_tongtienmat.Text);

            if (cmb_trangthai.Text == "Chờ xác nhận")
            {
                giaoca.TrangThai = 0;
            }
            else if (cmb_trangthai.Text == "Đã xác nhận")
            {
                giaoca.TrangThai = 1;
            }
            else if (cmb_trangthai.Text == "Không được xác nhận")
            {
                giaoca.TrangThai = 2;
            }
            return giaoca;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn lưu?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLGiaoCaServices.Update(GetDataFromGui()));
                    LoadData();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var listca = _iqLGiaoCaServices.GetAll().Where(c => c.ThoiGianVaoCa >= dtime_bdau.Value && c.ThoiGianVaoCa <= dtime_kthuc.Value).ToList();
                int stt = 1;
                dgrd_dsca.Rows.Clear();
                dgrd_dsca.ColumnCount = 8;
                dgrd_dsca.Columns[0].Name = "STT";
                dgrd_dsca.Columns[0].Width = 50;
                dgrd_dsca.Columns[1].Name = "ID";
                dgrd_dsca.Columns[1].Visible = false;
                dgrd_dsca.Columns[2].Name = "Thời gian vào";
                dgrd_dsca.Columns[3].Name = "Người trực ca";
                dgrd_dsca.Columns[4].Name = "Thời gian kết ca";
                dgrd_dsca.Columns[5].Name = "Doanh thu";
                dgrd_dsca.Columns[6].Name = "Ghi chú";
                dgrd_dsca.Columns[7].Name = "Trạng thái";
                foreach (var x in listca.OrderByDescending(c => c.ThoiGianVaoCa))
                {
                    string ten = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ten;
                    string ho = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ho;
                    string dem = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).TenDem;

                    dgrd_dsca.Rows.Add(stt++, x.Id, x.ThoiGianVaoCa, ho + " " + dem + " " + ten, x.ThoiGianKetCa, x.Tongtienhang, x.GhiChu, x.TrangThai == 0 ? "Chờ xác nhận" : (x.TrangThai == 1 ? "Đã xác nhận" : "Không được xác nhận"));
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_TimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var id = _iqNhanVienServices.GetAll().First(c => (c.Ho + " " + c.TenDem + " " + c.Ten) == cmb_nhvien.Text).Id;
                var lstca = _iqLGiaoCaServices.GetAll().Where(c => c.IdNguoiNhanCa == id).ToList();
                int stt = 1;
                dgrd_dsca.Rows.Clear();
                dgrd_dsca.ColumnCount = 8;
                dgrd_dsca.Columns[0].Name = "STT";
                dgrd_dsca.Columns[0].Width = 50;
                dgrd_dsca.Columns[1].Name = "ID";
                dgrd_dsca.Columns[1].Visible = false;
                dgrd_dsca.Columns[2].Name = "Thời gian vào";
                dgrd_dsca.Columns[3].Name = "Người trực ca";
                dgrd_dsca.Columns[4].Name = "Thời gian kết ca";
                dgrd_dsca.Columns[5].Name = "Doanh thu";
                dgrd_dsca.Columns[6].Name = "Ghi chú";
                dgrd_dsca.Columns[7].Name = "Trạng thái";
                foreach (var x in lstca.OrderByDescending(c => c.ThoiGianVaoCa))
                {
                    string ten = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ten;
                    string ho = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).Ho;
                    string dem = _iqNhanVienServices.GetAll().First(c => c.Id == x.IdNguoiNhanCa).TenDem;

                    dgrd_dsca.Rows.Add(stt++, x.Id, x.ThoiGianVaoCa, ho + " " + dem + " " + ten, x.ThoiGianKetCa, x.Tongtienhang, x.GhiChu, x.TrangThai == 0 ? "Chờ xác nhận" : (x.TrangThai == 1 ? "Đã xác nhận" : "Không được xác nhận"));
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
