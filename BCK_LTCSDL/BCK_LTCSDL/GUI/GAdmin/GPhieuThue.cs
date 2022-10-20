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
    public partial class GPhieuThue : Form
    {
        public GPhieuThue(string txt)
        {
            InitializeComponent();
            layphong();
            laysv();
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
                btThem.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;

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
                cbbGiaPhong.DataSource = ds;
                cbbGiaPhong.DisplayMember = "GiaPhong";
                cbbKP.DataSource = ds;
                cbbKP.DisplayMember = "KieuPhong";
                cbbSLSV.DataSource = ds;
                cbbSLSV.DisplayMember = "SoLuongSV";
                cbbTT.DataSource = ds;
                cbbTT.DisplayMember = "LoaiPhong";
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
        private void GPhieuThue_Load(object sender, EventArgs e)
        {
            CPhieuThue c = new CPhieuThue();
            TimKiem(c.SelectListBySoPhong(""));
        }
        private void TimKiem(List<MPhieuThue> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phiếu", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Mã SV", typeof(string));
                tb.Columns.Add("Loại phòng", typeof(string));
                tb.Columns.Add("Kiểu phòng", typeof(String));
                tb.Columns.Add("Giá phòng", typeof(int));
                tb.Columns.Add("Số lượng SV", typeof(string));
                tb.Columns.Add("Ngày thuê", typeof(string));
                tb.Columns.Add("Ghi chú", typeof(string));
                int tt = 0;
                foreach (MPhieuThue m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phiếu"] = m.SoPhieu;
                    r["Số phòng"] = m.SoPhong;
                    r["Mã SV"] = m.MaSV;
                   // r["Loại phòng"] = m.LoaiPhong;
                   // r["Kiểu phòng"] = m.KieuPhong;
                    r["Giá phòng"] = m.GiaPhong;
                    r["Số lượng SV"] = m.SLsv;
                    r["Ngày thuê"] = m.NgayThue;
                   // r["Ghi chú"] = m.GhiChu;
                    tb.Rows.Add(r);
                }
                dgv_qlmuonphong.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qlmuonphong.Columns["TT"].Width = 50;
                dgv_qlmuonphong.Columns["Số phiếu"].Width = 100;
            }
            else
                dgv_qlmuonphong.DataSource = null;
        }
        private void dgv_qlmuonphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qlmuonphong.Rows[e.RowIndex];
            tbSoPhieu.Text = r.Cells["Số phiếu"].Value.ToString();
            cbbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
            cbbTT.Text = r.Cells["Loại phòng"].Value.ToString();
            cbbKP.Text = r.Cells["Kiểu phòng"].Value.ToString();
            cbbGiaPhong.Text = r.Cells["Giá phòng"].Value.ToString();
            cbbSLSV.Text = r.Cells["Số lượng SV"].Value.ToString();
            dtNgayThue.Text = r.Cells["Ngày thuê"].Value.ToString();
            tbGChu.Text = r.Cells["Ghi chú"].Value.ToString();
        }
        private void ResetValue()
        {
            tbSoPhieu.Text = "";
            cbbSoPhong.Text = "";
            cbbMaSV.Text = "";
            cbbTT.Text = "";
            cbbKP.Text = "";
            cbbGiaPhong.Text = "";
            cbbSLSV.Text = "";
            tbGChu.Text = "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số phòng!");
                cbbSoPhong.Focus();
                return;
            }

            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã sinh viên!");
                cbbMaSV.Focus();
                return;
            }

           /* CPhieuThue c = new CPhieuThue();
            int dem = c.Insert(cbbSoPhong.Text, cbbMaSV.Text, cbbTT.Text, cbbKP.Text, cbbGiaPhong.Text, cbbSLSV.Text, dtNgayThue.Text, tbGChu.Text);
            if (dem == -2)
            {
                MessageBox.Show("Sinh viên này đã thuê phòng, bạn phải sử dụng mã khác!");
                cbbSoPhong.Focus();
                return;
            }
            else if (dem == 2)
            {
                MessageBox.Show("Giới tính sinh viên với loại phòng không giống nhau, mời bạn chọn phòng khác!");
                cbbSoPhong.Focus();
            }
            else if (dem == 1)
            {
                MessageBox.Show("Phòng đã đủ sinh viên, mời bạn chọn phòng khác!");
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                ResetValue();
                TimKiem(c.SelectListBySoPhong(""));
            }*/
        }

        private void btSua_Click(object sender, EventArgs e)
        {
           /* if (tbSoPhieu.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbSoPhieu.Focus();
                return;
            }
            DataGridViewRow r = dgv_qlmuonphong.SelectedRows[0];
            CPhieuThue c = new CPhieuThue();
            int dem = c.Update(r.Cells["Số phiếu"].Value.ToString(), cbbSoPhong.Text, cbbMaSV.Text, cbbTT.Text, cbbKP.Text, cbbGiaPhong.Text, cbbSLSV.Text, dtNgayThue.Text, tbGChu.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào chưa tồn tại, bạn phải sử dụng mã khác!");
                cbbSoPhong.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Sửa thành công!");
                ResetValue();
                TimKiem(c.SelectListBySoPhong(""));
            }*/
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbSoPhieu.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbSoPhieu.Focus();
                return;
            }

            DataGridViewRow r = dgv_qlmuonphong.SelectedRows[0];
            CPhieuThue c = new CPhieuThue();
            int dem = c.DeleteByMa(r.Cells["Số phiếu"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbSoPhieu.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Xóa thành công!");
                ResetValue();
                TimKiem(c.SelectListBySoPhong(""));
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CPhieuThue c = new CPhieuThue();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_qlmuonphong.DataSource = null;
                TimKiem(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_qlmuonphong.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    TimKiem(c.SelectListBySoPhong(""));
                }
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
    }
}
