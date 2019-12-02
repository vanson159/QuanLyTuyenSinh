using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh
{
    public static class Connect_DB
    {
        public static SqlConnection conn = null;
        static String strConn = "Data Source = DESKTOP-7V8H1NS; Database = tuyensinhthpt; Integrated Security = True";
        public static void openConn()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public static void closeConn()
        {
            if (conn == null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7V8H1NS; Database = tuyensinhthpt; Integrated Security = True");
            return conn;
        }
    }
}
