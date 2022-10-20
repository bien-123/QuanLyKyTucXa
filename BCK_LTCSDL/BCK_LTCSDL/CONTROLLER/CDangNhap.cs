using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CDangNhap
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

        public int DangNhap(string ma, string matkhau)
        {
            String tenProceduce = "spDangNhapPhanQuyen";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("matkhau", matkhau));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int DoiMK(string ma, string mkcu, string mkmoi)
        {
            String tenProceduce = "spDangNhapDoiMatKhau";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("matkhaucu", mkcu));
            dsThamSo.Add(new SqlParameter("matkhaumoi", mkmoi));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        

        public int Insert(string ma, string matkhau, string email, string phanquyen)
        {
            String tenProceduce = "spDangNhapThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("matkhau", matkhau));
            dsThamSo.Add(new SqlParameter("email", email));
            dsThamSo.Add(new SqlParameter("phanquyen", phanquyen));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int Update(string ma, string matkhau, string email, string phanquyen)
        {
            String tenProceduce = "spDangNhapSua";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("matkhau", matkhau));
            dsThamSo.Add(new SqlParameter("email", email));
            dsThamSo.Add(new SqlParameter("phanquyen", phanquyen));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string ma)
        {
            String tenProceduce = "spDangNhapXoa";
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

        public List<MDangNhap> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spDangNhapTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MDangNhap> ds = new List<MDangNhap>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MDangNhap m = new MDangNhap();
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
    }
}
