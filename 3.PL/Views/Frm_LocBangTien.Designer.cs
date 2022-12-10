namespace _3.PL.Views
{
    partial class Frm_LocBangTien
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
            this.tbx_Min = new System.Windows.Forms.TextBox();
            this.tbx_Max = new System.Windows.Forms.TextBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max";
            // 
            // tbx_Min
            // 
            this.tbx_Min.Location = new System.Drawing.Point(186, 65);
            this.tbx_Min.Name = "tbx_Min";
            this.tbx_Min.Size = new System.Drawing.Size(127, 23);
            this.tbx_Min.TabIndex = 2;
            // 
            // tbx_Max
            // 
            this.tbx_Max.Location = new System.Drawing.Point(186, 144);
            this.tbx_Max.Name = "tbx_Max";
            this.tbx_Max.Size = new System.Drawing.Size(127, 23);
            this.tbx_Max.TabIndex = 3;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(186, 248);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(104, 38);
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // Frm_LocBangTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 341);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.tbx_Max);
            this.Controls.Add(this.tbx_Min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LocBangTien";
            this.Text = "Frm_LocBangTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Min;
        private System.Windows.Forms.TextBox tbx_Max;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}