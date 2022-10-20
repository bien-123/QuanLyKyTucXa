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
    public partial class GPhong : Form
    {
        public GPhong(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layvaitro();
            layten();
            xetquyen();
        }
        string connection = Properties.Settings.Default.connection;
        private void xetquyen()
        {
            if (lbVT.Text == "Quản lý")
            {
                btThem.Enabled = false;
                btXoa.Enabled = false;
                btSua.Enabled = false;

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
        private void GPhong_Load(object sender, EventArgs e)
        {
            CPhong c = new CPhong();
            TimKiem(c.SelectListBySoPhong(""));
        }
        

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDanhSach.Rows[e.RowIndex];
            tbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            tbTang.Text = r.Cells["Tầng"].Value.ToString();
            cbbTT.Text = r.Cells["Loại phòng"].Value.ToString();
            cbbKP.Text = r.Cells["Kiểu phòng"].Value.ToString();
            tbGia.Text = r.Cells["Gia phòng"].Value.ToString();
            tbTBi.Text = r.Cells["Thiết bị"].Value.ToString();
            tbGChu.Text = r.Cells["Ghi chú"].Value.ToString();
            tbSLSV.Text = r.Cells["Số lượng SV"].Value.ToString();
        }
        private void ResetValue()
        {
            tbSoPhong.Text = "";
            tbTang.Text = "";
            cbbTT.Text = "";
            cbbKP.Text = "";
            tbTBi.Text = "";
            tbGia.Text = "";
            tbGChu.Text = "";
            tbSLSV.Text = "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbSoPhong.Focus();
                return;
            }

            if (tbTang.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTang.Focus();
                return;
            }

            CPhong c = new CPhong();
            int dem = c.Insert(tbSoPhong.Text, tbTang.Text, cbbTT.Text, cbbKP.Text, tbGia.Text, tbTBi.Text, tbGChu.Text, tbSLSV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbSoPhong.Focus();
                TimKiem(c.SelectListBySoPhong(""));
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
           

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CPhong c = new CPhong();
            int dem = c.Update(r.Cells["Số phòng"].Value.ToString(), tbTang.Text, cbbTT.Text, cbbKP.Text, tbGia.Text, tbTBi.Text, tbGChu.Text, tbSLSV.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue();
                tbSoPhong.Focus();
                TimKiem(c.SelectListBySoPhong(""));
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbSoPhong.Focus();
                return;
            }

            

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CPhong c = new CPhong();
            int dem = c.DeleteByMa(r.Cells["Số phòng"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue(); ;
                tbSoPhong.Focus();
                TimKiem(c.SelectListBySoPhong(""));
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
        private void TimKiem(List<MPhong> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Tầng", typeof(String));
                tb.Columns.Add("Loại phòng", typeof(string));
                tb.Columns.Add("Kiểu phòng", typeof(String));
                tb.Columns.Add("Gia phòng", typeof(int));
                tb.Columns.Add("Thiết bị", typeof(string));
                tb.Columns.Add("Ghi chú", typeof(string));
                tb.Columns.Add("Số lượng SV", typeof(string));
                tb.Columns.Add("Tình trạng", typeof(string));
                int tt = 0;
                foreach (MPhong m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phòng"] = m.sophong;
                    r["Tầng"] = m.tang;
                    r["Loại phòng"] = m.loaiphong;
                    r["Kiểu phòng"] = m.kieuphong;
                    r["Gia phòng"] = m.giaphong;
                    r["Thiết bị"] = m.thietbi;
                    r["Ghi chú"] = m.ghichu;
                    r["Số lượng SV"] = m.soluongsv;
                    r["Tình trạng"] = m.tinhtrang;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Số phòng"].Width = 100;
            }
            else
                dgvDanhSach.DataSource = null;
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CPhong c = new CPhong();
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
                    TimKiem(c.SelectListBySoPhong(""));
                }
            }
        }
    }
}
