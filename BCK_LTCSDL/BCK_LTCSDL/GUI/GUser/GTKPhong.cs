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
    public partial class GTKPhong : Form
    {
        public GTKPhong(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            layten();
            laysophong();
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
        private void GTKPhong_Load(object sender, EventArgs e)
        {
            CPhong c = new CPhong();
            TimKiem(c.SelectListBySoPhong(""));
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
                    tb.Rows.Add(r);
                }
                dgv_qlphong.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qlphong.Columns["TT"].Width = 50;
                dgv_qlphong.Columns["Số phòng"].Width = 100;
            }
            else
                dgv_qlphong.DataSource = null;
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
                dgv_qlphong.DataSource = null;
                TimKiem(c.SearchNhanVien(tbTimKiem.Text));
                if (dgv_qlphong.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    TimKiem(c.SelectListBySoPhong(""));
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
