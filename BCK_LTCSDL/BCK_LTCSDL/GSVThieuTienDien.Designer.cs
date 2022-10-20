
namespace BCK_LTCSDL
{
    partial class GSVThieuTienDien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SVThieuTienDien = new BCK_LTCSDL.SVThieuTienDien();
            this.tb_HDTienDienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_HDTienDienTableAdapter = new BCK_LTCSDL.SVThieuTienDienTableAdapters.tb_HDTienDienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienDienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_HDTienDienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BCK_LTCSDL.RSVThieuTienDien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SVThieuTienDien
            // 
            this.SVThieuTienDien.DataSetName = "SVThieuTienDien";
            this.SVThieuTienDien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HDTienDienBindingSource
            // 
            this.tb_HDTienDienBindingSource.DataMember = "tb_HDTienDien";
            this.tb_HDTienDienBindingSource.DataSource = this.SVThieuTienDien;
            // 
            // tb_HDTienDienTableAdapter
            // 
            this.tb_HDTienDienTableAdapter.ClearBeforeFill = true;
            // 
            // GSVThieuTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GSVThieuTienDien";
            this.Text = "GSVThieuTienDien";
            this.Load += new System.EventHandler(this.GSVThieuTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienDienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_HDTienDienBindingSource;
        private SVThieuTienDien SVThieuTienDien;
        private SVThieuTienDienTableAdapters.tb_HDTienDienTableAdapter tb_HDTienDienTableAdapter;
    }
}