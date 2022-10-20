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
using System.Data.SqlClient;

namespace BCK_LTCSDL.GUI.GUser
{
    public partial class GTKTienDien : Form
    {
        public GTKTienDien(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layten();
            layvaitro();
            laysophong();
        }
        string connection = Properties.Settings.Default.connection;
        public void layten()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_SinhVien.TenSV from tb_SinhVien where tb_SinhVien.MaSV = '" + lbMa.Text + "'  ";
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
        private void laysophong()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_SinhVien.SoPhong from tb_SinhVien where tb_SinhVien.MaSV = '" + lbMa.Text + "'  ";
            SqlCommand Comm_Ten = new SqlCommand(hoten, conn);
            conn.Open();
            SqlDataReader DR_Ten = Comm_Ten.ExecuteReader();
            if (DR_Ten.Read())
            {
                lbSP.Text = DR_Ten.GetValue(0).ToString();
            }
            conn.Close();


        }
        private void GTKTienDien_Load(object sender, EventArgs e)
        {
            CTienDien c = new CTienDien();
            DocDS(c.SelectListUser(lbMa.Text));
        }
        private void DocDS(List<MTienDien> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("SHD", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("CS Cũ", typeof(String));
                tb.Columns.Add("CS Mới", typeof(String));
                tb.Columns.Add("Đơn giá", typeof(String));
                tb.Columns.Add("Thành tiền", typeof(String));
                tb.Columns.Add("Ngày thu tiền", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Mã NV", typeof(String));
                int tt = 0;
                foreach (MTienDien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["SHD"] = m.shd;
                    r["Số phòng"] = m.sophong;
                    r["CS Cũ"] = m.cscu;
                    r["CS Mới"] = m.csmoi;
                    r["Đơn giá"] = m.dongia;
                    r["Thành tiền"] = m.thanhtien;
                    r["Ngày thu tiền"] = m.ngaythutien;
                    r["Mã SV"] = m.masv;
                    r["Mã NV"] = m.manv;
                    tb.Rows.Add(r);
                }
                dgv_tktiendien.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_tktiendien.Columns["TT"].Width = 50;
                dgv_tktiendien.Columns["SHD"].Width = 100;
            }
            else
                dgv_tktiendien.DataSource = null;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CTienDien c = new CTienDien();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_tktiendien.DataSource = null;
                DocDS(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_tktiendien.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    DocDS(c.SelectListByNoiDung(""));
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            GNguoiDung add = new GNguoiDung(lbMa.Text);
            add.Show();
            this.Hide();
        }
    }
}
