using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using System.Windows.Forms;
using BCK_LTCSDL.GUI.GStaff;
using System.Data.SqlClient;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GXuPhat : Form
    {
        public GXuPhat(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layphong();
            layten();
            layvaitro();
            laysv();
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
        private void layphong()
        {
            CPhong c = new CPhong();
            List<MPhong> ds = c.SelectListBySoPhong("");
            if (ds != null)
            {
                cbbSoPhong.DataSource = ds;
                cbbSoPhong.DisplayMember = "SoPhong";
            }
        }
        private void laysv()
        {
            CSinhVien c = new CSinhVien();
            List<MSinhVien> ds = c.SelectListByTen("");
            if (ds != null)
            {
                cbbMaSV.DataSource = ds;
                cbbMaSV.DisplayMember = "Ma";
            }
        }
        private void GXuPhat_Load(object sender, EventArgs e)
        {
            DocDS();
        }
        private void DocDS()
        {
            CXuPhat c = new CXuPhat();
            List<MXuPhat> ds = c.SelectListByNoiDung("");
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phiếu", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Nội dung", typeof(String));
                tb.Columns.Add("Hình thức", typeof(String));
                tb.Columns.Add("Ngày xử phạt", typeof(String));
                int tt = 0;
                foreach (MXuPhat m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phiếu"] = m.sophieu;
                    r["Mã SV"] = m.ma;
                    r["Số phòng"] = m.sophong;
                    r["Nội dung"] = m.noidung;
                    r["Hình thức"] = m.hinhthuc;
                    r["Ngày xử phạt"] = m.ngayxuphat;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Số phiếu"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }
        private void ResetValue()
        {
            tbSHD.Text = "";
            cbbSoPhong.Text = "";
            tbSoTien.Text = "";
            cbbMaSV.Text = "";
            tbTBi.Text = "";
            dtNgayThu.Text = "";
        }
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                cbbSoPhong.Focus();
                return;
            }

            if (tbTBi.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTBi.Focus();
                return;
            }

            CXuPhat c = new CXuPhat();
            int dem = c.Insert(cbbMaSV.Text, cbbSoPhong.Text, tbTBi.Text, tbSoTien.Text, dtNgayThu.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbSHD.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbSHD.Focus();
                DocDS();
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
           

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CXuPhat c = new CXuPhat();
            int dem = c.Update(r.Cells["Số phiếu"].Value.ToString(), cbbMaSV.Text, cbbSoPhong.Text, tbTBi.Text, tbSoTien.Text, dtNgayThu.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu cập nhật không tồn tại!");
                tbSHD.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbSHD.Focus();
                DocDS();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CXuPhat c = new CXuPhat();
            int dem = c.DeleteByMa(r.Cells["Số phiếu"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbSHD.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbSHD.Focus();
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
        private void TimKiem(List<MXuPhat> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phiếu", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Nội dung", typeof(String));
                tb.Columns.Add("Hình thức", typeof(String));
                tb.Columns.Add("Ngày xử phạt", typeof(String));
                int tt = 0;
                foreach (MXuPhat m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phiếu"] = m.sophieu;
                    r["Mã SV"] = m.ma;
                    r["Số phòng"] = m.sophong;
                    r["Nội dung"] = m.noidung;
                    r["Hình thức"] = m.hinhthuc;
                    r["Ngày xử phạt"] = m.ngayxuphat;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Số phiếu"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CXuPhat c = new CXuPhat();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgvDanhSach.DataSource = null;
                TimKiem(c.SearchXuPhat(tbTimKiem.Text));
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
            tbSHD.Text = r.Cells["Số phiếu"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
            cbbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            tbTBi.Text = r.Cells["Nội dung"].Value.ToString();
            tbSoTien.Text = r.Cells["Hình thức"].Value.ToString();
            dtNgayThu.Text = r.Cells["Ngày xử phạt"].Value.ToString();
        }
    }
}
