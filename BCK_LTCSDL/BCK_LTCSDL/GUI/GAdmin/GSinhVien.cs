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
    public partial class GSinhVien : Form
    {
        public GSinhVien(string txt)
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
        private void GSinhVien_Load(object sender, EventArgs e)
        {
            DocDS();
        }
        private void DocDS()
        {
            tbSoPhong.ReadOnly = true;
            CSinhVien c = new CSinhVien();
            List<MSinhVien> ds = c.SelectListByTen("");
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Tên SV", typeof(String));
                tb.Columns.Add("CMND", typeof(String));
                tb.Columns.Add("Lớp", typeof(String));
                tb.Columns.Add("Ngày sinh", typeof(String));
                tb.Columns.Add("giới tính", typeof(String));
                tb.Columns.Add("Địa chỉ", typeof(string));
                tb.Columns.Add("SDT", typeof(int));
                tb.Columns.Add("SoPhong", typeof(String));
                int tt = 0;
                foreach (MSinhVien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã SV"] = m.ma;
                    r["Tên SV"] = m.ten;
                    r["CMND"] = m.cmnd;
                    r["Lớp"] = m.lop;
                    r["Ngày sinh"] = m.ngaysinh;
                    r["giới tính"] = m.gioitinh;
                    r["Địa chỉ"] = m.diachi;
                    r["SDT"] = m.sdt;
                    r["SoPhong"] = m.sophong;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Mã SV"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }
        private void ResetValue()
        {
            tbMaSV.Text = "";
            cbbGT.Text = "";
            tbTenSV.Text = "";
            tbCMND.Text = "";
            //cbbSoPhong.Text = "";
            tbDiaChi.Text = "";
            tbSDT.Text = "";
            dtNgaySinh.Text = "";
            tbLop.Text = "";
        }
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMaSV.Focus();
                return;
            }

            if (tbTenSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTenSV.Focus();
                return;
            }

            CSinhVien c = new CSinhVien();
            int dem = c.Insert(tbMaSV.Text, tbTenSV.Text, tbCMND.Text, tbLop.Text, dtNgaySinh.Text, cbbGT.Text, tbDiaChi.Text, tbSDT.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbMaSV.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMaSV.Focus();
                DocDS();
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMaSV.Focus();
                return;
            }

            if (tbTenSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTenSV.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CSinhVien c = new CSinhVien();
            int dem = c.Update(r.Cells["Mã SV"].Value.ToString(), tbTenSV.Text, tbCMND.Text, tbLop.Text, dtNgaySinh.Text, cbbGT.Text, tbDiaChi.Text, tbSDT.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu cập nhật không tồn tại!");
                tbMaSV.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMaSV.Focus();
                DocDS();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMaSV.Focus();
                return;
            }

            if (tbTenSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTenSV.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CSinhVien c = new CSinhVien();
            int dem = c.DeleteByMa(r.Cells["Mã SV"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbMaSV.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbMaSV.Focus();
                DocDS();
            }
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
        private void TimKiem(List<MSinhVien> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã NV", typeof(String));
                tb.Columns.Add("Tên NV", typeof(String));
                tb.Columns.Add("CMND", typeof(String));
                tb.Columns.Add("Lớp", typeof(String));
                tb.Columns.Add("Ngày sinh", typeof(String));
                tb.Columns.Add("giới tính", typeof(String));
                tb.Columns.Add("Địa chỉ", typeof(string));
                tb.Columns.Add("SDT", typeof(int));
                int tt = 0;
                foreach (MSinhVien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã NV"] = m.ma;
                    r["Tên NV"] = m.ten;
                    r["CMND"] = m.cmnd;
                    r["Lớp"] = m.lop;
                    r["Ngày sinh"] = m.ngaysinh;
                    r["giới tính"] = m.gioitinh;
                    r["Địa chỉ"] = m.diachi;
                    r["SDT"] = m.sdt;
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

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CSinhVien c = new CSinhVien();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgvDanhSach.DataSource = null;
                TimKiem(c.SearchNhanVien(tbTimKiem.Text));
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
            tbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
            tbTenSV.Text = r.Cells["Tên SV"].Value.ToString();
            tbCMND.Text = r.Cells["CMND"].Value.ToString();
            dtNgaySinh.Text = r.Cells["Ngày sinh"].Value.ToString();
            cbbGT.Text = r.Cells["giới tính"].Value.ToString();
            tbDiaChi.Text = r.Cells["Địa chỉ"].Value.ToString();
            tbSDT.Text = r.Cells["SDT"].Value.ToString();
            tbLop.Text = r.Cells["Lớp"].Value.ToString();
            tbSoPhong.Text = r.Cells["SoPhong"].Value.ToString();
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
