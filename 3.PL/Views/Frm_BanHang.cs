using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System.IO;
using AForge.Video.DirectShow;
using System.Threading;
using ZXing;
using _3.PL.Utilities;

namespace _3.PL.Views
{
    public partial class Frm_BanHang : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private BanHangServices _banHangServices = new BanHangServices();
        //private IQLHoaDonServices _iQLHoaDonServices;
        private IQLChiTietSpServices _iQLChiTietSpServices;
        //private IQLChiTietHoaDonServices _iQLChiTietHoaDonServices;
        //private IQLChiTietPtttServices _iQLChiTietPtttServices;
        //private IQLPhuongThucThanhToanServices _iQLPhuongThucThanhToanServices;
        private KhachHang _khachHang;
        //private HoaDon? _hoaDon;
        private int _trangThaiBH = 0;
        private string _trangThaiHD = "Chờ thanh toán";
        private string _trangThaiDH = "Chờ giao hàng";
        private List<Guid> _lstIDPTTT = new List<Guid>();
        public HoaDon? _hoaDon { get; set; }
        public Frm_BanHang()
        {
            InitializeComponent();
            _iQLChiTietSpServices = new QLChiTietSpServices();
            LoadDTG_HoaDon(_trangThaiHD);
            LoadDTG_DatHang(_trangThaiDH);
            GetData(_iQLChiTietSpServices.GetAllView());
            cbx_TrangThai.SelectedIndex = 0;
            cbx_THDatHang.SelectedIndex = 0;
            foreach (var x in _banHangServices.GetAllPTTT())
            {
                _lstIDPTTT.Add(x.Id);
                cbx_HTTT.Items.Add(x.Ten);
            }
            //cbx_HTTT.SelectedIndex = 2;
        }
        private void GetData(List<ViewQLChiTietSp> lstview)
        {
            flp_SanPham.Controls.Clear();
            ThongTinSanPham thongTinSanPham;
            foreach (var x in lstview)
            {
                thongTinSanPham = new ThongTinSanPham();
                MemoryStream ms = new MemoryStream(x.Anh);
                Bitmap bitmap = new Bitmap(ms);
                thongTinSanPham.Anh = bitmap;
                thongTinSanPham.Ten = x.Ten;
                thongTinSanPham.SoLuong = x.SoLuongTon.ToString();
                thongTinSanPham.GiaTien = x.GiaBan.ToString();
                thongTinSanPham.Id = x.Id.ToString();
                thongTinSanPham.Click += new System.EventHandler(UserContrel_Click);
                flp_SanPham.Controls.Add(thongTinSanPham);           
            }
        }
        private void LoadThongTinHoaDon(HoaDon? hoaDon)
        {
            if (hoaDon == null)
            {
                tbx_MaHD.Text = "";
                tbx_TongTien.Text = "";
                tbx_TienKhachCD.Text = "";
            }
            else
            {
                tbx_MaHD.Text = hoaDon.Ma;
                tbx_TongTien.Text = _banHangServices.SumTienHang(hoaDon.Id).ToString();
                tbx_TienKhachCD.Text = (_banHangServices.SumTienHang(hoaDon.Id) - _banHangServices.SumTienKhachDua(hoaDon.Id)).ToString();
                if (hoaDon.TrangThai == 4) btn_Chot.Text = "Đã giao hàng";
                else if (hoaDon.TrangThai == 3) btn_Chot.Text = "Giao hàng";
                else if (hoaDon.TrangThai <3) btn_Chot.Text = "Thanh toán";
            }           
        }
        public void LoadDTG_ChiTietHD(List<ViewQLChiTietHoaDon> lstView)
        {
            dtg_ChiTietHD.Rows.Clear();
            dtg_ChiTietHD.ColumnCount = 11;
            dtg_ChiTietHD.Columns[0].Name = "Ma";
            dtg_ChiTietHD.Columns[1].Name = "Ten";
            dtg_ChiTietHD.Columns[2].Name = "Nsx";
            dtg_ChiTietHD.Columns[3].Name = "Mau Sac";
            dtg_ChiTietHD.Columns[4].Name = "LoaiSp";
            dtg_ChiTietHD.Columns[5].Name = "Kich Thuoc";
            dtg_ChiTietHD.Columns[6].Name = "Chat Lieu";
            dtg_ChiTietHD.Columns[7].Name = "So Luong";
            dtg_ChiTietHD.Columns[8].Name = "Id";
            dtg_ChiTietHD.Columns[8].Visible = false;
            dtg_ChiTietHD.Columns[9].Name = "Đơn giá";
            dtg_ChiTietHD.Columns[10].Name = "Tổng tiền";
            foreach (ViewQLChiTietHoaDon x in lstView)
            {
                dtg_ChiTietHD.Rows.Add(x.Ma, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.SoLuong, x.Id,x.DonGia,x.TongTien);
            }
        }
        public void LoadDTG_DatHang(string trangthai)
        {
            dtg_DatHang.Rows.Clear();
            dtg_DatHang.ColumnCount = 7;
            dtg_DatHang.Columns[0].Name = "Mã";
            dtg_DatHang.Columns[1].Name = "Nhân viên";
            dtg_DatHang.Columns[2].Name = "Ngày tạo";
            dtg_DatHang.Columns[3].Name = "Ngày giao hàng";
            dtg_DatHang.Columns[4].Name = "Ngày nhận hàng";
            dtg_DatHang.Columns[5].Name = "Tổng tiền";
            dtg_DatHang.Columns[6].Name = "Trạng thái";
            foreach (ViewQLHoaDon hoaDon in _banHangServices.GetAllHDV().Where(c => c.TrangThai == trangthai))
            {
                dtg_DatHang.Rows.Add(hoaDon.Ma, hoaDon.TenNv, hoaDon.NgayTao, hoaDon.NgayGiaoHang,hoaDon.NgayNhanHang,hoaDon.TongTien, hoaDon.TrangThai);
            }
        }
        //Sửa
        public void LoadDTG_HoaDon(string trangthai)
        {
            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.ColumnCount = 6;
            dtg_HoaDon.Columns[0].Name = "Mã";
            dtg_HoaDon.Columns[1].Name = "Nhân viên";
            dtg_HoaDon.Columns[2].Name = "Ngày tạo";
            dtg_HoaDon.Columns[3].Name = "Ngay thanh toán";
            dtg_HoaDon.Columns[4].Name = "Tổng tiền";
            dtg_HoaDon.Columns[5].Name = "Trạng thái";
            foreach (ViewQLHoaDon hoaDon in _banHangServices.GetAllHDV().Where(c=>c.TrangThai==trangthai))
            {
                dtg_HoaDon.Rows.Add(hoaDon.Ma, hoaDon.TenNv, hoaDon.NgayTao, hoaDon.NgayThanhToan,hoaDon.TongTien,hoaDon.TrangThai);
            }
        }
        private void UserContrel_Click(object sender, EventArgs e)
        {
            ThongTinSanPham obj = (ThongTinSanPham)sender;
            if(_hoaDon==null)
            {
                _hoaDon = _banHangServices.CreateHD(_trangThaiBH);
                LoadDTG_HoaDon(_trangThaiHD);
            }
            if (!_banHangServices.CheckHDThanhToan(_hoaDon))
            {
                ChiTietSp temp = _iQLChiTietSpServices.GetAll().First(c => c.Id == new Guid(obj.Id));
                if (temp.SoLuongTon > 0)
                {
                    _banHangServices.AddChiTietHD(temp, _hoaDon);
                    obj.lbl_SoLuong.Text = temp.SoLuongTon.ToString();
                }
                else
                {
                    MessageBox.Show("Sản phẩm hết hàng");
                }
                LoadThongTinHoaDon(_hoaDon);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
            }
            else MessageBox.Show("Hóa đơn đang được thanh toán");               
        }  
        private void tsb_BanHang_Click(object sender, EventArgs e)
        {
            //_trangThaiBH = 0;
            //_hoaDon = null;
            //LoadThongTinHoaDon(_hoaDon);
            //btn_Chot.Text = "Thanh toán";
            //lbl_TienShip.Visible = false;
            //tbx_TienShip.Visible = false;
        }
        private void tsb_DatHang_Click(object sender, EventArgs e)
        {
            //_trangThaiBH = 2;
            //_hoaDon = null;
            //LoadThongTinHoaDon(_hoaDon);
            //btn_Chot.Text = "Giao hàng";
            //lbl_TienShip.Visible = true;
            //tbx_TienShip.Visible = true;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start();
            //timer1.Start();
        }
        //private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        //{
        //    ptb_QR.Image = (Bitmap)eventArgs.Frame.Clone();
        //}

