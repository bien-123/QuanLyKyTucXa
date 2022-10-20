using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CNhanVien
    {
        DataAccesss da = new DataAccesss();
        public List<MNhanVien> SelectListByTen(String ten)
        {
            String tenProceduce = "spNhanVienTimTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MNhanVien> ds = new List<MNhanVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MNhanVien m = new MNhanVien();
                    m.ma = r["MaNV"].ToString();
                    m.ten = r["TenNV"].ToString();
                    m.cmnd = int.Parse(r["CMND"].ToString());
                    m.ngaysinh = r["NgaySinh"].ToString();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.diachi = r["DiaChi"].ToString();
                    m.sdt = int.Parse(r["SDT"].ToString());
                    m.qltang = int.Parse(r["QLTang"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string ma, string ten, string cmnd, string ngaysinh, string gioitinh,
            string diachi, string sdt, string qltang)
        {
            String tenProceduce = "spNhanVienThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("cmnd", cmnd));
            dsThamSo.Add(new SqlParameter("ngaysinh", ngaysinh));
            dsThamSo.Add(new SqlParameter("gioitinh", gioitinh));
            dsThamSo.Add(new SqlParameter("diachi", diachi));
            dsThamSo.Add(new SqlParameter("sdt", sdt));
            dsThamSo.Add(new SqlParameter("qltang", qltang));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string ma, string ten, string cmnd, string ngaysinh, string gioitinh,
            string diachi, string sdt, string qltang)
        {
            String tenProceduce = "spNhanVienSuaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("cmnd", cmnd));
            dsThamSo.Add(new SqlParameter("ngaysinh", ngaysinh));
            dsThamSo.Add(new SqlParameter("gioitinh", gioitinh));
            dsThamSo.Add(new SqlParameter("diachi", diachi));
            dsThamSo.Add(new SqlParameter("sdt", sdt));
            dsThamSo.Add(new SqlParameter("qltang", qltang));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string ma)
        {
            String tenProceduce = "spNhanVienXoaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        //public MNhanVien Search(string timkiem)
        //{
        //    String tenProceduce = "spTimKiemNhanVien";
        //    //nhap so phan tu dung vs proceduce
        //    List<SqlParameter> dsThamSo = new List<SqlParameter>();
        //    dsThamSo.Add(new SqlParameter("timkiem", timkiem));
        //    DataTable tb = da.Read(tenProceduce, dsThamSo);
        //    if (tb != null && tb.Rows.Count > 0)
        //    {
        //        MNhanVien m = new MNhanVien();
        //        m.ma = tb.Rows[0]["Ma"].ToString();
        //        m.ten = tb.Rows[0]["Ten"].ToString();
        //        m.cmnd = int.Parse(tb.Rows[0]["CMND"].ToString());
        //        m.ngaysinh = tb.Rows[0]["NgaySinh"].ToString();
        //        m.gioitinh = tb.Rows[0]["GioiTinh"].ToString();
        //        m.diachi = tb.Rows[0]["DiaChi"].ToString();
        //        m.sdt = int.Parse(tb.Rows[0]["SDT"].ToString());
        //        m.qltang = int.Parse(tb.Rows[0]["QLTang"].ToString());
        //        return m;
        //    }
        //    else
        //        return null;
        //}
        public List<MNhanVien> SearchNhanVien(String timkiem)
        {
            String tenProceduce = "spNhanVienTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MNhanVien> ds = new List<MNhanVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MNhanVien m = new MNhanVien();
                    m.ma = r["MaNV"].ToString();
                    m.ten = r["TenNV"].ToString();
                    m.cmnd = int.Parse(r["CMND"].ToString());
                    m.ngaysinh = r["NgaySinh"].ToString();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.diachi = r["DiaChi"].ToString();
                    m.sdt = int.Parse(r["SDT"].ToString());
                    m.qltang = int.Parse(r["QLTang"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
