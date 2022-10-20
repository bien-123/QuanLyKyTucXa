using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CPhieuTra
    {
        DataAccesss da = new DataAccesss(); 
        public List<MPhieuTra> SelectListByGhiChu(String ghichu)
        {
            String tenProceduce = "spPhieuTraTim";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuTra> ds = new List<MPhieuTra>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuTra m = new MPhieuTra();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.ngaytra = r["NgayTra"].ToString();
                    m.ghichu = r["GhiChu"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string ma, string sophong,  string ngaytra, string ghichu, string manv)
        {
            String tenProceduce = "spPhieuTraThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("masv", ma));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("ngaytra", ngaytra));
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string sophieu, string ma, string sophong, string ngaytra, string ghichu, string manv)
        {
            String tenProceduce = "spPhieuTraSuaTheoSoPhieu";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophieu", sophieu));
            dsThamSo.Add(new SqlParameter("masv", ma));
            dsThamSo.Add(new SqlParameter("sophong", sophong));
            dsThamSo.Add(new SqlParameter("ngaytra", ngaytra));
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
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
            String tenProceduce = "spPhieuTraXoaTheoSoPhieu";
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

        public List<MPhieuTra> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spPhieuTraTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuTra> ds = new List<MPhieuTra>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuTra m = new MPhieuTra();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophong = r["SoPhong"].ToString();
                    m.ngaytra = r["NgayTra"].ToString();
                    m.ghichu = r["GhiChu"].ToString();
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
