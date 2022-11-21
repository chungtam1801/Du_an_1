namespace _3.PL.Views
{
    partial class Frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nv_ma = new System.Windows.Forms.TextBox();
            this.nv_ten = new System.Windows.Forms.TextBox();
            this.nv_tendem = new System.Windows.Forms.TextBox();
            this.nv_ho = new System.Windows.Forms.TextBox();
            this.nv_mk = new System.Windows.Forms.TextBox();
            this.nv_Sdt = new System.Windows.Forms.TextBox();
            this.nv_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtg_nhanvien = new System.Windows.Forms.DataGridView();
            this.tk_timkiem = new System.Windows.Forms.TextBox();
            this.nv_cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.nv_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rbtn_conlam = new System.Windows.Forms.RadioButton();
            this.rbtn_nghilam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_seachbyma = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.Snow;
            this.btn_clear.Location = new System.Drawing.Point(157, 347);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 42);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Snow;
            this.btn_xoa.Location = new System.Drawing.Point(19, 347);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 44);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Snow;
            this.btn_sua.Location = new System.Drawing.Point(157, 287);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(123, 44);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Snow;
            this.btn_them.Location = new System.Drawing.Point(19, 287);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(123, 44);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên đệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Họ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giới tính";
            // 
            // nv_ma
            // 
            this.nv_ma.Location = new System.Drawing.Point(85, 7);
            this.nv_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_ma.Name = "nv_ma";
            this.nv_ma.Size = new System.Drawing.Size(195, 23);
            this.nv_ma.TabIndex = 30;
            // 
            // nv_ten
            // 
            this.nv_ten.Location = new System.Drawing.Point(85, 34);
            this.nv_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_ten.Name = "nv_ten";
            this.nv_ten.Size = new System.Drawing.Size(195, 23);
            this.nv_ten.TabIndex = 31;
            // 
            // nv_tendem
            // 
            this.nv_tendem.Location = new System.Drawing.Point(85, 61);
            this.nv_tendem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_tendem.Name = "nv_tendem";
            this.nv_tendem.Size = new System.Drawing.Size(195, 23);
            this.nv_tendem.TabIndex = 32;
            // 
            // nv_ho
            // 
            this.nv_ho.Location = new System.Drawing.Point(85, 88);
            this.nv_ho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_ho.Name = "nv_ho";
            this.nv_ho.Size = new System.Drawing.Size(195, 23);
            this.nv_ho.TabIndex = 33;
            // 
            // nv_mk
            // 
            this.nv_mk.Location = new System.Drawing.Point(85, 196);
            this.nv_mk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_mk.Name = "nv_mk";
            this.nv_mk.Size = new System.Drawing.Size(195, 23);
            this.nv_mk.TabIndex = 45;
            // 
            // nv_Sdt
            // 
            this.nv_Sdt.Location = new System.Drawing.Point(85, 169);
            this.nv_Sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_Sdt.Name = "nv_Sdt";
            this.nv_Sdt.Size = new System.Drawing.Size(195, 23);
            this.nv_Sdt.TabIndex = 44;
            // 
            // nv_diachi
            // 
            this.nv_diachi.Location = new System.Drawing.Point(85, 223);
            this.nv_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_diachi.Name = "nv_diachi";
            this.nv_diachi.Size = new System.Drawing.Size(195, 23);
            this.nv_diachi.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sdt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ngày sinh";
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(12, 89);
            this.dtg_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 29;
            this.dtg_nhanvien.Size = new System.Drawing.Size(1394, 404);
            this.dtg_nhanvien.TabIndex = 0;
            this.dtg_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_nhanvien_CellClick);
            // 
            // tk_timkiem
            // 
            this.tk_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tk_timkiem.Location = new System.Drawing.Point(11, 5);
            this.tk_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tk_timkiem.Multiline = true;
            this.tk_timkiem.Name = "tk_timkiem";
            this.tk_timkiem.PlaceholderText = "   Tìm kiếm nhân viên theo mã";
            this.tk_timkiem.Size = new System.Drawing.Size(370, 29);
            this.tk_timkiem.TabIndex = 46;
            // 
            // nv_cbb_gioitinh
            // 
            this.nv_cbb_gioitinh.AllowDrop = true;
            this.nv_cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nv_cbb_gioitinh.FormattingEnabled = true;
            this.nv_cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.nv_cbb_gioitinh.Location = new System.Drawing.Point(85, 115);
            this.nv_cbb_gioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_cbb_gioitinh.Name = "nv_cbb_gioitinh";
            this.nv_cbb_gioitinh.Size = new System.Drawing.Size(69, 23);
            this.nv_cbb_gioitinh.TabIndex = 48;
            this.nv_cbb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.nv_cbb_gioitinh_SelectedIndexChanged);
            // 
            // nv_ngaysinh
            // 
            this.nv_ngaysinh.Location = new System.Drawing.Point(85, 142);
            this.nv_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nv_ngaysinh.Name = "nv_ngaysinh";
            this.nv_ngaysinh.Size = new System.Drawing.Size(196, 23);
            this.nv_ngaysinh.TabIndex = 49;
            // 
            // rbtn_conlam
            // 
            this.rbtn_conlam.AutoSize = true;
            this.rbtn_conlam.Location = new System.Drawing.Point(85, 250);
            this.rbtn_conlam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_conlam.Name = "rbtn_conlam";
            this.rbtn_conlam.Size = new System.Drawing.Size(68, 19);
            this.rbtn_conlam.TabIndex = 50;
            this.rbtn_conlam.TabStop = true;
            this.rbtn_conlam.Text = "còn làm";
            this.rbtn_conlam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nghilam
            // 
            this.rbtn_nghilam.AutoSize = true;
            this.rbtn_nghilam.Location = new System.Drawing.Point(159, 250);
            this.rbtn_nghilam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_nghilam.Name = "rbtn_nghilam";
            this.rbtn_nghilam.Size = new System.Drawing.Size(72, 19);
            this.rbtn_nghilam.TabIndex = 51;
            this.rbtn_nghilam.TabStop = true;
            this.rbtn_nghilam.Text = "nghỉ làm";
            this.rbtn_nghilam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 35);
            this.panel1.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(69, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btn_seachbyma
            // 
            this.btn_seachbyma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seachbyma.Image = ((System.Drawing.Image)(resources.GetObject("btn_seachbyma.Image")));
            this.btn_seachbyma.Location = new System.Drawing.Point(387, 5);
            this.btn_seachbyma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seachbyma.Name = "btn_seachbyma";
            this.btn_seachbyma.Size = new System.Drawing.Size(31, 28);
            this.btn_seachbyma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seachbyma.TabIndex = 53;
            this.btn_seachbyma.TabStop = false;
            this.btn_seachbyma.Click += new System.EventHandler(this.btn_seachbyma_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nv_ma);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nv_ten);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rbtn_nghilam);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.nv_tendem);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.rbtn_conlam);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nv_ngaysinh);
            this.panel2.Controls.Add(this.nv_mk);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nv_ho);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.nv_Sdt);
            this.panel2.Controls.Add(this.nv_cbb_gioitinh);
            this.panel2.Controls.Add(this.nv_diachi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(9, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 404);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.tk_timkiem);
            this.panel3.Controls.Add(this.btn_seachbyma);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1724, 37);
            this.panel3.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(12, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1394, 35);
            this.panel4.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(622, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1403, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 468);
            this.panel5.TabIndex = 57;
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1724, 505);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtg_nhanvien);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NhanVien";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nv_ma;
        private System.Windows.Forms.TextBox nv_ten;
        private System.Windows.Forms.TextBox nv_tendem;
        private System.Windows.Forms.TextBox nv_ho;
        private System.Windows.Forms.TextBox nv_mk;
        private System.Windows.Forms.TextBox nv_Sdt;
        private System.Windows.Forms.TextBox nv_diachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tk_timkiem;
        private System.Windows.Forms.DataGridView dtg_nhanvien;
        private System.Windows.Forms.ComboBox nv_cbb_gioitinh;
        private System.Windows.Forms.DateTimePicker nv_ngaysinh;
        private System.Windows.Forms.RadioButton rbtn_conlam;
        private System.Windows.Forms.RadioButton rbtn_nghilam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_seachbyma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
    }
}