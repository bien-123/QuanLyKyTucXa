using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CPhieuThue
    {
        DataAccesss da = new DataAccesss();
        public List<MPhieuThue> SelectListBySoPhong(String sophong)
        {
            String tenProceduce = "spPhieuThueTimTheoLoaiPhong";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuThue> ds = new List<MPhieuThue>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuThue m = new MPhieuThue();
                    m.SoPhieu = int.Parse(r["SoPhieu"].ToString());
                    m.SoPhong = r["SoPhong"].ToString();
                    m.MaSV = r["MaSV"].ToString();
                 //   m.LoaiPhong = r["LoaiPhong"].ToString();
                 //   m.KieuPhong = r["KieuPhong"].ToString();
                    m.GiaPhong = r["GiaPhong"].ToString();
                    m.SLsv = r["SoLuongSV"].ToString();
                    m.NgayThue = r["NgayThue"].ToString();
                    //   m.GhiChu = r["GhiChu"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string sophong, string ma, string giaphong, string slsv, string ngaythue, string manv)
        {
            String tenProceduce = "spPhieuThueThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("masv", ma));
         //   dsThamSo.Add(new SqlParameter("loaiphong", loaiphong));
         //   dsThamSo.Add(new SqlParameter("kieuphong", kieuphong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("soluongsv", slsv));
            dsThamSo.Add(new SqlParameter("ngaythue", ngaythue));
            //   dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            dsThamSo.Add(new SqlParameter("manv", ma));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string sophieu, string sophong, string ma, string giaphong, string slsv, string ngaythue, string manv)
        {
            String tenProceduce = "spPhieuThueSuaTheoSoPhieu";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophieu", sophieu));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("masv", ma));
        //    dsThamSo.Add(new SqlParameter("loaiphong", loaiphong));
        //    dsThamSo.Add(new SqlParameter("kieuphong", kieuphong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("soluongsv", slsv));
            dsThamSo.Add(new SqlParameter("ngaythue", ngaythue));
            //    dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string sophieu)
        {
            String tenProceduce = "spPhieuThueXoaTheoSoPhieu";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophieu", sophieu));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        
        public List<MPhieuThue> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spPhieuThueTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuThue> ds = new List<MPhieuThue>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuThue m = new MPhieuThue();
                    m.SoPhieu = int.Parse(r["SoPhieu"].ToString());
                    m.SoPhong = r["SoPhong"].ToString();
                    m.MaSV = r["MaSV"].ToString();
                 //   m.LoaiPhong = r["LoaiPhong"].ToString();
                   // m.KieuPhong = r["KieuPhong"].ToString();
                    m.GiaPhong = r["GiaPhong"].ToString();
                    m.SLsv = r["SoLuongSV"].ToString();
                    m.NgayThue = r["NgayThue"].ToString();
                    //  m.GhiChu = r["GhiChu"].ToString();
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
