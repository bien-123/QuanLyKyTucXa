using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCK_LTCSDL
{
    public partial class GSVThieuTienNuoc : Form
    {
        public GSVThieuTienNuoc()
        {
            InitializeComponent();
        }

        private void GSVThieuTienNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SVThieuTienNuoc.tb_HDTienNuoc' table. You can move, or remove it, as needed.
            this.tb_HDTienNuocTableAdapter.Fill(this.SVThieuTienNuoc.tb_HDTienNuoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
