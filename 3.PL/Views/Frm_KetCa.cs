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
    public partial class Frm_KetCa : Form
    {
        private IQLGiaoCaServices _iQLGiaoCaServices;
        private IQLNhanVienServices _iQLNhanVienServices;
        private IQLHoaDonServices _iQLHoaDonServices;
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private IQLChiTietPtttServices _iQLChiTietPtttServices;
        private IQLPhuongThucThanhToanServices _iQLPhuongThucThanhToanServices;
        private Guid _id;
        public Frm_KetCa()
        {
            InitializeComponent();
            _iQLGiaoCaServices = new QLGiaoCaServices();
            _iQLNhanVienServices = new QLNhanVienServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            _iQLChiTietPtttServices = new QLChiTietPtttServices();
            _iQLPhuongThucThanhToanServices = new QLPhuongThucThanhToanServices();
            LoadNVBanGiao();
        }
        private void LoadNVBanGiao()
        {
            cmb_nvbangiao.Items.Clear();
            foreach(var x in _iQLNhanVienServices.GetAll())
            {
                cmb_nvbangiao.Items.Add(x.Ten);
            }
            cmb_nvbangiao.SelectedIndex = -1;
        }
        private void Frm_KetCa_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            // Tìm ca được lưu gần nhất lưu 
            List<GiaoCa> ca = _iQLGiaoCaServices.GetAll().OrderByDescending(c => c.ThoiGianVaoCa).ToList();
            //Lấy id của ca
            _id = ca[0].Id;
            // Nhân viên trực ca
            tbx_nvtrucca.Enabled = false;
            var idnv = ca[0].IdNguoiNhanCa;
            tbx_nvtrucca.Text = _iQLNhanVienServices.GetAll().First(c => c.Id == idnv).Ho;
            //Lấy thời gian vào ca gần nhất trong csdl
            tbx_giovao.Enabled = false;
            DateTime thoigian = Convert.ToDateTime(ca[0].ThoiGianVaoCa);
            tbx_giovao.Text = thoigian.ToString();
            //tbx_giovao.Text = Convert.ToString("2022-12-02");
            // Thời gian kết ca
            tbx_gioketca.Text = Convert.ToString(DateTime.Now);
            // Tiền mặt đầu ca
            var tiendauca = ca[0].TienDauca;
            tbx_tiendauca.Text = String.Format("{0:0,00}", tiendauca);
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
            tbx_tongtien.Enabled = false;
            // Lấy danh sách hóa đơn được tạo trong ca
            List<HoaDon> hoaDons = _iQLHoaDonServices.GetAll().Where(c=> c.NgayTao < Convert.ToDateTime(tbx_gioketca.Text) && c.NgayTao > Convert.ToDateTime(tbx_giovao.Text)).ToList();

            // Tính số lượng hóa đơn tạo ra
            tbx_soluonghoadon.Text = Convert.ToString(hoaDons.Count());

            // Tính số lượng hóa đơn đã thanh toán
            List<HoaDon> hoadontt = hoaDons.Where(c => c.TrangThai == 1).ToList();
            tbx_hđthanhtoan.Text = Convert.ToString(hoadontt.Count());

            // Tính số lượng hóa đơn chờ thanh toán
            List<HoaDon> hoadonchuatt = hoaDons.Where(c => c.TrangThai == 2).ToList();
            tbx_hđthanhtoan.Text = Convert.ToString(hoadonchuatt.Count());

            // List trả về hóa đơn thanh toán bằng tiền mặt 
            List<HoaDon> hdtienmat = (from a in _iQLHoaDonServices.GetAll()
                                     join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd 
                                     join c in _iQLPhuongThucThanhToanServices.GetAll().Where(c => c.Ten == "Tiền mặt") on b.IdPttt equals c.Id where a.Id == b.IdHd  && b.IdPttt == c.Id
                                     select a).ToList();
            var tienmat = from a in hdtienmat
                       join b in _iQLChiTietHoaDonServices.GetAll()
                        on a.Id equals b.IdHd
                          where a.Id == b.IdHd
                          select (b.DonGia * b.SoLuong);
            // Tính tiền hàng trả bằng tiền mặt
            tbx_trabangtienmat.Text = String.Format("{0:0,00}", tienmat.Sum());
            tbx_trabangtienmat.Enabled = false;
            // List trả về hóa đơn thanh toán bằng ngân hàng

            List<HoaDon> hdnganhang = (from a in _iQLHoaDonServices.GetAll()
                                       join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd
                                       join c in _iQLPhuongThucThanhToanServices.GetAll().Where(c => c.Ten == "Chuyển khoản" || c.Ten == "Thẻ") on b.IdPttt equals c.Id
                                       where a.Id == b.IdHd && b.IdPttt == c.Id
                                       select a).ToList();
            var nganhang = from a in hdnganhang
                       join b in _iQLChiTietHoaDonServices.GetAll()
                        on a.Id equals b.IdHd
                        where a.Id == b.IdHd
                       select (b.DonGia * b.SoLuong);
            // Tính tiền hàng trả bằng thẻ và chuyển khoản 
            tbx_trabangnganhang.Text = String.Format("{0:0,00}", nganhang.Sum());
            tbx_trabangnganhang.Enabled = false;
            // Tổng tiền hàng bán được
            var tongtienhang = nganhang.Sum() + tienmat.Sum();
            tbx_tongtienhang.Text = String.Format("{0:0,00}", tongtienhang);
            tbx_tongtienhang.Enabled = false;
            // Tổng tiền mặt cuối ca 
            decimal tongtienmatcuoica = Convert.ToDecimal(tienmat.Sum()) + Convert.ToDecimal(tbx_tiendauca.Text);
            tbx_ttienmatcuoica.Text = String.Format("{0:0,00}", tongtienmatcuoica);
            //decimal chenhlech = (Convert.ToDecimal(tbx_tongtien.Text) - tongtienmatcuoica);
            // Chênh lệch tiền mặt
            //tbx_chenhlechtienmat.Text = String.Format("{0:0,00}", chenhlech);
        }
        private void tbx_sl500_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl200_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbx_sl100_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void label17_Click_1(object sender, EventArgs e)
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

        private void tbx_sl200_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl100_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbx_sl100.Text))
            {
                tbx_ttien100.Text = "0";
            }
            else
            {
                int thanhtien = 100000 * Convert.ToInt32(tbx_sl100.Text);
                tbx_ttien100.Text = String.Format("{0:0,00}", thanhtien);
            }
        }

        private void tbx_sl50_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl20_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl10_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl5_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl2_TextChanged_1(object sender, EventArgs e)
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

        private void tbx_sl1_TextChanged(object sender, EventArgs e)
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

        private void btn_ketca_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn kết ca?", "", MessageBoxButtons.YesNo))
            {
                GiaoCa giaoca = new GiaoCa();
                giaoca.Id = _id;
                giaoca.TienCuoiCa = Convert.ToDecimal(tbx_ttienmatcuoica.Text);
                giaoca.ThoiGianKetCa = Convert.ToDateTime(tbx_gioketca.Text);
                giaoca.IdNguoiGiaoCa = _iQLNhanVienServices.GetAll().First(c => c.Ten == cmb_nvbangiao.Text).Id;
                giaoca.SoHoaDon = Convert.ToInt32(tbx_soluonghoadon);
                giaoca.GhiChu = tbx_ghichu.Text;
                giaoca.Tongtienhang = Convert.ToDecimal(tbx_tongtienhang.Text);
                MessageBox.Show(_iQLGiaoCaServices.Update(giaoca),"Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo)){
                this.Close();
            }
        }
    }
}
