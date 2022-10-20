
namespace BCK_LTCSDL
{
    partial class GSVThieuTienNuoc
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
            this.SVThieuTienNuoc = new BCK_LTCSDL.SVThieuTienNuoc();
            this.tb_HDTienNuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_HDTienNuocTableAdapter = new BCK_LTCSDL.SVThieuTienNuocTableAdapters.tb_HDTienNuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienNuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_HDTienNuocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BCK_LTCSDL.RSVThieuTienNuoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SVThieuTienNuoc
            // 
            this.SVThieuTienNuoc.DataSetName = "SVThieuTienNuoc";
            this.SVThieuTienNuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HDTienNuocBindingSource
            // 
            this.tb_HDTienNuocBindingSource.DataMember = "tb_HDTienNuoc";
            this.tb_HDTienNuocBindingSource.DataSource = this.SVThieuTienNuoc;
            // 
            // tb_HDTienNuocTableAdapter
            // 
            this.tb_HDTienNuocTableAdapter.ClearBeforeFill = true;
            // 
            // GSVThieuTienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GSVThieuTienNuoc";
            this.Text = "GSVThieuTienNuoc";
            this.Load += new System.EventHandler(this.GSVThieuTienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienNuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_HDTienNuocBindingSource;
        private SVThieuTienNuoc SVThieuTienNuoc;
        private SVThieuTienNuocTableAdapters.tb_HDTienNuocTableAdapter tb_HDTienNuocTableAdapter;
    }
}