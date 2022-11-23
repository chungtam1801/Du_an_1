namespace _3.PL.Views
{
    partial class Frm_ThemNhanhSP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_tensp = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(124, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 2);
            this.panel1.TabIndex = 1;
            // 
            // tbx_tensp
            // 
            this.tbx_tensp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_tensp.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_tensp.Location = new System.Drawing.Point(124, 51);
            this.tbx_tensp.Multiline = true;
            this.tbx_tensp.Name = "tbx_tensp";
            this.tbx_tensp.Size = new System.Drawing.Size(230, 23);
            this.tbx_tensp.TabIndex = 2;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btn_luu.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_luu.Image = global::_3.PL.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(124, 130);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(98, 44);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "     Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // btn_boqua
            // 
            this.btn_boqua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_boqua.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_boqua.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_boqua.Image = global::_3.PL.Properties.Resources.boqua;
            this.btn_boqua.Location = new System.Drawing.Point(256, 130);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(98, 44);
            this.btn_boqua.TabIndex = 4;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thêm sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_ThemNhanhSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tbx_tensp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(550, 100);
            this.Name = "Frm_ThemNhanhSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_ThemNhanhSP";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_tensp;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Label label2;
    }
}