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
        private IQLNsxServices _iqLNsxServices;
        private Guid _id;
        public Frm_NSX()
        {
            InitializeComponent();
            _iqLNsxServices = new QLNsxServices();
            tbx_ma.Enabled = false;
            tbx_ma.Text = MaTuSinh();
            LoadData(null);
        }

        private void LoadData(string s)
        {
            dgrd_nsx.ColumnCount = 5;
            dgrd_nsx.Columns[0].Name = "ID";
            dgrd_nsx.Columns[0].Visible = false;
            dgrd_nsx.Columns[1].Name = "Mã";
            dgrd_nsx.Columns[2].Name = "Tên";
            dgrd_nsx.Columns[3].Name = "Địa chỉ";
            dgrd_nsx.Columns[4].Name = "Trạng thái";
            dgrd_nsx.Rows.Clear();
            foreach(var x in _iqLNsxServices.GetAll(s))
            {
                dgrd_nsx.Rows.Add(x.Id,x.Ma,x.Ten, x.DiaChi,x.TrangThai == 1? "Hoạt động" : "Không hoạt động");
            }
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iqLNsxServices.GetAll().Count; i++)
            {
                string ma = _iqLNsxServices.GetAll()[i].Ma;
                string so = ma.Substring(3);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "NSX00" + (max + 1);
            return s;
        }
        private Nsx GetDataFromGUI()
        {
            Nsx nsx = new Nsx();
            nsx.Id = _id;
            nsx.Ma = MaTuSinh();
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
            if(tbx_ten.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLNsxServices.Add(GetDataFromGUI()));
                    LoadData(null);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên nhà sản xuất");
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_iqLNsxServices.Update(GetDataFromGUI()));
                LoadData(null);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
                {
                    MessageBox.Show(_iqLNsxServices.Delete(GetDataFromGUI()));
                    LoadData(null);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Nhà sản xuất này vẫn còn dữ liệu với sản phẩm");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_ma.Text = MaTuSinh();
            tbx_ten.Text = "";
            tbx_diachi.Text = "";
            rbtn_hd.Checked = true;
            LoadData(null);
        }

        private void dgrd_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >=0 && rowIndex < _iqLNsxServices.GetAll().Count)
            {
                var nsx = _iqLNsxServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgrd_nsx.Rows[rowIndex].Cells[0].Value.ToString()));
                _id = nsx.Id;
                tbx_ma.Text = nsx.Ma;
                tbx_ten.Text = nsx.Ten;
                tbx_diachi.Text = nsx.DiaChi;
                if (nsx.TrangThai == 1)
                {
                    rbtn_hd.Checked = true;
                }
                else if (nsx.TrangThai == 0)
                {
                    rbtn_kohd.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Ngoài vùng dữ liệu");
            }
        }

        private void tbx_timkiem_Click(object sender, EventArgs e)
        {
            tbx_timkiem.Text = "";
        }

        private void tbx_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbx_timkiem.Text);
        }

        private void tbx_timkiem_Leave(object sender, EventArgs e)
        {
            tbx_timkiem.Text = "";
            tbx_timkiem.PlaceholderText = "   Tìm kiếm nhà sản xuất theo tên";
            LoadData(null);
        }
    }
}
