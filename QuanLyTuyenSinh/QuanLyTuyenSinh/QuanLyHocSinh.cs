using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTuyenSinh
{
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            string name = txt_tenhs.Text;
            string gioitinh = cb_gioitinh.Text;
            string diachi = txt_diachi.Text;
            string lop = txt_lop.Text;
            string email = txt_email.Text;
            string sdt = txt_sdt.Text;
            string hokhau = txt_hokhau.Text;
            string matruong = txt_matruong.Text;
            string ngaysinh = dtp_ngaysinh.Value.ToString("yyyy-MM-dd");

            
            Connect_DB.openConn();
            string lenh = @" insert into hocsinh(hoten, gioitinh, diachi, lop, email, sdt, hokhau, matruong, ngaysinh)
                            values(N'" + name + "', N'" + gioitinh + "', '" + diachi + "', N'" + lop + "', N'" + email + "', N'" + sdt + "', N'" + hokhau + "', " + matruong + ", '" + ngaysinh + "')";
            SqlCommand cmd = new SqlCommand(lenh,Connect_DB.conn);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            if (a>0)
            {
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            Connect_DB.closeConn();
        }

        
    }
}
