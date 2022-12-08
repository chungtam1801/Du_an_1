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
using System.Security.Cryptography;

namespace _3.PL.Views
{
    public partial class Frm_MauSac : Form
    {
        private MauSacRepository _imsRepository;
        private IQLMauSacServices _iqLmsServices;
        private Guid _id;
        public Frm_MauSac()
        {
            InitializeComponent();
            
            _iqLmsServices = new QLMauSacServices();
            LoadData();
        }

        private void LoadData()
        {
            dgrd_mausac.ColumnCount = 4;
            dgrd_mausac.Columns[0].Name = "ID";
            dgrd_mausac.Columns[0].Visible = false;
            dgrd_mausac.Columns[1].Name = "Mã";
            dgrd_mausac.Columns[2].Name = "Tên";
            dgrd_mausac.Columns[3].Name = "Trạng thái";
            dgrd_mausac.Rows.Clear();
            
            foreach (var x in _iqLmsServices.GetAll())
            {
                dgrd_mausac.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _iqLmsServices.GetAll().Count; i++)
            {
                string ma = _iqLmsServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "CL00" + (max + 1);
            return s;
        }
        private MauSac GetDataFromGUI()
        {
            MauSac ms = new MauSac();
            ms.Id = _id;
            ms.Ma = MaTuSinh();
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
        
        
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if (tbx_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã màu sắc không được bỏ trống!");
                }
                else if (_iqLmsServices.GetAll().Any(p => p.Ma == tbx_ma.Text))
                {
                    MessageBox.Show("Mã màu sắc đã tồn tại!");
                }

                else if (tbx_ten.Text.Trim() == "")
                {
                    MessageBox.Show("Tên màu sắc không được bỏ trống!");
                }

                else if (rbtn_hd.Checked == false && rbtn_kohd.Checked == false)
                {
                    MessageBox.Show("Trạng thái màu sắc không được bỏ trống!");
                }
                else
                {
                    _iqLmsServices.Add(GetDataFromGUI());
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }



        
            

            
        

        private void Frm_MauSac_Load(object sender, EventArgs e)
        {
            tbx_ma.Text = MaTuSinh();
        }
        private void tb_timkiem_Leave(object sender, EventArgs e)
        {
            LoadData();
        }
        private void cbb_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (tbx_ma.Text.Trim() == "")
            {
                MessageBox.Show("Mã màu sắc không được để trống!");
            }
            else if (tbx_ten.Text.Trim() == "")
            {
                MessageBox.Show("Tên  màu sắc không được để trống!");
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                
                
                    _iqLmsServices.Update(GetDataFromGUI());
                    LoadData();
                
            }
            else
            {
                MessageBox.Show("Sửa  that bai");
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                if (tbx_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã màu sắc không được để trống!");
                }
                else if (tbx_ten.Text.Trim() == "")
                {
                    MessageBox.Show("Tên màu sắc không được để trống!");
                }
                else
                {
                    _iqLmsServices.Delete(GetDataFromGUI());
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            tbx_ma.Text = MaTuSinh();
            tbx_ten.Text = "";
            rbtn_hd.Checked = true;
            rbtn_kohd.Checked = false;
            LoadData();
        }

        private void tk_timkiem_TextChanged(object sender, EventArgs e)
        {

            dgrd_mausac.Rows.Clear();
            dgrd_mausac.ColumnCount = 4;
            dgrd_mausac.Columns[0].Name = "ID";
            dgrd_mausac.Columns[0].Visible = false;
            dgrd_mausac.Columns[1].Name = "Mã";
            dgrd_mausac.Columns[2].Name = "Tên";
            dgrd_mausac.Columns[3].Name = "Trạng thái";
            foreach (var x in _iqLmsServices.GetAll().Where(x => x.Ten.ToLower().Contains(tk_timkiem.Text.ToLower()) || x.Ma.Contains(tk_timkiem.Text)))
            {
                dgrd_mausac.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }

        private void rbtn_hd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgrd_mausac_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < _iqLmsServices.GetAll().Count)
            {
                var kt = _iqLmsServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgrd_mausac.Rows[rowIndex].Cells[0].Value.ToString()));
                _id = kt.Id;
                tbx_ma.Text = kt.Ma;
                tbx_ten.Text = kt.Ten;


                if (kt.TrangThai == 1)
                {
                    rbtn_hd.Checked = true;
                }
                else if (kt.TrangThai == 0)
                {
                    rbtn_kohd.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Ngoài phạm vi dữ liệu");
            }
        }
    }
}
