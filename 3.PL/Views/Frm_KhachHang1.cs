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
/*Tran văn lam thay frm_KhachHang thành frm_KhachHang1*/

namespace _3.PL.Views
{
    public partial class Frm_KhachHang1 : Form
    {
        private IQLKhachHangServices _IqlKhachHangServices;
        private IQLLichSuTichDiemServices _IqlLichSuTichDiemServices;
        private IQLHoaDonServices _IqlHoaDonServices;
        private IQLQuyDoiDiemServices _IqlQuyDoiDiemServices;
        private Guid _id;
        public Frm_KhachHang1()
        {
            InitializeComponent();
            _IqlKhachHangServices = new QLKhachHangServices();
            _IqlHoaDonServices =new QLHoaDonServices(); 
            _IqlQuyDoiDiemServices = new QLQuyDoiDiemServices();
            _IqlLichSuTichDiemServices=new QLLichSuTichDiemServices();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            kh_ma.Enabled = false;
            kh_ma.Text = MaTuSinh();
            kh_diemtich.Enabled = false;

        }
        private void LoadKH()
        {
            dtg_kh.Rows.Clear();
            dtg_kh.ColumnCount = 12;
            dtg_kh.Columns[0].Name = "STT";
            dtg_kh.Columns[1].Name = "Id";
            dtg_kh.Columns[1].Visible = false;
            dtg_kh.Columns[2].Name = "Mã";
            dtg_kh.Columns[3].Name = "Tên";
            dtg_kh.Columns[4].Name = "Tên đệm";
            dtg_kh.Columns[5].Name = "Họ";
            dtg_kh.Columns[6].Name = "Họ và tên";
            dtg_kh.Columns[7].Name = "Ngày sinh";
            dtg_kh.Columns[8].Name = "Số ĐT";
            dtg_kh.Columns[9].Name = "Địa chỉ";
            dtg_kh.Columns[10].Name = "Điểm tích";
            dtg_kh.Columns[11].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in _IqlKhachHangServices.GetAll())
            {
                dtg_kh.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.NgaySinh, x.Sdt, x.DiaChi, x.DiemTich, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
       
        public void Clear() 
        {
            kh_ma.Text = MaTuSinh();
            kh_ten.Text = "";
            kh_tendem.Text = "";
            kh_ho.Text = "";
            kh_ngaysinh.Value = DateTime.Now;
            kh_diachi.Text = "";
            kh_sdt.Text = "";
            kh_diemtich.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            LoadKH();
        }
        private void dtg_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            var kh = _IqlKhachHangServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_kh.Rows[rd].Cells[1].Value.ToString()));
            _id = kh.Id;
            kh_ma.Text = kh.Ma;
            kh_ten.Text = kh.Ten;
            kh_tendem.Text = kh.TenDem;
            kh_ho.Text = kh.Ho;
            kh_ngaysinh.Value = kh.NgaySinh;
            kh_diachi.Text = kh.DiaChi;
            kh_sdt.Text = kh.Sdt;
            //Tam Sua
            kh_diemtich.Text = kh.DiemTich.ToString();
            //
            if (kh.TrangThai == 1)
            {
                radioButton1.Checked = true;
            }
            else if (kh.TrangThai == 0)
            {
                radioButton2.Checked = false;
            }
        }
        private KhachHang GetDataFormGui()
        {
            KhachHang kh = new KhachHang();
            kh.Id = _id;
            kh.Ma = MaTuSinh();
            kh.Ten = kh_ten.Text;
            kh.TenDem = kh_tendem.Text;
            kh.Ho = kh_ho.Text;
            kh.NgaySinh = kh_ngaysinh.Value;
            kh.DiaChi = kh_diachi.Text;
            kh.Sdt = kh_sdt.Text;
            //Tam sua
            // kh.DiemTich = Convert.ToInt32(kh_diemtich.Text);
            //
            kh.DiemTich = 0;
            if (radioButton1.Checked == true)
            {
                kh.TrangThai = 1;
            }
            else if (radioButton2.Checked == true)
            {
                kh.TrangThai = 0;
            }
            return kh;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                if(kh_ma.Text.Trim() == "")
                {
                    MessageBox.Show("Mã khách hàng không được bỏ trống");
                }
                else if(_IqlKhachHangServices.GetAll().Any(c=>c.Ma== kh_ma.Text))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                }
                else if(kh_ten.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khách hàng không được bỏ trống");
                }
                else if (kh_tendem.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đệm khách hàng không được bỏ trống");
                }
                else if (kh_ho.Text.Trim() == "")
                {
                    MessageBox.Show("Họ khách hàng không được bỏ trống");
                }
                else if (kh_sdt.Text.Trim() == "")
                {
                    MessageBox.Show("SDT khách hàng không được bỏ trống!");
                }
                else if (kh_sdt.Text.Trim().Count() != 10)
                {
                    MessageBox.Show("SDT khách hàng không hợp lệ !");
                }
                else if (_IqlKhachHangServices.GetAll().Any(p => p.Sdt == kh_sdt.Text))
                {
                    MessageBox.Show("SDT khách hàng đã tồn tại!");
                }
                else if (kh_diachi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ khách hàng không được bỏ trống!");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Trạng thái khách hàng không được bỏ trống!");
                }
                else
                {
                    _IqlKhachHangServices.Add(GetDataFormGui());
                    LoadKH();
                }

            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlKhachHangServices.Update(GetDataFormGui());
                LoadKH();
            }
        }

       /* private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }*/

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

      
        public void loaddtgbysearch()
        {
          
        }
        private void btn_seachbyma_Click(object sender, EventArgs e)
        {
            dtg_kh.Rows.Clear();
            dtg_kh.ColumnCount = 12;
            dtg_kh.Columns[0].Name = "STT";
            dtg_kh.Columns[1].Name = "Id";
            dtg_kh.Columns[1].Visible = false;
            dtg_kh.Columns[2].Name = "Mã";
            dtg_kh.Columns[3].Name = "Tên";
            dtg_kh.Columns[4].Name = "Tên đệm";
            dtg_kh.Columns[5].Name = "Họ";
            dtg_kh.Columns[6].Name = "Họ và tên";
            dtg_kh.Columns[7].Name = "Ngày sinh";
            dtg_kh.Columns[8].Name = "Số ĐT";
            dtg_kh.Columns[9].Name = "Địa chỉ";
            dtg_kh.Columns[10].Name = "Điểm tích";
            dtg_kh.Columns[11].Name = "Trạng thái";
            int stt = 1;
            var tk = _IqlKhachHangServices.GetAll().Where(x => x.Ten.Contains(tk_timkiem.Text)).ToList();
            foreach (var x in tk)
            {
                dtg_kh.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten), x.NgaySinh, x.Sdt, x.DiaChi, x.DiemTich, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");

            }


        }
        private void tk_timkiem_TextChanged(object sender, EventArgs e, string s)
        {
        }

        private void tk_timkiem_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void Frm_KhachHang1_Load(object sender, EventArgs e)
        {
            LoadKH();
            LoadLSTD();
        }
        private void LoadLSTD()
        {
            dtg_xemtd.Rows.Clear();
            dtg_xemtd.ColumnCount = 8;
            dtg_xemtd.Columns[0].Name = "STT";
            dtg_xemtd.Columns[1].Name = "Id";
            dtg_xemtd.Columns[1].Visible = false;
            dtg_xemtd.Columns[2].Name = "Tên KH";
            dtg_xemtd.Columns[3].Name = "Số ĐT";
            dtg_xemtd.Columns[4].Name = "Mã HD";
            dtg_xemtd.Columns[5].Name = "Ngày Thay Đổi";
            dtg_xemtd.Columns[6].Name = "Điểm";
            dtg_xemtd.Columns[7].Name = "Trạng Thái";
            int stt = 1;
            dtg_xemtd.Rows.Clear();
            foreach (var x in _IqlLichSuTichDiemServices.GetAllView())
            {
                dtg_xemtd.Rows.Add(stt++, x.Id, x.Ten, x.Sdt, x.MaHD, x.NgayThayDoi, x.Diem, x.TrangThai == 1 ? "cộng điểm " : "trừ điểm ");
            }

        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _IqlKhachHangServices.GetAll().Count; i++)
            {
                string ma = _IqlKhachHangServices.GetAll()[i].Ma;
                string so = ma.Substring(2);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "KH00" + (max + 1);
            return s;
        }

        private void dtg_xemtd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
