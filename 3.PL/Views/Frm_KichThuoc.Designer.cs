namespace _3.PL.Views
{
    partial class Frm_KichThuoc
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
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.rbtn_conhang = new System.Windows.Forms.RadioButton();
            this.rbtn_hethang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_KichThuoc = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.cbb_timkiem = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KichThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ma
            // 
            this.tb_ma.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ma.Location = new System.Drawing.Point(100, 26);
            this.tb_ma.Multiline = true;
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(187, 34);
            this.tb_ma.TabIndex = 0;
            // 
            // tb_size
            // 
            this.tb_size.BackColor = System.Drawing.SystemColors.Window;
            this.tb_size.Location = new System.Drawing.Point(100, 78);
            this.tb_size.Multiline = true;
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(187, 34);
            this.tb_size.TabIndex = 1;
            // 
            // rbtn_conhang
            // 
            this.rbtn_conhang.AutoSize = true;
            this.rbtn_conhang.BackColor = System.Drawing.Color.LightGray;
            this.rbtn_conhang.Location = new System.Drawing.Point(100, 142);
            this.rbtn_conhang.Name = "rbtn_conhang";
            this.rbtn_conhang.Size = new System.Drawing.Size(77, 19);
            this.rbtn_conhang.TabIndex = 2;
            this.rbtn_conhang.TabStop = true;
            this.rbtn_conhang.Text = "Còn hàng";
            this.rbtn_conhang.UseVisualStyleBackColor = false;
            // 
            // rbtn_hethang
            // 
            this.rbtn_hethang.AutoSize = true;
            this.rbtn_hethang.BackColor = System.Drawing.Color.LightGray;
            this.rbtn_hethang.Location = new System.Drawing.Point(197, 142);
            this.rbtn_hethang.Name = "rbtn_hethang";
            this.rbtn_hethang.Size = new System.Drawing.Size(74, 19);
            this.rbtn_hethang.TabIndex = 3;
            this.rbtn_hethang.TabStop = true;
            this.rbtn_hethang.Text = "Hết hàng";
            this.rbtn_hethang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng thái";
            // 
            // dtg_KichThuoc
            // 
            this.dtg_KichThuoc.AllowUserToAddRows = false;
            this.dtg_KichThuoc.AllowUserToDeleteRows = false;
            this.dtg_KichThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_KichThuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_KichThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_KichThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_KichThuoc.Location = new System.Drawing.Point(0, 0);
            this.dtg_KichThuoc.Name = "dtg_KichThuoc";
            this.dtg_KichThuoc.RowHeadersWidth = 51;
            this.dtg_KichThuoc.RowTemplate.Height = 25;
            this.dtg_KichThuoc.Size = new System.Drawing.Size(728, 370);
            this.dtg_KichThuoc.TabIndex = 7;
            this.dtg_KichThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_KichThuoc_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_them.Location = new System.Drawing.Point(21, 216);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 55);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sua.Location = new System.Drawing.Point(157, 216);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 55);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_xoa.Location = new System.Drawing.Point(21, 277);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 55);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_clear.Location = new System.Drawing.Point(157, 277);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 55);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_ma);
            this.panel1.Controls.Add(this.tb_size);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbtn_conhang);
            this.panel1.Controls.Add(this.rbtn_hethang);
            this.panel1.Location = new System.Drawing.Point(751, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 370);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(751, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 35);
            this.panel2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(110, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức năng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.tb_timkiem);
            this.panel3.Controls.Add(this.cbb_timkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 35);
            this.panel3.TabIndex = 54;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tb_timkiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_timkiem.Location = new System.Drawing.Point(171, 6);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.PlaceholderText = "  Nhập dữ liệu cần tìm kiếm";
            this.tb_timkiem.Size = new System.Drawing.Size(237, 23);
            this.tb_timkiem.TabIndex = 1;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            this.tb_timkiem.Leave += new System.EventHandler(this.tb_timkiem_Leave);
            // 
            // cbb_timkiem
            // 
            this.cbb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbb_timkiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbb_timkiem.FormattingEnabled = true;
            this.cbb_timkiem.Items.AddRange(new object[] {
            "Tìm kiếm theo mã",
            "Tìm kiếm theo size"});
            this.cbb_timkiem.Location = new System.Drawing.Point(5, 6);
            this.cbb_timkiem.Name = "cbb_timkiem";
            this.cbb_timkiem.Size = new System.Drawing.Size(155, 23);
            this.cbb_timkiem.TabIndex = 0;
            this.cbb_timkiem.Text = "  Tìm kiếm theo...";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtg_KichThuoc);
            this.panel4.Location = new System.Drawing.Point(5, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 370);
            this.panel4.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(5, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(728, 35);
            this.panel5.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(266, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin kích thước";
            // 
            // Frm_KichThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 499);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_KichThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_KichThuoc";
            this.Load += new System.EventHandler(this.Frm_KichThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KichThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.RadioButton rbtn_conhang;
        private System.Windows.Forms.RadioButton rbtn_hethang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_KichThuoc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.ComboBox cbb_timkiem;
    }
}