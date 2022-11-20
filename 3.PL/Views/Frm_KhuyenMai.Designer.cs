namespace _3.PL.Views
{
    partial class Frm_KhuyenMai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.tbx_Giatri = new System.Windows.Forms.TextBox();
            this.dtm_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.rbt_Hoatdong = new System.Windows.Forms.RadioButton();
            this.rbt_koHoatdong = new System.Windows.Forms.RadioButton();
            this.dtm_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dgvKM = new System.Windows.Forms.DataGridView();
            this.tbn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá trị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái";
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(114, 40);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(290, 23);
            this.tbx_Ten.TabIndex = 5;
            // 
            // tbx_Giatri
            // 
            this.tbx_Giatri.Location = new System.Drawing.Point(494, 41);
            this.tbx_Giatri.Name = "tbx_Giatri";
            this.tbx_Giatri.Size = new System.Drawing.Size(294, 23);
            this.tbx_Giatri.TabIndex = 6;
            // 
            // dtm_NgayBD
            // 
            this.dtm_NgayBD.Location = new System.Drawing.Point(114, 80);
            this.dtm_NgayBD.Name = "dtm_NgayBD";
            this.dtm_NgayBD.Size = new System.Drawing.Size(290, 23);
            this.dtm_NgayBD.TabIndex = 7;
            // 
            // rbt_Hoatdong
            // 
            this.rbt_Hoatdong.AutoSize = true;
            this.rbt_Hoatdong.Location = new System.Drawing.Point(494, 103);
            this.rbt_Hoatdong.Name = "rbt_Hoatdong";
            this.rbt_Hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rbt_Hoatdong.TabIndex = 9;
            this.rbt_Hoatdong.TabStop = true;
            this.rbt_Hoatdong.Text = "Hoạt động";
            this.rbt_Hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbt_koHoatdong
            // 
            this.rbt_koHoatdong.AutoSize = true;
            this.rbt_koHoatdong.Location = new System.Drawing.Point(648, 103);
            this.rbt_koHoatdong.Name = "rbt_koHoatdong";
            this.rbt_koHoatdong.Size = new System.Drawing.Size(118, 19);
            this.rbt_koHoatdong.TabIndex = 10;
            this.rbt_koHoatdong.TabStop = true;
            this.rbt_koHoatdong.Text = "Không hoạt động";
            this.rbt_koHoatdong.UseVisualStyleBackColor = true;
            // 
            // dtm_NgayKT
            // 
            this.dtm_NgayKT.Location = new System.Drawing.Point(114, 122);
            this.dtm_NgayKT.Name = "dtm_NgayKT";
            this.dtm_NgayKT.Size = new System.Drawing.Size(290, 23);
            this.dtm_NgayKT.TabIndex = 11;
            // 
            // dgvKM
            // 
            this.dgvKM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKM.Location = new System.Drawing.Point(3, 238);
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.RowTemplate.Height = 25;
            this.dgvKM.Size = new System.Drawing.Size(794, 209);
            this.dgvKM.TabIndex = 12;
            this.dgvKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKM_CellClick);
            // 
            // tbn_Them
            // 
            this.tbn_Them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbn_Them.Location = new System.Drawing.Point(434, 176);
            this.tbn_Them.Name = "tbn_Them";
            this.tbn_Them.Size = new System.Drawing.Size(75, 23);
            this.tbn_Them.TabIndex = 13;
            this.tbn_Them.Text = "Thêm";
            this.tbn_Them.UseVisualStyleBackColor = false;
            this.tbn_Them.Click += new System.EventHandler(this.tbn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.Location = new System.Drawing.Point(526, 176);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Location = new System.Drawing.Point(622, 176);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.Location = new System.Drawing.Point(713, 176);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = " Tìm kiếm theo tên";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(115, 176);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(289, 23);
            this.tbx_TimKiem.TabIndex = 18;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // Frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.tbn_Them);
            this.Controls.Add(this.dgvKM);
            this.Controls.Add(this.dtm_NgayKT);
            this.Controls.Add(this.rbt_koHoatdong);
            this.Controls.Add(this.rbt_Hoatdong);
            this.Controls.Add(this.dtm_NgayBD);
            this.Controls.Add(this.tbx_Giatri);
            this.Controls.Add(this.tbx_Ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_KhuyenMai";
            this.Text = "Frm_KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.TextBox tbx_Giatri;
        private System.Windows.Forms.DateTimePicker dtm_NgayBD;
        private System.Windows.Forms.RadioButton rbt_Hoatdong;
        private System.Windows.Forms.RadioButton rbt_koHoatdong;
        private System.Windows.Forms.DateTimePicker dtm_NgayKT;
        private System.Windows.Forms.DataGridView dgvKM;
        private System.Windows.Forms.Button tbn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_TimKiem;
    }
}