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
    public partial class Frm_DatHang : Form
    {
        private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        private IQLPhuongThucThanhToanServices _iQLPhuongThucThanhToanServices;
        private IQLHoaDonServices _iQLHoaDonServices;
        public Frm_BanHang FrmParent { get; set; }
        public KhachHang? KH { get; set; }
        public HoaDon? HD { get; set; }
        public Frm_DatHang()
        {
            InitializeComponent();
            _iQLChiTietHoaDonServices = new QLChiTietHoaDonServices();
            _iQLPhuongThucThanhToanServices = new QLPhuongThucThanhToanServices();
            _iQLHoaDonServices = new QLHoaDonServices();
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
        }

        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_DaGiao_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoanTra_Click(object sender, EventArgs e)
        {

        }
    }
}
