using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCK_LTCSDL.CONTROLLER;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.GUI.GStaff;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GPhieuChuyen : Form
    {
        public GPhieuChuyen(string txt)
        {
            InitializeComponent();
            laysv();
            lbMa.Text = txt.ToString();
            tbMaNV.Text = txt.ToString();
            layten();
            layvaitro();
            xetquyen();
            tbMaNV.ReadOnly = true;
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
        private void laysv()
        {
            CSinhVien c = new CSinhVien();
            List<MSinhVien> ds = c.SelectListByTen("");
            if (ds != null)
            {
                cbbMaSV.DataSource = ds;
                cbbMaSV.DisplayMember = "Ma";
                cbbSoPhongCu.DataSource = ds;
                cbbSoPhongCu.DisplayMember = "SoPhong";
            }
        }

        private void GPhieuChuyen_Load(object sender, EventArgs e)
        {
            CPhieuChuyen c = new CPhieuChuyen();
            TimKiem(c.SelectListByGhiChu(""));
        }
        private void TimKiem(List<MPhieuChuyen> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phiếu", typeof(String));
                tb.Columns.Add("Mã SV", typeof(string));
                tb.Columns.Add("Số phòng cũ", typeof(String));
                tb.Columns.Add("Số phòng mới", typeof(String));
                tb.Columns.Add("Ngày chuyển", typeof(string));
                tb.Columns.Add("Mã NV", typeof(string));
                int tt = 0;
                foreach (MPhieuChuyen m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phiếu"] = m.sophieu;
                    r["Mã SV"] = m.masv;
                    r["Số phòng cũ"] = m.sophongcu;
                    r["Số phòng mới"] = m.sophongmoi;
                    r["Ngày chuyển"] = m.ngaychuyen;
                    r["Mã NV"] = m.manv;
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
        private void ResetValue()
        {
            tbSoPhieu.Text = "";
            cbbMaSV.Text = "";
            cbbSoPhongCu.Text = "";
            cbbSoPhongMoi.Text = "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã sinh viên!");
                cbbMaSV.Focus();
                return;
            }

            if (cbbSoPhongMoi.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số phòng mới!");
                cbbSoPhongMoi.Focus();
                return;
            }
            if (cbbSoPhongCu.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số phòng cũ!");
                cbbSoPhongCu.Focus();
                return;
            }
            CPhieuChuyen c = new CPhieuChuyen();
            int dem = c.Insert(cbbMaSV.Text, cbbSoPhongCu.Text, cbbSoPhongMoi.Text, dtNgayChuyen.Text,tbMaNV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã sinh viên bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                cbbMaSV.Focus();
                return;
            }
            else if (dem == 2)
            {
                MessageBox.Show("Giới tính sinh viên và loại phòng khác nhau, mời bạn nhập lại!");
                cbbSoPhongMoi.Focus();
                return;
            }
            else if (dem == 1)
            {
                MessageBox.Show("Phòng đã đủ số lượng sinh viên, bạn phải chọn phòng khác!");
                cbbSoPhongMoi.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                ResetValue();
                TimKiem(c.SelectListByGhiChu(""));
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgv_qlmuonphong.SelectedRows[0];
            CPhieuChuyen c = new CPhieuChuyen();
            int dem = c.Update(r.Cells["Số phiếu"].Value.ToString(), cbbMaSV.Text, cbbSoPhongCu.Text, cbbSoPhongMoi.Text, dtNgayChuyen.Text,tbMaNV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào chưa tồn tại, bạn phải sử dụng mã khác!");
                tbSoPhieu.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Sửa thành công!");
                ResetValue();
                TimKiem(c.SelectListByGhiChu(""));
            }
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
            CPhieuChuyen c = new CPhieuChuyen();
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
                TimKiem(c.SelectListByGhiChu(""));
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CPhieuChuyen c = new CPhieuChuyen();
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
                    TimKiem(c.SelectListByGhiChu(""));
                }
            }
        }

        private void dgv_qlmuonphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qlmuonphong.Rows[e.RowIndex];
            tbSoPhieu.Text = r.Cells["Số phiếu"].Value.ToString();
            cbbSoPhongCu.Text = r.Cells["Số phòng cũ"].Value.ToString();
            cbbSoPhongMoi.Text = r.Cells["Số phòng mới"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
            dtNgayChuyen.Text = r.Cells["Ngày chuyển"].Value.ToString();
          //  tbMaNV.Text = r.Cells["Mã NV"].Value.ToString();
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
