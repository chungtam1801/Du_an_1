using _1.DAL.DomainClass;
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
    public partial class Frm_LoaiSP : Form
    {
        private IQLLoaiSpServices _IplLoaiSPServices;
        private Guid _id;

        public Frm_LoaiSP()
        {
            InitializeComponent();
            _IplLoaiSPServices = new QLLoaiSpServices();
            loai_ma.Enabled = false;
            loai_ma.Text = MaTuSinh();
           

        }
        private void LoadLSPCha()
        {
            loai_macha.Items.Clear();
            foreach (var x in _IplLoaiSPServices.GetAll().Where(c => c.MaLoaiSpcha == null).ToList())
            {
                loai_macha.Items.Add(x.Ten);
            }
        }
        public void LoadLSP()
        {
            dtg_loai.Rows.Clear();
            dtg_loai.ColumnCount = 6;
            dtg_loai.Columns[0].Name = "STT";
            dtg_loai.Columns[1].Name = "Id";
            dtg_loai.Columns[1].Visible = false;
            dtg_loai.Columns[2].Name = "Mã";
            dtg_loai.Columns[3].Name = "Tên";
            dtg_loai.Columns[4].Name = "Tên SP cha";
           dtg_loai.Columns[5].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in _IplLoaiSPServices.GetAll())
            {
                dtg_loai.Rows.Add(stt++, x.Id, x.Ma, x.Ten,x.MaLoaiSpcha!=null?_IplLoaiSPServices.GetAll().First(c=>c.Id==x.MaLoaiSpcha).Ten:"", x.TrangThai == 1 ? "còn" : "hết");
            }

        }
        public void Loadform()
        {
            loai_ma.Text = MaTuSinh();
            loai_ten.Text = "";
            loai_macha.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            LoadLSP();

        }

        private void dtg_loai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if(rd >= 0 && rd < _IplLoaiSPServices.GetAll().Count)
            {
                var lsp = _IplLoaiSPServices.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_loai.Rows[rd].Cells[1].Value.ToString()));
                _id = lsp.Id;
                loai_ma.Text = lsp.Ma;
                loai_ten.Text = lsp.Ten;
                loai_macha.Text = lsp.MaLoaiSpcha != null ? _IplLoaiSPServices.GetAll().First(c => c.Id == lsp.MaLoaiSpcha).Ten : "";


                if (lsp.TrangThai == 1)
                {
                    radioButton1.Checked = true;
                }
                else if (lsp.TrangThai == 0)
                {
                    radioButton2.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Ngoài vùng dữ liệu");
            }
           
        }
        private LoaiSp getdataFormGui()
        {
            LoaiSp lsp = new LoaiSp();
            lsp.Id = _id;
            lsp.Ma=loai_ma.Text;
            lsp.Ten=loai_ten.Text;
            loai_macha.Text = lsp.MaLoaiSpcha != null ? _IplLoaiSPServices.GetAll().First(c => c.Id == lsp.MaLoaiSpcha).Ten : "";
            if (radioButton1.Checked == true)
            {
                lsp.TrangThai = 1;
            }
            else if (radioButton2.Checked == true)
            {
                lsp.TrangThai = 0;
            }
            return lsp;

        }
        private string MaTuSinh()
        {
            string s;
            int max = 0;
            for (int i = 0; i < _IplLoaiSPServices.GetAll().Count; i++)
            {
                string ma = _IplLoaiSPServices.GetAll()[i].Ma;
                string so = ma.Substring(3);
                int x = Convert.ToInt32(so);
                if (x > max)
                {
                    max = x;
                }
            }
            s = "LSP00" + (max + 1);
            return s;
        }

        private void Frm_LoaiSP_Load(object sender, EventArgs e)
        {
            LoadLSP();
            LoadLSPCha();
           
        }

        private void them_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
           
        }

        private void sua_Click(object sender, EventArgs e)
        {
           
        }

        private void xoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_seachbyma_Click(object sender, EventArgs e)
        {
            dtg_loai.Rows.Clear();
            dtg_loai.ColumnCount = 6;
            dtg_loai.Columns[0].Name = "STT";
            dtg_loai.Columns[1].Name = "Id";
            dtg_loai.Columns[1].Visible = false;
            dtg_loai.Columns[2].Name = "Mã";
            dtg_loai.Columns[3].Name = "Tên";
            dtg_loai.Columns[4].Name = "Tên SP cha";
            dtg_loai.Columns[5].Name = "Trạng thái";
            int stt = 1;
            var tk = _IplLoaiSPServices.GetAll().Where(c => c.Ten.Contains(tk_timkiem.Text)).ToList();
            foreach(var x in tk)
            {
                dtg_loai.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.MaLoaiSpcha != null ? _IplLoaiSPServices.GetAll().First(c => c.Id == x.MaLoaiSpcha).Ten : "", x.TrangThai == 1 ? "còn" : "hết");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            LoaiSp LSP = new LoaiSp();
            LSP.Id = _id;
            LSP.Ma = MaTuSinh();
            LSP.Ten = loai_ten.Text;
            if (radioButton1.Checked == true)
            {
                LSP.TrangThai = 1;
            }
            else if (radioButton2.Checked == true)
            {
                LSP.TrangThai = 0;
            }

            if (loai_macha.Text == "")
            {
                LSP.MaLoaiSpcha = null;
            }
            else
            {
                LSP.MaLoaiSpcha = _IplLoaiSPServices.GetAll().First(c => c.Ten == loai_macha.Text).Id;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_IplLoaiSPServices.Add(LSP));
            }
            LoadLSP();
            LoadLSPCha();
        }

        private void tk_timkiem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tk_timkiem_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            LoaiSp LSP = new LoaiSp();
            LSP.Id = _id;
            LSP.Ma = MaTuSinh();
            LSP.Ten = loai_ten.Text;
            if (loai_macha.Text == "")
            {
                LSP.MaLoaiSpcha = null;
            }
            if (radioButton1.Checked == true)
            {
                LSP.TrangThai = 1;
            }
            else if (radioButton2.Checked == true)
            {
                LSP.TrangThai = 0;
            }
            else
            {
                LSP.MaLoaiSpcha = _IplLoaiSPServices.GetAll().First(c => c.Ten == loai_macha.Text).Id;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(_IplLoaiSPServices.Update(LSP));
            }
            LoadLSP();
            LoadLSPCha();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Loadform();
        }
    }
}
