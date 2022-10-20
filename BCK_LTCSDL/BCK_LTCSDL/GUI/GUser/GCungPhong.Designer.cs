
namespace BCK_LTCSDL.GUI.GUser
{
    partial class GCungPhong
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
            this.dgv_qlphong = new System.Windows.Forms.DataGridView();
            this.lbSP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbVT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_qlphong
            // 
            this.dgv_qlphong.AllowUserToAddRows = false;
            this.dgv_qlphong.AllowUserToDeleteRows = false;
            this.dgv_qlphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlphong.Location = new System.Drawing.Point(12, 108);
            this.dgv_qlphong.Name = "dgv_qlphong";
            this.dgv_qlphong.ReadOnly = true;
            this.dgv_qlphong.RowHeadersVisible = false;
            this.dgv_qlphong.RowHeadersWidth = 51;
            this.dgv_qlphong.RowTemplate.Height = 24;
            this.dgv_qlphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qlphong.Size = new System.Drawing.Size(1041, 401);
            this.dgv_qlphong.TabIndex = 77;
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(886, 9);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(46, 17);
            this.lbSP.TabIndex = 101;
            this.lbSP.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Số phòng";
            // 
            // lbVT
            // 
            this.lbVT.AutoSize = true;
            this.lbVT.Location = new System.Drawing.Point(661, 9);
            this.lbVT.Name = "lbVT";
            this.lbVT.Size = new System.Drawing.Size(46, 17);
            this.lbVT.TabIndex = 99;
            this.lbVT.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 98;
            this.label4.Text = "Vai trò";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(398, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 17);
            this.lbTen.TabIndex = 97;
            this.lbTen.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "Tên sinh viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(109, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 95;
            this.lbMa.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 32);
            this.label2.TabIndex = 102;
            this.label2.Text = "THÔNG TIN SINH VIÊN CÙNG PHÒNG";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(401, 516);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 103;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // GCungPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_qlphong);
            this.Name = "GCungPhong";
            this.Text = "GCungPhong";
            this.Load += new System.EventHandler(this.GCungPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlphong;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDong;
    }
}