using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CTienNuoc
    {
        DataAccesss da = new DataAccesss();
        public List<MTienNuoc> SelectListByNoiDung(String ma)
        {
            String tenProceduce = "spHDTienNuocTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienNuoc> ds = new List<MTienNuoc>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienNuoc m = new MTienNuoc();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.tiennuoc = r["TienNuoc"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.masv = r["MaSV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string sophong, string tiennuoc, string ngaythu,
            string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienNuocThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tiennuoc", tiennuoc));
            dsThamSo.Add(new SqlParameter("ngaythutien", ngaythu));
            dsThamSo.Add(new SqlParameter("masv", masv));
            dsThamSo.Add(new SqlParameter("manv", manv));
            dsThamSo.Add(new SqlParameter("tinhtrang", tinhtrang));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string shd, string sophong, string tiennuoc, string ngaythu,
            string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienNuocSua";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("shd", shd));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tiennuoc", tiennuoc));
            dsThamSo.Add(new SqlParameter("ngaythutien", ngaythu));
            dsThamSo.Add(new SqlParameter("masv", masv));
            dsThamSo.Add(new SqlParameter("manv", manv));
            dsThamSo.Add(new SqlParameter("tinhtrang", tinhtrang));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string shd)
        {
            String tenProceduce = "spHDTienNuocXoa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("shd", shd));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public List<MTienNuoc> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spHDTienNuocTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienNuoc> ds = new List<MTienNuoc>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienNuoc m = new MTienNuoc();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.tiennuoc = r["TienNuoc"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.masv = r["MaSV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public List<MTienNuoc> SelectListUser(String ma)
        {
            String tenProceduce = "spUserHDTienNuocTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienNuoc> ds = new List<MTienNuoc>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienNuoc m = new MTienNuoc();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.tiennuoc = r["TienNuoc"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.masv = r["MaSV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
