namespace _3.PL.Views
{
    partial class Frm_QuenMatKhau
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NPass = new System.Windows.Forms.TextBox();
            this.btn_CNMK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password:";
            // 
            // txt_NPass
            // 
            this.txt_NPass.Location = new System.Drawing.Point(255, 192);
            this.txt_NPass.Name = "txt_NPass";
            this.txt_NPass.Size = new System.Drawing.Size(232, 27);
            this.txt_NPass.TabIndex = 8;
            // 
            // btn_CNMK
            // 
            this.btn_CNMK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CNMK.Location = new System.Drawing.Point(84, 263);
            this.btn_CNMK.Name = "btn_CNMK";
            this.btn_CNMK.Size = new System.Drawing.Size(120, 29);
            this.btn_CNMK.TabIndex = 9;
            this.btn_CNMK.Text = "Cập nhập ";
            this.btn_CNMK.UseVisualStyleBackColor = false;
            this.btn_CNMK.Click += new System.EventHandler(this.btn_CNMK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(146, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "SĐT:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(255, 122);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(232, 27);
            this.txt_SDT.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(393, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CNMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NPass);
            this.Controls.Add(this.label1);
            this.Name = "Frm_QuenMatKhau";
            this.Text = "Frm_QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NPass;
        private System.Windows.Forms.Button btn_CNMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button button1;
    }
}