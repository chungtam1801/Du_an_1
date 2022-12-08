using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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

    public partial class FrmKhuyenMai : Form
    {
        FpolyDBContext context;

        private IQLKhuyenMaiServices _iqLkmServices;
        private IQLChiTietKhuyenMaiServices _iqlctkmServices;
        private IQLSanPhamServices _iqlSanPhamServices;
        private IQLChiTietSpServices _iqlctSPServices;
        private ViewQLSanPham _viewSP;
        private ViewQLKhuyenMai _viewKM;
        private Guid _id;
        List<Guid> idKM = new List<Guid>();
        public FrmKhuyenMai()
        {
            InitializeComponent();

            _iqLkmServices = new QLKhuyenMaiServices();
            _iqlctkmServices = new QLChiTietKhuyenMaiServices();
            _iqlSanPhamServices = new QLSanPhamServices();
            _iqlctSPServices = new QLChiTietSpServices();
            _viewSP = new ViewQLSanPham();
            _viewKM = new ViewQLKhuyenMai();
            context = new FpolyDBContext();

            LoadSP();
        }
        public string GetTenSP(Guid? id)
        {
            var sp = _iqlSanPhamServices.GetAll().Find(p => p.Id == id);
            if (sp == null)
            {
                return "";
            }
            else return sp.Ten;
        }
        private void LoadData(string s)
        {
            dgvKM.ColumnCount = 7;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[4].Name = "Ngày bắt đầu";
            dgvKM.Columns[5].Name = "Ngày kết thúc";
            dgvKM.Columns[6].Name = "Trạng thái";
            dgvKM.Rows.Clear();

            foreach (var x in _iqLkmServices.GetAll())
            {
                string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, sp, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
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
        public List<KhuyenMai> GetAll2(bool input)
        {
            return _iqLkmServices.GetAll().Where(c => c.TrangThai == Convert.ToInt32(input)).ToList();
        }
        public List<KhuyenMai> GetAll3(DateTime input)
        {
            return _iqLkmServices.GetAll().Where(c => c.NgayKt >= DateTime.Now).ToList();
        }

        private void LoadData3(DateTime input)
        {
           
            dgvKM.ColumnCount = 7;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[4].Name = "Ngày bắt đầu";
            dgvKM.Columns[5].Name = "Ngày kết thúc";
            dgvKM.Columns[6].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll3(input))
            {
                string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, sp, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void LoadData1(string input)
        {
            dgvKM.ColumnCount = 7;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[4].Name = "Ngày bắt đầu";
            dgvKM.Columns[5].Name = "Ngày kết thúc";
            dgvKM.Columns[6].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll1(input))
            {
                string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, sp, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadData2(bool input)
        {


            dgvKM.ColumnCount = 7;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[4].Name = "Ngày bắt đầu";
            dgvKM.Columns[5].Name = "Ngày kết thúc";
            dgvKM.Columns[6].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll2(input))
            {
                string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, sp, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
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
            for (int i = 0; i <= dgv_sp.Rows.Count -1; i++)
            {
                if (Convert.ToBoolean(dgv_sp.Rows[i].Cells["chk"].Value) == true)
                {
                    km.IdSp = _iqlSanPhamServices.GetAll().First(c => c.Ten == Convert.ToString(dgv_sp.Rows[dgv_sp.CurrentRow.Index].Cells["Tên SP"].Value)).Id;
                }

            }
                   

                
            
            
            return km;

        }
        public List<KhuyenMai> GetKMByName(string name)
        {

            var km = context.KhuyenMais.Where(p => p.Ten.StartsWith(name));
            return km.ToList();
        }

        private void LoadSP()
        {
           
            dgv_sp.ColumnCount = 2;
            dgv_sp.Columns[0].Name = "Mã SP";
            dgv_sp.Columns[1].Name = "Tên SP";
            dgv_sp.Rows.Clear();
            DataGridViewCheckBoxColumn dgvcb = new DataGridViewCheckBoxColumn();
            dgvcb.HeaderText = "Select";
            dgvcb.Name = "chk";
            
            foreach (var x in _iqlSanPhamServices.GetAll())
            {
                dgv_sp.Rows.Add(x.Ma, x.Ten);
            }
            dgv_sp.Columns.Add(dgvcb);
            dgv_sp.AllowUserToAddRows = false;
        }
        private void btn_HienThi_Click(object sender, EventArgs e)
        {

        }


        private void tbn_Them_Click_1(object sender, EventArgs e)
        {
            if (tbx_Ten.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập tên!!!");
            }
            else if (tbx_Giatri.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập giá trị!!!");
            }
            else if (rbt_Hoatdong.Checked == false && rbt_koHoatdong.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!!!");
            }
            else if (dtm_NgayKT.Value.Date < dtm_NgayBD.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu và ngược lại!!!");
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                
                _iqLkmServices.Add(GetDataFromGUI());
                 
                
                LoadData(null);
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            if (tbx_Ten.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập tên!!!");
            }
            else if (tbx_Giatri.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập giá trị!!!");
            }
            else if (rbt_Hoatdong.Checked == false && rbt_koHoatdong.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!!!");
            }
            else if (dtm_NgayKT.Value.Date < dtm_NgayBD.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu và ngược lại!!!");
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i <= dgv_sp.Rows.Count -1 ; i++)
                {
                    
                    
                        _iqLkmServices.Update(GetDataFromGUI());
                    
                }
                   
                
                
                LoadData(null);
            }

        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            if (tbx_Ten.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn khuyến mãi!!!");
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _iqLkmServices.Delete(GetDataFromGUI());
                LoadData(null);
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            tbx_Ten.Text = null;
            tbx_Giatri.Text = null;

            dtm_NgayBD.Text = DateTime.Now.ToString();
            dtm_NgayKT.Text = DateTime.Now.ToString();
            rbt_Hoatdong.Checked = false;
            rbt_koHoatdong.Checked = false;
            cbx_conHan.Checked = false;
            cbx_Tatca.Checked = false;
            foreach (DataGridViewRow row in dgv_sp.Rows)
            {
                row.Cells["chk"].Value = false;
            }
            LoadData(null);
        }

        private void FrmKhuyenMai_Load_1(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rbt_Hoatdong.Checked == true)
            {
                LoadData2(rbt_Hoatdong.Checked);
            }
            else if (rbt_koHoatdong.Checked == true)
            {
                LoadData2(_viewKM.TrangThai == 0);
            }
        }

        private void dgvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            foreach (DataGridViewRow row in dgv_sp.Rows)
            {
               
                    if (Convert.ToString(row.Cells["Tên SP"].Value) == Convert.ToString(dgvKM.Rows[dgvKM.CurrentRow.Index].Cells["Sản phẩm"].Value))
                    {
                        row.Cells["chk"].Value = true;
                    }
                
            }
        }

        private void tbx_TimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadData1(tbx_TimKiem.Text);
        }

        private void cbx_conHan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbx_conHan.Checked == true)
            {
                LoadData3(dtm_NgayKT.Value.Date);
            }
            else
            {
                LoadData(null);
            }
        }

        private void cbx_Tatca_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_sp.Rows.Count; i++)
            {
                if (cbx_Tatca.Checked == true)
                {
                    ((DataGridViewCheckBoxCell)dgv_sp.Rows[i].Cells["chk"]).Value = true;
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgv_sp.Rows[i].Cells["chk"]).Value = false;
                }
            }
            
            
        }
    }
}
