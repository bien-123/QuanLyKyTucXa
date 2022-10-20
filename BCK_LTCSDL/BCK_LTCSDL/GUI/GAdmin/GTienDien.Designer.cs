
namespace BCK_LTCSDL.GUI.GAdmin
{
    partial class GTienDien
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_qltiendien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.tbCSMoi = new System.Windows.Forms.TextBox();
            this.tbCSCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dtNgayThu = new System.Windows.Forms.DateTimePicker();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.cbbSoPhong = new System.Windows.Forms.ComboBox();
            this.tbTienDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btXuatHD = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltiendien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(437, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(298, 32);
            this.label11.TabIndex = 147;
            this.label11.Text = "QUẢN LÝ TIỀN ĐIỆN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_qltiendien);
            this.groupBox2.Location = new System.Drawing.Point(35, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 307);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgv_qltiendien
            // 
            this.dgv_qltiendien.AllowUserToAddRows = false;
            this.dgv_qltiendien.AllowUserToDeleteRows = false;
            this.dgv_qltiendien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qltiendien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qltiendien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qltiendien.Location = new System.Drawing.Point(3, 18);
            this.dgv_qltiendien.Name = "dgv_qltiendien";
            this.dgv_qltiendien.ReadOnly = true;
            this.dgv_qltiendien.RowHeadersVisible = false;
            this.dgv_qltiendien.RowHeadersWidth = 51;
            this.dgv_qltiendien.RowTemplate.Height = 24;
            this.dgv_qltiendien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qltiendien.Size = new System.Drawing.Size(1039, 286);
            this.dgv_qltiendien.TabIndex = 80;
            this.dgv_qltiendien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qltiendien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.cbbTT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbSoPhieu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbDonGia);
            this.groupBox1.Controls.Add(this.tbCSMoi);
            this.groupBox1.Controls.Add(this.tbCSCu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Controls.Add(this.dtNgayThu);
            this.groupBox1.Controls.Add(this.cbbMaSV);
            this.groupBox1.Controls.Add(this.cbbSoPhong);
            this.groupBox1.Controls.Add(this.tbTienDien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 208);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbbTT.Location = new System.Drawing.Point(894, 120);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(121, 24);
            this.cbbTT.TabIndex = 101;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(772, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 100;
            this.label15.Text = "Tình trạng";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(100, 24);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(121, 22);
            this.tbSoPhieu.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 98;
            this.label10.Text = "Số hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 97;
            this.label8.Text = "Đơn giá";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(500, 56);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(123, 22);
            this.tbDonGia.TabIndex = 96;
            this.tbDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDonGia_KeyPress);
            // 
            // tbCSMoi
            // 
            this.tbCSMoi.Location = new System.Drawing.Point(500, 27);
            this.tbCSMoi.Name = "tbCSMoi";
            this.tbCSMoi.Size = new System.Drawing.Size(123, 22);
            this.tbCSMoi.TabIndex = 95;
            this.tbCSMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCSMoi_KeyPress);
            // 
            // tbCSCu
            // 
            this.tbCSCu.Location = new System.Drawing.Point(100, 90);
            this.tbCSCu.Name = "tbCSCu";
            this.tbCSCu.Size = new System.Drawing.Size(121, 22);
            this.tbCSCu.TabIndex = 94;
            this.tbCSCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCSCu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Chỉ số mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "Chỉ số cũ";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = global::BCK_LTCSDL.Properties.Resources.Search;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(714, 166);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(107, 36);
            this.btTimKiem.TabIndex = 90;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 89;
            this.label9.Text = "Tìm kiếm";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(339, 167);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(369, 35);
            this.tbTimKiem.TabIndex = 91;
            // 
            // dtNgayThu
            // 
            this.dtNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThu.Location = new System.Drawing.Point(894, 25);
            this.dtNgayThu.Name = "dtNgayThu";
            this.dtNgayThu.Size = new System.Drawing.Size(123, 22);
            this.dtNgayThu.TabIndex = 88;
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(894, 60);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(121, 24);
            this.cbbMaSV.TabIndex = 86;
            // 
            // cbbSoPhong
            // 
            this.cbbSoPhong.FormattingEnabled = true;
            this.cbbSoPhong.Location = new System.Drawing.Point(100, 56);
            this.cbbSoPhong.Name = "cbbSoPhong";
            this.cbbSoPhong.Size = new System.Drawing.Size(121, 24);
            this.cbbSoPhong.TabIndex = 83;
            // 
            // tbTienDien
            // 
            this.tbTienDien.Location = new System.Drawing.Point(500, 88);
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Size = new System.Drawing.Size(123, 22);
            this.tbTienDien.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Mã sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(773, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Ngày thu tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tiền điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Số phòng";
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(836, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 186;
            this.lbVT.Text = "label4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(781, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 185;
            this.label12.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(498, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 184;
            this.lbTen.Text = "label4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 183;
            this.label13.Text = "Tên nhân viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(146, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 182;
            this.lbMa.Text = "label2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 181;
            this.label14.Text = "Mã nhân viên:";
            // 
            // btXuatHD
            // 
            this.btXuatHD.Image = global::BCK_LTCSDL.Properties.Resources.hoa_don;
            this.btXuatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXuatHD.Location = new System.Drawing.Point(917, 321);
            this.btXuatHD.Name = "btXuatHD";
            this.btXuatHD.Size = new System.Drawing.Size(121, 51);
            this.btXuatHD.TabIndex = 146;
            this.btXuatHD.Text = "In hóa đơn";
            this.btXuatHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXuatHD.UseVisualStyleBackColor = true;
            this.btXuatHD.Click += new System.EventHandler(this.btXuatHD_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::BCK_LTCSDL.Properties.Resources.Exit;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(771, 321);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(86, 51);
            this.btDong.TabIndex = 143;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::BCK_LTCSDL.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(549, 321);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(81, 51);
            this.btXoa.TabIndex = 142;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::BCK_LTCSDL.Properties.Resources.edit_icon;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(359, 321);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(91, 51);
            this.btSua.TabIndex = 141;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::BCK_LTCSDL.Properties.Resources.Add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(172, 321);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(85, 51);
            this.btThem.TabIndex = 140;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(772, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 81;
            this.label7.Text = "Mã nhân viên";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(894, 93);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(123, 22);
            this.tbMaNV.TabIndex = 102;
            // 
            // GTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 690);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btXuatHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Name = "GTienDien";
            this.Text = "GTienDien";
            this.Load += new System.EventHandler(this.GTienDien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltiendien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_qltiendien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSoPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbCSMoi;
        private System.Windows.Forms.TextBox tbCSCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DateTimePicker dtNgayThu;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.ComboBox cbbSoPhong;
        private System.Windows.Forms.TextBox tbTienDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btXuatHD;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaNV;
    }
}