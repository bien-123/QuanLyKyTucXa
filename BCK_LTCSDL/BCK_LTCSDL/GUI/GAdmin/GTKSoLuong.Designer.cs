
namespace BCK_LTCSDL.GUI.GAdmin
{
    partial class GTKSoLuong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.rdbGT = new System.Windows.Forms.RadioButton();
            this.rdbTS = new System.Windows.Forms.RadioButton();
            this.rdbDN = new System.Windows.Forms.RadioButton();
            this.rdbSN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_qltienphong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltienphong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btThongKe);
            this.groupBox1.Controls.Add(this.rdbGT);
            this.groupBox1.Controls.Add(this.rdbTS);
            this.groupBox1.Controls.Add(this.rdbDN);
            this.groupBox1.Controls.Add(this.rdbSN);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo:";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(233, 429);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 40);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btThongKe
            // 
            this.btThongKe.Location = new System.Drawing.Point(7, 429);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(105, 40);
            this.btThongKe.TabIndex = 5;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // rdbGT
            // 
            this.rdbGT.AutoSize = true;
            this.rdbGT.Location = new System.Drawing.Point(25, 315);
            this.rdbGT.Name = "rdbGT";
            this.rdbGT.Size = new System.Drawing.Size(230, 21);
            this.rdbGT.TabIndex = 4;
            this.rdbGT.TabStop = true;
            this.rdbGT.Text = "Số lượng sinh viên theo giới tính";
            this.rdbGT.UseVisualStyleBackColor = true;
            // 
            // rdbTS
            // 
            this.rdbTS.AutoSize = true;
            this.rdbTS.Location = new System.Drawing.Point(25, 232);
            this.rdbTS.Name = "rdbTS";
            this.rdbTS.Size = new System.Drawing.Size(175, 21);
            this.rdbTS.TabIndex = 3;
            this.rdbTS.TabStop = true;
            this.rdbTS.Text = "Tổng số phòng hiện có";
            this.rdbTS.UseVisualStyleBackColor = true;
            // 
            // rdbDN
            // 
            this.rdbDN.AutoSize = true;
            this.rdbDN.Location = new System.Drawing.Point(25, 156);
            this.rdbDN.Name = "rdbDN";
            this.rdbDN.Size = new System.Drawing.Size(225, 21);
            this.rdbDN.TabIndex = 1;
            this.rdbDN.TabStop = true;
            this.rdbDN.Text = "Số lượng phòng theo tình trạng";
            this.rdbDN.UseVisualStyleBackColor = true;
            // 
            // rdbSN
            // 
            this.rdbSN.AutoSize = true;
            this.rdbSN.Location = new System.Drawing.Point(25, 76);
            this.rdbSN.Name = "rdbSN";
            this.rdbSN.Size = new System.Drawing.Size(211, 21);
            this.rdbSN.TabIndex = 0;
            this.rdbSN.TabStop = true;
            this.rdbSN.Text = "Số người có trong mỗi phòng";
            this.rdbSN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_qltienphong);
            this.groupBox2.Location = new System.Drawing.Point(348, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 489);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả thống kê";
            // 
            // dgv_qltienphong
            // 
            this.dgv_qltienphong.AllowUserToAddRows = false;
            this.dgv_qltienphong.AllowUserToDeleteRows = false;
            this.dgv_qltienphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qltienphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qltienphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qltienphong.Location = new System.Drawing.Point(3, 18);
            this.dgv_qltienphong.Name = "dgv_qltienphong";
            this.dgv_qltienphong.ReadOnly = true;
            this.dgv_qltienphong.RowHeadersVisible = false;
            this.dgv_qltienphong.RowHeadersWidth = 51;
            this.dgv_qltienphong.RowTemplate.Height = 24;
            this.dgv_qltienphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qltienphong.Size = new System.Drawing.Size(716, 468);
            this.dgv_qltienphong.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "THỐNG KÊ THEO SỐ LƯỢNG";
            // 
            // GTKSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GTKSoLuong";
            this.Text = "GTKSoLuong";
            this.Load += new System.EventHandler(this.GTKSoLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltienphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.RadioButton rdbGT;
        private System.Windows.Forms.RadioButton rdbTS;
        private System.Windows.Forms.RadioButton rdbDN;
        private System.Windows.Forms.RadioButton rdbSN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_qltienphong;
        private System.Windows.Forms.Label label1;
    }
}