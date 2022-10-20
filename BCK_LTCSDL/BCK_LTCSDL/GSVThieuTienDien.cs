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
    public partial class GSVThieuTienDien : Form
    {
        public GSVThieuTienDien()
        {
            InitializeComponent();
        }

        private void GSVThieuTienDien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SVThieuTienDien.tb_HDTienDien' table. You can move, or remove it, as needed.
            this.tb_HDTienDienTableAdapter.Fill(this.SVThieuTienDien.tb_HDTienDien);

            this.reportViewer1.RefreshReport();
        }
    }
}
