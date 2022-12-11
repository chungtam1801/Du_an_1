namespace _3.PL.Views
{
    partial class FrmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.cbx_Tatca = new System.Windows.Forms.CheckBox();
            this.tbn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_TimKiemSP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_koHoatdong = new System.Windows.Forms.RadioButton();
            this.tbx_Giatri = new System.Windows.Forms.TextBox();
            this.rbt_Hoatdong = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_conHan = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvKM = new System.Windows.Forms.DataGridView();
            this.dgv_ctkm = new System.Windows.Forms.DataGridView();
            this.rbt_KM = new System.Windows.Forms.RadioButton();
            this.rbt_ctKM = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctkm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_sp);
            this.groupBox2.Controls.Add(this.cbx_Tatca);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(734, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 375);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Áp dụng cho :";
            // 
            // dgv_sp
            // 
            this.dgv_sp.AllowUserToAddRows = false;
            this.dgv_sp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(6, 55);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.ReadOnly = true;
            this.dgv_sp.RowTemplate.Height = 25;
            this.dgv_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sp.Size = new System.Drawing.Size(441, 263);
            this.dgv_sp.TabIndex = 15;
            // 
            // cbx_Tatca
            // 
            this.cbx_Tatca.AutoSize = true;
            this.cbx_Tatca.Location = new System.Drawing.Point(6, 30);
            this.cbx_Tatca.Name = "cbx_Tatca";
            this.cbx_Tatca.Size = new System.Drawing.Size(114, 19);
            this.cbx_Tatca.TabIndex = 16;
            this.cbx_Tatca.Text = "Tất cả sản phẩm\r\n";
            this.cbx_Tatca.UseVisualStyleBackColor = true;
            this.cbx_Tatca.CheckedChanged += new System.EventHandler(this.cbx_Tatca_CheckedChanged_1);
            // 
            // tbn_Them
            // 
            this.tbn_Them.BackColor = System.Drawing.Color.SteelBlue;
            this.tbn_Them.Image = global::_3.PL.Properties.Resources.add;
            this.tbn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbn_Them.Location = new System.Drawing.Point(35, 258);
            this.tbn_Them.Name = "tbn_Them";
            this.tbn_Them.Size = new System.Drawing.Size(135, 50);
            this.tbn_Them.TabIndex = 13;
            this.tbn_Them.Text = "Thêm";
            this.tbn_Them.UseVisualStyleBackColor = false;
            this.tbn_Them.Click += new System.EventHandler(this.tbn_Them_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sua.Image = global::_3.PL.Properties.Resources.ghichu;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(176, 259);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(135, 49);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Xoa.Image = global::_3.PL.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(317, 259);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(135, 50);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Clear.Image = global::_3.PL.Properties.Resources.boqua;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(458, 261);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(135, 48);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbx_TimKiemSP);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgv_sp);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_Ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtm_NgayBD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtm_NgayKT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbt_koHoatdong);
            this.groupBox1.Controls.Add(this.tbx_Giatri);
            this.groupBox1.Controls.Add(this.rbt_Hoatdong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(7, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 375);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // tbx_TimKiemSP
            // 
            this.tbx_TimKiemSP.Location = new System.Drawing.Point(160, 270);
            this.tbx_TimKiemSP.Name = "tbx_TimKiemSP";
            this.tbx_TimKiemSP.Size = new System.Drawing.Size(203, 23);
            this.tbx_TimKiemSP.TabIndex = 34;
            this.tbx_TimKiemSP.TextChanged += new System.EventHandler(this.tbx_TimKiemSP_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3.PL.Properties.Resources.timkiem;
            this.pictureBox2.Location = new System.Drawing.Point(369, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(93, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = " Tìm kiếm:";
            // 
            // dgv_sp
            // 
            this.dgv_sp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(93, 299);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowTemplate.Height = 25;
            this.dgv_sp.Size = new System.Drawing.Size(500, 70);
            this.dgv_sp.TabIndex = 15;
            this.dgv_sp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sp_CellValueChanged);
            this.dgv_sp.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_sp_CurrentCellDirtyStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(357, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KM";
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Ten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Ten.Location = new System.Drawing.Point(93, 26);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(445, 23);
            this.tbx_Ten.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu ";
            // 
            // dtm_NgayBD
            // 
            this.dtm_NgayBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtm_NgayBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtm_NgayBD.Location = new System.Drawing.Point(93, 68);
            this.dtm_NgayBD.Name = "dtm_NgayBD";
            this.dtm_NgayBD.Size = new System.Drawing.Size(445, 23);
            this.dtm_NgayBD.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // dtm_NgayKT
            // 
            this.dtm_NgayKT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtm_NgayKT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtm_NgayKT.Location = new System.Drawing.Point(93, 120);
            this.dtm_NgayKT.Name = "dtm_NgayKT";
            this.dtm_NgayKT.Size = new System.Drawing.Size(445, 23);
            this.dtm_NgayKT.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá trị";
            // 
            // rbt_koHoatdong
            // 
            this.rbt_koHoatdong.AutoSize = true;
            this.rbt_koHoatdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_koHoatdong.Location = new System.Drawing.Point(199, 209);
            this.rbt_koHoatdong.Name = "rbt_koHoatdong";
            this.rbt_koHoatdong.Size = new System.Drawing.Size(118, 19);
            this.rbt_koHoatdong.TabIndex = 10;
            this.rbt_koHoatdong.TabStop = true;
            this.rbt_koHoatdong.Text = "Không hoạt động";
            this.rbt_koHoatdong.UseVisualStyleBackColor = true;
            // 
            // tbx_Giatri
            // 
            this.tbx_Giatri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Giatri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Giatri.Location = new System.Drawing.Point(93, 170);
            this.tbx_Giatri.Name = "tbx_Giatri";
            this.tbx_Giatri.Size = new System.Drawing.Size(445, 23);
            this.tbx_Giatri.TabIndex = 6;
            // 
            // rbt_Hoatdong
            // 
            this.rbt_Hoatdong.AutoSize = true;
            this.rbt_Hoatdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Hoatdong.Location = new System.Drawing.Point(93, 209);
            this.rbt_Hoatdong.Name = "rbt_Hoatdong";
            this.rbt_Hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rbt_Hoatdong.TabIndex = 9;
            this.rbt_Hoatdong.TabStop = true;
            this.rbt_Hoatdong.Text = "Hoạt động";
            this.rbt_Hoatdong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 22;
            // 
            // cbx_conHan
            // 
            this.cbx_conHan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_conHan.AutoSize = true;
            this.cbx_conHan.Location = new System.Drawing.Point(91, 50);
            this.cbx_conHan.Name = "cbx_conHan";
            this.cbx_conHan.Size = new System.Drawing.Size(70, 19);
            this.cbx_conHan.TabIndex = 29;
            this.cbx_conHan.Text = "Còn hạn";
            this.cbx_conHan.UseVisualStyleBackColor = true;
            this.cbx_conHan.CheckedChanged += new System.EventHandler(this.cbx_conHan_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.timkiem;
            this.pictureBox1.Location = new System.Drawing.Point(376, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_TimKiem.Location = new System.Drawing.Point(81, 431);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(289, 23);
            this.tbx_TimKiem.TabIndex = 27;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = " Tìm kiếm:";
            // 
            // dgvKM
            // 
            this.dgvKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKM.Location = new System.Drawing.Point(3, 75);
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.ReadOnly = true;
            this.dgvKM.RowTemplate.Height = 25;
            this.dgvKM.Size = new System.Drawing.Size(593, 151);
            this.dgvKM.TabIndex = 25;
            this.dgvKM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKM_CellContentClick);
            // 
            // dgv_ctkm
            // 
            this.dgv_ctkm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ctkm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ctkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctkm.Location = new System.Drawing.Point(606, 496);
            this.dgv_ctkm.Name = "dgv_ctkm";
            this.dgv_ctkm.RowTemplate.Height = 25;
            this.dgv_ctkm.Size = new System.Drawing.Size(486, 151);
            this.dgv_ctkm.TabIndex = 30;
            this.dgv_ctkm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctkm_CellContentClick);
            // 
            // rbt_KM
            // 
            this.rbt_KM.AutoSize = true;
            this.rbt_KM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_KM.Location = new System.Drawing.Point(9, 7);
            this.rbt_KM.Name = "rbt_KM";
            this.rbt_KM.Size = new System.Drawing.Size(90, 19);
            this.rbt_KM.TabIndex = 35;
            this.rbt_KM.TabStop = true;
            this.rbt_KM.Text = "Khuyến mãi";
            this.rbt_KM.UseVisualStyleBackColor = true;
            this.rbt_KM.CheckedChanged += new System.EventHandler(this.rbt_KM_CheckedChanged);
            // 
            // rbt_ctKM
            // 
            this.rbt_ctKM.AutoSize = true;
            this.rbt_ctKM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_ctKM.Location = new System.Drawing.Point(137, 7);
            this.rbt_ctKM.Name = "rbt_ctKM";
            this.rbt_ctKM.Size = new System.Drawing.Size(89, 19);
            this.rbt_ctKM.TabIndex = 36;
            this.rbt_ctKM.TabStop = true;
            this.rbt_ctKM.Text = "Chi Tiết KM";
            this.rbt_ctKM.UseVisualStyleBackColor = true;
            this.rbt_ctKM.CheckedChanged += new System.EventHandler(this.rbt_ctKM_CheckedChanged);
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1098, 652);
            this.Controls.Add(this.rbt_ctKM);
            this.Controls.Add(this.rbt_KM);
            this.Controls.Add(this.dgv_ctkm);
            this.Controls.Add(this.cbx_conHan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvKM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_KhuyenMai";
            this.Load += new System.EventHandler(this.FrmKhuyenMai_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctkm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tbn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_sp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_NgayBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_NgayKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_koHoatdong;
        private System.Windows.Forms.TextBox tbx_Giatri;
        private System.Windows.Forms.RadioButton rbt_Hoatdong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbx_conHan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKM;
        private System.Windows.Forms.DataGridView dgv_ctkm;
        private System.Windows.Forms.TextBox tbx_TimKiemSP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbt_KM;
        private System.Windows.Forms.RadioButton rbt_ctKM;
    }
}