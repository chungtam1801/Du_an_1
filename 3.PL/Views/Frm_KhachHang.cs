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
    public partial class Frm_KhachHang : Form
    {
       
        private IQLKhachHangServices _IqlKhachHangServices;
        private Guid _id;
        public Frm_KhachHang()
        {
            InitializeComponent();
           
            _IqlKhachHangServices = new QLKhachHangServices();
            kh_ma.Enabled = false;
            kh_diemtich.Enabled = false;
            
            
        }
        private void LoadKH()
        {
            dtg_kh.Rows.Clear();
            dtg_kh.ColumnCount = 12;
            dtg_kh.Columns[0].Name = "STT";
            dtg_kh.Columns[1].Name = "Id";
            dtg_kh.Columns[1].Visible=false;
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
                dtg_kh.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.TenDem, x.Ho, string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten),x.NgaySinh,x.Sdt,x.DiaChi,x.DiemTich,x.TrangThai==1?"Hoạt động":"Không hoạt động");
            }

        }
        public void Clear()
        {
            kh_ma.Text = "";
            kh_ten.Text = "";
            kh_tendem.Text = "";
            kh_ho.Text = "";
            kh_ngaysinh.Value=DateTime.Now;
            kh_diachi.Text = "";
            kh_sdt.Text = "";
            kh_diemtich.Text = "";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            LoadKH();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtg_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd=e.RowIndex;
            var kh = _IqlKhachHangServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_kh.Rows[rd].Cells[1].Value.ToString()));
            _id = kh.Id;
            kh_ma.Text = kh.Ma;
            kh_ten.Text = kh.Ten;
            kh_tendem.Text = kh.TenDem;
            kh_ho.Text = kh.Ho;
            kh_ngaysinh.Value = kh.NgaySinh;
            kh_diachi.Text = kh.DiaChi;
            kh_sdt.Text = kh.Sdt;
            kh_diemtich.Text = kh.DiemTich;
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
            KhachHang kh =new KhachHang();
            kh.Id = _id;
            kh.Ma = kh_ma.Text;
            kh.Ten = kh_ten.Text;
            kh.TenDem= kh_tendem.Text;
            kh.Ho = kh_ho.Text;
            kh.NgaySinh = kh_ngaysinh.Value;
            kh.DiaChi= kh_diachi.Text;
            kh.Sdt= kh_sdt.Text;
            kh.DiemTich= kh_diemtich.Text;
            if (radioButton1.Checked == true)
            {
                kh.TrangThai = 1;
            }
            else if(radioButton2.Checked == true)
            {
                kh.TrangThai= 0;
            }
            return kh;

        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();

        }

        private void them_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                _IqlKhachHangServices.Add(GetDataFormGui());
                LoadKH();
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlKhachHangServices.Update(GetDataFormGui());
                LoadKH();
            }
        }

       /* private void xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo))
            {
                _IqlKhachHangServices.Delete(GetDataFormGui());
                LoadKH();
            }
        }*/

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void kh_timkiem_TextChanged(object sender, EventArgs e)
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
            dtg_kh.Columns[10].Name = "Điẻm tích";
            dtg_kh.Columns[11].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in _IqlKhachHangServices.GetAll())
            {
               
            }
        }
    }
}
