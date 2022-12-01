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
    public partial class Frm_ChatLieu : Form
    {
        private IQLChatLieuServices _iqLclServices;
        private Guid _id;
        public Frm_ChatLieu()
        {
            InitializeComponent();
            _iqLclServices = new QLChatLieuServices();
            LoadData();
        }

        private void LoadData()
        {
            dgvChatLieu.ColumnCount = 4;
            dgvChatLieu.Columns[0].Name = "ID";
            dgvChatLieu.Columns[0].Width = 385;
            dgvChatLieu.Columns[1].Name = "Mã";
            dgvChatLieu.Columns[2].Name = "Tên";
            dgvChatLieu.Columns[3].Name = "Trạng thái";
            dgvChatLieu.Rows.Clear();
            foreach (var x in _iqLclServices.GetAll())
            {
                dgvChatLieu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private ChatLieu GetDataFromGUI()
        {
            ChatLieu cl = new ChatLieu();
            cl.Id = _id;
            cl.Ma = txtMa.Text;
            cl.Ten = txtTen.Text;
            if (rbtn_hd.Checked == true)
            {
                cl.TrangThai = 1;
            }
            else if (rbtn_kohd.Checked == true)
            {
                cl.TrangThai = 0;
            }
            return cl;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
           
             if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
                {
                    if (txtMa.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã chất liệu không được bỏ trống!");
                    }
                    else if (_iqLclServices.GetAll().Any(p => p.Ma == txtMa.Text))
                    {
                        MessageBox.Show("Mã chất liệu đã tồn tại!");
                    }

                    else if (txtTen.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên chất liệu không được bỏ trống!");
                    }

                    else if (rbtn_hd.Checked == false && rbtn_kohd.Checked == false)
                    {
                        MessageBox.Show("Trạng thái chất liệu không được bỏ trống!");
                    }
                    else
                    {
                        _iqLclServices.Add(GetDataFromGUI());
                        LoadData();
                    }
             }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLclServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLclServices.Delete(GetDataFromGUI());
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

        private void dgrd_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var cl = _iqLclServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgvChatLieu.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = cl.Id;
            txtMa.Text = cl.Ma;
            txtTen.Text = cl.Ten;
            
            if (cl.TrangThai == 1)
            {
                rbtn_hd.Checked = true;
            }
            else if (cl.TrangThai == 0)
            {
                rbtn_kohd.Checked = true;
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLclServices.Add(GetDataFromGUI());
                LoadData();
            }
        }

        private void tk_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_timkiem.Text == "Tìm kiếm theo mã")
            {
                var tk = _iqLclServices.GetAll().Where(p => p.Ma == cbb_timkiem.Text);
                dgvChatLieu.Rows.Clear();
                dgvChatLieu.ColumnCount = 4;
                dgvChatLieu.Columns[0].Name = "ID";
                dgvChatLieu.Columns[0].Width = 385;
                dgvChatLieu.Columns[1].Name = "Mã";
                dgvChatLieu.Columns[2].Name = "Tên";
                dgvChatLieu.Columns[3].Name = "Trạng thái";
                foreach (var x in tk)
                {
                    dgvChatLieu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo Ten")
            {
                var tk = _iqLclServices.GetAll().Where(p => p.Ten == cbb_timkiem.Text);
                dgvChatLieu.Rows.Clear();
                dgvChatLieu.ColumnCount = 4;
                dgvChatLieu.Columns[0].Name = "ID";
                dgvChatLieu.Columns[0].Width = 385;
                dgvChatLieu.Columns[1].Name = "Mã";
                dgvChatLieu.Columns[2].Name = "Tên";
                dgvChatLieu.Columns[3].Name = "Trạng thái";
                foreach (var x in tk)
                {
                    dgvChatLieu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }

            }
        }
    }
}

