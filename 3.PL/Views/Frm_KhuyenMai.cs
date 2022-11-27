using _1.DAL.Context;
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
    public partial class Frm_KhuyenMai : Form
    {
        FpolyDBContext context;
        private IQLKhuyenMaiServices _iqLkmServices;
        private Guid _id;
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            _iqLkmServices = new QLKhuyenMaiServices();
            context = new FpolyDBContext();
            LoadData();
        }
        private void LoadData()
        {
            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in _iqLkmServices.GetAll())
            {
                dgvKM.Rows.Add(x.Id,x.Ten,x.GiaTri,x.NgayBd,x.NgayKt,x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public List<KhuyenMai> GetAll1(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return _iqLkmServices.GetAll();
            }
            return _iqLkmServices.GetAll().Where(c => c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        private void LoadData1(string input)
        {
            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll1(input))
            {
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private KhuyenMai GetDataFromGUI()
        {
            KhuyenMai km = new KhuyenMai();
            km.Id = _id;
            km.Ten = tbx_Ten.Text;
            km.GiaTri = tbx_Giatri.Text;
            km.NgayBd = Convert.ToDateTime(dtm_NgayBD.Text);
            km.NgayKt = Convert.ToDateTime(dtm_NgayKT.Text);
            if (rbt_Hoatdong.Checked == true)
            {
                km.TrangThai = 1;
            }
            else if (rbt_koHoatdong.Checked == true)
            {
                km.TrangThai = 0;
            }
            return km;
        }

        private void tbn_Them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _iqLkmServices.Add(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLkmServices.Update(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLkmServices.Delete(GetDataFromGUI());
                LoadData();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
           
            tbx_Ten.Text = "";
            tbx_Giatri.Text = "";
            dtm_NgayBD.Text = DateTime.Now.ToString();
            dtm_NgayKT.Text = DateTime.Now.ToString();
            rbt_Hoatdong.Checked = true;
            LoadData();
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var km = _iqLkmServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgvKM.Rows[rowIndex].Cells[0].Value.ToString()));
            _id = km.Id;
            tbx_Ten.Text = km.Ten;
            tbx_Giatri.Text = km.GiaTri;
            dtm_NgayBD.Text = km.NgayBd.ToString();
            dtm_NgayKT.Text = km.NgayKt.ToString();
            if (km.TrangThai == 1)
            {
                rbt_Hoatdong.Checked = true;
            }
            else if (km.TrangThai == 0)
            {
                rbt_koHoatdong.Checked = true;
            }
        }
        public List<KhuyenMai> GetKMByName(string name)
        {
           
            var km = context.KhuyenMais.Where(p => p.Ten.StartsWith(name));
            return km.ToList();
        }
        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            
            LoadData1(tbx_TimKiem.Text);
        }
    }
}
