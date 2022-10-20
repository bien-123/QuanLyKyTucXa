using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CXuPhat
    {
        DataAccesss da = new DataAccesss();
        public List<MXuPhat> SelectListByNoiDung(String noidung)
        {
            String tenProceduce = "spXuPhatTimTheoNoiDung";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("noidung", noidung));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MXuPhat> ds = new List<MXuPhat>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MXuPhat m = new MXuPhat();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.ma = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.noidung = r["NoiDung"].ToString();
                    m.hinhthuc = r["HinhThuc"].ToString();
                    m.ngayxuphat = r["NgayXuPhat"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string ma, string sophong, string noidung, string hinhthuc, string ngayxuphat)
        {
            String tenProceduce = "spXuPhatThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("noidung", noidung));
            dsThamSo.Add(new SqlParameter("hinhthuc", hinhthuc));
            dsThamSo.Add(new SqlParameter("ngayxuphat", ngayxuphat));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string sophieu, string ma, string sophong, string noidung, string hinhthuc, string ngayxuphat)
        {
            String tenProceduce = "spXuPhatSuaTheoSoPhieu";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophieu", sophieu));
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("noidung", noidung));
            dsThamSo.Add(new SqlParameter("hinhthuc", hinhthuc));
            dsThamSo.Add(new SqlParameter("ngayxuphat", ngayxuphat));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
        public int DeleteByMa(string sophieu)
        {
            String tenProceduce = "spXuPhatXoaTheoSoPhieu";
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
        
        public List<MXuPhat> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spXuPhatTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MXuPhat> ds = new List<MXuPhat>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MXuPhat m = new MXuPhat();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.ma = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.noidung = r["NoiDung"].ToString();
                    m.hinhthuc = r["HinhThuc"].ToString();
                    m.ngayxuphat = r["NgayXuPhat"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
    }
}
