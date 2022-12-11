namespace _3.PL.Views
{
    partial class Frm_QR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QR));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Camera = new System.Windows.Forms.ComboBox();
            this.ptb_QR = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tbx_Chuoi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // cbx_Camera
            // 
            this.cbx_Camera.FormattingEnabled = true;
            this.cbx_Camera.Location = new System.Drawing.Point(162, 45);
            this.cbx_Camera.Name = "cbx_Camera";
            this.cbx_Camera.Size = new System.Drawing.Size(198, 23);
            this.cbx_Camera.TabIndex = 1;
            // 
            // ptb_QR
            // 
            this.ptb_QR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_QR.Image = ((System.Drawing.Image)(resources.GetObject("ptb_QR.Image")));
            this.ptb_QR.Location = new System.Drawing.Point(162, 83);
            this.ptb_QR.Name = "ptb_QR";
            this.ptb_QR.Size = new System.Drawing.Size(474, 454);
            this.ptb_QR.TabIndex = 2;
            this.ptb_QR.TabStop = false;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Start.Location = new System.Drawing.Point(717, 132);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(105, 48);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tbx_Chuoi
            // 
            this.tbx_Chuoi.Location = new System.Drawing.Point(717, 199);
            this.tbx_Chuoi.Multiline = true;
            this.tbx_Chuoi.Name = "tbx_Chuoi";
            this.tbx_Chuoi.Size = new System.Drawing.Size(181, 33);
            this.tbx_Chuoi.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(922, 540);
            this.Controls.Add(this.tbx_Chuoi);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.ptb_QR);
            this.Controls.Add(this.cbx_Camera);
            this.Controls.Add(this.label1);
            this.Name = "Frm_QR";
            this.Text = "Frm_QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QR_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Camera;
        private System.Windows.Forms.PictureBox ptb_QR;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tbx_Chuoi;
        private System.Windows.Forms.Timer timer1;
    }
}