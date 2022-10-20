using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;


namespace BCK_LTCSDL.CONTROLLER
{
    class CPhong
    {
        DataAccesss da = new DataAccesss();
        public List<MPhong> SelectListBySoPhong(string thietbi)
        {
            String tenProceduce = "spPhongTimTheoThietBi";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("thietbi", thietbi));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhong> ds = new List<MPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhong m = new MPhong();
                    m.sophong = r["SoPhong"].ToString();
                    m.tang = r["Tang"].ToString();
                    m.loaiphong = r["LoaiPhong"].ToString();
                    m.kieuphong = r["KieuPhong"].ToString();
                    m.giaphong = int.Parse(r["GiaPhong"].ToString());
                    m.thietbi = r["ThietBi"].ToString();
                    m.ghichu = r["GhiChu"].ToString();
                    m.soluongsv = r["SoLuongSV"].ToString();
                    m.tinhtrang = r["TinhTrang"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string sophong, string tang, string loaiphong, string kieuphong, string giaphong,
            string thietbi, string ghichu, string soluongsv)
        {
            String tenProceduce = "spPhongThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tang", tang));
            dsThamSo.Add(new SqlParameter("loaiphong", loaiphong));
            dsThamSo.Add(new SqlParameter("kieuphong", kieuphong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("thietbi", thietbi));
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            dsThamSo.Add(new SqlParameter("soluongsv", soluongsv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string sophong, string tang, string loaiphong, string kieuphong, string giaphong,
            string thietbi, string ghichu, string soluongsv)
        {
            String tenProceduce = "spPhongSuaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("tang", tang));
            dsThamSo.Add(new SqlParameter("loaiphong", loaiphong));
            dsThamSo.Add(new SqlParameter("kieuphong", kieuphong));
            dsThamSo.Add(new SqlParameter("giaphong", giaphong));
            dsThamSo.Add(new SqlParameter("thietbi", thietbi));
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            dsThamSo.Add(new SqlParameter("soluongsv", soluongsv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(String sophong)
        {
            String tenProceduce = "spPhongXoaTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public List<MPhong> SearchNhanVien(String timkiem)
        {
            String tenProceduce = "spPhongTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhong> ds = new List<MPhong>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhong m = new MPhong();
                    m.sophong = r["SoPhong"].ToString();
                    m.tang = r["Tang"].ToString();
                    m.loaiphong = r["LoaiPhong"].ToString();
                    m.kieuphong = r["KieuPhong"].ToString();
                    m.giaphong = int.Parse(r["GiaPhong"].ToString());
                    m.thietbi = r["ThietBi"].ToString();
                    m.ghichu = r["GhiChu"].ToString();
                    m.soluongsv = r["SoLuongSV"].ToString();
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
