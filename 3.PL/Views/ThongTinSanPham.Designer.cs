namespace _3.PL.Views
{
    partial class ThongTinSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Anh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_Anh.Enabled = false;
            this.ptb_Anh.Location = new System.Drawing.Point(0, 0);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(287, 231);
            this.ptb_Anh.TabIndex = 0;
            this.ptb_Anh.TabStop = false;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(3, 246);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(25, 15);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Location = new System.Drawing.Point(74, 279);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(38, 15);
            this.lbl_GiaTien.TabIndex = 4;
            this.lbl_GiaTien.Text = "label4";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(74, 307);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(38, 15);
            this.lbl_SoLuong.TabIndex = 5;
            this.lbl_SoLuong.Text = "label5";
            // 
            // ThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.ptb_Anh);
            this.Name = "ThongTinSanPham";
            this.Size = new System.Drawing.Size(287, 338);
            this.MouseEnter += new System.EventHandler(this.ThongTinSanPham_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ThongTinSanPham_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Anh;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_GiaTien;
        public System.Windows.Forms.Label lbl_SoLuong;
    }
}
