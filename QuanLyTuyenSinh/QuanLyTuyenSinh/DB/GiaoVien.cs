using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecec.DB
{
    class GiaoVien
    {
        public static DataTable GiaoVien_GetAll()
        {
            string queryString = "SELECT * FROM giaovien";
            SqlCommand command = new SqlCommand(queryString);
            return Database.GetData(command);
        }
        public static int GiaoVien_Insert(string hoten, string email, string ngaysinh, string sdt, string gioitinh, string chucvu)
        {
            string queryString = "insert into giaovien values(@hoten,@ngaysinh,@gioitinh,@email,@sdt,@chucvu)";
            SqlCommand command = new SqlCommand(queryString);
            command.Parameters.AddWithValue("@hoten",hoten);
            command.Parameters.AddWithValue("@ngaysinh",ngaysinh);
            command.Parameters.AddWithValue("@gioitinh",gioitinh);
            command.Parameters.AddWithValue("@email",email);
            command.Parameters.AddWithValue("@sdt",sdt);
            command.Parameters.AddWithValue("@chucvu",chucvu);
            return Database.ExecuteNoneQuery(command);
        }
        public static int GiaoVien_Update(string id,string hoten, string email, string ngaysinh, string sdt, string gioitinh, string chucvu)
        {
            string queryString = "update giaovien set hoten = @hoten,ngaysinh = @ngaysinh,gioitinh = @gioitinh,email = @email,sdt = @sdt,machucvu = @chucvu where magiaovien = @id";
            SqlCommand command = new SqlCommand(queryString);
            command.Parameters.AddWithValue("@hoten", hoten);
            command.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            command.Parameters.AddWithValue("@gioitinh", gioitinh);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@sdt", sdt);
            command.Parameters.AddWithValue("@chucvu", chucvu);
            command.Parameters.AddWithValue("@id", id);
            return Database.ExecuteNoneQuery(command);
        }
        public static int GiaoVien_Delete(string id)
        {
            string sql = "delete giaovien where magiaovien = @id";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            return Database.ExecuteNoneQuery(command);
        }
    }
}
