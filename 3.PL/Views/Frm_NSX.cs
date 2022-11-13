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
    public partial class Frm_NSX : Form
    {
        private INsxRepository _insxRepository;
        private IQLNsxServices _iqLNsxServices;
        private Guid _id;
        public Frm_NSX()
        {
            InitializeComponent();
            _insxRepository = new NsxRepository();
            _iqLNsxServices = new QLNsxServices();
            LoadData();
        }

        private void LoadData()
        {
            dgrd_nsx.ColumnCount = 5;
            dgrd_nsx.Columns[0].Name = "ID";
            dgrd_nsx.Columns[1].Name = "Mã";
            dgrd_nsx.Columns[2].Name = "Tên";
            dgrd_nsx.Columns[3].Name = "Địa chỉ";
            dgrd_nsx.Columns[4].Name = "Trạng thái";
            dgrd_nsx.Rows.Clear();
            foreach(var x in _iqLNsxServices.GetAll())
            {
                dgrd_nsx.Rows.Add(x.Id,x.Ma,x.Ten, x.DiaChi,x.TrangThai == 1? "Hoạt động" : "Không hoạt động");
            }
        }
        private Nsx GetDataFromGUI()
        {
            Nsx nsx = new Nsx();
            nsx.Id = _id;
            nsx.Ma = tbx_ma.Text;
            nsx.Ten = tbx_ten.Text;
            nsx.DiaChi =tbx_diachi.Text;
            if(rbtn_hd.Checked == true)
            {
                nsx.TrangThai = 1;
            }else if(rbtn_kohd.Checked == true)
            {
                nsx.TrangThai = 0;
            }
            return nsx;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLNsxServices.Add(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLNsxServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLNsxServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_ma.Text = "";
            tbx_ten.Text = "";
            tbx_diachi.Text = "";
            rbtn_hd.Checked = true;
            LoadData();
        }

        private void dgrd_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var nsx = _iqLNsxServices.GetAll().FirstOrDefault(c=> c.Id == Guid.Parse(dgrd_nsx.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = nsx.Id;
            tbx_ma.Text = nsx.Ma;
            tbx_ten.Text = nsx.Ten;
            tbx_diachi.Text = nsx.DiaChi;
            if(nsx.TrangThai == 1)
            {
                rbtn_hd.Checked = true;
            }else if(nsx.TrangThai == 0)
            {
                rbtn_kohd.Checked = true;
            }
        }
    }
}
