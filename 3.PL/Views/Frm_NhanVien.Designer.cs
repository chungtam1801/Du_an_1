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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tk_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_nhanvien = new System.Windows.Forms.DataGridView();
            this.nv_cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.nv_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(497, 227);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 39);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(335, 227);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(125, 39);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(176, 227);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(125, 39);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(13, 227);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(125, 39);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên đệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Họ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giới tính";
            // 
            // nv_ma
            // 
            this.nv_ma.Location = new System.Drawing.Point(79, 33);
            this.nv_ma.Name = "nv_ma";
            this.nv_ma.Size = new System.Drawing.Size(222, 27);
            this.nv_ma.TabIndex = 30;
            // 
            // nv_ten
            // 
            this.nv_ten.Location = new System.Drawing.Point(79, 69);
            this.nv_ten.Name = "nv_ten";
            this.nv_ten.Size = new System.Drawing.Size(222, 27);
            this.nv_ten.TabIndex = 31;
            // 
            // nv_tendem
            // 
            this.nv_tendem.Location = new System.Drawing.Point(79, 106);
            this.nv_tendem.Name = "nv_tendem";
            this.nv_tendem.Size = new System.Drawing.Size(222, 27);
            this.nv_tendem.TabIndex = 32;
            // 
            // nv_ho
            // 
            this.nv_ho.Location = new System.Drawing.Point(79, 141);
            this.nv_ho.Name = "nv_ho";
            this.nv_ho.Size = new System.Drawing.Size(222, 27);
            this.nv_ho.TabIndex = 33;
            // 
            // nv_mk
            // 
            this.nv_mk.Location = new System.Drawing.Point(456, 141);
            this.nv_mk.Name = "nv_mk";
            this.nv_mk.Size = new System.Drawing.Size(222, 27);
            this.nv_mk.TabIndex = 45;
            // 
            // nv_Sdt
            // 
            this.nv_Sdt.Location = new System.Drawing.Point(456, 106);
            this.nv_Sdt.Name = "nv_Sdt";
            this.nv_Sdt.Size = new System.Drawing.Size(222, 27);
            this.nv_Sdt.TabIndex = 44;
            // 
            // nv_diachi
            // 
            this.nv_diachi.Location = new System.Drawing.Point(456, 69);
            this.nv_diachi.Name = "nv_diachi";
            this.nv_diachi.Size = new System.Drawing.Size(222, 27);
            this.nv_diachi.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sdt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tk_timkiem);
            this.groupBox1.Controls.Add(this.dtg_nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(0, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 259);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tìm kiếm";
            // 
            // tk_timkiem
            // 
            this.tk_timkiem.Location = new System.Drawing.Point(122, 26);
            this.tk_timkiem.Name = "tk_timkiem";
            this.tk_timkiem.Size = new System.Drawing.Size(645, 27);
            this.tk_timkiem.TabIndex = 46;
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(8, 57);
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 29;
            this.dtg_nhanvien.Size = new System.Drawing.Size(759, 196);
            this.dtg_nhanvien.TabIndex = 0;
            this.dtg_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_nhanvien_CellClick);
            // 
            // nv_cbb_gioitinh
            // 
            this.nv_cbb_gioitinh.AllowDrop = true;
            this.nv_cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nv_cbb_gioitinh.FormattingEnabled = true;
            this.nv_cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.nv_cbb_gioitinh.Location = new System.Drawing.Point(79, 180);
            this.nv_cbb_gioitinh.Name = "nv_cbb_gioitinh";
            this.nv_cbb_gioitinh.Size = new System.Drawing.Size(78, 28);
            this.nv_cbb_gioitinh.TabIndex = 48;
            this.nv_cbb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.nv_cbb_gioitinh_SelectedIndexChanged);
            // 
            // nv_ngaysinh
            // 
            this.nv_ngaysinh.Location = new System.Drawing.Point(455, 36);
            this.nv_ngaysinh.Name = "nv_ngaysinh";
            this.nv_ngaysinh.Size = new System.Drawing.Size(223, 27);
            this.nv_ngaysinh.TabIndex = 49;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(463, 182);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "còn làm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(605, 184);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 24);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "nghỉ làm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.nv_ngaysinh);
            this.Controls.Add(this.nv_cbb_gioitinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nv_mk);
            this.Controls.Add(this.nv_Sdt);
            this.Controls.Add(this.nv_diachi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nv_ho);
            this.Controls.Add(this.nv_tendem);
            this.Controls.Add(this.nv_ten);
            this.Controls.Add(this.nv_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tk_timkiem;
        private System.Windows.Forms.DataGridView dtg_nhanvien;
        private System.Windows.Forms.ComboBox nv_cbb_gioitinh;
        private System.Windows.Forms.DateTimePicker nv_ngaysinh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}