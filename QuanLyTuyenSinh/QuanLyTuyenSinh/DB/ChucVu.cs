using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecec.DB
{
    class ChucVu
    {
        public static DataTable ChucVu_GetAll()
        {
            string queryString = "SELECT * FROM chucvu";
            SqlCommand command = new SqlCommand(queryString);
            return Database.GetData(command);
        }
        public static int ChucVu_Insert(string tencv)
        {
            string sql = "insert into chucvu values(@tencv)";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@tencv", tencv);
            return Database.ExecuteNoneQuery(command);
        }
        public static int ChucVu_Update(string id,string tencv)
        {
            string sql = "update chucvu set tenchucvu = @tencv where machucvu = @id";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@tencv", tencv);
            command.Parameters.AddWithValue("@id", id);
            return Database.ExecuteNoneQuery(command);
        }
        public static int ChucVu_Delete(string id)
        {
            string sql = "delete chucvu where machucvu = @id";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            return Database.ExecuteNoneQuery(command);
        }
        public static DataTable ChucVu_GetName(string id)
        {
            string sql = "select tenchucvu from chucvu where machucvu = @id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", id);
            return Database.GetData(cmd);
        }
    }
}
