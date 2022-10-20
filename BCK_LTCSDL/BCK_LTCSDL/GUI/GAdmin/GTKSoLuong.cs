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
    public partial class GTKSoLuong : Form
    {
        public GTKSoLuong()
        {
            InitializeComponent();
        }
        private void TKSoNguoiTrongMoiPhong()
        {
             CThongKe c = new CThongKe();
            List<MPhong> ds = c.ThongKeSoNguoiTrongMoiPhong("");
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Số lượng sinh viên", typeof(int));
                int tt = 0;
                foreach (MPhong m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["Số phòng"] = m.sophong;
                    r["Số lượng sinh viên"] = m.soluongsv;
                    tb.Rows.Add(r);
                }
                dgv_qltienphong.DataSource = tb;
            }
            else
                dgv_qltienphong.DataSource = null;
        }
        //private void TKTongSoPhong()
        //{
        //    CThongKe c = new CThongKe();
        //    List<MPhong> ds = c.ThongKeTongSoPhong("");
        //    if (ds != null && ds.Count > 0)
        //    {
        //        DataTable tb = new DataTable();
        //        tb.Columns.Add("Số phòng hiện có", typeof(String));
        //        foreach (MPhong m in ds)
        //        {
        //            DataRow r = tb.NewRow();
        //            r["Số phòng hiện có"] = m.sophong;
        //            tb.Rows.Add(r);
        //        }
        //        dgv_qltienphong.DataSource = tb;
        //    }
        //    else
        //        dgv_qltienphong.DataSource = null;
        //}

      /*  private void TKSinhVienTheoGioiTinh()
        {
            CThongKe c = new CThongKe();
            List<MSinhVien> ds = c.ThongKeSinhVienTheoGioiTinh(cbbGT.Text);
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("Giới tính", typeof(String));
                tb.Columns.Add("Số lượng", typeof(String));
                foreach (MSinhVien m in ds)
                {
                    DataRow r = tb.NewRow();
                    r["Giới tính"] = m.gioitinh;
                    r["Số lượng"] = m.ma;
                    tb.Rows.Add(r);
                }
                dgv_qltienphong.DataSource = tb;
            }
            else
                dgv_qltienphong.DataSource = null;
        }*/
        private void layds()
        {
            //tbTienDien.ReadOnly = true;
            CThongKe c = new CThongKe();
            DataTable tb = c.Select("");
            if (tb != null)
            {
                dgv_qltienphong.DataSource = tb;
                dgv_qltienphong.Columns["Column1"].HeaderText = "Tổng số phòng hiện có";
            }
        }
        private void laydstheoGT()
        {
            //tbTienDien.ReadOnly = true;
            CThongKe c = new CThongKe();
            DataTable tb = c.SelectGT("");
            if (tb != null)
            {
                dgv_qltienphong.DataSource = tb;
                dgv_qltienphong.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv_qltienphong.Columns["Column1"].HeaderText = "Số lượng sinh viên";
                
            }
        }
        private void laydsP()
        {
            //tbTienDien.ReadOnly = true;
            CThongKe c = new CThongKe();
            DataTable tb = c.SelectDTN("");
            if (tb != null)
            {
                dgv_qltienphong.DataSource = tb;
                dgv_qltienphong.Columns["Column1"].HeaderText = "Số lượng phòng";
                dgv_qltienphong.Columns["TinhTrang"].HeaderText = "Tình trạng";
            }
        }
        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (rdbGT.Checked == true)
            {
                laydstheoGT();
            }
            else if (rdbTS.Checked == true)
            {
                layds();
            }
            else if (rdbSN.Checked == true)
            {
                TKSoNguoiTrongMoiPhong();
            }
            else if (rdbDN.Checked == true)
            {
                laydsP();
            }
        }

        private void GTKSoLuong_Load(object sender, EventArgs e)
        {
            
        }
    }
}
