using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CDKDV
    {
        DataAccesss da = new DataAccesss();
        public List<MDKDV> SelectListByTen(String ten)
        {
            String tenProceduce = "spDKDVTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("tinhtrang", ten));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDKDV> ds = new List<MDKDV>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDKDV m = new MDKDV();
                    m.id = int.Parse(r["ID"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.tendv = r["TenDV"].ToString();
                    m.gia = r["Gia"].ToString();
                    m.ngaythue = r["NgayThue"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string masv, string sophong, string tendv, string gia, string ngaythue, string tinhtrang, string manv)
        {
            String tenProceduce = "spDKDVThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("masv", masv));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tendv", tendv));
            dsThamSo.Add(new SqlParameter("gia", gia));
            dsThamSo.Add(new SqlParameter("ngaythue", ngaythue));
            dsThamSo.Add(new SqlParameter("tinhtrang", tinhtrang));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            //ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string id, string masv, string sophong, string tendv, string gia, string ngaythue, string tinhtrang, string manv)
        {
            String tenProceduce = "spDKDVSuaTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            dsThamSo.Add(new SqlParameter("masv", masv));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tendv", tendv));
            dsThamSo.Add(new SqlParameter("gia", gia));
            dsThamSo.Add(new SqlParameter("ngaythue", ngaythue));
            dsThamSo.Add(new SqlParameter("tinhtrang", tinhtrang));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string id)
        {
            String tenProceduce = "spDKDVXoa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public List<MDKDV> SearchNhanVien(String timkiem)
        {
            String tenProceduce = "spDKDVTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDKDV> ds = new List<MDKDV>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDKDV m = new MDKDV();
                    m.id = int.Parse(r["ID"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.tendv = r["TenDV"].ToString();
                    m.gia = r["Gia"].ToString();
                    m.ngaythue = r["NgayThue"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
