using BCK_LTCSDL.GUI.GAdmin;
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
    public partial class GPhongHetCho : Form
    {
        public GPhongHetCho()
        {
            InitializeComponent();
        }

        private void GPhongHetCho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSPhongHetCho.tb_Phong' table. You can move, or remove it, as needed.
            this.tb_PhongTableAdapter.Fill(this.DSPhongHetCho.tb_Phong);

            this.reportViewer1.RefreshReport();
        }

        private void thốngKêTheoSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKSoLuong add = new GTKSoLuong();
            add.Show();
            this.Hide();
        }

        private void thốngKêPhòngCònChỗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhongConCho add = new GPhongConCho();
            add.Show();
            this.Hide();
        }
    }
}
