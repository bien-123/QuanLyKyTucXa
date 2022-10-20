using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CSoPhong
    {
        DataAccesss da = new DataAccesss();
        public List<MSinhVien> SelectListByTen(String ten)
        {
            String tenProceduce = "spSinhVienCungPhong";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("sophong", ten));
            DataTable dt = da.Read(tenProceduce, dsThamSo);
            List<MSinhVien> ds = new List<MSinhVien>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    MSinhVien m = new MSinhVien();
                    m.ma = r["MaSV"].ToString();
                    m.ten = r["TenSV"].ToString();
                    m.cmnd = r["CMND"].ToString();
                    m.lop = r["Lop"].ToString();
                    m.ngaysinh = r["NgaySinh"].ToString();
                    m.gioitinh = r["GioiTinh"].ToString();
                    m.diachi = r["DiaChi"].ToString();
                    m.sdt = int.Parse(r["SDT"].ToString());
                    m.sophong = r["SoPhong"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }
        public int LaySP(int ma)
        {
            String tenProceduce = "spLaySoPhong";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Read(tenProceduce, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
    }
}
