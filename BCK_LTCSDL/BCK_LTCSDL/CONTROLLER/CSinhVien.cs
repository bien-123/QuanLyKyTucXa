using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CSinhVien
    {
        DataAccesss da = new DataAccesss();
        public List<MSinhVien> SelectListByTen(String ten)
        {
            String tenProceduce = "spSinhVienTimTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MSinhVien> ds = new List<MSinhVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MSinhVien m = new MSinhVien();
                    m.ma = r["MaSV"].ToString();
                    m.ten = r["TenSV"].ToString();
                    m.cmnd = r["CMND"].ToString();
                    m.lop = r["Lop"].ToString();
                    m.ngaysinh = r["NgaySinh"].ToString();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.diachi = r["DiaChi"].ToString();
                    m.sdt = int.Parse(r["SDT"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string ma, string ten, string cmnd, string lop, string ngaysinh, string gioitinh,
            string diachi, string sdt)
        {
            String tenProceduce = "spSinhVienThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("cmnd", cmnd));
            dsThamSo.Add(new SqlParameter("lop", lop));
            dsThamSo.Add(new SqlParameter("ngaysinh", ngaysinh));
            dsThamSo.Add(new SqlParameter("gioitinh", gioitinh));
            dsThamSo.Add(new SqlParameter("diachi", diachi));
            dsThamSo.Add(new SqlParameter("sdt", sdt));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string ma, string ten, string cmnd, string lop, string ngaysinh, string gioitinh,
            string diachi, string sdt)
        {
            String tenProceduce = "spSinhVienSuaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("cmnd", cmnd));
            dsThamSo.Add(new SqlParameter("lop", lop));
            dsThamSo.Add(new SqlParameter("ngaysinh", ngaysinh));
            dsThamSo.Add(new SqlParameter("gioitinh", gioitinh));
            dsThamSo.Add(new SqlParameter("diachi", diachi));
            dsThamSo.Add(new SqlParameter("sdt", sdt));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string ma)
        {
            String tenProceduce = "spSinhVienXoaTheoMa";
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
        public List<MSinhVien> SearchNhanVien(String timkiem)
        {
            String tenProceduce = "spSinhVienTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MSinhVien> ds = new List<MSinhVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MSinhVien m = new MSinhVien();
                    m.ma = r["MaSV"].ToString();
                    m.ten = r["TenSV"].ToString();
                    m.cmnd = r["CMND"].ToString();
                    m.lop = r["Lop"].ToString();
                    m.ngaysinh = r["NgaySinh"].ToString();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.diachi = r["DiaChi"].ToString();
                    m.sdt = int.Parse(r["SDT"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
