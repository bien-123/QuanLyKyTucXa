
namespace BCK_LTCSDL.GUI.GUser
{
    partial class GTKTienPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.dgv_tktienphong = new System.Windows.Forms.DataGridView();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktienphong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 32);
            this.label2.TabIndex = 95;
            this.label2.Text = "HÓA ĐƠN TIỀN PHÒNG";
            // 
            // btDong
            // 
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(880, 129);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(89, 38);
            this.btDong.TabIndex = 94;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // dgv_tktienphong
            // 
            this.dgv_tktienphong.AllowUserToAddRows = false;
            this.dgv_tktienphong.AllowUserToDeleteRows = false;
            this.dgv_tktienphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tktienphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tktienphong.Location = new System.Drawing.Point(26, 173);
            this.dgv_tktienphong.Name = "dgv_tktienphong";
            this.dgv_tktienphong.ReadOnly = true;
            this.dgv_tktienphong.RowHeadersVisible = false;
            this.dgv_tktienphong.RowHeadersWidth = 51;
            this.dgv_tktienphong.RowTemplate.Height = 24;
            this.dgv_tktienphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tktienphong.Size = new System.Drawing.Size(1041, 291);
            this.dgv_tktienphong.TabIndex = 93;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(277, 129);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(470, 38);
            this.tbTimKiem.TabIndex = 92;
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(753, 129);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(111, 38);
            this.btTimKiem.TabIndex = 91;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "Tìm kiếm";
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(897, 9);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(46, 17);
            this.lbSP.TabIndex = 109;
            this.lbSP.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "Số phòng";
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(672, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 107;
            this.lbVT.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 106;
            this.label4.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(409, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 105;
            this.lbTen.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Tên sinh viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(120, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 103;
            this.lbMa.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Mã sinh viên:";
            // 
            // GTKTienPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 499);
            this.Controls.Add(this.lbSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.dgv_tktienphong);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.label9);
            this.Name = "GTKTienPhong";
            this.Text = "GTKTienPhong";
            this.Load += new System.EventHandler(this.GTKTienPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktienphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridView dgv_tktienphong;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label1;
    }
}