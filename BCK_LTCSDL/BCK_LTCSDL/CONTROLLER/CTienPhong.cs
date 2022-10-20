using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CTienPhong
    {
        DataAccesss da = new DataAccesss();
        public List<MTienPhong> SelectListByNoiDung(String ma)
        {
            String tenProceduce = "spHDTienPhongTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienPhong> ds = new List<MTienPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienPhong m = new MTienPhong();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.giaphong = int.Parse( r["GiaPhong"].ToString());
                    m.sothang = int.Parse( r["SoThang"].ToString());
                    m.thang = r["Thang"].ToString();
                    m.sotien = r["ThanhTien"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.thoihan = r["ThoiHan"].ToString();
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
        public int Insert(string sophong, string giaphong, string sothang, string thang, string ngaythu, string thoihan,
            string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienPhongThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("sothang", sothang));
            dsThamSo.Add(new SqlParameter("thang", thang));
            dsThamSo.Add(new SqlParameter("ngaythutien", ngaythu));
            dsThamSo.Add(new SqlParameter("thoihan", thoihan));
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

        public int Update(string shd, string sophong, string giaphong, string sothang, string thang, string ngaythu, 
            string thoihan, string masv, string manv, string tinhtrang)
        {
            String tenProceduce = "spHDTienPhongSua";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("shd", shd));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("sothang", sothang));
            dsThamSo.Add(new SqlParameter("thang", thang));
            dsThamSo.Add(new SqlParameter("ngaythutien", ngaythu));
            dsThamSo.Add(new SqlParameter("thoihan", thoihan));
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
            String tenProceduce = "spHDTienPhongXoa";
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

        public List<MTienPhong> Search(String timkiem)
        {
            String tenProceduce = "spHDTienPhongTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienPhong> ds = new List<MTienPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienPhong m = new MTienPhong();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.giaphong = int.Parse(r["GiaPhong"].ToString());
                    m.sothang = int.Parse(r["SoThang"].ToString());
                    m.thang = r["Thang"].ToString();
                    m.sotien = r["ThanhTien"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.thoihan = r["ThoiHan"].ToString();
                    m.masv = r["MaSV"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public List<MTienPhong> SelectListUser(String ma)
        {
            String tenProceduce = "spUserHDTienPhongTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MTienPhong> ds = new List<MTienPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MTienPhong m = new MTienPhong();
                    m.shd = int.Parse(r["SHD"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    m.giaphong = int.Parse(r["GiaPhong"].ToString());
                    m.sothang = int.Parse(r["CSMoi"].ToString());
                    m.thang = r["Thang"].ToString();
                    m.sotien = r["ThanhTien"].ToString();
                    m.ngaythutien = r["NgayThuTien"].ToString();
                    m.thoihan = r["ThoiHan"].ToString();
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
