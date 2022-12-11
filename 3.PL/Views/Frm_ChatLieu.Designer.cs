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
            this.btn_seachbyma = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataChatLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_seachbyma);
            this.groupBox2.Controls.Add(this.tbt_timkiem);
            this.groupBox2.Controls.Add(this.ShowDataChatLieu);
            this.groupBox2.Location = new System.Drawing.Point(49, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(666, 338);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // tbt_timkiem
            // 
            this.tbt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbt_timkiem.Location = new System.Drawing.Point(5, 20);
            this.tbt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_timkiem.Name = "tbt_timkiem";
            this.tbt_timkiem.PlaceholderText = "Nhập tên hoặc mã chất liệu cần tìm";
            this.tbt_timkiem.Size = new System.Drawing.Size(239, 25);
            this.tbt_timkiem.TabIndex = 57;
            this.tbt_timkiem.TextChanged += new System.EventHandler(this.tbt_timkiem_TextChanged);
            // 
            // ShowDataChatLieu
            // 
            this.ShowDataChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowDataChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataChatLieu.Location = new System.Drawing.Point(5, 49);
            this.ShowDataChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDataChatLieu.Name = "ShowDataChatLieu";
            this.ShowDataChatLieu.RowHeadersWidth = 51;
            this.ShowDataChatLieu.RowTemplate.Height = 29;
            this.ShowDataChatLieu.Size = new System.Drawing.Size(653, 255);
            this.ShowDataChatLieu.TabIndex = 17;
            this.ShowDataChatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataChatLieu_CellClick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(38, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 19);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Mã chất liệu:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(38, 251);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(129, 53);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(181, 179);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(127, 58);
            this.btn_Sua.TabIndex = 20;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(38, 179);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(129, 58);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(38, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 19);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Tên chất liệu:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(38, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 19);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Trạng thái:";
            // 
            // tbt_Ma
            // 
            this.tbt_Ma.Location = new System.Drawing.Point(140, 45);
            this.tbt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_Ma.Name = "tbt_Ma";
            this.tbt_Ma.Size = new System.Drawing.Size(165, 23);
            this.tbt_Ma.TabIndex = 14;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(181, 251);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 53);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rd_khd
            // 
            this.rd_khd.AutoSize = true;
            this.rd_khd.Location = new System.Drawing.Point(234, 136);
            this.rd_khd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_khd.Name = "rd_khd";
            this.rd_khd.Size = new System.Drawing.Size(74, 19);
            this.rd_khd.TabIndex = 27;
            this.rd_khd.TabStop = true;
            this.rd_khd.Text = "Hết hàng";
            this.rd_khd.UseVisualStyleBackColor = true;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(140, 86);
            this.tbt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(165, 23);
            this.tbt_Ten.TabIndex = 16;
            // 
            // rd_hd
            // 
            this.rd_hd.AutoSize = true;
            this.rd_hd.Location = new System.Drawing.Point(140, 136);
            this.rd_hd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_hd.Name = "rd_hd";
            this.rd_hd.Size = new System.Drawing.Size(77, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(732, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 338);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_seachbyma
            // 
            this.btn_seachbyma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seachbyma.Image = ((System.Drawing.Image)(resources.GetObject("btn_seachbyma.Image")));
            this.btn_seachbyma.Location = new System.Drawing.Point(250, 17);
            this.btn_seachbyma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seachbyma.Name = "btn_seachbyma";
            this.btn_seachbyma.Size = new System.Drawing.Size(31, 28);
            this.btn_seachbyma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seachbyma.TabIndex = 58;
            this.btn_seachbyma.TabStop = false;
            // 
            // Frm_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.Frm_ChatLieu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataChatLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seachbyma)).EndInit();
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
        private System.Windows.Forms.PictureBox btn_seachbyma;
    }
}