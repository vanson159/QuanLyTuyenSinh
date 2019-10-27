using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tendn = txtTenDN.Text;
            String mk = txtMK.Text;
            SqlConnection conn = Connect_DB.connect();
            conn.Open();
            string queryString = "SELECT * FROM taikhoan where tentaikhoan = @tentaikhoan and matkhau = @matkhau;";

            SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar, 50).Value = tendn;
                command.Parameters.Add("@matkhau", SqlDbType.NVarChar, 255).Value = Hash(mk);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Close();
                    conn.Close();
                    this.Hide();
                    TrangChu tc = new TrangChu();
                    tc.Show();
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu k đúng");
                }
            }
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
