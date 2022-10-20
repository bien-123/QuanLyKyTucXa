using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CDichVu
    {
        DataAccesss da = new DataAccesss();
        public List<MDichVu> SelectListByTen(String ten)
        {
            String tenProceduce = "spDichVuTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("tendv", ten));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDichVu> ds = new List<MDichVu>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDichVu m = new MDichVu();
                    m.madv = r["MaDV"].ToString();
                    m.tendv = r["TenDV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    m.tennv = r["TenNV"].ToString();
                    m.diadiem = r["DiaDiem"].ToString();
                    m.gia = r["Gia"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string madv, string tendv, string manv, string tennv, string diadiem, string gia)
        {
            String tenProceduce = "spDichVuThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("madv", madv));
            dsThamSo.Add(new SqlParameter("tendv", tendv));
            dsThamSo.Add(new SqlParameter("manv", manv));
            dsThamSo.Add(new SqlParameter("tennv", tennv));
            dsThamSo.Add(new SqlParameter("diadiem", diadiem));
            dsThamSo.Add(new SqlParameter("gia", gia));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            //ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string madv, string tendv, string manv, string tennv, string diadiem, string gia)
        {
            String tenProceduce = "spDichVuSuaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("madv", madv));
            dsThamSo.Add(new SqlParameter("tendv", tendv));
            dsThamSo.Add(new SqlParameter("manv", manv));
            dsThamSo.Add(new SqlParameter("tennv", tennv));
            dsThamSo.Add(new SqlParameter("diadiem", diadiem));
            dsThamSo.Add(new SqlParameter("gia", gia));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string madv, string manv)
        {
            String tenProceduce = "spDichVuXoa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("madv", madv));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public List<MDichVu> SearchNhanVien(String timkiem)
        {
            String tenProceduce = "spDichVuTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDichVu> ds = new List<MDichVu>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDichVu m = new MDichVu();
                    m.madv = r["MaDV"].ToString();
                    m.tendv = r["TenDV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    m.tennv = r["TenNV"].ToString();
                    m.diadiem = r["DiaDiem"].ToString();
                    m.gia = r["Gia"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
