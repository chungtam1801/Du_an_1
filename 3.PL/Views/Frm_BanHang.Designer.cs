namespace _3.PL.Views
{
    partial class Frm_BanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BanHang));
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.pnl_CTSP = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flp_SanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tsc_HoaDon = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_BanHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_DatHang = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaAll = new System.Windows.Forms.Button();
            this.dtg_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_QR = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.pnl_CTSP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tsc_HoaDon.TopToolStripPanel.SuspendLayout();
            this.tsc_HoaDon.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_HoaDon
            // 
            this.dtg_HoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_HoaDon.Location = new System.Drawing.Point(3, 21);
            this.dtg_HoaDon.Name = "dtg_HoaDon";
            this.dtg_HoaDon.RowTemplate.Height = 25;
            this.dtg_HoaDon.Size = new System.Drawing.Size(528, 290);
            this.dtg_HoaDon.TabIndex = 10;
            this.dtg_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_HoaDon_CellClick);
            // 
            // pnl_CTSP
            // 
            this.pnl_CTSP.Controls.Add(this.groupBox3);
            this.pnl_CTSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CTSP.Location = new System.Drawing.Point(0, 519);
            this.pnl_CTSP.Name = "pnl_CTSP";
            this.pnl_CTSP.Size = new System.Drawing.Size(1924, 542);
            this.pnl_CTSP.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flp_SanPham);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1924, 542);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // flp_SanPham
            // 
            this.flp_SanPham.AutoScroll = true;
            this.flp_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_SanPham.Location = new System.Drawing.Point(3, 21);
            this.flp_SanPham.Name = "flp_SanPham";
            this.flp_SanPham.Size = new System.Drawing.Size(1918, 518);
            this.flp_SanPham.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1136, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 519);
            this.panel4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tsc_HoaDon);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(788, 519);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin hóa đơn";
            // 
            // tsc_HoaDon
            // 
            this.tsc_HoaDon.BottomToolStripPanelVisible = false;
            // 
            // tsc_HoaDon.ContentPanel
            // 
            this.tsc_HoaDon.ContentPanel.Size = new System.Drawing.Size(782, 470);
            this.tsc_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_HoaDon.LeftToolStripPanelVisible = false;
            this.tsc_HoaDon.Location = new System.Drawing.Point(3, 21);
            this.tsc_HoaDon.Name = "tsc_HoaDon";
            this.tsc_HoaDon.RightToolStripPanelVisible = false;
            this.tsc_HoaDon.Size = new System.Drawing.Size(782, 495);
            this.tsc_HoaDon.TabIndex = 0;
            this.tsc_HoaDon.Text = "toolStripContainer1";
            // 
            // tsc_HoaDon.TopToolStripPanel
            // 
            this.tsc_HoaDon.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_BanHang,
            this.toolStripSeparator1,
            this.tsb_DatHang});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(138, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsb_BanHang
            // 
            this.tsb_BanHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_BanHang.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BanHang.Image")));
            this.tsb_BanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BanHang.Name = "tsb_BanHang";
            this.tsb_BanHang.Size = new System.Drawing.Size(61, 22);
            this.tsb_BanHang.Text = "Bán hàng";
            this.tsb_BanHang.Click += new System.EventHandler(this.tsb_BanHang_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_DatHang
            // 
            this.tsb_DatHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_DatHang.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DatHang.Image")));
            this.tsb_DatHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DatHang.Name = "tsb_DatHang";
            this.tsb_DatHang.Size = new System.Drawing.Size(59, 22);
            this.tsb_DatHang.Text = "Đặt hàng";
            this.tsb_DatHang.Click += new System.EventHandler(this.tsb_DatHang_Click);
            // 
            // btn_XoaAll
            // 
            this.btn_XoaAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_XoaAll.Location = new System.Drawing.Point(958, 0);
            this.btn_XoaAll.Name = "btn_XoaAll";
            this.btn_XoaAll.Size = new System.Drawing.Size(172, 54);
            this.btn_XoaAll.TabIndex = 11;
            this.btn_XoaAll.Text = "Xoá toàn bộ";
            this.btn_XoaAll.UseVisualStyleBackColor = true;
            // 
            // dtg_ChiTietHD
            // 
            this.dtg_ChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dtg_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_ChiTietHD.GridColor = System.Drawing.Color.White;
            this.dtg_ChiTietHD.Location = new System.Drawing.Point(3, 21);
            this.dtg_ChiTietHD.Name = "dtg_ChiTietHD";
            this.dtg_ChiTietHD.RowTemplate.Height = 25;
            this.dtg_ChiTietHD.Size = new System.Drawing.Size(1130, 121);
            this.dtg_ChiTietHD.TabIndex = 10;
            this.dtg_ChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChiTietHD_CellClick);
            this.dtg_ChiTietHD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_ChiTietHD_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 519);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.dtg_ChiTietHD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 205);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_XoaAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 54);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_QR);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 314);
            this.panel1.TabIndex = 16;
            // 
            // ptb_QR
            // 
            this.ptb_QR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_QR.Location = new System.Drawing.Point(534, 0);
            this.ptb_QR.Name = "ptb_QR";
            this.ptb_QR.Size = new System.Drawing.Size(602, 314);
            this.ptb_QR.TabIndex = 15;
            this.ptb_QR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_HoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 314);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pnl_CTSP);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.pnl_CTSP.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tsc_HoaDon.TopToolStripPanel.ResumeLayout(false);
            this.tsc_HoaDon.TopToolStripPanel.PerformLayout();
            this.tsc_HoaDon.ResumeLayout(false);
            this.tsc_HoaDon.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_CTSP;
        private System.Windows.Forms.DataGridView dtg_HoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtg_ChiTietHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_SanPham;
        private System.Windows.Forms.ToolStripContainer tsc_HoaDon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_BanHang;
        private System.Windows.Forms.ToolStripButton tsb_DatHang;
        private System.Windows.Forms.PictureBox ptb_QR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btn_XoaAll;
        private System.Windows.Forms.Panel panel3;
    }
}
