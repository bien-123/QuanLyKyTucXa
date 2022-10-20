
namespace BCK_LTCSDL.GUI
{
    partial class GDangKy
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTK = new System.Windows.Forms.ComboBox();
            this.rNV = new System.Windows.Forms.RadioButton();
            this.rSV = new System.Windows.Forms.RadioButton();
            this.cbbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTaoTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_qltiendien = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.lbVT = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltiendien)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(167, 315);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(294, 22);
            this.tbEmail.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cấp tài khoản";
            // 
            // cbbTK
            // 
            this.cbbTK.FormattingEnabled = true;
            this.cbbTK.Location = new System.Drawing.Point(167, 207);
            this.cbbTK.Name = "cbbTK";
            this.cbbTK.Size = new System.Drawing.Size(294, 24);
            this.cbbTK.TabIndex = 29;
            // 
            // rNV
            // 
            this.rNV.AutoSize = true;
            this.rNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNV.Location = new System.Drawing.Point(347, 156);
            this.rNV.Name = "rNV";
            this.rNV.Size = new System.Drawing.Size(114, 27);
            this.rNV.TabIndex = 28;
            this.rNV.TabStop = true;
            this.rNV.Text = "Nhân viên";
            this.rNV.UseVisualStyleBackColor = true;
            this.rNV.CheckedChanged += new System.EventHandler(this.rNV_CheckedChanged);
            // 
            // rSV
            // 
            this.rSV.AutoSize = true;
            this.rSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSV.Location = new System.Drawing.Point(24, 156);
            this.rSV.Name = "rSV";
            this.rSV.Size = new System.Drawing.Size(106, 27);
            this.rSV.TabIndex = 27;
            this.rSV.TabStop = true;
            this.rSV.Text = "Sinh viên";
            this.rSV.UseVisualStyleBackColor = true;
            this.rSV.CheckedChanged += new System.EventHandler(this.rSV_CheckedChanged);
            // 
            // cbbPhanQuyen
            // 
            this.cbbPhanQuyen.FormattingEnabled = true;
            this.cbbPhanQuyen.Items.AddRange(new object[] {
            "ADMIN"});
            this.cbbPhanQuyen.Location = new System.Drawing.Point(167, 371);
            this.cbbPhanQuyen.Name = "cbbPhanQuyen";
            this.cbbPhanQuyen.Size = new System.Drawing.Size(294, 24);
            this.cbbPhanQuyen.TabIndex = 32;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(305, 485);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(156, 35);
            this.btThoat.TabIndex = 34;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTaoTK
            // 
            this.btTaoTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoTK.Location = new System.Drawing.Point(24, 431);
            this.btTaoTK.Name = "btTaoTK";
            this.btTaoTK.Size = new System.Drawing.Size(156, 35);
            this.btTaoTK.TabIndex = 33;
            this.btTaoTK.Text = "Tạo tài khoản";
            this.btTaoTK.UseVisualStyleBackColor = true;
            this.btTaoTK.Click += new System.EventHandler(this.btTaoTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Phân quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tài khoản";
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(167, 259);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(294, 22);
            this.tbMK.TabIndex = 30;
            this.tbMK.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_qltiendien);
            this.groupBox2.Location = new System.Drawing.Point(477, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 364);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
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
            this.dgv_qltiendien.Size = new System.Drawing.Size(588, 343);
            this.dgv_qltiendien.TabIndex = 80;
            this.dgv_qltiendien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qltiendien_CellClick);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(24, 485);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(156, 35);
            this.btXoa.TabIndex = 147;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(305, 431);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(156, 35);
            this.btSua.TabIndex = 148;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(935, 113);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(106, 36);
            this.btTimKiem.TabIndex = 150;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 149;
            this.label9.Text = "Tìm kiếm";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(575, 110);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(344, 35);
            this.tbTimKiem.TabIndex = 151;
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(813, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 192;
            this.lbVT.Text = "label4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(758, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 191;
            this.label12.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(523, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 190;
            this.lbTen.Text = "label4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 189;
            this.label13.Text = "Tên nhân viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(234, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 188;
            this.lbMa.Text = "label2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 187;
            this.label14.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 32);
            this.label3.TabIndex = 193;
            this.label3.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // GDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbTK);
            this.Controls.Add(this.rNV);
            this.Controls.Add(this.rSV);
            this.Controls.Add(this.cbbPhanQuyen);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTaoTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMK);
            this.Name = "GDangKy";
            this.Text = "GDangKy";
            this.Load += new System.EventHandler(this.GDangKy_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltiendien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTK;
        private System.Windows.Forms.RadioButton rNV;
        private System.Windows.Forms.RadioButton rSV;
        private System.Windows.Forms.ComboBox cbbPhanQuyen;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTaoTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_qltiendien;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
    }
}