using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class Frm_BanHangTaiQuay : Form
    {
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private IQLPhuongThucThanhToanServices _iQLPhuongThucThanhToanServices;
        private IQLHoaDonServices _iQLHoaDonServices;
        private IQLChiTietPtttServices _iQLChiTietPtttServices;
        public Frm_BanHang FrmParent { get; set; }
        public KhachHang? KH { get; set; }
        public HoaDon? HD { get; set; }
        public Frm_BanHangTaiQuay()
        {
            InitializeComponent();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            _iQLPhuongThucThanhToanServices = new QLPhuongThucThanhToanServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            foreach (var x in _iQLPhuongThucThanhToanServices.GetAll())
            {
                cbx_HTTT.Items.Add(x.Ten);
            }
        }
        private void tbx_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            tbx_TienThua.Text = (Convert.ToInt32(tbx_TienKhachDua.Text) - Convert.ToInt32(tbx_TongTien.Text)).ToString();
        }
        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Ma = ClassSP.AutoID("HD", _iQLHoaDonServices.GetAll().Count);
            hoaDon.IdNv = new Guid("506AE5B4-6D31-43E6-A5EB-BA535A67D692");
            hoaDon.NgayTao = DateTime.Now;
            _iQLHoaDonServices.Add(hoaDon);
            //Frm_BanHangTaiQuay frm = new Frm_BanHangTaiQuay();
            HD = hoaDon;
            tbx_MaHD.Text = HD.Ma;
            tbx_TongTien.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == HD.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
            FrmParent.LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
            //OpenChildFrm(frm);
            //return hoaDon;
            //LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (HD == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else if (HD.NgayThanhToan != null)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
            }
            else if (_iQLChiTietHoaDonServices.GetAll().Where(c=>c.IdHd==HD.Id).ToList().Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {
                HD.NgayThanhToan = DateTime.Now;
                MessageBox.Show(_iQLHoaDonServices.Update(HD));
                FrmParent.LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
                //LoadDTG_HoaDon(_iQLHoaDonServices.GetAll());
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BanHangTaiQuay_Load(object sender, EventArgs e)
        {
            if (HD != null)
            {
                tbx_MaHD.Text = HD.Ma;
                tbx_TongTien.Text = _iQLChiTietHoaDonServices.GetAll().Where(c => c.IdHd == HD.Id).Sum(d => d.SoLuong * d.DonGia).ToString();
            }
        }
    }
}
