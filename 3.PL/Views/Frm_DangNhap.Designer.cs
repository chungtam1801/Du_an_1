namespace _3.PL.Views
{
    partial class Frm_DangNhap
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
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(234, 51);
            this.tb_taikhoan.Multiline = true;
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(342, 26);
            this.tb_taikhoan.TabIndex = 9;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_dangnhap.Location = new System.Drawing.Point(117, 241);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(116, 44);
            this.bt_dangnhap.TabIndex = 8;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản : ";
            // 
            // lb_QuenMatKhau
            // 
            this.lb_QuenMatKhau.AutoSize = true;
            this.lb_QuenMatKhau.Location = new System.Drawing.Point(269, 203);
            this.lb_QuenMatKhau.Name = "lb_QuenMatKhau";
            this.lb_QuenMatKhau.Size = new System.Drawing.Size(89, 15);
            this.lb_QuenMatKhau.TabIndex = 11;
            this.lb_QuenMatKhau.TabStop = true;
            this.lb_QuenMatKhau.Text = "Quên mật khẩu";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(234, 145);
            this.tb_matkhau.Multiline = true;
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(342, 26);
            this.tb_matkhau.TabIndex = 12;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(397, 241);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(122, 44);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 303);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.lb_QuenMatKhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_DangNhap";
            this.Text = "Frm_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lb_QuenMatKhau;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button btn_Thoat;
    }
}