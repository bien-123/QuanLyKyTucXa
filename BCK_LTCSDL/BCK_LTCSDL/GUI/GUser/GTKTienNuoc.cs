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
    public partial class GTKTienNuoc : Form
    {
        public GTKTienNuoc(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            laysophong();
            layten();
            layvaitro();
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
        private void GTKTienNuoc_Load(object sender, EventArgs e)
        {
            CTienNuoc c = new CTienNuoc();
            DocDS(c.SelectListUser(lbMa.Text));
        }
        private void DocDS(List<MTienNuoc> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("SHD", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Tiền nước", typeof(String));
                tb.Columns.Add("Ngày thu tiền", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Mã NV", typeof(String));
                int tt = 0;
                foreach (MTienNuoc m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["SHD"] = m.shd;
                    r["Số phòng"] = m.sophong;
                    r["Tiền nước"] = m.tiennuoc;
                    r["Ngày thu tiền"] = m.ngaythutien;
                    r["Mã SV"] = m.masv;
                    r["Mã NV"] = m.manv;
                    tb.Rows.Add(r);
                }
                dgv_tktiennuoc.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_tktiennuoc.Columns["TT"].Width = 50;
                dgv_tktiennuoc.Columns["SHD"].Width = 100;
            }
            else
                dgv_tktiennuoc.DataSource = null;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CTienNuoc c = new CTienNuoc();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_tktiennuoc.DataSource = null;
                DocDS(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_tktiennuoc.DataSource == null)
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
