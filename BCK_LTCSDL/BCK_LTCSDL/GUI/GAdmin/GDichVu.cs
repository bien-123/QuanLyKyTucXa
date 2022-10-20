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
    public partial class GDichVu : Form
    {
        public GDichVu(string txt)
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
            if(lbVT.Text=="Quản lý")
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
        private void GDichVu_Load(object sender, EventArgs e)
        {
            CDichVu c = new CDichVu();
            TimKiem(c.SelectListByTen(""));
        }
        private void TimKiem(List<MDichVu> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã DV", typeof(String));
                tb.Columns.Add("Tên DV", typeof(String));
                tb.Columns.Add("Mã NV", typeof(string));
                tb.Columns.Add("Tên NV", typeof(String));
                tb.Columns.Add("Địa điểm", typeof(string));
                tb.Columns.Add("Gía", typeof(string));
                int tt = 0;
                foreach (MDichVu m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Mã DV"] = m.madv;
                    r["Tên DV"] = m.tendv;
                    r["Mã NV"] = m.manv;
                    r["Tên NV"] = m.tennv;
                    r["Địa điểm"] = m.diadiem;
                    r["Gía"] = m.gia;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Mã DV"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (tbMaDV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMaDV.Focus();
                return;
            }

            if (tbTenDV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTenDV.Focus();
                return;
            }

            CDichVu c = new CDichVu();
            int dem = c.Insert(tbMaDV.Text, tbTenDV.Text, cbbMaNV.Text, cbbTenNV.Text, tbDD.Text, tbGia.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbMaDV.Focus();
                return;
            }
            else
            {
                tbMaDV.Text = "";
                tbMaDV.Focus();
                ResetValue();
                TimKiem(c.SelectListByTen(""));
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CDichVu c = new CDichVu();
            int dem = c.Update(r.Cells["Mã DV"].Value.ToString(), tbTenDV.Text, cbbMaNV.Text, cbbTenNV.Text, tbDD.Text, tbGia.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbMaDV.Focus();
                return;
            }
            else
            {
                tbMaDV.Text = "";
                tbMaDV.Focus();
                ResetValue();
                TimKiem(c.SelectListByTen(""));
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbMaDV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMaDV.Focus();
                return;
            }



            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CDichVu c = new CDichVu();
            int dem = c.DeleteByMa(r.Cells["Mã DV"].Value.ToString(), cbbMaNV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbMaDV.Focus();
                return;
            }
            else
            {
                tbMaDV.Text = "";
                tbMaDV.Focus();
                ResetValue();
                TimKiem(c.SelectListByTen(""));
            }
        }

        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            CDichVu c = new CDichVu();
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
                    TimKiem(c.SearchNhanVien(""));
                }
            }
        }

        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDanhSach.Rows[e.RowIndex];
            tbMaDV.Text = r.Cells["Mã DV"].Value.ToString();
            tbTenDV.Text = r.Cells["Tên DV"].Value.ToString();
            cbbMaNV.Text = r.Cells["Mã NV"].Value.ToString();
            cbbTenNV.Text = r.Cells["Tên NV"].Value.ToString();
            tbDD.Text = r.Cells["Địa điểm"].Value.ToString();
            tbGia.Text = r.Cells["Gía"].Value.ToString();
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
        private void ResetValue()
        {
            tbMaDV.Text = "";
            tbTenDV.Text = "";
            tbGia.Text = "";
            tbDD.Text = "";
            cbbMaNV.Text = "";
            cbbTenNV.Text = "";
        }
    }
}
