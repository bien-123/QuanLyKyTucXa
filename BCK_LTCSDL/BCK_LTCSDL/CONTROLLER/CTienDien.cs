using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;


namespace BCK_LTCSDL.CONTROLLER
{
    class CTienDien
    {
        DataAccesss da = new DataAccesss();
        public List<MTienDien> SelectListByNoiDung(String ma)
        {
            String tenProceduce = "spHDTienDienTimTheoMaSV";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienDien> ds = new List<MTienDien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienDien m = new MTienDien();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.cscu = r["CSCu"].ToString();
                    m.csmoi = r["CSMoi"].ToString();
                    m.dongia = r["DonGia"].ToString();
                    m.thanhtien = r["ThanhTien"].ToString();
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
        public int Insert(string sophong, string cscu, string csmoi, string dongia, string ngaythu,
            string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienDienThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("cscu", cscu));
            dsThamSo.Add(new SqlParameter("csmoi", csmoi));
            dsThamSo.Add(new SqlParameter("dongia", dongia));
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

        public int Update(string shd, string sophong, string cscu, string csmoi, string dongia, string ngaythu,
            string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienDienSuaTheoSHD";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("shd", shd));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("cscu", cscu));
            dsThamSo.Add(new SqlParameter("csmoi", csmoi));
            dsThamSo.Add(new SqlParameter("dongia", dongia));
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
            String tenProceduce = "spHDTienDienXoaTheoSHD";
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

        public List<MTienDien> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spHDTienDienTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienDien> ds = new List<MTienDien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienDien m = new MTienDien();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.cscu = r["CSCu"].ToString();
                    m.csmoi = r["CSMoi"].ToString();
                    m.dongia = r["DonGia"].ToString();
                    m.thanhtien = r["ThanhTien"].ToString();
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
        public List<MTienDien> SelectListUser(String ma)
        {
            String tenProceduce = "spUserTimHDTienDien";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienDien> ds = new List<MTienDien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienDien m = new MTienDien();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.cscu = r["CSCu"].ToString();
                    m.csmoi = r["CSMoi"].ToString();
                    m.dongia = r["DonGia"].ToString();
                    m.thanhtien = r["ThanhTien"].ToString();
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
