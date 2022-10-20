
namespace BCK_LTCSDL.GUI.GUser
{
    partial class GTKTienNuoc
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
            this.dgv_tktiennuoc = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktiennuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 32);
            this.label2.TabIndex = 95;
            this.label2.Text = "HÓA ĐƠN TIỀN NƯỚC";
            // 
            // btDong
            // 
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btDong.Location = new System.Drawing.Point(855, 98);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(86, 43);
            this.btDong.TabIndex = 94;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // dgv_tktiennuoc
            // 
            this.dgv_tktiennuoc.AllowUserToAddRows = false;
            this.dgv_tktiennuoc.AllowUserToDeleteRows = false;
            this.dgv_tktiennuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tktiennuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tktiennuoc.Location = new System.Drawing.Point(20, 147);
            this.dgv_tktiennuoc.Name = "dgv_tktiennuoc";
            this.dgv_tktiennuoc.ReadOnly = true;
            this.dgv_tktiennuoc.RowHeadersVisible = false;
            this.dgv_tktiennuoc.RowHeadersWidth = 51;
            this.dgv_tktiennuoc.RowTemplate.Height = 24;
            this.dgv_tktiennuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tktiennuoc.Size = new System.Drawing.Size(1041, 300);
            this.dgv_tktiennuoc.TabIndex = 93;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(314, 98);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(408, 43);
            this.tbTimKiem.TabIndex = 92;
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btTimKiem.Location = new System.Drawing.Point(728, 98);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(103, 43);
            this.btTimKiem.TabIndex = 91;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "Tìm kiếm";
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(891, 9);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(46, 17);
            this.lbSP.TabIndex = 109;
            this.lbSP.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "Số phòng";
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(666, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 107;
            this.lbVT.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 106;
            this.label4.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(403, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 105;
            this.lbTen.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Tên sinh viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(114, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 103;
            this.lbMa.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Mã sinh viên:";
            // 
            // GTKTienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 464);
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
            this.Controls.Add(this.dgv_tktiennuoc);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.label9);
            this.Name = "GTKTienNuoc";
            this.Text = "GTKTienNuoc";
            this.Load += new System.EventHandler(this.GTKTienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktiennuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridView dgv_tktiennuoc;
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