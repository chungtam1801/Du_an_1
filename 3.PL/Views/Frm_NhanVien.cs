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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _3.PL.Views
{
    public partial class Frm_NhanVien : Form
    {
        private IQLNhanVienServices _IqlNhanVienServices;
        private IQLChucVuServices _iqLChucVuServices;
        private ViewQLNhanVien _vnv = new ViewQLNhanVien();
        private Guid _id;
        public Frm_NhanVien()
        {
            InitializeComponent();
            _IqlNhanVienServices = new QLNhanVienServices();
            _iqLChucVuServices = new QLChucVuServices();
            tb_ma.Text = MaTuSinh();
            tb_ma.Enabled = false;
            LoadChucVu();
            LoadNV();
        }
        private void LoadNV()
        {
            dtg_nhanvien.Rows.Clear();
            dtg_nhanvien.ColumnCount = 15;
            dtg_nhanvien.Columns[0].Name = "STT";
            dtg_nhanvien.Columns[1].Name = "ID";
            dtg_nhanvien.Columns[1].Visible = false;
            dtg_nhanvien.Columns[2].Name = "Chức vụ";
            dtg_nhanvien.Columns[14].Name = "IDCV";
            dtg_nhanvien.Columns[14].Visible = false;
            dtg_nhanvien.Columns[3].Name = "Mã";
            dtg_nhanvien.Columns[4].Name = "Tên";
            dtg_nhanvien.Columns[5].Name = "Tên đệm";
            dtg_nhanvien.Columns[6].Name = "Họ";
            dtg_nhanvien.Columns[7].Name = "Họ và tên";
            dtg_nhanvien.Columns[7].Width = 150;
            dtg_nhanvien.Columns[8].Name = "Giới tính";
            dtg_nhanvien.Columns[9].Name = "Ngày sinh";
            dtg_nhanvien.Columns[9].Width = 160;
            dtg_nhanvien.Columns[10].Name = "Địa chỉ";
            dtg_nhanvien.Columns[10].Width = 130;
            dtg_nhanvien.Columns[11].Name = "Số DT";
            dtg_nhanvien.Columns[12].Name = "Mật khẩu";
            dtg_nhanvien.Columns[12].Width = 110;
            dtg_nhanvien.Columns[13].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in _IqlNhanVienServices.GetAllView())
            {
                dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
            }
        }
        private void LoadChucVu()
        {
            if (_iqLChucVuServices.GetAll().Count == 0) return;
            {
                foreach (var x in _iqLChucVuServices.GetAll())
                {
                    cbb_cv.Items.Add(x.Ten);
                }
                cbb_cv.SelectedIndex = -1;
            }
        }
        //private void LoadcbbChucVu()
        //{
        //    foreach (var item in _iqLChucVuServices.GetAll().Where(p => p.TrangThai == 0))
        //    {
        //        cbb_cv.Items.Add(item.Ten);
        //    }
        //}
        private NhanVien GetDataFormGui()
        {
            NhanVien nv = new NhanVien();
            nv.Id = _id;
            nv.IdCv = _iqLChucVuServices.GetAll().FirstOrDefault(p => p.Ten == cbb_cv.Text).Id;
            nv.Ma = tb_ma.Text;
            nv.Ten = tb_ten.Text;
            nv.TenDem = tb_tendem.Text;
            nv.Ho = tb_ho.Text;
            nv.GioiTinh = nv_cbb_gioitinh.Text;
            nv.NgaySinh = dtp_ngaysinh.Value;
            nv.DiaChi = tb_diachi.Text;
            nv.Sdt = tb_sdt.Text;
            nv.MatKhau = tb_matkhau.Text;
            if (rbtn_conlam.Checked == true)
            {
                nv.TrangThai = 1;
            }
            else if (rbtn_nghilam.Checked == true)
            {
                nv.TrangThai = 0;
            }
            return nv;
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            rbtn_conlam.Checked = true;
        }
        public static bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((0(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _IqlNhanVienServices.GetAll().Count; i++)
            {
                string ma = _IqlNhanVienServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "NV00" + (max + 1);
            return s;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if (tb_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã nhân viên không được bỏ trống!");
                }
                else if (_IqlNhanVienServices.GetAllView().Any(p => p.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                }
                else if (tb_ho.Text.Trim() == "")
                {
                    MessageBox.Show("Họ nhân viên không được bỏ trống!");
                }
                else if (tb_ten.Text.Trim() == "")
                {
                    MessageBox.Show("Tên nhân viên không được bỏ trống!");
                }
                else if (nv_cbb_gioitinh.Text.Trim() == "")
                {
                    MessageBox.Show("Giới tính nhân viên không được bỏ trống!");
                }
                else if (dtp_ngaysinh.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Ngày sinh nhân viên không được bỏ trống!");
                }
                else if (nv_cbb_gioitinh.Text.Trim() == "")
                {
                    MessageBox.Show("Giới tính nhân viên không được bỏ trống!");
                }
                else if (DateTime.Now.Year - dtp_ngaysinh.Value.Year < 18)
                {
                    MessageBox.Show("Người này chưa đủ 18 tuổi!");
                }
                else if (tb_sdt.Text.Trim() == "")
                {
                    MessageBox.Show("SDT nhân viên không được bỏ trống!");
                }
                else if (IsValidVietNamPhoneNumber(tb_sdt.Text) == true && tb_sdt.Text.Trim().Count() != 10)
                {
                    MessageBox.Show("SDT nhân viên không hợp lệ 0xxxxxxxxx!");
                }
                else if (tb_ma.Text.Substring(0) == "0")
                {
                    MessageBox.Show("SDT nhân viên không hợp lệ 0xxxxxxxxx!");
                }
                else if (_IqlNhanVienServices.GetAllView().Any(p => p.Sdt == tb_sdt.Text))
                {
                    MessageBox.Show("SDT nhân viên đã tồn tại!");
                }
                else if (IsValidVietNamPhoneNumber(tb_sdt.Text) == false)
                {
                    MessageBox.Show("Số DT!");
                }
                else if (tb_matkhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu nhân viên không được bỏ trống!");
                }
                else if (tb_diachi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ nhân viên không được bỏ trống!");
                }
                else if (rbtn_conlam.Checked == false && rbtn_nghilam.Checked == false)
                {
                    MessageBox.Show("Trạng thái nhân viên không được bỏ trống!");
                }
                else
                {
                    _IqlNhanVienServices.Add(GetDataFormGui());
                    LoadNV();
                }
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
            tb_ma.Text = MaTuSinh();
            tb_ten.Text = "";
            tb_tendem.Text = "";
            tb_ho.Text = "";
            cbb_cv.SelectedIndex = -1;
            nv_cbb_gioitinh.SelectedIndex = -1;
            tb_sdt.Text = "";
            tb_matkhau.Text = "";
            tb_diachi.Text = "";
            rbtn_conlam.Checked = false;
            rbtn_nghilam.Checked = false;
        }

        private void nv_cbb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loaddtgbysearch()
        {
            //dtg_nhanvien.DataSource = ;
        }
        private void btn_seachbyma_Click(object sender, EventArgs e)
        {

            //foreach (var item in nv.Ma)
            //{

            //}
        }
        private void tk_timkiem_TextChanged(object sender, EventArgs e, string s)
        {
        }

        private void dtg_nhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var nv = _IqlNhanVienServices.GetAllView().FirstOrDefault(c => c.Id == Guid.Parse(dtg_nhanvien.CurrentRow.Cells[1].Value.ToString()));
            _id = nv.Id;
            tb_ma.Text = nv.Ma;
            tb_ten.Text = nv.Ten;
            tb_tendem.Text = nv.TenDem;
            tb_ho.Text = nv.Ho;
            cbb_cv.Text = nv.TenCv;
            nv_cbb_gioitinh.Text = nv.GioiTinh;
            dtp_ngaysinh.Value = nv.NgaySinh;
            tb_matkhau.Text = nv.MatKhau;
            tb_diachi.Text = nv.DiaChi;
            tb_sdt.Text = nv.Sdt;
            if (nv.TrangThai == 1)
            {
                rbtn_conlam.Checked = true;
            }
            else if (nv.TrangThai == 0)
            {
                rbtn_nghilam.Checked = true;
            }
        }
        public void cbbtimkiem()
        {
            if (cbb_timkiem.Text == "Tìm kiếm theo mã")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.Ma == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }

            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo họ")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.Ho == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo tên đệm")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.TenDem == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo tên")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.Ten == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo giới tính")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.GioiTinh == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo SDT")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.Sdt == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo địa chỉ")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.DiaChi == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            else if (cbb_timkiem.Text == "Tìm kiếm theo chức vụ")
            {
                var tk = _IqlNhanVienServices.GetAllView().Where(p => p.TenCv == tk_timkiem.Text);
                dtg_nhanvien.Rows.Clear();
                dtg_nhanvien.ColumnCount = 15;
                dtg_nhanvien.Columns[0].Name = "STT";
                dtg_nhanvien.Columns[1].Name = "ID";
                dtg_nhanvien.Columns[1].Visible = false;
                dtg_nhanvien.Columns[2].Name = "Chức vụ";
                dtg_nhanvien.Columns[14].Name = "IDCV";
                dtg_nhanvien.Columns[14].Visible = false;
                dtg_nhanvien.Columns[3].Name = "Mã";
                dtg_nhanvien.Columns[4].Name = "Tên";
                dtg_nhanvien.Columns[5].Name = "Tên đệm";
                dtg_nhanvien.Columns[6].Name = "Họ";
                dtg_nhanvien.Columns[7].Name = "Họ và tên";
                dtg_nhanvien.Columns[7].Width = 150;
                dtg_nhanvien.Columns[8].Name = "Giới tính";
                dtg_nhanvien.Columns[9].Name = "Ngày sinh";
                dtg_nhanvien.Columns[9].Width = 160;
                dtg_nhanvien.Columns[10].Name = "Địa chỉ";
                dtg_nhanvien.Columns[10].Width = 130;
                dtg_nhanvien.Columns[11].Name = "Số DT";
                dtg_nhanvien.Columns[12].Name = "Mật khẩu";
                dtg_nhanvien.Columns[12].Width = 110;
                dtg_nhanvien.Columns[13].Name = "Trạng thái";
                int stt = 1;
                foreach (var x in tk)
                {
                    dtg_nhanvien.Rows.Add(stt++, x.Id, x.TenCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
                }
            }
            //else if (cbb_timkiem.Text == "Tìm kiếm theo trạng thái")
            //{
            //    int index = 0;
            //    if (rbtn_conlam.Checked == true)
            //    {
            //        index = 1;
            //    }else if (rbtn_nghilam.Checked == true)
            //    {
            //        index = 0;
            //    }
            //    var tk = _IqlNhanVienServices.GetAll(index);
            //    dtg_nhanvien.Rows.Clear();
            //    dtg_nhanvien.ColumnCount = 14;
            //    dtg_nhanvien.Columns[0].Name = "STT";
            //    dtg_nhanvien.Columns[1].Name = "ID";
            //    dtg_nhanvien.Columns[1].Visible = false;
            //    dtg_nhanvien.Columns[2].Name = "IDCV";
            //    dtg_nhanvien.Columns[2].Visible = false;
            //    dtg_nhanvien.Columns[3].Name = "Mã";
            //    dtg_nhanvien.Columns[4].Name = "Tên";
            //    dtg_nhanvien.Columns[5].Name = "Tên đệm";
            //    dtg_nhanvien.Columns[6].Name = "Họ";
            //    dtg_nhanvien.Columns[7].Name = "Họ và tên";
            //    dtg_nhanvien.Columns[7].Width = 150;
            //    dtg_nhanvien.Columns[8].Name = "Giới tính";
            //    dtg_nhanvien.Columns[9].Name = "Ngày sinh";
            //    dtg_nhanvien.Columns[9].Width = 160;
            //    dtg_nhanvien.Columns[10].Name = "Địa chỉ";
            //    dtg_nhanvien.Columns[10].Width = 130;
            //    dtg_nhanvien.Columns[11].Name = "Số DT";
            //    dtg_nhanvien.Columns[12].Name = "Mật khẩu";
            //    dtg_nhanvien.Columns[12].Width = 110;
            //    dtg_nhanvien.Columns[13].Name = "Trạng thái";
            //    int stt = 1;
            //    foreach (var x in tk)
            //    {
            //        dtg_nhanvien.Rows.Add(stt++, x.Id, x.IdCv, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TrangThai == 1 ? "còn làm" : "nghỉ làm");
            //    }
            //}
        }
        private void tk_timkiem_TextChanged(object sender, EventArgs e)
        {
            cbbtimkiem();
        }

        private void tk_timkiem_Leave(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if (tb_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã nhân viên không được bỏ trống!");
                }
                else if (_IqlNhanVienServices.GetAllView().Any(p => p.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                }
                else if (tb_ho.Text.Trim() == "")
                {
                    MessageBox.Show("Họ nhân viên không được bỏ trống!");
                }
                else if (tb_ten.Text.Trim() == "")
                {
                    MessageBox.Show("Tên nhân viên không được bỏ trống!");
                }
                else if (nv_cbb_gioitinh.Text.Trim() == "")
                {
                    MessageBox.Show("Giới tính nhân viên không được bỏ trống!");
                }
                else if (dtp_ngaysinh.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Ngày sinh nhân viên không được bỏ trống!");
                }
                else if (nv_cbb_gioitinh.Text.Trim() == "")
                {
                    MessageBox.Show("Giới tính nhân viên không được bỏ trống!");
                }
                else if (DateTime.Now.Year - dtp_ngaysinh.Value.Year < 18)
                {
                    MessageBox.Show("Người này chưa đủ 18 tuổi!");
                }
                else if (tb_sdt.Text.Trim() == "")
                {
                    MessageBox.Show("SDT nhân viên không được bỏ trống!");
                }
                else if (IsValidVietNamPhoneNumber(tb_sdt.Text) == true && tb_sdt.Text.Trim().Count() != 10)
                {
                    MessageBox.Show("SDT nhân viên không hợp lệ 0xxxxxxxxx!");
                }
                else if (tb_ma.Text.Substring(0) == "0")
                {
                    MessageBox.Show("SDT nhân viên không hợp lệ 0xxxxxxxxx!");
                }
                else if (_IqlNhanVienServices.GetAllView().Any(p => p.Sdt == tb_sdt.Text))
                {
                    MessageBox.Show("SDT nhân viên đã tồn tại!");
                }
                else if (IsValidVietNamPhoneNumber(tb_sdt.Text) == false)
                {
                    MessageBox.Show("Số DT!");
                }
                else if (tb_matkhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu nhân viên không được bỏ trống!");
                }
                else if (tb_diachi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ nhân viên không được bỏ trống!");
                }
                else if (rbtn_conlam.Checked == false && rbtn_nghilam.Checked == false)
                {
                    MessageBox.Show("Trạng thái nhân viên không được bỏ trống!");
                }
                else
                {
                    _IqlNhanVienServices.Add(GetDataFormGui());
                    LoadNV();
                }
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlNhanVienServices.Update(GetDataFormGui());
                LoadNV();
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlNhanVienServices.Delete(GetDataFormGui());
                LoadNV();
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            tb_ma.Text = MaTuSinh();
            tb_ten.Text = "";
            tb_tendem.Text = "";
            tb_ho.Text = "";
            cbb_cv.SelectedIndex = -1;
            nv_cbb_gioitinh.SelectedIndex = -1;
            tb_sdt.Text = "";
            tb_matkhau.Text = "";
            tb_diachi.Text = "";
            rbtn_conlam.Checked = false;
            rbtn_nghilam.Checked = false;
        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nv = _IqlNhanVienServices.GetAllView().FirstOrDefault(c => c.Id == Guid.Parse(dtg_nhanvien.CurrentRow.Cells[1].Value.ToString()));
            _id = nv.Id;
            tb_ma.Text = nv.Ma;
            tb_ten.Text = nv.Ten;
            tb_tendem.Text = nv.TenDem;
            tb_ho.Text = nv.Ho;
            cbb_cv.Text = nv.TenCv;
            nv_cbb_gioitinh.Text = nv.GioiTinh;
            dtp_ngaysinh.Value = nv.NgaySinh;
            tb_matkhau.Text = nv.MatKhau;
            tb_diachi.Text = nv.DiaChi;
            tb_sdt.Text = nv.Sdt;
            if (nv.TrangThai == 1)
            {
                rbtn_conlam.Checked = true;
            }
            else if (nv.TrangThai == 0)
            {
                rbtn_nghilam.Checked = true;
            }
        }

        private void tk_timkiem_TextChanged_1(object sender, EventArgs e)
        {
            cbbtimkiem();
        }
    }
}
