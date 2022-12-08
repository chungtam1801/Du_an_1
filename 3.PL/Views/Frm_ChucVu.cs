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
    public partial class Frm_ChucVu : Form
    {
        private IQLChucVuServices _iqLcvServices;
        private Guid _id;
        public Frm_ChucVu()
        {
            InitializeComponent();
            _iqLcvServices = new QLChucVuServices();
            LoadData();
        }

        private void LoadData()
        {
            dgvChucVu.ColumnCount = 4;
            dgvChucVu.Columns[0].Name = "ID";
            dgvChucVu.Columns[0].Visible = false;
            dgvChucVu.Columns[1].Name = "Mã";
            dgvChucVu.Columns[2].Name = "Tên";
            dgvChucVu.Columns[3].Name = "Trạng thái";
            dgvChucVu.Rows.Clear();
            foreach (var x in _iqLcvServices.GetAll())
            {
                dgvChucVu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private ChucVu GetDataFromGUI()
        {
            ChucVu cv = new ChucVu();
            cv.Id = _id;
            cv.Ma = txtMa.Text;
            cv.Ten = txtTen.Text;
            if (rbtn_hd.Checked == true)
            {
                cv.TrangThai = 1;
            }
            else if (rbtn_kohd.Checked == true)
            {
                cv.TrangThai = 0;
            }
            return cv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mã!!!");
            }
            else if (txtTen.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập tên!!!");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    _iqLcvServices.Add(GetDataFromGUI());
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLcvServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLcvServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            rbtn_hd.Checked = true;
            LoadData();
        }
        

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var cv = _iqLcvServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgvChucVu.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = cv.Id;
            txtMa.Text = cv.Ma;
            txtTen.Text = cv.Ten;

            if (cv.TrangThai == 1)
            {
                rbtn_hd.Checked = true;
            }
            else if (cv.TrangThai == 0)
            {
                rbtn_kohd.Checked = true;
            }
        }
    }
}