        //private void Frm_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (videoCaptureDevice != null)
        //    {
        //        if (videoCaptureDevice.IsRunning)
        //        {
        //            videoCaptureDevice.Stop();
        //        }
        //    }
        //    this.Close();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            //BarcodeReader barcodeReader = new BarcodeReader();
            //if(ptb_QR.Image != null)
            //{
            //    Result result = barcodeReader.Decode((Bitmap)ptb_QR.Image);
            //    if (result != null)
            //    {
            //        //tbx_Chuoi.Text = result.ToString();
            //        timer1.Stop();
            //        if (videoCaptureDevice.IsRunning)
            //        {
            //            videoCaptureDevice.Stop();
            //        }
            //    }
            //}              
        }
        private void pic_TimKiem_Click(object sender, EventArgs e)
        {
            GetData(_iQLChiTietSpServices.GetAllView().Where(c => c.Ten.Contains(tbx_TimKiem.Text)).ToList());
        }
        //pnl ThongTinHoaDon
        private void cbx_HTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_HTTT.Text == "Điểm")
            {
                tbx_DiemSD.Enabled = true;
                tbx_TienKhachDua.Text = "";
                tbx_TienKhachDua.Enabled = false;
            }
            else
            {
                tbx_DiemSD.Text = "";
                tbx_DiemSD.Enabled = false;
                tbx_TienKhachDua.Enabled = true;
            } 
        }
        private void tbx_SDT_Leave(object sender, EventArgs e)
        {
            tbx_TenKH.Text = "";
            tbx_DiaChi.Text = "";
            _khachHang = _banHangServices.GetKhachHang(tbx_SDT.Text);
            if (_khachHang != null)
            {
                tbx_TenKH.Text = _khachHang.Ho + " " + _khachHang.TenDem + " " + _khachHang.Ten;
                tbx_DiaChi.Text = _khachHang.DiaChi;
                tbx_DiemHT.Text = _khachHang.DiemTich.ToString();
            }
            else
            {
                tbx_TenKH.Text = "";
                tbx_DiaChi.Text = "";
                tbx_DiemHT.Text = "";
            }
        }
        private void tbx_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhach;
            if (decimal.TryParse(tbx_TienKhachDua.Text, out tienKhach))
            {
                decimal tienThua = tienKhach - Convert.ToDecimal(tbx_TienKhachCD.Text);
                if (tienThua > 0)
                {
                    tbx_TienThua.Text = tienThua.ToString();
                }
                else
                {
                    tbx_TienThua.Text = "0";
                }
            }
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (Utility.CheckStringEmpty(tbx_GhiChu.Text))
            {
                MessageBox.Show("Vui lòng điền ghi chú");
            }
            else
            {
                MessageBox.Show(_banHangServices.UpdateTrangThaiHD(_hoaDon, 6));
                LoadDTG_HoaDon(_trangThaiHD);
            }
        }
        private void btn_Chot_Click(object sender, EventArgs e)
        {
            if (_hoaDon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else if (_hoaDon.TrangThai == 1)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
            }
            else if (_banHangServices.GetAllChiTietHDV(_hoaDon.Id).Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else if(cbx_HTTT.Text == "Điểm" && _khachHang==null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng khi sử dụng điểm");
            }
            else if (btn_Chot.Text == "Đã giao hàng")
            {
                MessageBox.Show(_banHangServices.UpdateTrangThaiHD(_hoaDon, 5));
                if (_trangThaiBH < 3)
                {
                    LoadDTG_HoaDon(_trangThaiHD);
                }
                else
                {
                    LoadDTG_DatHang(_trangThaiDH);
                }
            }
            else
            {
                MessageBox.Show(_banHangServices.Chot(_lstIDPTTT[cbx_HTTT.SelectedIndex], _hoaDon, _khachHang, tbx_TienKhachDua.Text == String.Empty ? 0 : Convert.ToDecimal(tbx_TienKhachDua.Text), Convert.ToDecimal(tbx_TienKhachCD.Text), _trangThaiBH, tbx_TienShip.Text == String.Empty ? null : Convert.ToDecimal(tbx_TienShip.Text), tbx_DiemSD.Text == String.Empty ? 0 : Convert.ToInt32(tbx_DiemSD.Text)));
                LoadThongTinHoaDon(_hoaDon);
                if (_trangThaiBH < 3)
                {
                    LoadDTG_HoaDon(_trangThaiHD);
                }
                else
                {
                    LoadDTG_DatHang(_trangThaiDH);
                }
            }
        }
        private void tbx_DiemSD_TextChanged(object sender, EventArgs e)
        {
            if(Utility.CheckNumber(tbx_DiemSD.Text))
            {
                tbx_TienKhachDua.Text = _banHangServices.QuyDoiDiem(Convert.ToInt32(tbx_DiemSD.Text)).ToString();
            }             
        }
        //pnl HoaDon
        private void pic_TaoHoaDon_Click(object sender, EventArgs e)
        {
            _hoaDon = _banHangServices.CreateHD(0);
            _trangThaiBH = 0;
            LoadThongTinHoaDon(_hoaDon);
            LoadDTG_HoaDon(_trangThaiHD);
            LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
        }
        private void cbx_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            _trangThaiHD = cbx_TrangThai.Text;
            LoadDTG_HoaDon(_trangThaiHD);
        }
        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_HoaDon.CurrentRow.Cells[0].Value != null)
            {
                _trangThaiBH = 0;
                _hoaDon = _banHangServices.GetAllHD().First(c => c.Ma == dtg_HoaDon.CurrentRow.Cells[0].Value.ToString());
                LoadThongTinHoaDon(_hoaDon);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
            }
        }
        //pnl DatHang
        private void pic_TaoDatHang_Click(object sender, EventArgs e)
        {
            _hoaDon = _banHangServices.CreateHD(3);
            _trangThaiBH = 3;
            LoadThongTinHoaDon(_hoaDon);
            LoadDTG_DatHang(_trangThaiDH);
            LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
        }
        private void cbx_THDatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            _trangThaiDH = cbx_THDatHang.Text;
            LoadDTG_DatHang(_trangThaiDH);
        }
        private void dtg_DatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DatHang.CurrentRow.Cells[0].Value != null)
            {
                _trangThaiBH = 3;
                _hoaDon = _banHangServices.GetAllHD().First(c => c.Ma == dtg_DatHang.CurrentRow.Cells[0].Value.ToString());
                LoadThongTinHoaDon(_hoaDon);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
            }
        }
        //pnl GioHang
        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            if (_hoaDon != null)
            {
                _banHangServices.DeleteALLChiTietHD(_hoaDon.Id);
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                GetData(_iQLChiTietSpServices.GetAllView());
            }
        }
        private void dtg_ChiTietHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!_banHangServices.CheckHDThanhToan(_hoaDon))
            {
                _banHangServices.UpdateSoLuongChiTietHD(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()), Convert.ToInt32(dtg_ChiTietHD.CurrentRow.Cells[7].Value));
                LoadThongTinHoaDon(_hoaDon);
                //Sua
                _iQLChiTietSpServices = new QLChiTietSpServices();
                //
                GetData(_iQLChiTietSpServices.GetAllView());
            }
            else MessageBox.Show("Hoá đơn đang được thanh toán");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(dtg_ChiTietHD.CurrentRow.Cells[8].Value!=null)
            {
                _banHangServices.DeleteChiTietHD(new Guid(dtg_ChiTietHD.CurrentRow.Cells[8].Value.ToString()));
                LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(_hoaDon.Id));
                GetData(_iQLChiTietSpServices.GetAllView());
            }           
        }

        private void btn_QR_Click(object sender, EventArgs e)
        {
            Frm_QR frm_qr = new Frm_QR();
            frm_qr.frmPatents = this;
            frm_qr.ShowDialog();
        }
    }
}
