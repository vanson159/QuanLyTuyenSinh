using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn thay đổi", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
               
                string ngaysinh = dtp_ngaysinh.Value.ToString("dd/MM/yyyy");
                string query = @"update hocsinh set hoten = N'" + txt_hoten.Text + "' , gioitinh=N'" + cb_gioitinh.Text + "', diachi=N'" + txt_diachi.Text + "', lop = N'" + txt_lop.Text + "', email=N'" + txt_email.Text + "' , sdt=N'" + txt_sdt.Text + "',hokhau=N'" + txt_hokhau.Text + "',matruong = " + txt_matruong.Text + ", ngaysinh='" + ngaysinh + "'" +
                                "where mahocsinh =" + txt_mahs.Text;
                Connect_DB.openConn();
                SqlCommand cmd = new SqlCommand(query, Connect_DB.conn);
                cmd.CommandType = CommandType.Text;
                int a = cmd.ExecuteNonQuery();
                Connect_DB.closeConn();
                if (a > 0)
                {
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
