using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
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
    public partial class Frm_KichThuoc : Form
    {
        private IQLKichThuocServices _iqlkichThuocServices;
        private Guid _id;
        public Frm_KichThuoc()
        {
            _iqlkichThuocServices = new QLKichThuocServices();
            InitializeComponent();
        }
        private void LoadData()
        {
            dtg_KichThuoc.Rows.Clear();
            dtg_KichThuoc.ColumnCount = 4;
            dtg_KichThuoc.Columns[0].Name = "ID";
            dtg_KichThuoc.Columns[0].Width = 385;
            dtg_KichThuoc.Columns[1].Name = "Mã";
            dtg_KichThuoc.Columns[2].Name = "Size";
            dtg_KichThuoc.Columns[3].Name = "Trạng thái";
            foreach (var x in _iqlkichThuocServices.GetAll())
            {
                dtg_KichThuoc.Rows.Add(x.Id, x.Ma, x.Size, x.TrangThai == 1? "Còn hàng" : "Hết hàng");
            }
        }
        private KichThuoc GetDataFromGUI()
        {
            KichThuoc kt = new KichThuoc();
            kt.Id = _id;
            kt.Ma = tb_ma.Text;
            kt.Size = tb_size.Text;
            if (rbtn_conhang.Checked == true)
            {
                kt.TrangThai = 1;
            }
            else if (rbtn_hethang.Checked == true)
            {
                kt.TrangThai = 0;
            }
            return kt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if (_iqlkichThuocServices.GetAll().Any(p => p.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã kích thước đã tồn tại!");
                }else if (tb_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã kích thước không được để trống!");
                }
                else if (tb_size.Text.Trim() == "")
                {
                    MessageBox.Show("kích thước không được để trống!");
                }
                else if (_iqlkichThuocServices.GetAll().Any(p => p.Size == tb_size.Text))
                {
                    MessageBox.Show("kích thước đã tồn tại!");
                }
                else if (rbtn_conhang.Checked == false && rbtn_hethang.Checked)
                {
                    MessageBox.Show("Trạng thái kích thước không được bỏ trống!");
                }
                else
                {
                    _iqlkichThuocServices.Add(GetDataFromGUI());
                    LoadData();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqlkichThuocServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqlkichThuocServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_ma.Text = "";
            tb_size.Text = "";
            rbtn_conhang.Checked = false;
            rbtn_hethang.Checked = false;
            LoadData();
        }

        private void dtg_KichThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var kt = _iqlkichThuocServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_KichThuoc.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = kt.Id;
            tb_ma.Text = kt.Ma;
            tb_size.Text = kt.Size;
            if (kt.TrangThai == 1)
            {
                rbtn_conhang.Checked = true;
            }
            else if (kt.TrangThai == 0)
            {
                rbtn_hethang.Checked = true;
            }
        }

        private void Frm_KichThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
            rbtn_conhang.Checked = true;
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_timkiem.Text == "Tìm kiếm theo mã")
            {
                var tk = _iqlkichThuocServices.GetAll().Where(p => p.Ma == tb_timkiem.Text);
                dtg_KichThuoc.Rows.Clear();
                dtg_KichThuoc.ColumnCount = 4;
                dtg_KichThuoc.Columns[0].Name = "ID";
                dtg_KichThuoc.Columns[0].Width = 385;
                dtg_KichThuoc.Columns[1].Name = "Mã";
                dtg_KichThuoc.Columns[2].Name = "Size";
                dtg_KichThuoc.Columns[3].Name = "Trạng thái";
                foreach (var x in tk)
                {
                    dtg_KichThuoc.Rows.Add(x.Id, x.Ma, x.Size, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
                }
            }else if (cbb_timkiem.Text == "Tìm kiếm theo size")
            {
                var tk = _iqlkichThuocServices.GetAll().Where(p => p.Size == tb_timkiem.Text);
                dtg_KichThuoc.Rows.Clear();
                dtg_KichThuoc.ColumnCount = 4;
                dtg_KichThuoc.Columns[0].Name = "ID";
                dtg_KichThuoc.Columns[0].Width = 385;
                dtg_KichThuoc.Columns[1].Name = "Mã";
                dtg_KichThuoc.Columns[2].Name = "Size";
                dtg_KichThuoc.Columns[3].Name = "Trạng thái";
                foreach (var x in tk)
                {
                    dtg_KichThuoc.Rows.Add(x.Id, x.Ma, x.Size, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
                }
            }
        }

        private void tb_timkiem_Leave(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
