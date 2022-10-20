using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using System.Windows.Forms;

namespace BCK_LTCSDL.GUI.GUser
{
    public partial class GCungPhong : Form
    {
        public GCungPhong(string txt)
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

        private void DocDS()
        {
            CSoPhong c = new CSoPhong();
            List<MSinhVien> ds = c.SelectListByTen(lbSP.Text);
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
                dgv_qlphong.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qlphong.Columns["TT"].Width = 50;
                dgv_qlphong.Columns["Mã SV"].Width = 100;
            }
            else
                dgv_qlphong.DataSource = null;
        }

        private void GCungPhong_Load(object sender, EventArgs e)
        {
            DocDS();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            GNguoiDung add = new GNguoiDung(lbMa.Text);
            add.Show();
            this.Hide();
        }
    }
}
