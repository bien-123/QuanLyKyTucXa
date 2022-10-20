
namespace BCK_LTCSDL
{
    partial class GPhongHetCho
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_PhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPhongHetCho = new BCK_LTCSDL.DSPhongHetCho();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_PhongTableAdapter = new BCK_LTCSDL.DSPhongHetChoTableAdapters.tb_PhongTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêPhòngCònChỗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêPhòngHếtChỗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chưaNộpTiềnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chưaNộpTiềnĐiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chưaNộpTiềnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongHetCho)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_PhongBindingSource
            // 
            this.tb_PhongBindingSource.DataMember = "tb_Phong";
            this.tb_PhongBindingSource.DataSource = this.DSPhongHetCho;
            // 
            // DSPhongHetCho
            // 
            this.DSPhongHetCho.DataSetName = "DSPhongHetCho";
            this.DSPhongHetCho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tb_PhongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BCK_LTCSDL.RPPhongHetCho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1020, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_PhongTableAdapter
            // 
            this.tb_PhongTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêPhòngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thốngKêTheoSốLượngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêPhòngToolStripMenuItem
            // 
            this.thốngKêPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêPhòngCònChỗToolStripMenuItem,
            this.thốngKêPhòngHếtChỗToolStripMenuItem});
            this.thốngKêPhòngToolStripMenuItem.Name = "thốngKêPhòngToolStripMenuItem";
            this.thốngKêPhòngToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.thốngKêPhòngToolStripMenuItem.Text = "Thống kê phòng";
            // 
            // thốngKêPhòngCònChỗToolStripMenuItem
            // 
            this.thốngKêPhòngCònChỗToolStripMenuItem.Name = "thốngKêPhòngCònChỗToolStripMenuItem";
            this.thốngKêPhòngCònChỗToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.thốngKêPhòngCònChỗToolStripMenuItem.Text = "Thống kê phòng còn chỗ";
            this.thốngKêPhòngCònChỗToolStripMenuItem.Click += new System.EventHandler(this.thốngKêPhòngCònChỗToolStripMenuItem_Click);
            // 
            // thốngKêPhòngHếtChỗToolStripMenuItem
            // 
            this.thốngKêPhòngHếtChỗToolStripMenuItem.Name = "thốngKêPhòngHếtChỗToolStripMenuItem";
            this.thốngKêPhòngHếtChỗToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.thốngKêPhòngHếtChỗToolStripMenuItem.Text = "Thống kê phòng hết chỗ";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chưaNộpTiềnPhòngToolStripMenuItem,
            this.chưaNộpTiềnĐiệnToolStripMenuItem,
            this.chưaNộpTiềnNướcToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê sinh viên chưa nộp tiền";
            // 
            // chưaNộpTiềnPhòngToolStripMenuItem
            // 
            this.chưaNộpTiềnPhòngToolStripMenuItem.Name = "chưaNộpTiềnPhòngToolStripMenuItem";
            this.chưaNộpTiềnPhòngToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.chưaNộpTiềnPhòngToolStripMenuItem.Text = "Chưa nộp tiền phòng";
            // 
            // chưaNộpTiềnĐiệnToolStripMenuItem
            // 
            this.chưaNộpTiềnĐiệnToolStripMenuItem.Name = "chưaNộpTiềnĐiệnToolStripMenuItem";
            this.chưaNộpTiềnĐiệnToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.chưaNộpTiềnĐiệnToolStripMenuItem.Text = "Chưa nộp tiền điện";
            // 
            // chưaNộpTiềnNướcToolStripMenuItem
            // 
            this.chưaNộpTiềnNướcToolStripMenuItem.Name = "chưaNộpTiềnNướcToolStripMenuItem";
            this.chưaNộpTiềnNướcToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.chưaNộpTiềnNướcToolStripMenuItem.Text = "Chưa nộp tiền nước";
            // 
            // thốngKêTheoSốLượngToolStripMenuItem
            // 
            this.thốngKêTheoSốLượngToolStripMenuItem.Name = "thốngKêTheoSốLượngToolStripMenuItem";
            this.thốngKêTheoSốLượngToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.thốngKêTheoSốLượngToolStripMenuItem.Text = "Thống kê theo số lượng";
            this.thốngKêTheoSốLượngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoSốLượngToolStripMenuItem_Click);
            // 
            // GPhongHetCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GPhongHetCho";
            this.Text = "GPhongHetCho";
            this.Load += new System.EventHandler(this.GPhongHetCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_PhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongHetCho)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_PhongBindingSource;
        private DSPhongHetCho DSPhongHetCho;
        private DSPhongHetChoTableAdapters.tb_PhongTableAdapter tb_PhongTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhòngCònChỗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhòngHếtChỗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chưaNộpTiềnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chưaNộpTiềnĐiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chưaNộpTiềnNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoSốLượngToolStripMenuItem;
    }
}