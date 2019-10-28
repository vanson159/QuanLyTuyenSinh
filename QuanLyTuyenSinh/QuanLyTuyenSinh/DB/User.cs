using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecec.DB
{
    class User
    {
        public static DataTable User_Login(string taikhoan, string matkhau)
        {
            string queryString = "SELECT * FROM taikhoan where tentaikhoan = @tentaikhoan and matkhau = @matkhau;";
            SqlCommand command = new SqlCommand(queryString);
            command.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar, 50).Value = taikhoan;
            command.Parameters.Add("@matkhau", SqlDbType.NVarChar, 255).Value = Hash(matkhau);
            return Database.GetData(command);
        }
        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
