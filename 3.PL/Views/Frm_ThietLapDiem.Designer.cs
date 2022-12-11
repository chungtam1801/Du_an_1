namespace _3.PL.Views
{
    partial class Frm_ThietLapDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Tien1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Tien2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.dtg_Diem = new System.Windows.Forms.DataGridView();
            this.chbx_Check = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỉ lệ quy đổi điểm thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thanh toán bằng điểm";
            // 
            // tbx_Tien1
            // 
            this.tbx_Tien1.Location = new System.Drawing.Point(691, 78);
            this.tbx_Tien1.Name = "tbx_Tien1";
            this.tbx_Tien1.Size = new System.Drawing.Size(100, 23);
            this.tbx_Tien1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "=";
            // 
            // tbx_Tien2
            // 
            this.tbx_Tien2.Location = new System.Drawing.Point(891, 128);
            this.tbx_Tien2.Name = "tbx_Tien2";
            this.tbx_Tien2.Size = new System.Drawing.Size(100, 23);
            this.tbx_Tien2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(801, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(997, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "VNĐ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(859, 292);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.Location = new System.Drawing.Point(958, 292);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(75, 23);
            this.btn_BoQua.TabIndex = 15;
            this.btn_BoQua.Text = "Bỏ qua";
            this.btn_BoQua.UseVisualStyleBackColor = true;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // dtg_Diem
            // 
            this.dtg_Diem.AllowUserToAddRows = false;
            this.dtg_Diem.AllowUserToDeleteRows = false;
            this.dtg_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Diem.Location = new System.Drawing.Point(12, 81);
            this.dtg_Diem.Name = "dtg_Diem";
            this.dtg_Diem.RowTemplate.Height = 25;
            this.dtg_Diem.Size = new System.Drawing.Size(481, 231);
            this.dtg_Diem.TabIndex = 16;
            this.dtg_Diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Diem_CellClick);
            // 
            // chbx_Check
            // 
            this.chbx_Check.AutoSize = true;
            this.chbx_Check.Location = new System.Drawing.Point(499, 166);
            this.chbx_Check.Name = "chbx_Check";
            this.chbx_Check.Size = new System.Drawing.Size(216, 19);
            this.chbx_Check.TabIndex = 17;
            this.chbx_Check.Text = "Không cộng điểm khi sử dụng điểm";
            this.chbx_Check.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(891, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "1 điểm thưởng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(730, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "1 điểm thưởng";
            // 
            // Frm_ThietLapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chbx_Check);
            this.Controls.Add(this.dtg_Diem);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Tien2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Tien1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ThietLapDiem";
            this.Text = "Frm_ThietLapDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Tien1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Tien2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.DataGridView dtg_Diem;
        private System.Windows.Forms.CheckBox chbx_Check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}