using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using System.Windows.Forms;

namespace BCK_LTCSDL.GUI.GUser
{
    public partial class GNguoiDung : Form
    {
        public GNguoiDung(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            laysophong();
            layten();
            layvaitro();
        }
        string connection = Properties.Settings.Default.connection;
        public void layten()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_SinhVien.TenSV from tb_SinhVien where tb_SinhVien.MaSV = '" + lbMa.Text + "'  ";
            SqlCommand Comm_Ten = new SqlCommand(hoten, conn);
            conn.Open();
            SqlDataReader DR_Ten = Comm_Ten.ExecuteReader();
            if (DR_Ten.Read())
            {
                lbTen.Text = DR_Ten.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void layvaitro()
        {
            CVaiTro c = new CVaiTro();
            int dem = c.LayVaiTro(lbMa.Text);
            if (dem == 1)
            {
                lbVT.Text = "Quản lý";
            }
            if (dem == -1)
            {
                lbVT.Text = "Nhân viên";
            }
            else if (dem == 2)
            {
                lbVT.Text = "Sinh viên";
            }
        }
        private void laysophong()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_SinhVien.SoPhong from tb_SinhVien where tb_SinhVien.MaSV = '" + lbMa.Text + "'  ";
            SqlCommand Comm_Ten = new SqlCommand(hoten, conn);
            conn.Open();
            SqlDataReader DR_Ten = Comm_Ten.ExecuteReader();
            if (DR_Ten.Read())
            {
                lbSP.Text = DR_Ten.GetValue(0).ToString();
            }
            conn.Close();


        }

        private void sinhViênCùngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GCungPhong add = new GCungPhong(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void tiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKTienDien add = new GTKTienDien(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void tiềnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKTienNuoc add = new GTKTienNuoc(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void tiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKTienPhong add = new GTKTienPhong(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GDoiMK add = new GDoiMK(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLogin add = new GLogin();
            add.Show();
            this.Hide();
        }

        private void thôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTKPhong add = new GTKPhong(lbMa.Text);
            add.Show();
            this.Hide();
        }
    }
}
