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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(358, 33);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 15);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Trạng thái:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(22, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 15);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Tên chất liệu:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(22, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 15);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Mã chất liệu:";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(234, 124);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 22);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(395, 124);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 22);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(65, 124);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 22);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Location = new System.Drawing.Point(44, 159);
            this.dgvChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 51;
            this.dgvChatLieu.RowTemplate.Height = 29;
            this.dgvChatLieu.Size = new System.Drawing.Size(653, 211);
            this.dgvChatLieu.TabIndex = 17;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(144, 80);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(110, 23);
            this.txtTen.TabIndex = 16;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(144, 28);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(110, 23);
            this.txtMa.TabIndex = 14;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(472, 9);
            this.rbtn_hd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(82, 19);
            this.rbtn_hd.TabIndex = 26;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "Hoạt động";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            // 
            // rbtn_kohd
            // 
            this.rbtn_kohd.AutoSize = true;
            this.rbtn_kohd.Location = new System.Drawing.Point(472, 49);
            this.rbtn_kohd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_kohd.Name = "rbtn_kohd";
            this.rbtn_kohd.Size = new System.Drawing.Size(118, 19);
            this.rbtn_kohd.TabIndex = 27;
            this.rbtn_kohd.TabStop = true;
            this.rbtn_kohd.Text = "Không hoạt động";
            this.rbtn_kohd.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(570, 124);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 22);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // Frm_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 438);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rbtn_kohd);
            this.Controls.Add(this.rbtn_hd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ChatLieu";
            this.Text = "ChatLieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}