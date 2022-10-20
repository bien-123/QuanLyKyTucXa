using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BCK_LTCSDL.CONTROLLER
{
    class DataAccesss
    {
        string connection = Properties.Settings.Default.connection;
        public void Write(String tenProceduce,List<SqlParameter> dsThamSo)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenProceduce;
            foreach (SqlParameter para in dsThamSo)
                cmd.Parameters.Add(para);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }
        }
        public DataTable Read(String tenProceduce, List<SqlParameter> dsThamSo)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenProceduce;
            foreach (SqlParameter para in dsThamSo)
                cmd.Parameters.Add(para);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
    }
}
