namespace _3.PL.Views
{
    partial class Frm_ChatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChatLieu));
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.rbtn_hd = new System.Windows.Forms.RadioButton();
            this.rbtn_kohd = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_timkiem = new System.Windows.Forms.ComboBox();
            this.tk_timkiem = new System.Windows.Forms.TextBox();
            this.btn_seachbyma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(54, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 20);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Trạng thái:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(54, 121);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 20);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Tên chất liệu:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(54, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 20);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Mã chất liệu:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(267, 253);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(59, 336);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(59, 253);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Location = new System.Drawing.Point(6, 137);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 51;
            this.dgvChatLieu.RowTemplate.Height = 29;
            this.dgvChatLieu.Size = new System.Drawing.Size(746, 281);
            this.dgvChatLieu.TabIndex = 17;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(223, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(125, 27);
            this.txtTen.TabIndex = 16;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(223, 60);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(125, 27);
            this.txtMa.TabIndex = 14;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(160, 182);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(102, 24);
            this.rbtn_hd.TabIndex = 26;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "Hoạt động";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            // 
            // rbtn_kohd
            // 
            this.rbtn_kohd.AutoSize = true;
            this.rbtn_kohd.Location = new System.Drawing.Point(267, 182);
            this.rbtn_kohd.Name = "rbtn_kohd";
            this.rbtn_kohd.Size = new System.Drawing.Size(146, 24);
            this.rbtn_kohd.TabIndex = 27;
            this.rbtn_kohd.TabStop = true;
            this.rbtn_kohd.Text = "Không hoạt động";
            this.rbtn_kohd.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(267, 336);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.rbtn_kohd);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.rbtn_hd);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Location = new System.Drawing.Point(864, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 450);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_timkiem);
            this.groupBox2.Controls.Add(this.tk_timkiem);
            this.groupBox2.Controls.Add(this.btn_seachbyma);
            this.groupBox2.Controls.Add(this.dgvChatLieu);
            this.groupBox2.Location = new System.Drawing.Point(83, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 450);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cbb_timkiem
            // 
            this.cbb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbb_timkiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbb_timkiem.FormattingEnabled = true;
            this.cbb_timkiem.Items.AddRange(new object[] {
            "Tìm kiếm theo mã",
            "Tìm kiếm theo size"});
            this.cbb_timkiem.Location = new System.Drawing.Point(86, 52);
            this.cbb_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_timkiem.Name = "cbb_timkiem";
            this.cbb_timkiem.Size = new System.Drawing.Size(177, 28);
            this.cbb_timkiem.TabIndex = 59;
            this.cbb_timkiem.Text = "  Tìm kiếm theo...";
            // 
            // tk_timkiem
            // 
            this.tk_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tk_timkiem.Location = new System.Drawing.Point(269, 52);
            this.tk_timkiem.Multiline = true;
            this.tk_timkiem.Name = "tk_timkiem";
            this.tk_timkiem.PlaceholderText = "   Nhập dữ liệu cần tìm";
            this.tk_timkiem.Size = new System.Drawing.Size(273, 29);
            this.tk_timkiem.TabIndex = 57;
            this.tk_timkiem.TextChanged += new System.EventHandler(this.tk_timkiem_TextChanged);
            // 
            // btn_seachbyma
            // 
            this.btn_seachbyma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seachbyma.Image = ((System.Drawing.Image)(resources.GetObject("btn_seachbyma.Image")));
            this.btn_seachbyma.Location = new System.Drawing.Point(568, 52);
            this.btn_seachbyma.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_seachbyma.Name = "btn_seachbyma";
            this.btn_seachbyma.Size = new System.Drawing.Size(35, 37);
            this.btn_seachbyma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seachbyma.TabIndex = 58;
            this.btn_seachbyma.TabStop = false;
            // 
            // Frm_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ChatLieu";
            this.Text = "ChatLieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.RadioButton rbtn_hd;
        private System.Windows.Forms.RadioButton rbtn_kohd;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_timkiem;
        private System.Windows.Forms.TextBox tk_timkiem;
        private System.Windows.Forms.PictureBox btn_seachbyma;
    }
}