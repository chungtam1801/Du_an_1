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
        private ViewQLChiTietSp _viewctSP;
        private ViewQLKhuyenMai _viewKM;
        private ViewQLChiTietKhuyenMai _viewctKM;
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
            _viewctSP = new ViewQLChiTietSp();
            _viewKM = new ViewQLKhuyenMai();
            _viewctKM = new ViewQLChiTietKhuyenMai();
            context = new FpolyDBContext();

            LoadSP(null);
            LoadCTKM();
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

            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
           // dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in _iqLkmServices.GetAll())
            {
                //string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
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
        /*public List<ChiTietSp> GetAll4(string input)
        {
            string sp = GetTenSP(_viewSP.Id);
            if (string.IsNullOrEmpty(input))
            {
                return _iqlctSPServices.GetAll();
            }
            return _iqlctSPServices.GetAll().Where(sp.ToLower().StartsWith(input.ToLower())).ToList();
        }*/
        public List<ChiTietKhuyenMai> GetAll5(bool input)
        {
            return _iqlctkmServices.GetAll().Where(c => c.TrangThai == Convert.ToInt32(input)).ToList();
        }
        private void LoadData3(DateTime input)
        {

            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            // dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll3(input))
            {
                //string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void LoadData1(string input)
        {
            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            // dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll1(input))
            {
                //string sp = GetTenSP(x.IdSp);
                dgvKM.Rows.Add(x.Id, x.Ten, x.GiaTri, x.NgayBd, x.NgayKt, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void LoadData2(bool input)
        {


            dgvKM.ColumnCount = 6;
            dgvKM.Columns[0].Name = "ID";
            dgvKM.Columns[1].Name = "Tên";
            dgvKM.Columns[2].Name = "Giá trị";
            // dgvKM.Columns[3].Name = "Sản phẩm";
            dgvKM.Columns[3].Name = "Ngày bắt đầu";
            dgvKM.Columns[4].Name = "Ngày kết thúc";
            dgvKM.Columns[5].Name = "Trạng thái";
            dgvKM.Rows.Clear();
            foreach (var x in GetAll2(input))
            {
                //string sp = GetTenSP(x.IdSp);
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

            /*for (int i = 0; i < dgv_sp.RowCount; i++)
            {
                if ((bool)dgv_sp.Rows[i].Cells["chk"].Value == true)
                {

                    km.IdSp = _iqlSanPhamServices.GetAll().First(c => c.Ten == dgv_sp.Rows[i].Cells["Tên SP"].Value.ToString()).Id;
                }
            }*/
            
            return km;

        }
        private ChiTietKhuyenMai GetDataFromGUI1()
        {
            ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
            ctkm.Id = _id;
            ctkm.IdKm = _iqLkmServices.GetAll().First(c => c.Ten == tbx_Ten.Text).Id;
            if (rbt_Hoatdong.Checked == true)
            {
                ctkm.TrangThai = 1;
            }
            else if (rbt_koHoatdong.Checked == true)
            {
                ctkm.TrangThai = 0;
            }
            /*int inserted = 0;
            foreach (DataGridViewRow row in dgv_sp.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                if (isSelected == true)
                {
                    //ctkm.IdCtsp = _iqlctSPServices.GetAll().First(c => c.Id.ToString() == row.Cells[0].Value.ToString()).Id;
                    //ctkm.IdCtsp = Guid.Parse(row.Cells[0].Value.ToString());

                    inserted++;
                }
            }*/

            /*int r = dgv_sp.CurrentCell.RowIndex;
            Guid Id = Guid.Parse(dgv_sp.Rows[r].Cells[0].Value.ToString());
            /*for (int i = 0; i <= dgv_sp.RowCount -1; i++)

            {*/
            /* if ((bool)dgv_sp.Rows[r].Cells["chk"].Value == true)
             {

             ctkm.IdCtsp = Id;
             }*/
            //}
            for (int i = 0; i <= dgv_sp.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgv_sp.Rows[i];
                Guid Id = Guid.Parse(row.Cells[0].Value.ToString());
                if (Convert.ToBoolean(row.Cells["chk"].Value)==true)
                {
                    ctkm.IdCtsp = Id;
                }
            }
            return ctkm;

        }
        public List<KhuyenMai> GetKMByName(string name)
        {

            var km = context.KhuyenMais.Where(p => p.Ten.StartsWith(name));
            return km.ToList();
        }

        private void LoadSP(string s)
        {

            DataGridViewCheckBoxColumn dgvcb = new DataGridViewCheckBoxColumn();
            dgvcb.HeaderText = "Select";
            dgvcb.Name = "chk";
            
            dgv_sp.Rows.Clear();
            dgv_sp.ColumnCount = 3;
            dgv_sp.Columns[0].Name = "Id";
            //dgv_sp.Columns[0].Visible = false;
            dgv_sp.Columns[1].Name = "Mã SP";
           // dgv_sp.Columns[2].Name = "Loại sản phẩm";
            dgv_sp.Columns[2].Name = "Sản phẩm";

            foreach (var x in _iqlctSPServices.GetAllView(s))
            {
                dgv_sp.Rows.Add(x.Id, x.Ma, x.Ten);
            }
            dgv_sp.Columns.Add(dgvcb);
            dgv_sp.AllowUserToAddRows = false;
        }
       /* private void LoadSP1(string input)
        {

            DataGridViewCheckBoxColumn dgvcb = new DataGridViewCheckBoxColumn();
            dgvcb.HeaderText = "Select";
            dgvcb.Name = "chk";
            
            dgv_sp.Rows.Clear();
            dgv_sp.ColumnCount = 3;
            dgv_sp.Columns[0].Name = "Id";
            //dgv_sp.Columns[0].Visible = false;
            dgv_sp.Columns[1].Name = "Mã SP";
            //dgv_sp.Columns[2].Name = "Loại sản phẩm";
            dgv_sp.Columns[2].Name = "Sản phẩm";

            foreach (var x in GetAll4(input))
            {
                string sp = GetTenSP(x.IdSp);
                dgv_sp.Rows.Add(x.Id, x.Ma, sp);
            }
            dgv_sp.Columns.Add(dgvcb);
            dgv_sp.AllowUserToAddRows = false;
        }*/
        private void btn_HienThi_Click(object sender, EventArgs e)
        {

        }
        public string GetTenKM(Guid? id)
        {
            var km = _iqLkmServices.GetAll().Find(p => p.Id == id);
            if (km == null)
            {
                return "";
            }
            else return km.Ten;
        }
        public string GetCTSP(Guid? id)
        {
            var ctsp = _iqlctSPServices.GetAll().FirstOrDefault(p => p.Id == id);
            var ctsp1 = _iqlctSPServices.GetAllView().FirstOrDefault(p => p.Id == id);
            if (ctsp == null)
            {
                return "";
            }
            else
            {

                return ctsp1.Ten;
            }
        }
        private void LoadCTKM()
        {
            dgv_ctkm.ColumnCount = 4;
            dgv_ctkm.Columns[0].Name = "ID";
            dgv_ctkm.Columns[1].Name = "Tên KM";
            dgv_ctkm.Columns[2].Name = "Sản phẩm";
            dgv_ctkm.Columns[3].Name = "Trạng thái";
            dgv_ctkm.Rows.Clear();
            foreach (var x in _iqlctkmServices.GetAll())
            {
                string km = GetTenKM(x.IdKm);
                string sp = GetCTSP(x.IdCtsp);
                dgv_ctkm.Rows.Add(x.Id, km,sp, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadCTKM1(bool input)
        {
            dgv_ctkm.ColumnCount = 4;
            dgv_ctkm.Columns[0].Name = "ID";
            dgv_ctkm.Columns[1].Name = "Tên KM";
            dgv_ctkm.Columns[2].Name = "Sản phẩm";
            dgv_ctkm.Columns[3].Name = "Trạng thái";
            dgv_ctkm.Rows.Clear();
            foreach (var x in GetAll5(input))
            {
                string km = GetTenKM(x.IdKm);
                string sp = GetCTSP(x.IdCtsp);
                dgv_ctkm.Rows.Add(x.Id, km, sp, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
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

                //int inserted = 1;
                /*foreach (DataGridViewRow row in dgv_sp.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                    if (isSelected == true)
                    {
                        _iqLkmServices.Add(GetDataFromGUI());
                        inserted++;
                    }
                }*/



                //inserted++;
                if (rbt_ctKM.Checked == false && rbt_KM.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn Khuyến mãi or Chi tiết KM");
                }
                else if (rbt_KM.Checked == true)
                {
                    _iqLkmServices.Add(GetDataFromGUI());
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    
                    _iqlctkmServices.Add(GetDataFromGUI1());
                    MessageBox.Show("Thêm thành công!");
                }

                LoadData(null);
                LoadCTKM();
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
                if (rbt_ctKM.Checked == false && rbt_KM.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn Khuyến mãi or Chi tiết KM");
                }
                else if (rbt_KM.Checked == true)
                {
                    _iqLkmServices.Update(GetDataFromGUI());
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {

                    _iqlctkmServices.Update(GetDataFromGUI1());
                    MessageBox.Show("Sửa thành công!");
                }


                LoadCTKM();
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
                if (rbt_ctKM.Checked == false && rbt_KM.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn Khuyến mãi or Chi tiết KM");
                }
                else if (rbt_KM.Checked == true)
                {
                    _iqLkmServices.Delete(GetDataFromGUI());
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {

                    _iqlctkmServices.Delete(GetDataFromGUI1());
                    MessageBox.Show("Xóa thành công!");

                }
                LoadCTKM();
                LoadData(null);
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            if (rbt_KM.Checked == true)
            {
                tbx_Ten.Text = null;

                tbx_Giatri.Text = null;

                dtm_NgayBD.Text = DateTime.Now.ToString();

                dtm_NgayKT.Text = DateTime.Now.ToString();

                rbt_Hoatdong.Checked = false;
                rbt_koHoatdong.Checked = false;
            }
            else
            {
                rbt_Hoatdong.Checked = false;
                rbt_koHoatdong.Checked = false;
                cbx_conHan.Checked = false;
                //cbx_Tatca.Checked = false;

                foreach (DataGridViewRow row in dgv_sp.Rows)
                {
                    row.Cells["chk"].Value = false;
                }
            }
            
            LoadData(null);
        }

        private void FrmKhuyenMai_Load_1(object sender, EventArgs e)
        {
            LoadData(null);
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rbt_KM.Checked == true)
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
            else
            {

                if (rbt_Hoatdong.Checked == true)
                {
                    LoadCTKM1(rbt_Hoatdong.Checked);
                }
                else if (rbt_koHoatdong.Checked == true)
                {
                    LoadCTKM1(_viewctKM.TrangThai == 0);
                }

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
            
            /*foreach (DataGridViewRow row in dgv_sp.Rows)
            {

                if (Convert.ToString(row.Cells["Tên SP"].Value) == Convert.ToString(dgvKM.Rows[dgvKM.CurrentRow.Index].Cells["Sản phẩm"].Value))
                {
                    row.Cells["chk"].Value = true;
                }

            }
           /* DataGridView dgv1 = (DataGridView)this.Controls["dgvKM"];
            DataGridView dgv2 = (DataGridView)this.Controls["dgv_ctkm"];
            DataGridViewRow ThemMoi = dgv1.CurrentRow;
            //dgv2.Rows.Add(new DataGridViewRow());
            dgv2.Rows[dgv2.Rows.Count - 1].Cells["Tên KM"].Value = ThemMoi.Cells["Tên"].Value;
            dgv2.Rows[dgv2.Rows.Count - 1].Cells["Sản phẩm"].Value = ThemMoi.Cells["Sản phẩm"].Value;*/
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
           /* for (int i = 0; i < dgv_sp.Rows.Count; i++)
            {
                if (cbx_Tatca.Checked == true)
                {
                    ((DataGridViewCheckBoxCell)dgv_sp.Rows[i].Cells["chk"]).Value = true;
                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgv_sp.Rows[i].Cells["chk"]).Value = false;
                }
            }*/


        }

        private void dgv_sp_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (dgv_sp.IsCurrentCellDirty)
            {
                dgv_sp.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_sp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_sp.Columns[e.ColumnIndex].Name == "chk")
            {


                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)dgv_sp.
                    Rows[e.RowIndex].Cells["chk"];


                dgv_sp.Invalidate();
            }
        }

        private void tbx_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            LoadSP1(tbx_TimKiemSP.Text);
        }

        private void rbt_KM_CheckedChanged(object sender, EventArgs e)
        {
            tbx_Ten.Enabled = true;
            tbx_Giatri.Enabled = true;
            dtm_NgayBD.Enabled = true;
            dtm_NgayKT.Enabled = true;
           // cbx_Tatca.Enabled = false;
            tbx_TimKiemSP.Enabled = false;
            dgv_sp.Enabled = false;
        }

        private void rbt_ctKM_CheckedChanged(object sender, EventArgs e)
        {
            tbx_Ten.Enabled = false;
            tbx_Giatri.Enabled = false;
            dtm_NgayBD.Enabled = false;
            dtm_NgayKT.Enabled = false;
            //cbx_Tatca.Enabled = true;
            tbx_TimKiemSP.Enabled = true;
            dgv_sp.Enabled = true;
        }

        private void dgv_ctkm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var ctkm = _iqlctkmServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgv_ctkm.Rows[rowIndex].Cells[0].Value.ToString()));
            KhuyenMai km = _iqLkmServices.GetAll().First(c => c.Id == ctkm.IdKm);
            _id = ctkm.Id;
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

                if (Convert.ToString(row.Cells["Sản phẩm"].Value) == Convert.ToString(dgv_ctkm.Rows[dgv_ctkm.CurrentRow.Index].Cells["Sản phẩm"].Value))
                {
                    row.Cells["chk"].Value = true;
                }

            }
        }

        private void tbx_TimKiemKM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
