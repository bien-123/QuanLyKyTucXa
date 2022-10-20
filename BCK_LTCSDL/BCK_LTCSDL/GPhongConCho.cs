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
    public partial class GPhongConCho : Form
    {
        public GPhongConCho()
        {
            InitializeComponent();
        }

        private void GPhongConCho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSPhongConCho.tb_Phong' table. You can move, or remove it, as needed.
            this.tb_PhongTableAdapter.Fill(this.DSPhongConCho.tb_Phong);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            this.Hide();
        }

        private void thốngKêTheoSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKSoLuong add = new GTKSoLuong();
            add.Show();
            this.Hide();
        }

        private void thốngKêPhòngHếtChỗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhongHetCho add = new GPhongHetCho();
            add.Show();
            this.Hide();
        }
    }
}
