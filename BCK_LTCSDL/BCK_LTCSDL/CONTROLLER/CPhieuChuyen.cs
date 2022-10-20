using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CPhieuChuyen
    {
        DataAccesss da = new DataAccesss();
        public List<MPhieuChuyen> SelectListByGhiChu(String ghichu)
        {
            String tenProceduce = "spChuyenPhongTimTheoSoPhong";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ghichu", ghichu));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuChuyen> ds = new List<MPhieuChuyen>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuChuyen m = new MPhieuChuyen();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophongcu = r["SoPhongCu"].ToString();
                    m.sophongmoi = r["SoPhongMoi"].ToString();
                    m.ngaychuyen = r["NgayChuyen"].ToString();
                    m.manv = r["MaNV"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int Insert(string ma, string sophongcu, string sophongmoi, string ngaychuyen, string manv)
        {
            String tenProceduce = "spChuyenPhongThem";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("masv", ma));
            dsThamSo.Add(new SqlParameter("sophongcu", sophongcu));
            dsThamSo.Add(new SqlParameter("sophongmoi", sophongmoi));
            dsThamSo.Add(new SqlParameter("ngaychuyen", ngaychuyen));
            dsThamSo.Add(new SqlParameter("manv", manv));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        public int Update(string sophieu, string ma, string sophongcu, string sophongmoi, string ngaychuyen, string manv)
        {
            String tenProceduce = "spChuyenPhongSuaTheoSoPhieu";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophieu", sophieu));
            dsThamSo.Add(new SqlParameter("masv", ma));
            dsThamSo.Add(new SqlParameter("sophongcu", sophongcu));
            dsThamSo.Add(new SqlParameter("sophongmoi", sophongmoi));
            dsThamSo.Add(new SqlParameter("ngaychuyen", ngaychuyen));
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
            String tenProceduce = "spChuyenPhongXoaTheoSoPhieu";
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

        public List<MPhieuChuyen> SearchXuPhat(String timkiem)
        {
            String tenProceduce = "spChuyenPhongTimKiem";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("timkiem", timkiem));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MPhieuChuyen> ds = new List<MPhieuChuyen>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MPhieuChuyen m = new MPhieuChuyen();
                    m.sophieu = int.Parse(r["SoPhieu"].ToString());
                    m.masv = r["MaSV"].ToString();
                    m.sophongcu = r["SoPhongCu"].ToString();
                    m.sophongmoi = r["SoPhongMoi"].ToString();
                    m.ngaychuyen = r["NgayChuyen"].ToString();
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
