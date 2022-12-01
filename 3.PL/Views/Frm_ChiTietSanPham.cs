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
using System.IO;
using _3.PL.Views;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views
{
    public partial class Frm_ChiTietSanPham : Form
    {
        private IQLChiTietSpServices _iqLChiTietSpServices;
        private IQLSanPhamServices _iqlSanPhamServices;
        private IQLNsxServices _iqlNsxServices;
        private IQLMauSacServices _iqlMauSacServices;
        private IQLKichThuocServices _iqlLKichThuocServices;
        private IQLLoaiSpServices _iqLLoaiSpServices;
        private IQLChatLieuServices _iqLChatLieuServices;

        private Guid _id;
        public Frm_ChiTietSanPham()
        {
            InitializeComponent();
            _iqLChiTietSpServices = new QLChiTietSpServices();
            _iqlSanPhamServices = new QLSanPhamServices();
            _iqlNsxServices = new QLNsxServices();
            _iqLChatLieuServices = new QLChatLieuServices();
            _iqlLKichThuocServices = new QLKichThuocServices();
            _iqLLoaiSpServices = new QLLoaiSpServices();
            _iqlMauSacServices = new QLMauSacServices();
            LoadData(null);
            LoadSanPham();
            LoadChatLieu();
            LoadMauSac();
            LoadNSX();
            LoadKichThuoc();
            LoadLoaiSP();
            LoadTimKiem();
            tbx_masp.Enabled = false;
        }
        
        // Load dữ liệu
        private void LoadData(string s)
        {
            dgrd_ctsp.Height = 40;
            dgrd_ctsp.ColumnCount = 14;
            dgrd_ctsp.Rows.Clear();
            dgrd_ctsp.Columns[0].Name = "Id";
            dgrd_ctsp.Columns[0].Visible = false;
            dgrd_ctsp.Columns[1].Name = "Mã SP";
            dgrd_ctsp.Columns[2].Name = "Sản phẩm";
            dgrd_ctsp.Columns[3].Name = "Nhà sản xuất";
            dgrd_ctsp.Columns[4].Name = "Màu sắc";
            dgrd_ctsp.Columns[5].Name = "Loại sản phẩm";
            dgrd_ctsp.Columns[6].Name = "Kích thước";
            dgrd_ctsp.Columns[7].Name = "Chất liệu";
            dgrd_ctsp.Columns[8].Name = "Ảnh";
            dgrd_ctsp.Columns[9].Name = "Mô tả";
            dgrd_ctsp.Columns[10].Name = "Số lượng tồn";
            dgrd_ctsp.Columns[11].Name = "Giá nhập";
            dgrd_ctsp.Columns[12].Name = "Giá bán";
            dgrd_ctsp.Columns[13].Name = "Trạng thái";
            dgrd_ctsp.Rows.Clear();
            foreach (var x in _iqLChiTietSpServices.GetAllView(s))
            {
                dgrd_ctsp.Rows.Add(x.Id,x.Ma, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu,x.Anh,x.MoTa,x.SoLuongTon, x.GiaNhap, x.GiaBan, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
       
        // Load thuộc tính
        private void LoadSanPham()
        {
            cmb_sp.Items.Clear();
            if (_iqlSanPhamServices.GetAll().Count == 0) return;
            {
                foreach (var x in _iqlSanPhamServices.GetAll())
                {
                    cmb_sp.Items.Add(x.Ten);
                }
                cmb_sp.SelectedIndex = -1;
            }
        }
        private void LoadNSX()
        { 
            cmb_nsx.Items.Clear();
            if (_iqlNsxServices.GetAll().Count == 0) return;
            foreach (var x in _iqlNsxServices.GetAll())
            {
                cmb_nsx.Items.Add(x.Ten);
            }
            cmb_nsx.SelectedIndex = -1;
        }
        private void LoadMauSac()
        {
            cmb_mausac.Items.Clear();
            if (_iqlMauSacServices.GetAll().Count == 0) return;
            foreach (var x in _iqlMauSacServices.GetAll())
            {
                cmb_mausac.Items.Add(x.Ten);
            }
            cmb_mausac.SelectedIndex = -1;
        }
        private void LoadChatLieu()
        {
            cmb_chatlieu.Items.Clear();
            if (_iqLChatLieuServices.GetAll().Count == 0) return;
            foreach (var x in _iqLChatLieuServices.GetAll())
            {
                cmb_chatlieu.Items.Add(x.Ten);
            }
            cmb_chatlieu.SelectedIndex = -1;
        }
        private void LoadKichThuoc()
        {
            cmb_kichthuoc.Items.Clear();
            if (_iqlLKichThuocServices.GetAll().Count == 0) return;
            foreach (var x in _iqlLKichThuocServices.GetAll())
            {
                cmb_kichthuoc.Items.Add(x.Size);
            }
            cmb_kichthuoc.SelectedIndex = -1;
        }
        private void LoadLoaiSP()
        {
            cmb_loaisp.Items.Clear();
            List<LoaiSp> _lstlsp = _iqLLoaiSpServices.GetAll().Where(c=> c.MaLoaiSpcha != null).ToList();
            if (_lstlsp.Count == 0) return;
            foreach (var x in _lstlsp)
            {
                cmb_loaisp.Items.Add(x.Ten);
            }
            cmb_loaisp.SelectedIndex = -1;
        }
        //Lấy data từ controls
        private ChiTietSp GetDataFromGUI()
        {
            ChiTietSp ctsp = new ChiTietSp();
            ctsp.Id = _id;
            ctsp.IdSp = _iqlSanPhamServices.GetAll().First(c=> c.Ten == cmb_sp.Text).Id;
            ctsp.IdMauSac = _iqlMauSacServices.GetAll().First(c => c.Ten == cmb_mausac.Text).Id;
            ctsp.IdClieu = _iqLChatLieuServices.GetAll().First(c => c.Ten == cmb_chatlieu.Text).Id;
            ctsp.IdNsx = _iqlNsxServices.GetAll().First(c => c.Ten == cmb_nsx.Text).Id;
            ctsp.IdKt = _iqlLKichThuocServices.GetAll().First(c => c.Size == cmb_kichthuoc.Text).Id;
            ctsp.IdLoaiSp = _iqLLoaiSpServices.GetAll().First(c => c.Ten == cmb_loaisp.Text).Id;
            ctsp.MoTa = tbx_mota.Text;
            ctsp.GiaBan = Convert.ToDecimal(tbx_giaban.Text);
            ctsp.GiaNhap = Convert.ToDecimal(tbx_gianhap.Text);
            ctsp.SoLuongTon = Convert.ToInt32(tbx_soluong.Text);
            ctsp.Ma = tbx_masp.Text;
            //Ảnh
            if (pic_anhsp.Image == null)
            {
                ctsp.Anh = null;
            }else
            {
                MemoryStream stream = new MemoryStream();
                pic_anhsp.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                ctsp.Anh = stream.ToArray();
            } 
            
            if (rbtn_hd.Checked == true)
            {
                ctsp.TrangThai = 1;
            }
            else if (rbtn_kohd.Checked == true)
            {
                ctsp.TrangThai = 0;
            }
            if(pic_anhsp.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pic_anhsp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                ctsp.Anh = data;
            }           
            return ctsp;
        }
        // CRUD
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cmb_sp.Text == "" || cmb_nsx.Text == "" || cmb_mausac.Text == "" || cmb_loaisp.Text == "" || cmb_kichthuoc.Text == "" || cmb_chatlieu.Text == "" || tbx_giaban.Text == "" || tbx_gianhap.Text == "" || tbx_soluong.Text == "")
            {
                MessageBox.Show("Thuộc tính sản phẩm, giá nhập, giá bán, số lượng tồn không được để trống");
            }
            if (Convert.ToDecimal(tbx_giaban.Text) < Convert.ToDecimal(tbx_gianhap.Text))
            {
                MessageBox.Show("Giá bán phải lớn hơn giá nhập");
            }
            if (_iqLChiTietSpServices.GetAllView().Any(c => c.Ma == tbx_masp.Text))
            {
                MessageBox.Show("Sản phẩm bạn nhập đã tồn tại trong ứng dụng");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLChiTietSpServices.Add(GetDataFromGUI()));
                }
                LoadData(null);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_iqLChiTietSpServices.Update(GetDataFromGUI()));

            }
            LoadData(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_iqLChiTietSpServices.Delete(GetDataFromGUI()));
            }
            LoadData(null);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_sp.SelectedIndex = 0;
            cmb_chatlieu.SelectedIndex = 0;
            cmb_nsx.SelectedIndex = 0;
            cmb_mausac.SelectedIndex = 0;
            cmb_kichthuoc.SelectedIndex = 0;
            cmb_loaisp.SelectedIndex = 0;
            tbx_masp.Text = "";
            tbx_giaban.Text = "";
            tbx_gianhap.Text = "";
            tbx_mota.Text = "";
            tbx_soluong.Text = "";
            pic_anhsp.Image = null;
            LoadData(null);

        }
        // Cell click
        private void dgrd_ctsp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex <_iqLChiTietSpServices.GetAllView().Count)
            {
                var row = dgrd_ctsp.Rows[rowIndex];
                ChiTietSp ctsp = _iqLChiTietSpServices.GetAll().First(c => c.Id == Guid.Parse(row.Cells[0].Value.ToString()));
                SanPham sp = _iqlSanPhamServices.GetAll().First(c => c.Id == ctsp.IdSp);
                MauSac ms = _iqlMauSacServices.GetAll().First(c => c.Id == ctsp.IdMauSac);
                KichThuoc kt = _iqlLKichThuocServices.GetAll().First(c => c.Id == ctsp.IdKt);
                LoaiSp lsp = _iqLLoaiSpServices.GetAll().First(c => c.Id == ctsp.IdLoaiSp);
                Nsx nsx = _iqlNsxServices.GetAll().First(c => c.Id == ctsp.IdNsx);
                ChatLieu cl = _iqLChatLieuServices.GetAll().First(c => c.Id == ctsp.IdClieu);
                _id = ctsp.Id;
                tbx_masp.Text = ctsp.Ma;
                cmb_sp.Text = sp.Ten;
                cmb_mausac.Text = ms.Ten;
                cmb_kichthuoc.Text = kt.Size;
                cmb_loaisp.Text = lsp.Ten;
                cmb_nsx.Text = nsx.Ten;
                cmb_chatlieu.Text = cl.Ten;
                tbx_mota.Text = ctsp.MoTa;
                tbx_soluong.Text = ctsp.SoLuongTon.ToString();
                tbx_gianhap.Text = ctsp.GiaNhap.ToString();
                tbx_giaban.Text = ctsp.GiaBan.ToString();
                //ẢNh
                if (ctsp.Anh == null)
                {
                    pic_anhsp.Image = null;
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream(ctsp.Anh.ToArray());
                    Image img = Image.FromStream(memoryStream);
                    if (img == null) return;
                    pic_anhsp.Image = img;
                }
                if (ctsp.TrangThai == 1)
                {
                    rbtn_hd.Checked = true;
                }
                else if (ctsp.TrangThai == 0)
                {
                    rbtn_kohd.Checked = true;
                }
            }
        }
        // Thêm nhanh các thuộc tính
        private void Frm_ChiTietSanPham_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pic_themnhanhsp, "Thêm nhanh");
            toolTip.SetToolTip(pic_themnhanhnsx, "Thêm nhanh");
            toolTip.SetToolTip(pic_themnhanhchatlieu, "Thêm nhanh");
            toolTip.SetToolTip(pic_themnhanhkichthuoc, "Thêm nhanh");
            toolTip.SetToolTip(pic_themnhanhloaisp, "Thêm nhanh");
            toolTip.SetToolTip(pic_themnhanhmausac, "Thêm nhanh");
            toolTip.SetToolTip(pic_anhsp, "CLick để thêm ảnh");
            pic_anhsp.AllowDrop = true;
        }
        void ThemNhanhSP(string s)
        {
            LoadSanPham();
            cmb_sp.Text = s;
        }
        private void pic_themnhanhsp_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Frm_ThemNhanhSP form = new Frm_ThemNhanhSP();
            form.Themsp = new Frm_ThemNhanhSP.ADDSP(ThemNhanhSP);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        void ThemNhanhNSX(string s)
        {
            LoadNSX();
            cmb_nsx.Text = s;
        }
        private void pic_themnhanhnsx_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhNSX form = new Frm_ThemNhanhNSX();
            form.Themnsx = new Frm_ThemNhanhNSX.ADDNSX(ThemNhanhNSX);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        void ThemNhanhMauSac(string s)
        {
            LoadMauSac();
            cmb_mausac.Text = s;
        }
        private void pic_themnhanhmausac_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhMauSac form = new Frm_ThemNhanhMauSac();
            form.Themms = new Frm_ThemNhanhMauSac.AddMauSac(ThemNhanhMauSac);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        void ThemNhanhLSP(string s)
        {
            LoadLoaiSP();
            cmb_loaisp.Text = s;
        }
        private void pic_themnhanhloaisp_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhLoaiSP form = new Frm_ThemNhanhLoaiSP();
            form.Themlsp = new Frm_ThemNhanhLoaiSP.ADDLoaiSP(ThemNhanhLSP);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        void ThemNhanhKichThuoc(string s)
        {
            LoadKichThuoc();
            cmb_kichthuoc.Text = s;
        }
        private void pic_themnhanhkichthuoc_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhKichThuoc form = new Frm_ThemNhanhKichThuoc();
            form.ThemKichThuoc = new Frm_ThemNhanhKichThuoc.AddKichThuoc(ThemNhanhKichThuoc);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        void ThemNhanhChatLieu(string s)
        {
            LoadChatLieu();
            cmb_chatlieu.Text = s;
        }
        private void pic_themnhanhchatlieu_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhChatLieu form = new Frm_ThemNhanhChatLieu();
            form.ThemChatLieu = new Frm_ThemNhanhChatLieu.AddChatLieu(ThemNhanhChatLieu);
            form.TopMost = true;
            form.BringToFront();
            form.ShowDialog();
        }
        // Xóa bằng nháy phải trên datagrid view
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    DataGridViewRow dataGrid = dgrd_ctsp.CurrentRow;
                    ChiTietSp ctsp = _iqLChiTietSpServices.GetAll().First(c => c.Id == Guid.Parse(dataGrid.Cells[0].Value.ToString()));
                    MessageBox.Show(_iqLChiTietSpServices.Delete(ctsp));
                    LoadData(null);
                }
            }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OKCancel);
                }
}
        // Tìm kiếm theo combox 
        private void LoadTimKiem()
        {
            cmb_timkiem.Items.Add("Sản Phẩm");
            cmb_timkiem.Items.Add("Nhà sản xuất");
            cmb_timkiem.Items.Add("Màu sắc");
            cmb_timkiem.Items.Add("Loại sản phẩm");
            cmb_timkiem.Items.Add("Chất liệu");
            cmb_timkiem.Items.Add("Kích thước");
        }

        private void cmb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cmb_timkiem.Text == "Sản Phẩm")
            { 
                if (_iqlSanPhamServices.GetAll().Count == 0) return;
                {
                    cmb_thanhphan.Items.Clear();
                    foreach (var x in _iqlSanPhamServices.GetAll())
                    {
                        cmb_thanhphan.Items.Add(x.Ten);
                    }
                    cmb_thanhphan.SelectedIndex = -1;
                }
            }else if(cmb_timkiem.Text == "Nhà sản xuất")
            {
                if (_iqlNsxServices.GetAll().Count == 0) return;
                cmb_thanhphan.Items.Clear();
                foreach (var x in _iqlNsxServices.GetAll())
                {
                    cmb_thanhphan.Items.Add(x.Ten);
                }
                cmb_thanhphan.SelectedIndex = -1;
            }else if(cmb_timkiem.Text == "Màu sắc")
            {
                if (_iqlMauSacServices.GetAll().Count == 0) return;
                cmb_thanhphan.Items.Clear();
                foreach (var x in _iqlMauSacServices.GetAll())
                {
                    cmb_thanhphan.Items.Add(x.Ten);
                }
                cmb_thanhphan.SelectedIndex = -1;
            }
            else if(cmb_timkiem.Text == "Loại sản phẩm")
            {
                List<LoaiSp> _lstlsp = _iqLLoaiSpServices.GetAll().Where(c => c.MaLoaiSpcha != null).ToList();
                if (_lstlsp.Count == 0) return;
                cmb_thanhphan.Items.Clear();
                foreach (var x in _lstlsp)
                {
                    cmb_thanhphan.Items.Add(x.Ten);
                }
                cmb_thanhphan.SelectedIndex = -1;
            }
            else if(cmb_timkiem.Text == "Kích thước")
            {
                if (_iqlLKichThuocServices.GetAll().Count == 0) return;
                cmb_thanhphan.Items.Clear();
                foreach (var x in _iqlLKichThuocServices.GetAll())
                {
                    cmb_thanhphan.Items.Add(x.Size);
                }
                cmb_thanhphan.SelectedIndex = -1;
            }
            else if(cmb_timkiem.Text == "Chất liệu") 
            {
                if (_iqLChatLieuServices.GetAll().Count == 0) return;
                cmb_thanhphan.Items.Clear();
                foreach (var x in _iqLChatLieuServices.GetAll())
                {
                    cmb_thanhphan.Items.Add(x.Ten);
                }
                cmb_thanhphan.SelectedIndex = -1;
            }

            cmb_thanhphan_TextChanged(sender, e);
        }

        private void cmb_thanhphan_TextChanged(object sender, EventArgs e)
        {
            LoadData(cmb_thanhphan.Text);
        }
        //Lọc theo giá bán
        private void pic_locgia_Click(object sender, EventArgs e)
        {
            var list = _iqLChiTietSpServices.GetAllView().Where(c => c.GiaBan >= Convert.ToDecimal(tbx_min.Text) && c.GiaBan <= Convert.ToDecimal(tbx_max.Text)).ToList();
            dgrd_ctsp.Height = 35;
            dgrd_ctsp.ColumnCount = 13;
            dgrd_ctsp.Rows.Clear();
            dgrd_ctsp.Columns[0].Name = "Id";
            dgrd_ctsp.Columns[0].Visible = false;
            dgrd_ctsp.Columns[1].Name = "Sản phẩm";
            dgrd_ctsp.Columns[2].Name = "Nhà sản xuất";
            dgrd_ctsp.Columns[3].Name = "Màu sắc";
            dgrd_ctsp.Columns[4].Name = "Loại sản phẩm";
            dgrd_ctsp.Columns[5].Name = "Kích thước";
            dgrd_ctsp.Columns[6].Name = "Chất liệu";
            dgrd_ctsp.Columns[7].Name = "Ảnh";
            dgrd_ctsp.Columns[8].Name = "Mô tả";
            dgrd_ctsp.Columns[9].Name = "Số lượng tồn";
            dgrd_ctsp.Columns[10].Name = "Giá nhập";
            dgrd_ctsp.Columns[11].Name = "Giá bán";
            dgrd_ctsp.Columns[12].Name = "Trạng thái";
            dgrd_ctsp.Rows.Clear();
            foreach (var x in list)
            {
                dgrd_ctsp.Rows.Add(x.Id, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.Anh, x.MoTa, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void pic_anhsp_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var filename = data as string[];
                    if (filename.Length > 0 && filename.Length < 512000)
                    {
                        pic_anhsp.Image = Image.FromFile(filename[0]);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void pic_anhsp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pic_anhsp_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pic_anhsp.Image = Image.FromFile(opf.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmb_sp_SelectedValueChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text,cmb_nsx.Text,cmb_mausac.Text, cmb_loaisp.Text,cmb_kichthuoc.Text,cmb_chatlieu.Text);
        }

        private void cmb_nsx_SelectedValueChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text, cmb_nsx.Text, cmb_mausac.Text, cmb_loaisp.Text, cmb_kichthuoc.Text, cmb_chatlieu.Text);
        }

        private void cmb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text, cmb_nsx.Text, cmb_mausac.Text, cmb_loaisp.Text, cmb_kichthuoc.Text, cmb_chatlieu.Text);
        }

        private void cmb_loaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text, cmb_nsx.Text, cmb_mausac.Text, cmb_loaisp.Text, cmb_kichthuoc.Text, cmb_chatlieu.Text);
        }

        private void cmb_kichthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text, cmb_nsx.Text, cmb_mausac.Text, cmb_loaisp.Text, cmb_kichthuoc.Text, cmb_chatlieu.Text);
        }

        private void cmb_chatlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_masp.Text = MaSP(cmb_sp.Text, cmb_nsx.Text, cmb_mausac.Text, cmb_loaisp.Text, cmb_kichthuoc.Text, cmb_chatlieu.Text);
        }
        //Mã SP
        private string MaSP(string sp, string nsx, string mausac, string lsp, string kt, string cl)
        {
            string masp = cmb_sp.Text == "" ? "" : _iqlSanPhamServices.GetAll().First(c => c.Ten == cmb_sp.Text).Ma;
            string mansx = cmb_nsx.Text == "" ? "" : _iqlNsxServices.GetAll().First(c => c.Ten == cmb_nsx.Text).Ma;
            string mamsac = cmb_mausac.Text == "" ? "" : _iqlMauSacServices.GetAll().First(c => c.Ten == cmb_mausac.Text).Ten;
            string malsp = cmb_loaisp.Text == "" ? "" : _iqLLoaiSpServices.GetAll().First(c => c.Ten == cmb_loaisp.Text).Ten;
            string makt = cmb_kichthuoc.Text == "" ? "" : _iqlLKichThuocServices.GetAll().First(c => c.Size == cmb_kichthuoc.Text).Size;
            string macl = cmb_chatlieu.Text == "" ? "" : _iqLChatLieuServices.GetAll().First(c => c.Ten == cmb_chatlieu.Text).Ten;
            mamsac = mamsac == "" ? "" : mamsac.Substring(0, 2);
            malsp = malsp == "" ? "" : malsp.Substring(0, 2);
            macl = macl == "" ? "" : macl.Substring(0, 2);
            string mactsp = masp + "/" + mansx + "/" + mamsac + "/" + malsp + "/" + makt + "/" + macl;
            mactsp = mactsp.Trim();
            return mactsp;
        }

        private void tbx_gianhap_Leave(object sender, EventArgs e)
        {
            if (Utilities.Utility.IsNumber(tbx_gianhap.Text) == false)
            {
                MessageBox.Show("Giá nhập phải là số");
            }
        }

        private void tbx_giaban_Leave(object sender, EventArgs e)
        {
            if (Utilities.Utility.IsNumber(tbx_giaban.Text) == false)
            {
                MessageBox.Show("Giá bán phải là số");
            }
        }

        private void tbx_soluong_Leave(object sender, EventArgs e)
        {
            if (Utilities.Utility.IsNumber(tbx_soluong.Text) == false)
            {
                MessageBox.Show("Số lượng tồn phải là số");
            }
        }
    }
}
