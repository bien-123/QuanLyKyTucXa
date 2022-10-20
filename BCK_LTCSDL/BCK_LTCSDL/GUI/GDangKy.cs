using BCK_LTCSDL.CONTROLLER;
using BCK_LTCSDL.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BCK_LTCSDL.GUI.GAdmin;

namespace BCK_LTCSDL.GUI
{
    public partial class GDangKy : Form
    {
        public GDangKy(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
        }

        private void rSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rSV.Checked)
                rNV.Checked = false;
            CSinhVien c = new CSinhVien();
            List<MSinhVien> ds  = c.SelectListByTen("");
            if (ds != null)
            {
                cbbTK.DataSource = ds;
                cbbTK.DisplayMember = "Ma";
            }
            cbbPhanQuyen.Text = "USER";
        }

        private void rNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rSV.Checked)
                rNV.Checked = false;
            CNhanVien c = new CNhanVien();
            List<MNhanVien> ds = c.SelectListByTen("");
            if (ds != null)
            {
                cbbTK.DataSource = ds;
                cbbTK.DisplayMember = "Ma";
            }
            cbbPhanQuyen.Text = "STAFF";
        }
        private void resetvalue()
        {
            cbbTK.Text = "";
            cbbPhanQuyen.Text = "";
            tbEmail.Text = "";
            tbMK.Text = "";
        }

        private void btTaoTK_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                cbbTK.Focus();
                return;
            }

            if (tbMK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbMK.Focus();
                return;
            }
            string UserEmail = tbEmail.Text;
            if (IsValidEmailId(UserEmail) == true)
            {
                CDangNhap c = new CDangNhap();
                int dem = c.Insert(cbbTK.Text, tbMK.Text, tbEmail.Text, cbbPhanQuyen.Text);
                if (dem == -2)
                {
                    MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                    cbbTK.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    resetvalue();
                    return;
                    
                }
            }
            else
            {
                MessageBox.Show("Định dạng email ko đúng!");
                tbEmail.Focus();
            }
        }
        public static bool IsValidEmailId(string InputEmail)
        {
            InputEmail = InputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(InputEmail))
                return (true);
            else
                return (false);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            GQuanLy add = new GQuanLy(lbMa.Text);
            add.Show();
            this.Hide();
        }

        private void GDangKy_Load(object sender, EventArgs e)
        {
            CDangNhap c = new CDangNhap();
            TimKiem(c.SelectListByGhiChu(""));
        }
        private void TimKiem(List<MDangNhap> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã", typeof(String));
                tb.Columns.Add("Mật khẩu", typeof(string));
                tb.Columns.Add("Email", typeof(String));
                tb.Columns.Add("Phân quyền", typeof(string));
                int tt = 0;
                foreach (MDangNhap m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã"] = m.Ma;
                    r["Mật khẩu"] = m.MatKhau;
                    r["Email"] = m.Email;
                    r["Phân quyền"] = m.PhanQuyen;
                    tb.Rows.Add(r);
                }
                dgv_qltiendien.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qltiendien.Columns["TT"].Width = 50;
                dgv_qltiendien.Columns["Mã"].Width = 100;
            }
            else
                dgv_qltiendien.DataSource = null;
        }

        private void dgv_qltiendien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qltiendien.Rows[e.RowIndex];
            cbbTK.Text = r.Cells["Mã"].Value.ToString();
            tbMK.Text = r.Cells["Mật khẩu"].Value.ToString();
            tbEmail.Text = r.Cells["Email"].Value.ToString();
            cbbPhanQuyen.Text = r.Cells["Phân quyền"].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đăng nhập!");
                cbbTK.Focus();
                return;
            }
            string UserEmail = tbEmail.Text;
            if (IsValidEmailId(UserEmail) == true)
            {
                DataGridViewRow r = dgv_qltiendien.SelectedRows[0];
                CDangNhap c = new CDangNhap();
                int dem = c.Update(r.Cells["Mã"].Value.ToString(), tbMK.Text, tbEmail.Text, cbbPhanQuyen.Text);
                if (dem == -2)
                {
                    MessageBox.Show("Mã bạn nhập vào chưa tồn tại, bạn phải sử dụng mã khác!");
                    cbbTK.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công!");
                    resetvalue();
                    TimKiem(c.SelectListByGhiChu(""));
                }
            }
            else
            {
                MessageBox.Show("Định dạng email ko đúng!");
                tbEmail.Focus();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đăng nhập!");
                cbbTK.Focus();
                return;
            }
            string UserEmail = tbEmail.Text;
            if (IsValidEmailId(UserEmail) == true)
            {
                DataGridViewRow r = dgv_qltiendien.SelectedRows[0];
                CDangNhap c = new CDangNhap();
                int dem = c.DeleteByMa(r.Cells["Mã"].Value.ToString());
                if (dem == -2)
                {
                    MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                    cbbTK.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công!");
                    resetvalue();
                    TimKiem(c.SelectListByGhiChu(""));
                }
            }
            else
            {
                MessageBox.Show("Định dạng email ko đúng!");
                tbEmail.Focus();
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CDangNhap c = new CDangNhap();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_qltiendien.DataSource = null;
                TimKiem(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_qltiendien.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    TimKiem(c.SelectListByGhiChu(""));
                }
            }
        }
    }
}
