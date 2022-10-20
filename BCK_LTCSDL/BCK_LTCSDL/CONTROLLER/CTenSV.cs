using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BCK_LTCSDL.MODEL;

namespace BCK_LTCSDL.CONTROLLER
{
    class CTenSV
    {
        DataAccesss da = new DataAccesss();
        string ketQua;
        public string SelectTenSV(string ma)
        {
            String tenProceduce = "spLayTenSV";
            
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Read(tenProceduce, dsThamSo);
            ketQua =  pkq.Value.ToString();
            return ketQua;
        }
    }
}
