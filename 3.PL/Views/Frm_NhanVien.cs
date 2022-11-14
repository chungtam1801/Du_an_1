using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;

namespace _3.PL.Views
{
    public partial class Frm_NhanVien : Form
    {
        private INhanVienRepository _INhanVienRepository;
        private IQLNhanVienServices _IqlNhanVienServices;
        private Guid _id;
        public Frm_NhanVien()
        {
            InitializeComponent();
            _INhanVienRepository = new NhanVienRepository();
            _IqlNhanVienServices = new QLNhanVienServices();
        }
        private void LoadNV()
        {
            dtg_nhanvien.Rows.Clear();
            dtg_nhanvien.ColumnCount = 14;
            dtg_nhanvien.Columns[0].Name = "STT";
            dtg_nhanvien.Columns[1].Name = "ID";
            dtg_nhanvien.Columns[1].Visible = false;
            dtg_nhanvien.Columns[2].Name = "IDCV";
            dtg_nhanvien.Columns[2].Visible = false;
            dtg_nhanvien.Columns[3].Name = "Mã";
            dtg_nhanvien.Columns[4].Name = "Tên";
            dtg_nhanvien.Columns[5].Name = "Tên đệm";
            dtg_nhanvien.Columns[6].Name = "Họ";
            dtg_nhanvien.Columns[7].Name = "Họ và tên";
            dtg_nhanvien.Columns[8].Name = "Giới tính";
            dtg_nhanvien.Columns[9].Name = "Ngày sinh";
            dtg_nhanvien.Columns[10].Name = "Địa chỉ";
            dtg_nhanvien.Columns[11].Name = "Số DT";
            dtg_nhanvien.Columns[12].Name = "Mật khẩu";
            dtg_nhanvien.Columns[13].Name = "Trạng thái";
            int stt = 1;
            foreach (var  x in _IqlNhanVienServices.GetAll())
            {
                dtg_nhanvien.Rows.Add(stt++, x.Id, x.IdCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten),x.GioiTinh,x.NgaySinh,x.DiaChi,x.Sdt,x.MatKhau,x.TrangThai==1?"còn làm":"nghỉ làm");
            }
        }
        public void LoadCBB()
        {
            foreach (var x in _IqlNhanVienServices.GetAll())
            {
                nv_cbb_gioitinh.Items.Add("Nam");
                nv_cbb_gioitinh.Items.Add("Nữ");
            }
        }
        public void Clear() 
        {
            nv_ma.Text = "";
            nv_ten.Text = "";
            nv_tendem.Text = "";
            nv_ho.Text = "";
            nv_cbb_gioitinh.Text = "";
            nv_ngaysinh.Value=DateTime.Now;
            nv_diachi.Text = "";
            nv_Sdt.Text = "";
            nv_mk.Text = "";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            LoadNV();
        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd=e.RowIndex;
            var nv = _IqlNhanVienServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_nhanvien.Rows[rd].Cells[1].Value.ToString()));
            _id = nv.Id;
            nv_ma.Text = nv.Ma;
            nv_ten.Text = nv.Ten;
            nv_tendem.Text = nv.TenDem;
            nv_ho.Text = nv.Ho;
            nv_cbb_gioitinh.Text=nv.GioiTinh;
            nv_ngaysinh.Value = nv.NgaySinh;
            nv_diachi.Text = nv.DiaChi;
            nv_Sdt.Text=nv.Sdt;
            if (nv.TrangThai == 1)
            {
                radioButton1.Checked = true;
            }
            else if (nv.TrangThai == 0)
            {
                radioButton2.Checked=true;
            }
                
        }
        private NhanVien GetDataFormGui()
        {
            NhanVien nv=new NhanVien();
            nv.Id = _id;
            nv.Ma = nv_ma.Text;
            nv.Ten = nv_ten.Text;
            nv.TenDem=nv_tendem.Text;
            nv.Ho=nv_ho.Text;
            nv.GioiTinh=nv_cbb_gioitinh.Text;
            nv.NgaySinh = nv_ngaysinh.Value;
            nv.DiaChi = nv_diachi.Text;
            nv.Sdt=nv_Sdt.Text;
            nv.MatKhau = nv_mk.Text;
            if (radioButton1.Checked == true)
            {
                nv.TrangThai = 1;
            }
            else if(radioButton2.Checked == true)
            {
                nv.TrangThai= 0;
            }
            return nv;
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadCBB();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _IqlNhanVienServices.Add(GetDataFormGui());
                LoadNV();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlNhanVienServices.Update(GetDataFormGui());
                LoadNV();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlNhanVienServices.Delete(GetDataFormGui());
                LoadNV();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void nv_cbb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
