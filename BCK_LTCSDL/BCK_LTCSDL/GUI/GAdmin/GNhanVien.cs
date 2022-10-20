using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using BCK_LTCSDL.GUI.GStaff;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GNhanVien : Form
    {
        public GNhanVien(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layten();
            layvaitro();
            xetquyen();
        }
        string connection = Properties.Settings.Default.connection;
        private void xetquyen()
        {
            if (lbVT.Text == "Quản lý")
            {
                btThemMoi.Enabled = false;
                btXoa.Enabled = false;
                btCapNhat.Enabled = false;

            }
        }
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
            else if (dem == 2)
            {
                lbVT.Text = "Sinh viên";
            }
        }
        private void GNhanVien_Load(object sender, EventArgs e)
        {
            DocDS();
        }
        private void DocDS()
        {
            CNhanVien c = new CNhanVien();
            List<MNhanVien> ds = c.SelectListByTen("");
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã NV", typeof(String));
                tb.Columns.Add("Tên NV", typeof(String));
                tb.Columns.Add("CMND", typeof(int));
                tb.Columns.Add("Ngày sinh", typeof(String));
                tb.Columns.Add("giới tính", typeof(String));
                tb.Columns.Add("Địa chỉ", typeof(string));
                tb.Columns.Add("SDT", typeof(int));
                tb.Columns.Add("QL Tầng", typeof(int));
                int tt = 0;
                foreach (MNhanVien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã NV"] = m.ma;
                    r["Tên NV"] = m.ten;
                    r["CMND"] = m.cmnd;
                    r["Ngày sinh"] = m.ngaysinh;
                    r["giới tính"] = m.gioitinh;
                    r["Địa chỉ"] = m.diachi;
                    r["SDT"] = m.sdt;
                    r["QL Tầng"] = m.qltang;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Mã NV"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            CNhanVien c = new CNhanVien();
            int dem = c.Insert(tbMa.Text, tbTen.Text, tbCMND.Text, dtNgaySinh.Text, cbbGT.Text, tbDiaChi.Text, tbSDT.Text, tbQLTang.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbMa.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMa.Focus();
                DocDS();
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CNhanVien c = new CNhanVien();
            int dem = c.Update(r.Cells["Mã NV"].Value.ToString(), tbTen.Text, tbCMND.Text, dtNgaySinh.Text, cbbGT.Text, tbDiaChi.Text, tbSDT.Text, tbQLTang.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu cập nhật không tồn tại!");
                tbMa.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMa.Focus();
                DocDS();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CNhanVien c = new CNhanVien();
            int dem = c.DeleteByMa(r.Cells["Mã NV"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbMa.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMa.Focus();
                DocDS();
            }
        }

        private void TimKiem(List<MNhanVien> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã NV", typeof(String));
                tb.Columns.Add("Tên NV", typeof(String));
                tb.Columns.Add("CMND", typeof(int));
                tb.Columns.Add("Ngày sinh", typeof(String));
                tb.Columns.Add("giới tính", typeof(String));
                tb.Columns.Add("Địa chỉ", typeof(string));
                tb.Columns.Add("SDT", typeof(int));
                tb.Columns.Add("QL Tầng", typeof(int));
                int tt = 0;
                foreach (MNhanVien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã NV"] = m.ma;
                    r["Tên NV"] = m.ten;
                    r["CMND"] = m.cmnd;
                    r["Ngày sinh"] = m.ngaysinh;
                    r["giới tính"] = m.gioitinh;
                    r["Địa chỉ"] = m.diachi;
                    r["SDT"] = m.sdt;
                    r["QL Tầng"] = m.qltang;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Mã NV"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }


        private void btDong_Click(object sender, EventArgs e)
        {
            if (lbVT.Text == "Quản lý")
            {
                GQuanLy add = new GQuanLy(lbMa.Text);
                add.Show();
                this.Hide();
            }
            else if (lbVT.Text == "Nhân viên")
            {
                GNhanVienKTX add = new GNhanVienKTX(lbMa.Text);
                add.Show();
                this.Hide();
            }
        }

        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            CNhanVien c = new CNhanVien();
            if (tbTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTK.Focus();
            }
            else
            {
                dgvDanhSach.DataSource = null;
                TimKiem(c.SearchNhanVien(tbTK.Text));
                if (dgvDanhSach.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    DocDS();
                }
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDanhSach.Rows[e.RowIndex];
            tbMa.Text = r.Cells["Mã NV"].Value.ToString();
            tbTen.Text = r.Cells["Tên NV"].Value.ToString();
            tbCMND.Text = r.Cells["CMND"].Value.ToString();
            dtNgaySinh.Text = r.Cells["Ngày sinh"].Value.ToString();
            cbbGT.Text = r.Cells["giới tính"].Value.ToString();
            tbDiaChi.Text = r.Cells["Địa chỉ"].Value.ToString();
            tbSDT.Text = r.Cells["SDT"].Value.ToString();
            tbQLTang.Text = r.Cells["QL Tầng"].Value.ToString();
        }
        private void ResetValue()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbCMND.Text = "";
            cbbGT.Text = "";
            tbDiaChi.Text = "";
            tbSDT.Text = "";
            tbQLTang.Text = "";
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
