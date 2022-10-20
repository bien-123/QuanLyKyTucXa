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
    public partial class GDKDV : Form
    {
        public GDKDV(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            xetquyen();
            layvaitro();
            layten();
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
        private void GDKDV_Load(object sender, EventArgs e)
        {
            CDKDV c = new CDKDV();
            TimKiem(c.SelectListByTen(""));
        }
        private void TimKiem(List<MDKDV> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phiếu", typeof(String));
                tb.Columns.Add("Mã SV", typeof(string));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Tên DV", typeof(String));
                tb.Columns.Add("Giá", typeof(string));
                tb.Columns.Add("Ngày thuê", typeof(string));
                tb.Columns.Add("Tình trạng", typeof(string));
                tb.Columns.Add("Mã NV", typeof(string));
                int tt = 0;
                foreach (MDKDV m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phiếu"] = m.id;
                    r["Mã SV"] = m.masv;
                    r["Số phòng"] = m.sophong;
                    r["Tên DV"] = m.tendv;
                    r["Giá"] = m.gia;
                    r["Ngày thuê"] = m.ngaythue;
                    r["Tình trạng"] = m.tinhtrang;
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
            cbbSoPhong.Text = "";
            cbbTenDV.Text = "";
            cbbTT.Text = "";
            cbbGia.Text = "";
            dtNgayChuyen.Text = "";
            tbMaNV.Text = "";
        }
        private void dgv_qlmuonphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qlmuonphong.Rows[e.RowIndex];
            tbSoPhieu.Text = r.Cells["Số phiếu"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
            cbbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            cbbTenDV.Text = r.Cells["Tên DV"].Value.ToString();
            cbbGia.Text = r.Cells["Giá"].Value.ToString();
            dtNgayChuyen.Text = r.Cells["Ngày thuê"].Value.ToString();
            cbbTT.Text = r.Cells["Tình trạng"].Value.ToString();
            tbMaNV.Text = r.Cells["Mã NV"].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã sinh viên!");
                cbbMaSV.Focus();
                return;
            }

            if (cbbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số phòng !");
                cbbSoPhong.Focus();
                return;
            }
            if (cbbTenDV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên dịch vụ!");
                cbbTenDV.Focus();
                return;
            }
            CDKDV c = new CDKDV();
            int dem = c.Insert(cbbMaSV.Text, cbbSoPhong.Text, cbbTenDV.Text, cbbGia.Text, dtNgayChuyen.Text, cbbTT.Text, tbMaNV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã sinh viên bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                cbbMaSV.Focus();
                return;
            }
            
            else
            {
                MessageBox.Show("Thêm thành công!");
                ResetValue();
                TimKiem(c.SelectListByTen(""));
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgv_qlmuonphong.SelectedRows[0];
            CDKDV c = new CDKDV();
            int dem = c.Update(r.Cells["Số phiếu"].Value.ToString(), cbbMaSV.Text, cbbSoPhong.Text, cbbTenDV.Text, cbbGia.Text, dtNgayChuyen.Text, cbbTT.Text, tbMaNV.Text);
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
                TimKiem(c.SelectListByTen(""));
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
            CDKDV c = new CDKDV();
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
                TimKiem(c.SelectListByTen(""));
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CDKDV c = new CDKDV();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_qlmuonphong.DataSource = null;
                TimKiem(c.SearchNhanVien(tbTimKiem.Text));
                if (dgv_qlmuonphong.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    TimKiem(c.SelectListByTen(""));
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            if(lbVT.Text=="Quản lý")
            {
                GQuanLy add = new GQuanLy(lbMa.Text);
                add.Show();
                this.Hide();
            }    
            else if(lbVT.Text=="Nhân viên")
            {
                GNhanVienKTX add = new GNhanVienKTX(lbMa.Text);
                add.Show();
                this.Hide();
            }    
        }
    }
}
