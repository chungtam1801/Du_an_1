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
    public partial class Frm_MauSac : Form
    {
        private IMauSacRepository _imsRepository;
        private IQLMauSacServices _iqLmsServices;
        private Guid _id;
        public Frm_MauSac()
        {
            InitializeComponent();
            _imsRepository = new MauSacRepository();
            _iqLmsServices = new QLMauSacServices();
            LoadData();
        }

        private void LoadData()
        {
            dgrd_mausac.ColumnCount = 4;
            dgrd_mausac.Columns[0].Name = "ID";
            dgrd_mausac.Columns[1].Name = "Mã";
            dgrd_mausac.Columns[2].Name = "Tên";
            dgrd_mausac.Columns[3].Name = "Trạng thái";
            dgrd_mausac.Rows.Clear();
            foreach (var x in _iqLmsServices.GetAll())
            {
                dgrd_mausac.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private MauSac GetDataFromGUI()
        {
            MauSac ms = new MauSac();
            ms.Id = _id;
            ms.Ma = tbx_ma.Text;
            ms.Ten = tbx_ten.Text;
            if (rbtn_hd.Checked == true)
            {
                ms.TrangThai = 1;
            }
            else if (rbtn_kohd.Checked == true)
            {
                ms.TrangThai = 0;
            }
            return ms;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLmsServices.Add(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLmsServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLmsServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_ma.Text = "";
            tbx_ten.Text = "";
            rbtn_hd.Checked = true;
            LoadData();
        }

        private void dgrd_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var ms = _iqLmsServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgrd_mausac.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = ms.Id;
            tbx_ma.Text = ms.Ma;
            tbx_ten.Text = ms.Ten;

            if (ms.TrangThai == 1)
            {
                rbtn_hd.Checked = true;
            }
            else if (ms.TrangThai == 0)
            {
                rbtn_kohd.Checked = true;
            }
        }
    }
}
