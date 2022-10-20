
namespace BCK_LTCSDL.GUI.GAdmin
{
    partial class GPhieuChuyen
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
            this.lbVT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_qlmuonphong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSoPhongMoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbSoPhongCu = new System.Windows.Forms.ComboBox();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.dtNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlmuonphong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(693, 33);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 166;
            this.lbVT.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 165;
            this.label8.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(403, 33);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 164;
            this.lbTen.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 163;
            this.label10.Text = "Tên nhân viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(114, 33);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 162;
            this.lbMa.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 161;
            this.label11.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 32);
            this.label7.TabIndex = 160;
            this.label7.Text = "QUẢN LÝ CHUYỂN PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_qlmuonphong);
            this.groupBox2.Location = new System.Drawing.Point(8, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 244);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chuyển phòng";
            // 
            // dgv_qlmuonphong
            // 
            this.dgv_qlmuonphong.AllowUserToAddRows = false;
            this.dgv_qlmuonphong.AllowUserToDeleteRows = false;
            this.dgv_qlmuonphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlmuonphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlmuonphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qlmuonphong.Location = new System.Drawing.Point(3, 18);
            this.dgv_qlmuonphong.Name = "dgv_qlmuonphong";
            this.dgv_qlmuonphong.ReadOnly = true;
            this.dgv_qlmuonphong.RowHeadersVisible = false;
            this.dgv_qlmuonphong.RowHeadersWidth = 51;
            this.dgv_qlmuonphong.RowTemplate.Height = 24;
            this.dgv_qlmuonphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qlmuonphong.Size = new System.Drawing.Size(1037, 223);
            this.dgv_qlmuonphong.TabIndex = 92;
            this.dgv_qlmuonphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlmuonphong_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbSoPhongMoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbSoPhongCu);
            this.groupBox1.Controls.Add(this.tbSoPhieu);
            this.groupBox1.Controls.Add(this.dtNgayChuyen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbMaSV);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 192);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyển phòng";
            // 
            // cbbSoPhongMoi
            // 
            this.cbbSoPhongMoi.FormattingEnabled = true;
            this.cbbSoPhongMoi.Location = new System.Drawing.Point(476, 80);
            this.cbbSoPhongMoi.Name = "cbbSoPhongMoi";
            this.cbbSoPhongMoi.Size = new System.Drawing.Size(147, 24);
            this.cbbSoPhongMoi.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 116;
            this.label4.Text = "Số phòng mới";
            // 
            // cbbSoPhongCu
            // 
            this.cbbSoPhongCu.FormattingEnabled = true;
            this.cbbSoPhongCu.Location = new System.Drawing.Point(476, 29);
            this.cbbSoPhongCu.Name = "cbbSoPhongCu";
            this.cbbSoPhongCu.Size = new System.Drawing.Size(147, 24);
            this.cbbSoPhongCu.TabIndex = 115;
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(118, 27);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(143, 22);
            this.tbSoPhieu.TabIndex = 114;
            // 
            // dtNgayChuyen
            // 
            this.dtNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayChuyen.Location = new System.Drawing.Point(841, 27);
            this.dtNgayChuyen.Name = "dtNgayChuyen";
            this.dtNgayChuyen.Size = new System.Drawing.Size(143, 22);
            this.dtNgayChuyen.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "Ngày chuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Số phiếu";
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(124, 80);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(143, 24);
            this.cbbMaSV.TabIndex = 110;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = global::BCK_LTCSDL.Properties.Resources.Search;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(685, 141);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(106, 36);
            this.btTimKiem.TabIndex = 108;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 107;
            this.label9.Text = "Tìm kiếm";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(332, 141);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(344, 36);
            this.tbTimKiem.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Số phòng cũ";
            // 
            // btDong
            // 
            this.btDong.Image = global::BCK_LTCSDL.Properties.Resources.Exit;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(696, 323);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(94, 43);
            this.btDong.TabIndex = 156;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::BCK_LTCSDL.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(546, 323);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 43);
            this.btXoa.TabIndex = 155;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::BCK_LTCSDL.Properties.Resources.edit_icon;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(361, 323);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(98, 43);
            this.btSua.TabIndex = 154;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::BCK_LTCSDL.Properties.Resources.Add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(200, 323);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 43);
            this.btThem.TabIndex = 153;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(841, 82);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(143, 22);
            this.tbMaNV.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 118;
            this.label6.Text = "Mã nhân viên";
            // 
            // GPhieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 648);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Name = "GPhieuChuyen";
            this.Text = "GPhieuChuyen";
            this.Load += new System.EventHandler(this.GPhieuChuyen_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlmuonphong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_qlmuonphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbSoPhongCu;
        private System.Windows.Forms.TextBox tbSoPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayChuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbbSoPhongMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label6;
    }
}