
namespace BCK_LTCSDL
{
    partial class GSVThieuTienPhong
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
            this.SVThieuTienPhong = new BCK_LTCSDL.SVThieuTienPhong();
            this.tb_HDTienPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_HDTienPhongTableAdapter = new BCK_LTCSDL.SVThieuTienPhongTableAdapters.tb_HDTienPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_HDTienPhongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BCK_LTCSDL.RSVThieuTienPhong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SVThieuTienPhong
            // 
            this.SVThieuTienPhong.DataSetName = "SVThieuTienPhong";
            this.SVThieuTienPhong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HDTienPhongBindingSource
            // 
            this.tb_HDTienPhongBindingSource.DataMember = "tb_HDTienPhong";
            this.tb_HDTienPhongBindingSource.DataSource = this.SVThieuTienPhong;
            // 
            // tb_HDTienPhongTableAdapter
            // 
            this.tb_HDTienPhongTableAdapter.ClearBeforeFill = true;
            // 
            // GSVThieuTienPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GSVThieuTienPhong";
            this.Text = "GSVThieuTienPhong";
            this.Load += new System.EventHandler(this.GSVThieuTienPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SVThieuTienPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HDTienPhongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_HDTienPhongBindingSource;
        private SVThieuTienPhong SVThieuTienPhong;
        private SVThieuTienPhongTableAdapters.tb_HDTienPhongTableAdapter tb_HDTienPhongTableAdapter;
    }
}