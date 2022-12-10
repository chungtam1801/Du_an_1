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
        private IQLLichSuTichDiemServices _iqLLichSuTichDiemServices;
        private IQLQuyDoiDiemServices _iqQuyDoiDiemServices;
        private Guid _id;
        private decimal _tientralai;

        public Frm_KetCa()
        {
            InitializeComponent();
            _iQLGiaoCaServices = new QLGiaoCaServices();
            _iQLNhanVienServices = new QLNhanVienServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            _iQLChiTietPtttServices = new QLChiTietPtttServices();
            _iQLPhuongThucThanhToanServices = new QLPhuongThucThanhToanServices();
            _iqLLichSuTichDiemServices = new QLLichSuTichDiemServices();
            _iqQuyDoiDiemServices = new QLQuyDoiDiemServices();
            LoadNVBanGiao();
            btn_resetca.Enabled = false;
        }
        private void LoadNVBanGiao()
        {
            cmb_nvbangiao.Items.Clear();
            foreach (var x in _iQLNhanVienServices.GetAll())
            {
                cmb_nvbangiao.Items.Add(x.Ma);
            }
            cmb_nvbangiao.SelectedIndex = -1;
        }
        private void Frm_KetCa_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();

            // Tìm ca được lưu gần nhất lưu 
            List<GiaoCa> ca = _iQLGiaoCaServices.GetAll().OrderByDescending(c => c.ThoiGianVaoCa).ToList();
            //Lấy thời gian vào ca gần nhất trong csdl
            tbx_giovao.Enabled = false;
            DateTime thoigianvao = Convert.ToDateTime(ca[0].ThoiGianVaoCa);
            tbx_giovao.Text = thoigianvao.ToString();

            //Lấy id của ca
            _id = ca[0].Id;
            // lấy ghi chú nếu có
            tbx_ghichu.Text = ca[0].GhiChu;
            // Nhân viên trực ca
            tbx_nvtrucca.Enabled = false;
            var idnv = ca[0].IdNguoiNhanCa;
            tbx_nvtrucca.Text = _iQLNhanVienServices.GetAll().First(c => c.Id == idnv).Ma;
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
            List<HoaDon> hoaDons = _iQLHoaDonServices.GetAll().Where(c => c.NgayTao > Convert.ToDateTime(tbx_giovao.Text) && c.NgayTao < DateTime.Now).ToList();

            // Số lượng hóa đơn tạo ra
            tbx_soluonghoadon.Text = Convert.ToString(hoaDons.Count());

            // Số lượng hóa đơn đã thanh toán
            List<HoaDon> hoadontt = hoaDons.Where(c => c.TrangThai == 1 || c.TrangThai == 4).ToList();
            tbx_hđthanhtoan.Text = Convert.ToString(hoadontt.Count());

            // Số lượng hóa đơn chờ thanh toán
            List<HoaDon> hoaDonsngay = _iQLHoaDonServices.GetAll().Where(c => c.NgayTao == DateTime.Today).ToList();

            List<HoaDon> hoadonchuatt = hoaDons.Where(c => c.TrangThai == 3 || c.TrangThai == 0).ToList();
            tbx_hdchothanhtoan.Text = Convert.ToString(hoadonchuatt.Count());

            // Số lượng hóa đơn hủy
            List<HoaDon> hoadonhuy = hoaDons.Where(c => c.TrangThai == 2 || c.TrangThai == 6).ToList();
            tbx_hdhuy.Text = Convert.ToString(hoadonhuy.Count());

            // Danh sách hóa đơn có 2 phương thức thanh toán
            var hd2pttt = (from a in hoadontt
                           where (from b in _iQLChiTietPtttServices.GetAll()
                                  where a.Id == b.IdHd
                                  select b).Count() > 1
                           select a).ToList();

            // Tìm tiền hàng của hóa đơn
            var thang = (from a in hd2pttt
                         join b in _iQLChiTietHoaDonServices.GetAll()
                          on a.Id equals b.IdHd
                         select (b.SoLuong * b.DonGia)).ToList();

            var nhang = (from a in hd2pttt
                         join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd
                         join c in _iQLPhuongThucThanhToanServices.GetAll().Where(c => c.Ten == "Chuyển khoản") on b.IdPttt equals c.Id
                         select b.TienKhachDua).ToList();
            var sddiem2pttt = (from a in hd2pttt
                               join b in _iqLLichSuTichDiemServices.GetAll()
                              on a.Id equals b.IdHd
                               join c in _iqQuyDoiDiemServices.GetAll()
                               on b.IdQuyDoiDiem equals c.Id
                               where b.Diem < 0
                               select b.Diem * c.TiLeTieuDiem).ToList();
            var ssdiem2pttt = sddiem2pttt.Sum();
            var tmat = thang.Sum() - nhang.Sum() + ssdiem2pttt;

            // Hóa đơn 1 pttt


            var hd1pttt = (from a in hoadontt
                           where (from b in _iQLChiTietPtttServices.GetAll()
                                  where a.Id == b.IdHd
                                  select b).Count() == 1
                           select a).ToList();

            //Tiền hàng mua bằng chuyển khoản và thẻ khi trả đúng tiền hàng
            List<HoaDon> hdnganhang = (from a in hd1pttt
                                       join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd
                                       join c in _iQLPhuongThucThanhToanServices.GetAll().Where(c => c.Ten == "Chuyển khoản") on b.IdPttt equals c.Id
                                       select a).ToList();
            var sddiemttnghang = (from a in hdnganhang
                                  join b in _iqLLichSuTichDiemServices.GetAll()
                                  on a.Id equals b.IdHd
                                  join c in _iqQuyDoiDiemServices.GetAll()
                                  on b.IdQuyDoiDiem equals c.Id
                                  where b.Diem < 0
                                  select b.Diem * c.TiLeTieuDiem).ToList();

            var nganhang2 = from a in hdnganhang
                            join b in _iQLChiTietHoaDonServices.GetAll() on a.Id equals b.IdHd
                            select (b.DonGia * b.SoLuong);

            // Nếu tiền chuyển khoản lớn hơn tiền hàng thì phải lấy tiền mặt trả lại
            var nganhang = from a in hdnganhang
                           join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd
                           select b.TienKhachDua;

            // Tiền mặt trả lại khách khi thừa tiền lúc chuyển khoản
            _tientralai = Convert.ToDecimal(nganhang.Sum()) - Convert.ToDecimal(nganhang2.Sum());

            // List trả về hóa đơn thanh toán bằng tiền mặt 
            List<HoaDon> hdtienmat = (from a in hd1pttt
                                      join b in _iQLChiTietPtttServices.GetAll() on a.Id equals b.IdHd
                                      join c in _iQLPhuongThucThanhToanServices.GetAll().Where(c => c.Ten == "Tiền mặt")
                                      on b.IdPttt equals c.Id
                                      select a).ToList();
            var tienmat = from a in hdtienmat
                          join b in _iQLChiTietHoaDonServices.GetAll()
                          on a.Id equals b.IdHd
                          select (b.DonGia * b.SoLuong);
            // List hóa đơn sd điểm
            var sddiemtmat = (from a in hdtienmat
                              join b in _iqLLichSuTichDiemServices.GetAll()
                              on a.Id equals b.IdHd
                              join c in _iqQuyDoiDiemServices.GetAll()
                              on b.IdQuyDoiDiem equals c.Id
                              where b.Diem < 0
                              select b.Diem * c.TiLeTieuDiem).ToList();
            var sddiemtttmat = sddiemtmat.Sum();
            // Tiền sử dụng điểm 
            tbx_tiensddiem.Text = String.Format("{0:0,00}", sddiemtttmat + sddiemttnghang.Sum() + ssdiem2pttt);

            // Tính tiền hàng trả bằng tiền mặt - tiền trả lại khách 
            var trabangtienmat = tienmat.Sum() + tmat - _tientralai + sddiemtttmat + ssdiem2pttt;
            tbx_trabangtienmat.Text = String.Format("{0:0,00}", trabangtienmat);
            tbx_trabangtienmat.Enabled = false;

            // Tính tiền khách hàng dùng thẻ và chuyển khoản 
            tbx_trabangnganhang.Text = String.Format("{0:0,00}", nganhang.Sum() + nhang.Sum() + sddiemttnghang.Sum());
            tbx_trabangnganhang.Enabled = false;

            // Tổng tiền hàng bán được
            var tongtienhang = nganhang2.Sum() + tienmat.Sum() + thang.Sum() + Convert.ToDecimal(tbx_tiensddiem.Text);



            tbx_tongtienhang.Text = String.Format("{0:0,00}", tongtienhang);
            tbx_tongtienhang.Enabled = false;

            // Tổng tiền mặt cuối ca = tiền đầu ca + tiền khách trả bằng tiền mặt - tiền trả lại khách khi khách chuyển khoản thừa - tien sd điểm
            decimal tongtienmatcuoica = Convert.ToDecimal(tbx_trabangtienmat.Text) + Convert.ToDecimal(tbx_tiendauca.Text) + Convert.ToDecimal(tbx_tiensddiem.Text);
            tbx_ttienmatcuoica.Text = String.Format("{0:0,00}", tongtienmatcuoica);
        }
        private void tbx_tongtien_TextChanged(object sender, EventArgs e)
        {
            decimal tienmatcuoica = tbx_ttienmatcuoica.Text == "" ? 0 : Convert.ToDecimal(tbx_ttienmatcuoica.Text);
            decimal chenhlech = Convert.ToDecimal(tbx_tongtien.Text) - tienmatcuoica;
            //Chênh lệch tiền mặt
            tbx_chenhlechtienmat.Text = String.Format("{0:0,00}", chenhlech);
        }

        private void chk_ketcacuoingay_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ketcacuoingay.Checked == true)
            {
                cmb_nvbangiao.Enabled = false;
                cmb_nvbangiao.Text = "";
                btn_ketca.Enabled = false;
                btn_resetca.Enabled = true;
            }
            else if (chk_ketcacuoingay.Checked == false)
            {
                cmb_nvbangiao.Enabled = true;
                btn_resetca.Enabled = false;
                btn_ketca.Enabled = true;
            }
        }
        private void btn_resetca_Click(object sender, EventArgs e)
        {
            decimal tienchenhlech = Convert.ToDecimal(tbx_chenhlechtienmat.Text);
            if (tbx_tongtien.Text == "")
            {
                MessageBox.Show("Bạn chưa kê khai tiền mặt cuối ca");
            }
            else if (tienchenhlech != 0 && String.IsNullOrEmpty(tbx_ghichu.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập lý do có tiền phát sinh");
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn kết ca và Reset lại toàn bộ dữ liệu trong ngày?", "", MessageBoxButtons.YesNo))
            {
                GiaoCa giaoca = new GiaoCa();
                giaoca.Id = _id;
                giaoca.GhiChu = tbx_ghichu.Text;
                giaoca.ThoiGianVaoCa = Convert.ToDateTime(tbx_giovao.Text);
                giaoca.TienDauca = Convert.ToDecimal(tbx_tiendauca.Text);
                giaoca.TienCuoiCa = Convert.ToDecimal(tbx_tongtien.Text);
                giaoca.ThoiGianKetCa = DateTime.Now;
                giaoca.SoHoaDon = Convert.ToInt32(tbx_soluonghoadon.Text);
                giaoca.Tongtienhang = Convert.ToDecimal(tbx_tongtienhang.Text);
                giaoca.Tienmat = Convert.ToDecimal(tbx_trabangtienmat.Text);
                giaoca.Nganhang = Convert.ToDecimal(tbx_trabangnganhang.Text);
                giaoca.TienSDDiem = tbx_tiensddiem.Text == "" ? 0 : Convert.ToDecimal(tbx_tiensddiem.Text);
                giaoca.TongTienMat = Convert.ToDecimal(tbx_ttienmatcuoica.Text);
                giaoca.TrangThai = 0;
                MessageBox.Show(_iQLGiaoCaServices.Update(giaoca), "Thông báo");
            }
        }
        private void btn_ketca_Click(object sender, EventArgs e)
        {
            decimal tienchenhlech = Convert.ToDecimal(tbx_chenhlechtienmat.Text);
            if (Convert.ToDecimal(tbx_tongtien.Text) == 0)
            {
                MessageBox.Show("Bạn chưa kê khai tiền mặt cuối ca");
            }
            else if (String.IsNullOrEmpty(cmb_nvbangiao.Text))
            {
                MessageBox.Show("Bạn chưa chọn người bàn giao ca");
            }
            else if (tienchenhlech != 0 && String.IsNullOrEmpty(tbx_ghichu.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập lý do có tiền phát sinh");
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn kết ca?", "", MessageBoxButtons.YesNo))
            {
                GiaoCa giaoca = new GiaoCa();
                giaoca.Id = _id;
                giaoca.IdNguoiGiaoCa = _iQLNhanVienServices.GetAll().First(c => c.Ma == cmb_nvbangiao.Text).Id;
                giaoca.GhiChu = tbx_ghichu.Text;
                giaoca.ThoiGianVaoCa = Convert.ToDateTime(tbx_giovao.Text);
                giaoca.TienDauca = Convert.ToDecimal(tbx_tiendauca.Text);
                giaoca.TienCuoiCa = Convert.ToDecimal(tbx_tongtien.Text);
                giaoca.ThoiGianKetCa = DateTime.Now;
                giaoca.SoHoaDon = Convert.ToInt32(tbx_soluonghoadon.Text);
                giaoca.Tongtienhang = Convert.ToDecimal(tbx_tongtienhang.Text);
                giaoca.Tienmat = Convert.ToDecimal(tbx_trabangtienmat.Text);
                giaoca.Nganhang = Convert.ToDecimal(tbx_trabangnganhang.Text);
                giaoca.TienSDDiem = tbx_tiensddiem.Text == "" ? 0 : Convert.ToDecimal(tbx_tiensddiem.Text);
                giaoca.TongTienMat = Convert.ToDecimal(tbx_ttienmatcuoica.Text);
                giaoca.TrangThai = 0;
                MessageBox.Show(_iQLGiaoCaServices.Update(giaoca), "Thông báo");
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
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
            tbx_tongtien.Text = String.Format("{0:0,00}", tongtien);
        }

    }
}