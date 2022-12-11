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

namespace _3.PL.Views
{
    public partial class Frm_ThietLapDiem : Form
    {
        private QuyDoiDiemServices _quyDoiDiemServices = new QuyDoiDiemServices();
        public Frm_ThietLapDiem()
        {
            InitializeComponent();
            LoadDTG_Diem();
        }
        public void LoadDTG_Diem()
        {
            dtg_Diem.Rows.Clear();
            dtg_Diem.ColumnCount = 6;
            dtg_Diem.Columns[0].Name = "STT";
            dtg_Diem.Columns[1].Name = "Số điểm";
            dtg_Diem.Columns[2].Name = "Tỉ lệ tích điểm";
            dtg_Diem.Columns[3].Name = "Tỉ lệ tiêu điểm";
            dtg_Diem.Columns[4].Name = "Trạng thái";
            dtg_Diem.Columns[5].Name = "Id";
            dtg_Diem.Columns[5].Visible = false;
            int stt = 1;
            foreach(var x in _quyDoiDiemServices.GetAll())
            {
                dtg_Diem.Rows.Add(stt++, x.SoDiem, x.TiLeTichDiem, x.TiLeTieuDiem, x.TrangThai, x.Id);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_quyDoiDiemServices.CreateQuyDoiDiem(Convert.ToDecimal(tbx_Tien1.Text), Convert.ToInt32(tbx_Diem.Text), Convert.ToDecimal(tbx_Tien2.Text)));
            LoadDTG_Diem();
        }
        private void btn_BoQua_Click(object sender, EventArgs e)
        {

        }
        private void dtg_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_Tien1.Text = dtg_Diem.CurrentRow.Cells[2].Value.ToString();
            tbx_Tien2.Text = dtg_Diem.CurrentRow.Cells[3].Value.ToString();
            tbx_Diem.Text = dtg_Diem.CurrentRow.Cells[1].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
