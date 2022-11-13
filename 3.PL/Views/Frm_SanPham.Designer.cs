namespace _3.PL.Views
{
    partial class Frm_SanPham
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
            this.dgrd_sanpham = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_kohd = new System.Windows.Forms.RadioButton();
            this.rbtn_hd = new System.Windows.Forms.RadioButton();
            this.tbx_mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(466, 125);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 29);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(325, 125);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 29);
            this.btn_xoa.TabIndex = 26;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(186, 125);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 29);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(43, 125);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 29);
            this.btn_them.TabIndex = 24;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgrd_sanpham
            // 
            this.dgrd_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrd_sanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrd_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_sanpham.Location = new System.Drawing.Point(12, 170);
            this.dgrd_sanpham.Name = "dgrd_sanpham";
            this.dgrd_sanpham.RowTemplate.Height = 25;
            this.dgrd_sanpham.Size = new System.Drawing.Size(776, 260);
            this.dgrd_sanpham.TabIndex = 23;
            this.dgrd_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_sanpham_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Trạng thái";
            // 
            // rbtn_kohd
            // 
            this.rbtn_kohd.AutoSize = true;
            this.rbtn_kohd.Location = new System.Drawing.Point(435, 89);
            this.rbtn_kohd.Name = "rbtn_kohd";
            this.rbtn_kohd.Size = new System.Drawing.Size(118, 19);
            this.rbtn_kohd.TabIndex = 21;
            this.rbtn_kohd.TabStop = true;
            this.rbtn_kohd.Text = "Không hoạt động";
            this.rbtn_kohd.UseVisualStyleBackColor = true;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(436, 64);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hd.TabIndex = 20;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "Hoạt động";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            // 
            // tbx_mota
            // 
            this.tbx_mota.Location = new System.Drawing.Point(435, 20);
            this.tbx_mota.Multiline = true;
            this.tbx_mota.Name = "tbx_mota";
            this.tbx_mota.Size = new System.Drawing.Size(328, 38);
            this.tbx_mota.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mô tả:";
            // 
            // tbx_ten
            // 
            this.tbx_ten.Location = new System.Drawing.Point(112, 64);
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(196, 23);
            this.tbx_ten.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(112, 20);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(196, 23);
            this.tbx_ma.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã";
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrd_sanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtn_kohd);
            this.Controls.Add(this.rbtn_hd);
            this.Controls.Add(this.tbx_mota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.label1);
            this.Name = "Frm_SanPham";
            this.Text = "Frm_SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgrd_sanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_kohd;
        private System.Windows.Forms.RadioButton rbtn_hd;
        private System.Windows.Forms.TextBox tbx_mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label1;
    }
}