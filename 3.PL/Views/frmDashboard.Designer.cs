namespace _3.PL.Views
{
    partial class frmDashboard
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
            this.dtg_SanPham = new System.Windows.Forms.DataGridView();
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.tbx_TienThoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_TienKhachDua = new System.Windows.Forms.TextBox();
            this.tbx_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_NgayThanhToan = new System.Windows.Forms.TextBox();
            this.tbx_NhanVien = new System.Windows.Forms.TextBox();
            this.tbx_NgayTao = new System.Windows.Forms.TextBox();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_SanPham
            // 
            this.dtg_SanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtg_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SanPham.Location = new System.Drawing.Point(37, 296);
            this.dtg_SanPham.Name = "dtg_SanPham";
            this.dtg_SanPham.RowTemplate.Height = 25;
            this.dtg_SanPham.Size = new System.Drawing.Size(406, 148);
            this.dtg_SanPham.TabIndex = 0;
            this.dtg_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SanPham_CellClick);
            // 
            // dtg_HoaDon
            // 
            this.dtg_HoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HoaDon.Location = new System.Drawing.Point(37, 21);
            this.dtg_HoaDon.Name = "dtg_HoaDon";
            this.dtg_HoaDon.RowTemplate.Height = 25;
            this.dtg_HoaDon.Size = new System.Drawing.Size(406, 124);
            this.dtg_HoaDon.TabIndex = 1;
            this.dtg_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_HoaDon_CellClick);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(33, 354);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(89, 35);
            this.btn_TaoHoaDon.TabIndex = 2;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox1.Controls.Add(this.btn_ThanhToan);
            this.groupBox1.Controls.Add(this.tbx_TienThoi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbx_TienKhachDua);
            this.groupBox1.Controls.Add(this.tbx_TongTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbx_NgayThanhToan);
            this.groupBox1.Controls.Add(this.btn_TaoHoaDon);
            this.groupBox1.Controls.Add(this.tbx_NhanVien);
            this.groupBox1.Controls.Add(this.tbx_NgayTao);
            this.groupBox1.Controls.Add(this.tbx_Ma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(464, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 423);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(139, 354);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(89, 35);
            this.btn_ThanhToan.TabIndex = 14;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // tbx_TienThoi
            // 
            this.tbx_TienThoi.Location = new System.Drawing.Point(35, 215);
            this.tbx_TienThoi.Name = "tbx_TienThoi";
            this.tbx_TienThoi.Size = new System.Drawing.Size(193, 23);
            this.tbx_TienThoi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền thối";
            // 
            // tbx_TienKhachDua
            // 
            this.tbx_TienKhachDua.Location = new System.Drawing.Point(35, 171);
            this.tbx_TienKhachDua.Name = "tbx_TienKhachDua";
            this.tbx_TienKhachDua.Size = new System.Drawing.Size(193, 23);
            this.tbx_TienKhachDua.TabIndex = 11;
            this.tbx_TienKhachDua.TextChanged += new System.EventHandler(this.tbx_TienKhachDua_TextChanged);
            // 
            // tbx_TongTien
            // 
            this.tbx_TongTien.Location = new System.Drawing.Point(35, 127);
            this.tbx_TongTien.Name = "tbx_TongTien";
            this.tbx_TongTien.Size = new System.Drawing.Size(193, 23);
            this.tbx_TongTien.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền khách đưa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền";
            // 
            // tbx_NgayThanhToan
            // 
            this.tbx_NgayThanhToan.Location = new System.Drawing.Point(35, 302);
            this.tbx_NgayThanhToan.Name = "tbx_NgayThanhToan";
            this.tbx_NgayThanhToan.Size = new System.Drawing.Size(193, 23);
            this.tbx_NgayThanhToan.TabIndex = 7;
            // 
            // tbx_NhanVien
            // 
            this.tbx_NhanVien.Location = new System.Drawing.Point(35, 81);
            this.tbx_NhanVien.Name = "tbx_NhanVien";
            this.tbx_NhanVien.Size = new System.Drawing.Size(193, 23);
            this.tbx_NhanVien.TabIndex = 6;
            // 
            // tbx_NgayTao
            // 
            this.tbx_NgayTao.Location = new System.Drawing.Point(35, 258);
            this.tbx_NgayTao.Name = "tbx_NgayTao";
            this.tbx_NgayTao.Size = new System.Drawing.Size(193, 23);
            this.tbx_NgayTao.TabIndex = 5;
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(35, 37);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(193, 23);
            this.tbx_Ma.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // dtg_ChiTietHoaDon
            // 
            this.dtg_ChiTietHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtg_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChiTietHoaDon.Location = new System.Drawing.Point(37, 151);
            this.dtg_ChiTietHoaDon.Name = "dtg_ChiTietHoaDon";
            this.dtg_ChiTietHoaDon.RowTemplate.Height = 25;
            this.dtg_ChiTietHoaDon.Size = new System.Drawing.Size(406, 139);
            this.dtg_ChiTietHoaDon.TabIndex = 4;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(758, 477);
            this.Controls.Add(this.dtg_ChiTietHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_HoaDon);
            this.Controls.Add(this.dtg_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_SanPham;
        private System.Windows.Forms.DataGridView dtg_HoaDon;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_NgayThanhToan;
        private System.Windows.Forms.TextBox tbx_NhanVien;
        private System.Windows.Forms.TextBox tbx_NgayTao;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.TextBox tbx_TienThoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_TienKhachDua;
        private System.Windows.Forms.TextBox tbx_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtg_ChiTietHoaDon;
    }
}