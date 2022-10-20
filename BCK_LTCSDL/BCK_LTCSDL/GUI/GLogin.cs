using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using BCK_LTCSDL.GUI.GAdmin;
using BCK_LTCSDL.GUI.GUser;
using BCK_LTCSDL.GUI.GStaff;
using System.Windows.Forms;

namespace BCK_LTCSDL.GUI
{
    public partial class GLogin : Form
    {
        public GLogin()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
           // DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CDangNhap c = new CDangNhap();
            int dem = c.DangNhap(tbMa.Text, tbMK.Text);
            if (dem == -1)
            {
                this.Hide();
                GNhanVienKTX fc = new GNhanVienKTX(tbMa.Text);
                fc.Show();
            }
            else if(dem == 1)
            {
                this.Hide();
                GQuanLy fc = new GQuanLy(tbMa.Text);
                fc.Show();
            }
            else if(dem==2)
            {
                this.Hide();
                GNguoiDung fc = new GNguoiDung(tbMa.Text);
                fc.Show();
            }    
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng. Mời bạn nhập lại!");
                tbMa.Focus();
                return;
            }    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbMK.UseSystemPasswordChar = false;
            }
            else
            {
                tbMK.UseSystemPasswordChar = true;
            }
        }
    }
}
