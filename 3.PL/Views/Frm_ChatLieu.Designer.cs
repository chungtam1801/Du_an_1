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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbt_timkiem = new System.Windows.Forms.TextBox();
            this.ShowDataChatLieu = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbt_Ma = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rd_khd = new System.Windows.Forms.RadioButton();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.rd_hd = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataChatLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbt_timkiem);
            this.groupBox2.Controls.Add(this.ShowDataChatLieu);
            this.groupBox2.Location = new System.Drawing.Point(56, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 451);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_timkiem.Location = new System.Drawing.Point(6, 92);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.PlaceholderText = "Nhập tên hoặc mã chất liệu cần tìm";
            this.tbt_timkiem.Size = new System.Drawing.Size(273, 29);
            this.tbt_timkiem.TabIndex = 57;
            this.tbt_timkiem.TextChanged += new System.EventHandler(this.tbt_timkiem_TextChanged);
            // 
            // ShowDataChatLieu
            // 
            this.ShowDataChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowDataChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataChatLieu.Location = new System.Drawing.Point(6, 137);
            this.ShowDataChatLieu.Name = "ShowDataChatLieu";
            this.ShowDataChatLieu.RowHeadersWidth = 51;
            this.ShowDataChatLieu.RowTemplate.Height = 29;
            this.ShowDataChatLieu.Size = new System.Drawing.Size(746, 281);
            this.ShowDataChatLieu.TabIndex = 17;
            this.ShowDataChatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataChatLieu_CellClick);
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
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(59, 336);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(127, 45);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(267, 253);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(118, 51);
            this.btn_Sua.TabIndex = 20;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(59, 253);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(127, 51);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            // tbt_Ma
            // 
            this.tbt_Ma.Location = new System.Drawing.Point(223, 60);
            this.tbt_Ma.Name = "tbt_Ma";
            this.tbt_Ma.Size = new System.Drawing.Size(125, 27);
            this.tbt_Ma.TabIndex = 14;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(267, 336);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 45);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rd_khd
            // 
            this.rd_khd.AutoSize = true;
            this.rd_khd.Location = new System.Drawing.Point(267, 181);
            this.rd_khd.Name = "rd_khd";
            this.rd_khd.Size = new System.Drawing.Size(91, 24);
            this.rd_khd.TabIndex = 27;
            this.rd_khd.TabStop = true;
            this.rd_khd.Text = "Hết hàng";
            this.rd_khd.UseVisualStyleBackColor = true;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(223, 115);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(125, 27);
            this.tbt_Ten.TabIndex = 16;
            // 
            // rd_hd
            // 
            this.rd_hd.AutoSize = true;
            this.rd_hd.Location = new System.Drawing.Point(160, 181);
            this.rd_hd.Name = "rd_hd";
            this.rd_hd.Size = new System.Drawing.Size(93, 24);
            this.rd_hd.TabIndex = 26;
            this.rd_hd.TabStop = true;
            this.rd_hd.Text = "Còn hàng";
            this.rd_hd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbt_Ma);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.rd_khd);
            this.groupBox1.Controls.Add(this.tbt_Ten);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.rd_hd);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Location = new System.Drawing.Point(837, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 451);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
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
            this.Load += new System.EventHandler(this.Frm_ChatLieu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataChatLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbt_timkiem;
        private System.Windows.Forms.DataGridView ShowDataChatLieu;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox tbt_Ma;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rd_khd;
        private System.Windows.Forms.TextBox tbt_Ten;
        private System.Windows.Forms.RadioButton rd_hd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}