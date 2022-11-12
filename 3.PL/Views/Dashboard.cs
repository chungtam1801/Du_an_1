using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _3.PL.Views
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int BottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btn_Dashboard.Height;
            pnlNav.Top = btn_Dashboard.Top;
            pnlNav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbl_Title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_Dashboard.Height;
            pnlNav.Top = btn_Dashboard.Top;
            pnlNav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
            lbl_Title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_Sell.Height;
            pnlNav.Top = btn_Sell.Top;
            btn_Sell.BackColor = Color.FromArgb(46, 51, 73);
            lbl_Title.Text = "Sell";
            this.PnlFormLoader.Controls.Clear();
        }

        private void btn_Dashboard_Leave(object sender, EventArgs e)
        {
            btn_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Sell_Leave(object sender, EventArgs e)
        {
            btn_Sell.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
