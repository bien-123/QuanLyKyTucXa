
namespace BCK_LTCSDL.GUI
{
    partial class GDoiMK
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
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSuaMK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMKMoi = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(379, 109);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(160, 22);
            this.tbTK.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(413, 243);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(126, 35);
            this.btThoat.TabIndex = 42;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btSuaMK
            // 
            this.btSuaMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaMK.Location = new System.Drawing.Point(193, 243);
            this.btSuaMK.Name = "btSuaMK";
            this.btSuaMK.Size = new System.Drawing.Size(160, 35);
            this.btSuaMK.TabIndex = 41;
            this.btSuaMK.Text = "Sửa mật khẩu";
            this.btSuaMK.UseVisualStyleBackColor = true;
            this.btSuaMK.Click += new System.EventHandler(this.btSuaMK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tài khoản";
            // 
            // tbMKMoi
            // 
            this.tbMKMoi.Location = new System.Drawing.Point(379, 183);
            this.tbMKMoi.Name = "tbMKMoi";
            this.tbMKMoi.Size = new System.Drawing.Size(160, 22);
            this.tbMKMoi.TabIndex = 40;
            this.tbMKMoi.UseSystemPasswordChar = true;
            this.tbMKMoi.UseWaitCursor = true;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(379, 147);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(160, 22);
            this.tbMK.TabIndex = 39;
            this.tbMK.UseSystemPasswordChar = true;
            // 
            // GDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSuaMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMKMoi);
            this.Controls.Add(this.tbMK);
            this.Name = "GDoiMK";
            this.Text = "GDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSuaMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMKMoi;
        private System.Windows.Forms.TextBox tbMK;
    }
}