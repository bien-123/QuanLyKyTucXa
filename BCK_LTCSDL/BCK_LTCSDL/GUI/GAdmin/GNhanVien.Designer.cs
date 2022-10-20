
namespace BCK_LTCSDL.GUI.GAdmin
{
    partial class GNhanVien
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
            this.label8 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThemMoi = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.cbbGT = new System.Windows.Forms.ComboBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbQLTang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbMaPhanLoai = new System.Windows.Forms.Label();
            this.lbMota = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lbVT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btXoa
            // 
            this.btXoa.Image = global::BCK_LTCSDL.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(559, 273);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 42);
            this.btXoa.TabIndex = 37;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Image = global::BCK_LTCSDL.Properties.Resources.edit_icon;
            this.btCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCapNhat.Location = new System.Drawing.Point(424, 273);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(90, 42);
            this.btCapNhat.TabIndex = 36;
            this.btCapNhat.Text = "Sửa";
            this.btCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThemMoi
            // 
            this.btThemMoi.Image = global::BCK_LTCSDL.Properties.Resources.Add;
            this.btThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMoi.Location = new System.Drawing.Point(290, 273);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(90, 42);
            this.btThemMoi.TabIndex = 35;
            this.btThemMoi.Text = "Thêm";
            this.btThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMoi.UseVisualStyleBackColor = true;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::BCK_LTCSDL.Properties.Resources.Exit;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(707, 273);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(90, 42);
            this.btDong.TabIndex = 134;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTK);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.cbbGT);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.tbQLTang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbMa);
            this.groupBox1.Controls.Add(this.lbSL);
            this.groupBox1.Controls.Add(this.lbDonGia);
            this.groupBox1.Controls.Add(this.lbDVT);
            this.groupBox1.Controls.Add(this.lbMaPhanLoai);
            this.groupBox1.Controls.Add(this.lbMota);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 185);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 110;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 109;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Tìm kiếm";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(361, 143);
            this.tbTK.Multiline = true;
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(305, 36);
            this.tbTK.TabIndex = 106;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = global::BCK_LTCSDL.Properties.Resources.Search;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(677, 143);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(108, 36);
            this.btTimKiem.TabIndex = 108;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click_1);
            // 
            // cbbGT
            // 
            this.cbbGT.FormattingEnabled = true;
            this.cbbGT.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbbGT.Location = new System.Drawing.Point(462, 57);
            this.cbbGT.Name = "cbbGT";
            this.cbbGT.Size = new System.Drawing.Size(121, 24);
            this.cbbGT.TabIndex = 105;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(465, 19);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(121, 22);
            this.dtNgaySinh.TabIndex = 104;
            // 
            // tbQLTang
            // 
            this.tbQLTang.Location = new System.Drawing.Point(773, 98);
            this.tbQLTang.Name = "tbQLTang";
            this.tbQLTang.Size = new System.Drawing.Size(153, 22);
            this.tbQLTang.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "QL tầng";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(773, 60);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(153, 22);
            this.tbSDT.TabIndex = 101;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSDT_KeyPress);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(773, 21);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(153, 22);
            this.tbDiaChi.TabIndex = 100;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(139, 98);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(127, 22);
            this.tbCMND.TabIndex = 99;
            this.tbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCMND_KeyPress);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(139, 57);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(127, 22);
            this.tbTen.TabIndex = 98;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(139, 21);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(127, 22);
            this.tbMa.TabIndex = 97;
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(695, 60);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(40, 19);
            this.lbSL.TabIndex = 96;
            this.lbSL.Text = "SĐT";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(691, 22);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(62, 19);
            this.lbDonGia.TabIndex = 95;
            this.lbDonGia.Text = "Địa chỉ";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(338, 58);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(78, 19);
            this.lbDVT.TabIndex = 94;
            this.lbDVT.Text = "Giới tính";
            // 
            // lbMaPhanLoai
            // 
            this.lbMaPhanLoai.AutoSize = true;
            this.lbMaPhanLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhanLoai.Location = new System.Drawing.Point(335, 22);
            this.lbMaPhanLoai.Name = "lbMaPhanLoai";
            this.lbMaPhanLoai.Size = new System.Drawing.Size(81, 19);
            this.lbMaPhanLoai.TabIndex = 93;
            this.lbMaPhanLoai.Text = "Ngày sinh";
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMota.Location = new System.Drawing.Point(23, 99);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(61, 19);
            this.lbMota.TabIndex = 92;
            this.lbMota.Text = "CMND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 261);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 21);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(960, 234);
            this.dgvDanhSach.TabIndex = 40;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(851, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 186;
            this.lbVT.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 185;
            this.label3.Text = "Vai trò";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 183;
            this.label10.Text = "Tên nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 181;
            this.label11.Text = "Mã nhân viên:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(278, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 187;
            this.lbMa.Text = "label6";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(568, 8);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 188;
            this.lbTen.Text = "label7";
            // 
            // GNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 592);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThemMoi);
            this.Name = "GNhanVien";
            this.Text = "GNhanVien";
            this.Load += new System.EventHandler(this.GNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThemMoi;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.ComboBox cbbGT;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbQLTang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbMaPhanLoai;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
    }
}