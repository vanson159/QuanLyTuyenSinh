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
            DataTable dt = Ecec.DB.User.User_Login(tendn,mk);
            if (dt.Rows.Count>0)
            {
                this.Hide();
                //TrangChu tc = new TrangChu();
                //tc.Show();
                State.login = true;
                
            }
            else
            {
            
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu k đúng");
            }
        }
        
    }
}
