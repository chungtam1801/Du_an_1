namespace _3.PL.Views
{
    partial class Frm_LoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiSP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loai_ma = new System.Windows.Forms.TextBox();
            this.loai_ten = new System.Windows.Forms.TextBox();
            this.loai_macha = new System.Windows.Forms.ComboBox();
            this.dtg_loai = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tk_timkiem = new System.Windows.Forms.TextBox();
            this.btn_seachbyma = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã cha ";
            // 
            // loai_ma
            // 
            this.loai_ma.Location = new System.Drawing.Point(365, 33);
            this.loai_ma.Name = "loai_ma";
            this.loai_ma.Size = new System.Drawing.Size(263, 27);
            this.loai_ma.TabIndex = 3;
            // 
            // loai_ten
            // 
            this.loai_ten.Location = new System.Drawing.Point(365, 86);
            this.loai_ten.Name = "loai_ten";
            this.loai_ten.Size = new System.Drawing.Size(263, 27);
            this.loai_ten.TabIndex = 4;
            // 
            // loai_macha
            // 
            this.loai_macha.FormattingEnabled = true;
            this.loai_macha.Location = new System.Drawing.Point(365, 130);
            this.loai_macha.Name = "loai_macha";
            this.loai_macha.Size = new System.Drawing.Size(263, 28);
            this.loai_macha.TabIndex = 5;
            // 
            // dtg_loai
            // 
            this.dtg_loai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_loai.Location = new System.Drawing.Point(1, 416);
            this.dtg_loai.Name = "dtg_loai";
            this.dtg_loai.RowHeadersWidth = 51;
            this.dtg_loai.RowTemplate.Height = 29;
            this.dtg_loai.Size = new System.Drawing.Size(814, 201);
            this.dtg_loai.TabIndex = 6;
            this.dtg_loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_loai_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(242, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(377, 185);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "còn ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(496, 185);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 29);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "hết";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tk_timkiem
            // 
            this.tk_timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tk_timkiem.Location = new System.Drawing.Point(1, 322);
            this.tk_timkiem.Name = "tk_timkiem";
            this.tk_timkiem.PlaceholderText = "Tìm kiếm loại sản phẩm theo tên";
            this.tk_timkiem.Size = new System.Drawing.Size(717, 34);
            this.tk_timkiem.TabIndex = 14;
            this.tk_timkiem.TextChanged += new System.EventHandler(this.tk_timkiem_TextChanged);
            this.tk_timkiem.Leave += new System.EventHandler(this.tk_timkiem_Leave);
            // 
            // btn_seachbyma
            // 
            this.btn_seachbyma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seachbyma.Image = ((System.Drawing.Image)(resources.GetObject("btn_seachbyma.Image")));
            this.btn_seachbyma.Location = new System.Drawing.Point(724, 322);
            this.btn_seachbyma.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_seachbyma.Name = "btn_seachbyma";
            this.btn_seachbyma.Size = new System.Drawing.Size(91, 35);
            this.btn_seachbyma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seachbyma.TabIndex = 54;
            this.btn_seachbyma.TabStop = false;
            this.btn_seachbyma.Click += new System.EventHandler(this.btn_seachbyma_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::_3.PL.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(105, 240);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(15, 7, 24, 7);
            this.btn_them.Size = new System.Drawing.Size(141, 58);
            this.btn_them.TabIndex = 55;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_sua.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::_3.PL.Properties.Resources.edit;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(295, 242);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(17, 9, 46, 9);
            this.btn_sua.Size = new System.Drawing.Size(151, 58);
            this.btn_sua.TabIndex = 56;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_clear.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = global::_3.PL.Properties.Resources.iconfinder_broom_clean_service_labor_website_4622511_122412;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(488, 242);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Padding = new System.Windows.Forms.Padding(15, 7, 35, 7);
            this.btn_clear.Size = new System.Drawing.Size(140, 56);
            this.btn_clear.TabIndex = 58;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Frm_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 610);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_seachbyma);
            this.Controls.Add(this.tk_timkiem);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_loai);
            this.Controls.Add(this.loai_macha);
            this.Controls.Add(this.loai_ten);
            this.Controls.Add(this.loai_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LoaiSP";
            this.Text = "Frm_LoaiSP";
            this.Load += new System.EventHandler(this.Frm_LoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loai_ma;
        private System.Windows.Forms.TextBox loai_ten;
        private System.Windows.Forms.ComboBox loai_macha;
        private System.Windows.Forms.DataGridView dtg_loai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tk_timkiem;
        private System.Windows.Forms.PictureBox btn_seachbyma;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
    }
}