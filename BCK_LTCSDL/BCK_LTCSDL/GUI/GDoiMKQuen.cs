using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BCK_LTCSDL.CONTROLLER;

namespace BCK_LTCSDL.GUI
{
    public partial class GDoiMKQuen : Form
    {
        public GDoiMKQuen(string txt)
        {
            InitializeComponent(); 
            tbTK.Text = txt.ToString();
            tbTK.ReadOnly = true;
        }
        private void resetvalue()
        {
            tbMKMoi.Text = "";
            tbTK.Text = "";
            tbMK.Text = "";
        }

        private void btSuaMK_Click(object sender, EventArgs e)
        {
            if (tbTK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã!");
                tbTK.Focus();
                return;
            }

            if (tbMK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ!");
                tbMK.Focus();
                return;
            }
            if (tbMKMoi.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới!");
                tbMKMoi.Focus();
                return;
            }
            if (tbMK.Text == tbMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới phải khác nhau!");
            }
            else
            {
                CDangNhap c = new CDangNhap();
                int dem = c.DoiMK(tbTK.Text, tbMK.Text, tbMKMoi.Text);
                if (dem == -2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu cũ không đúng. Mời bạn nhập lại!");
                    tbTK.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    resetvalue();
                    return;
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            GLogin add = new GLogin();
            add.Show();
            this.Hide();
        }
    }
}
