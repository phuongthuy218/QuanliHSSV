using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace quanlyhocsinhgiaovien.DataAccessLayer
{
    class DataProvider
    {
        
        private static SqlConnection conn;
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyHSGV;Integrated Security=True";
                conn = new SqlConnection(sql);
                conn.Open();
                return conn;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;

            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {

            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
 
