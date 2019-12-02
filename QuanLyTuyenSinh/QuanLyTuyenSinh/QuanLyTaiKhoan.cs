using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class QuanLyTaiKhoan : Form
    {
        private string maTk, tenDN, mk, mess;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Connect_DB.openConn();
            string query = "select  giaovien.magiaovien , hoten, mataikhoan, tentaikhoan,matkhau from taikhoan inner join giaovien on taikhoan.magiaovien = giaovien.magiaovien; ";
            SqlCommand cmd = new SqlCommand(query, Connect_DB.connect());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            adt.Fill(dtb);
            dgv_taikhoan.DataSource = dtb;

            // Select mã giáo viên cho combobox
            string queryMGV = "Select * from giaovien";
            SqlCommand cmd2 = new SqlCommand(queryMGV, Connect_DB.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cb_maGV.DataSource = ds.Tables[0];
            cb_maGV.ValueMember = "magiaovien";
            cb_maGV.DisplayMember = "magiaovien";
            cb_maGV.Enabled = true;
            Connect_DB.closeConn();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string maGV = cb_maGV.Text;
            string tenGV = tb_tengv.Text;
            tenDN = tb_tenDN.Text;
            mk = tb_mk.Text;
            if (checkValidate())
            {
                Connect_DB.openConn();
                string lenh = @"insert into taikhoan(magiaovien,matkhau,tentaikhoan)
                            values (" + maGV + ",N'" + mk + "','" + tenDN + "')";
                SqlCommand cmd = new SqlCommand(lenh, Connect_DB.conn);
                cmd.CommandType = CommandType.Text;
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                QuanLyTaiKhoan_Load(sender, e);
                Connect_DB.closeConn();
            }
            else
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_taikhoan.Rows[e.RowIndex];
            cb_maGV.Text = row.Cells[0].Value.ToString();
            tb_tengv.Text = row.Cells[1].Value.ToString();
            tb_matk.Text = row.Cells[2].Value.ToString();
            tb_tenDN.Text = row.Cells[3].Value.ToString();
            tb_mk.Text = row.Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            maTk = tb_matk.Text;
            tenDN = tb_tenDN.Text;
            mk = tb_mk.Text;
            if (maTk == "")
            {
                MessageBox.Show("Bạn phải chọn tài khoản để cập nhật!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                if (checkValidate())
                {
                    Connect_DB.openConn();
                    string lenh = @"update taikhoan set tentaikhoan = N'" + tenDN + "' , matkhau=N'" + mk + "' where mataikhoan = " + maTk;
                    SqlCommand cmd = new SqlCommand(lenh, Connect_DB.conn);
                    cmd.CommandType = CommandType.Text;
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    QuanLyTaiKhoan_Load(sender, e);
                    tb_matk.Text = null;
                    tb_tenDN.Text = null;
                    tb_mk.Text = null;
                    Connect_DB.closeConn();
                }
                else
                {
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string maTk = tb_matk.Text.ToString();
            if (maTk == null || maTk == "")
            {
                MessageBox.Show("Bạn phải chọn tài khoản để xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    Connect_DB.openConn();
                    string lenh = @"delete taikhoan where mataikhoan =" + maTk;
                    SqlCommand cmd = new SqlCommand(lenh, Connect_DB.conn);
                    cmd.CommandType = CommandType.Text;
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    QuanLyTaiKhoan_Load(sender, e);
                    tb_matk.Text = null;
                    tb_tenDN.Text = null;
                    tb_mk.Text = null;
                    Connect_DB.closeConn();
                }
            }
        }

        private void cb_maGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Connect_DB.openConn();
            String maGV = cb_maGV.Text.ToString();
            if (maGV != null || maGV != "")
            {
                string queryMGV = @"select * from giaovien where magiaovien=" + maGV;
                SqlCommand cmd2 = new SqlCommand(queryMGV, Connect_DB.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string tenGV = ds.Tables[0].Rows[0].Field<string>(1);
                tb_tengv.Text = tenGV;
                Connect_DB.closeConn();
            }
        }

        private void cb_maGV_SelectedValueChanged(object sender, EventArgs e)
        {
            Connect_DB.openConn();
            String maGV = cb_maGV.Text.ToString();
            if (maGV != null || maGV != "")
            {
                string queryMGV = @"select * from giaovien where magiaovien=" + maGV;
                SqlCommand cmd2 = new SqlCommand(queryMGV, Connect_DB.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string tenGV = ds.Tables[0].Rows[0].Field<string>(1);
                tb_tengv.Text = tenGV;
                Connect_DB.closeConn();
            }
        }

        public bool checkValidate()
        {
            // Check null
            if (tenDN == "" || mk == "")
            {
                mess = "Tên đăng nhập hoặc mật khẩu không được trống";
                return false;
            }
            else if (mk.Length < 6)
            {
                mess = "Mật khẩu phải lớn hơn 6 kí tự";
                return false;
            }
            return true;
        }
    }
}