using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Repositories;
using _1.DAL.IRepositories;
using _2.BUS.Services;
using _2.BUS.IServices;
using _1.DAL.DomainClass;
namespace _3.PL.Views
{
    public partial class Frm_SanPham : Form
    {
        private IQLSanPhamServices _iqLSanPhamServices;
        private Guid _id;
        public Frm_SanPham()
        {
            InitializeComponent();
            _iqLSanPhamServices = new QLSanPhamServices();
            LoadData();
        }
        private void LoadData()
        {
            dgrd_sanpham.ColumnCount = 5;
            dgrd_sanpham.Columns[0].Name = "ID";
            dgrd_sanpham.Columns[1].Name = "Mã";
            dgrd_sanpham.Columns[2].Name = "Tên";
            dgrd_sanpham.Columns[3].Name = "Mô tả";
            dgrd_sanpham.Columns[4].Name = "Trạng thái";
            dgrd_sanpham.Rows.Clear();
            foreach (var x in _iqLSanPhamServices.GetAll())
            {
                dgrd_sanpham.Rows.Add(x.Id, x.Ma, x.Ten, x.MoTa, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private SanPham GetDataFromGUI()
        {
            SanPham sp = new SanPham();
            sp.Id = _id;
            sp.Ma = tbx_ma.Text;
            sp.Ten = tbx_ten.Text;
            sp.MoTa = tbx_mota.Text;
            if (rbtn_hd.Checked == true)
            {
                sp.TrangThai = 1;
            }
            else if (rbtn_kohd.Checked == true)
            {
                sp.TrangThai = 0;
            }
            return sp;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLSanPhamServices.Add(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLSanPhamServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLSanPhamServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_ma.Text = "";
            tbx_ten.Text = "";
            tbx_mota.Text = "";
            rbtn_hd.Checked = true;
            LoadData();
        }

        private void dgrd_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var sp = _iqLSanPhamServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgrd_sanpham.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = sp.Id;
            tbx_ma.Text = sp.Ma;
            tbx_ten.Text = sp.Ten;
            tbx_mota.Text = sp.MoTa;
            if (sp.TrangThai == 1)
            {
                rbtn_hd.Checked = true;
            }
            else if (sp.TrangThai == 0)
            {
                rbtn_kohd.Checked = true;
            }
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
