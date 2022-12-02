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
    public partial class Frm_ChatLieu : Form
    {
        private IQLChatLieuServices qLChatLieuServices;
        private Guid _id;
        public Frm_ChatLieu()
        {
            InitializeComponent();
            qLChatLieuServices = new QLChatLieuServices();
            LoadData();
        }

        private void LoadData()
        {
            ShowDataChatLieu.Rows.Clear();
            ShowDataChatLieu.ColumnCount = 4;
            ShowDataChatLieu.Columns[0].Name = "ID";
            ShowDataChatLieu.Columns[0].Visible = false;
            ShowDataChatLieu.Columns[1].Name = "Mã";
            ShowDataChatLieu.Columns[2].Name = "Ten";
            ShowDataChatLieu.Columns[3].Name = "Trạng thái";

            foreach (var x in qLChatLieuServices.GetAll())
            {
                ShowDataChatLieu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
    
    private ChatLieu GetDataFromGUI()
    {
        ChatLieu kt = new ChatLieu();
        kt.Id = _id;
        kt.Ma = MaTuSinh();
        kt.Ten = tbt_Ten.Text;
        if (rd_hd.Checked == true)
        {
            kt.TrangThai = 1;
        }
        else if (rd_khd.Checked == true)
        {
            kt.TrangThai = 0;
        }
        return kt;
    }






        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if (qLChatLieuServices.GetAll().Any(p => p.Ma == tbt_Ma.Text))
                {
                    MessageBox.Show("Mã chất liệu đã tồn tại!");
                }
                else if (tbt_Ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã chất liệu không được để trống!");
                }
                else if (tbt_Ten.Text.Trim() == "")
                {
                    MessageBox.Show("Ten chất liệu không được để trống!");
                }
                else if (qLChatLieuServices.GetAll().Any(p => p.Ten == tbt_Ten.Text))
                {
                    MessageBox.Show("Ten chất liệu đã tồn tại!");
                }
                else if (rd_hd.Checked == false && rd_khd.Checked == false)
                {
                    MessageBox.Show("Trạng thái chất liệu không được bỏ trống!");
                }
                else
                {
                    qLChatLieuServices.Add(GetDataFromGUI());
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {

                if (tbt_Ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã chất liệu không được để trống!");
                }
                else if (tbt_Ten.Text.Trim() == "")
                {
                    MessageBox.Show("Ten chất liệu không được để trống!");
                }
                else
                {
                    qLChatLieuServices.Update(GetDataFromGUI());
                    LoadData();
                }

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                if (tbt_Ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã chất liệu không được để trống!");
                }
                else if (tbt_Ten.Text.Trim() == "")
                {
                    MessageBox.Show("Ten chất liệu không được để trống!");
                }
                else
                {
                    qLChatLieuServices.Delete(GetDataFromGUI());
                    LoadData();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = MaTuSinh();
            tbt_Ten.Text = "";
            rd_hd.Checked = false;
            rd_khd.Checked = false;
            LoadData();
        }

        private void ShowDataChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var kt = qLChatLieuServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(ShowDataChatLieu.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = kt.Id;
            tbt_Ma.Text = kt.Ma;
            tbt_Ten.Text = kt.Ten;


            if (kt.TrangThai == 1)
            {
                rd_hd.Checked = true;
            }
            else if (kt.TrangThai == 0)
            {
                rd_khd.Checked = true;
            }
        }

        private void tbt_timkiem_TextChanged(object sender, EventArgs e)
        {
            ShowDataChatLieu.Rows.Clear();
            ShowDataChatLieu.ColumnCount = 4;
            ShowDataChatLieu.Columns[0].Name = "ID";
            ShowDataChatLieu.Columns[0].Visible = false;
            ShowDataChatLieu.Columns[1].Name = "Mã";
            ShowDataChatLieu.Columns[2].Name = "Ten";
            ShowDataChatLieu.Columns[3].Name = "Trạng thái";

            foreach (var item in qLChatLieuServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_timkiem.Text.ToLower()) || x.Ma.Contains(tbt_timkiem.Text)))
            {
                ShowDataChatLieu.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < qLChatLieuServices.GetAll().Count; i++)
            {
                string ma = qLChatLieuServices.GetAll()[i].Ma;
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

        private void Frm_ChatLieu_Load(object sender, EventArgs e)
        {
            tbt_Ma.Text = MaTuSinh();
        }
    }
}

