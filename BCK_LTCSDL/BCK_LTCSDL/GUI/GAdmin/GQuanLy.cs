using BCK_LTCSDL.CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GQuanLy : Form
    {
        public GQuanLy(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layvaitro();
            layten();
        }
        string connection = Properties.Settings.Default.connection;
        public void layten()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_NhanVien.TenNV from tb_NhanVien where tb_NhanVien.MaNV = '" + lbMa.Text + "'  ";
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
            else if(dem == 2)
            {
                lbVT.Text = "Sinh viên";
            }
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhong add = new GPhong(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GNhanVien add = new GNhanVien(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GSinhVien add = new GSinhVien(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnTiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTienDien add = new GTienDien(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void hóaĐơnTiềnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTienNuoc add = new GTienNuoc(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void hóaĐơnTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTienPhong add = new GTienPhong(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýMượnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhieuThue add = new GPhieuThue(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhieuTra add = new GPhieuTra(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void quảnLýXửPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GXuPhat add = new GXuPhat(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GDangKy add = new GDangKy(lbMa.Text);
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

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GDichVu add = new GDichVu(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhongConCho add = new GPhongConCho();
            add.Show();
            this.Hide();
        }

        private void quảnLýChuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPhieuChuyen add = new GPhieuChuyen(lbMa.Text);
            add.Show();
            this.Hide();
        }
    }
}
