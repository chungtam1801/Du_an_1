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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

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
            LoadData();
            LoadSanPham();
            LoadChatLieu();
            LoadMauSac();
            LoadNSX();
            LoadKichThuoc();
            LoadLoaiSP();
        }
        private void LoadData()
        {
            dgrd_ctsp.ColumnCount = 12;
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
            dgrd_ctsp.Columns[7].Name = "Mô tả";
            dgrd_ctsp.Columns[8].Name = "Số lượng tồn";
            dgrd_ctsp.Columns[9].Name = "Giá nhập";
            dgrd_ctsp.Columns[10].Name = "Giá bán";
            dgrd_ctsp.Columns[11].Name = "Trạng thái";
            foreach (var x in _iqLChiTietSpServices.GetAllView())
            {
                dgrd_ctsp.Rows.Add(x.Id, x.Ten, x.Nsx, x.MauSac, x.LoaiSp, x.KichThuoc, x.ChatLieu, x.MoTa, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadSanPham()
        {
            foreach (var x in _iqlSanPhamServices.GetAll())
            {
                cmb_sp.Items.Add(x.Ten);
            }
            cmb_sp.SelectedIndex = 0;
        }
        private void LoadNSX()
        {
            foreach (var x in _iqlNsxServices.GetAll())
            {
                cmb_nsx.Items.Add(x.Ten);
            }
            cmb_nsx.SelectedIndex = 0;
        }
        private void LoadMauSac()
        {
            foreach (var x in _iqlMauSacServices.GetAll())
            {
                cmb_mausac.Items.Add(x.Ten);
            }
            cmb_mausac.SelectedIndex = 0;
        }
        private void LoadChatLieu()
        {
            foreach (var x in _iqLChatLieuServices.GetAll())
            {
                cmb_chatlieu.Items.Add(x.Ten);
            }
            cmb_chatlieu.SelectedIndex = 0;
        }
        private void LoadKichThuoc()
        {
            foreach (var x in _iqlLKichThuocServices.GetAll())
            {
                cmb_kichthuoc.Items.Add(x.Size);
            }
            cmb_kichthuoc.SelectedIndex = 0;
        }
        private void LoadLoaiSP()
        {
            foreach (var x in _iqLLoaiSpServices.GetAll())
            {
                cmb_loaisp.Items.Add(x.Ten);
            }
            cmb_loaisp.SelectedIndex = 0;
        }
        private ChiTietSp GetDataFromGUI()
        {
            ChiTietSp ctsp = new ChiTietSp();
            ctsp.Id = _id;
            ctsp.IdSp = _iqlSanPhamServices.GetAll()[cmb_sp.SelectedIndex].Id;
            ctsp.IdMauSac = _iqlMauSacServices.GetAll()[cmb_mausac.SelectedIndex].Id;
            ctsp.IdClieu = _iqLChatLieuServices.GetAll()[cmb_chatlieu.SelectedIndex].Id;
            ctsp.IdNsx = _iqlNsxServices.GetAll()[cmb_nsx.SelectedIndex].Id;
            ctsp.IdKt = _iqlLKichThuocServices.GetAll()[cmb_kichthuoc.SelectedIndex].Id;
            ctsp.IdLoaiSp = _iqLLoaiSpServices.GetAll()[cmb_loaisp.SelectedIndex].Id;
            ctsp.MoTa = tbx_mota.Text;
            ctsp.GiaBan = Convert.ToDecimal(tbx_giaban.Text);
            ctsp.GiaNhap = Convert.ToDecimal(tbx_gianhap.Text);
            ctsp.SoLuongTon = Convert.ToInt32(tbx_soluong.Text);
            //Ảnh
            if(pictureBox_spham.Image == null)
            {
                ctsp.Anh = null;
            }else
            {
                MemoryStream stream = new MemoryStream();
                pictureBox_spham.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            if(pictureBox_spham.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_spham.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                ctsp.Anh = data;
            }           
            return ctsp;
        }

        private void btn_openfile_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file)) return;
            Image myImage = Image.FromFile(file);
            pictureBox_spham.Image = myImage;
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLChiTietSpServices.Add(GetDataFromGUI());
            }
            LoadData();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLChiTietSpServices.Update(GetDataFromGUI());
            }
            LoadData();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLChiTietSpServices.Delete(GetDataFromGUI());
            }
            LoadData();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            LoadData();
            LoadSanPham();
            LoadChatLieu();
            LoadMauSac();
            LoadNSX();
            LoadKichThuoc(); _id = Guid.Empty;
            tbx_giaban.Text = "";
            tbx_gianhap.Text = "";
            tbx_mota.Text = "";
            tbx_soluong.Text = "";
            pictureBox_spham.Image = null;
            LoadData();
        }

        private void dgrd_ctsp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < _iqLChiTietSpServices.GetAllView().Count)
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
                cmb_sp.SelectedIndex = _iqlSanPhamServices.GetAll().IndexOf(sp);
                cmb_mausac.SelectedIndex = _iqlMauSacServices.GetAll().IndexOf(ms);
                cmb_kichthuoc.SelectedIndex = _iqlLKichThuocServices.GetAll().IndexOf(kt);
                cmb_loaisp.SelectedIndex = _iqLLoaiSpServices.GetAll().IndexOf(lsp);
                cmb_nsx.SelectedIndex = _iqlNsxServices.GetAll().IndexOf(nsx);
                cmb_chatlieu.SelectedIndex = _iqLChatLieuServices.GetAll().IndexOf(cl);
                tbx_mota.Text = ctsp.MoTa;
                tbx_soluong.Text = ctsp.SoLuongTon.ToString();
                tbx_gianhap.Text = ctsp.GiaNhap.ToString();
                tbx_giaban.Text = ctsp.GiaBan.ToString();
                //ẢNh
                if (ctsp.Anh == null)
                {
                    pictureBox_spham.Image = null;
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream(ctsp.Anh.ToArray());
                    Image img = Image.FromStream(memoryStream);
                    if (img == null) return;
                    pictureBox_spham.Image = img;

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

        private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
