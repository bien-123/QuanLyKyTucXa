using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;
using System.IO;

namespace BCK_LTCSDL.CONTROLLER
{
    class CThongKe
    {
        DataAccesss da = new DataAccesss();

        public List<MDangNhap> SelectListByGhiChu(String email)
        {
            String tenProceduce = "spDangNhapTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("email", email));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDangNhap> ds = new List<MDangNhap>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDangNhap m = new MDangNhap();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Ma = r["Ma"].ToString();
                    m.MatKhau = r["MatKhau"].ToString();
                    m.Email = r["Email"].ToString();
                    m.PhanQuyen = r["PhanQuyen"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        public List<MPhong> ThongKeSoNguoiTrongMoiPhong(String sophong)
        {
            String tenProceduce = "spThongKeSoNguoiTrongMoiPhong";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhong> ds = new List<MPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhong m = new MPhong();
                    m.sophong = r["SoPhong"].ToString();
                    m.soluongsv = r["SoLuongSV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public List<MPhong> ThongKeTongSoPhong(String sophong)
        {
            String tenProceduce = "spThongKeTongSoPhong";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhong> ds = new List<MPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                //foreach (DataRow r in dt.Rows)
                //{
                //    MPhong m = new MPhong();
                //    m.sophong = r["SoPhong"].ToString();
                //    ds.Add(m);
                //}
               // DataTable table = new DataTable();
                foreach (DataRow r in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        object value = r[col.ColumnName];
                    }
                    
                }
                return ds;
            }
            else
                return null;
        }
        /*public List<MSinhVien> ThongKeSinhVienTheoGioiTinh(String gioitinh)
        {
            String tenProceduce = "spThongKeGioiTinhSV";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("gioitinh", gioitinh));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MSinhVien> ds = new List<MSinhVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MSinhVien m = new MSinhVien();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.ma = r["MaSV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }*/

        String connection = Properties.Settings.Default.connection;
      //  DataAccesss da = new DataAccesss();
        public DataTable Doc(string query)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;
            }
            catch (Exception e)
            {
                Log(e.ToString());
                return null;
            }
        }
        public DataTable Select(string condition)
        {
            string query = "SELECT COUNT(SoPhong) FROM tb_Phong";
            if (!String.IsNullOrEmpty(condition))
                query += " Where " + condition;
            return Doc(query);
        }
        public DataTable SelectGT(string condition)
        {
            string query = "SELECT GioiTinh, COUNT(MaSV) from tb_SinhVien  GROUP BY GioiTinh";
            if (!String.IsNullOrEmpty(condition))
                query += " Where " + condition;
            return Doc(query);
        }
        public DataTable SelectDTN(string condition)
        {
            string query = "SELECT TinhTrang, COUNT(SoPhong) FROM tb_Phong GROUP BY TinhTrang";
            if (!String.IsNullOrEmpty(condition))
                query += " Where " + condition;
            return Doc(query);
        }
        public void Log(string value)
        {
            using (StreamWriter s = new StreamWriter("Log.txt", true))
            {
                s.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ":" + value);
            }
        }
    }
}
