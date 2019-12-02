using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class QuanLyHocSinh : Form
    {
        public string nameHS, gioitinhHS, diachiHS, lopHS, emailHS, sdtHS, hokhauHS, matruongHS, ngaysinhHS;
        public string mess;

        public QuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            // Fill data to combobox mã trường
            Connect_DB.openConn();
            string query = "Select * from truongthcs";
            SqlCommand cmd = new SqlCommand(query, Connect_DB.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cb_matruong.DataSource = ds.Tables[0];
            cb_matruong.ValueMember = "matruong";
            cb_matruong.DisplayMember = "matruong";
            cb_matruong.Enabled = true;

            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");
            cb_gioitinh.SelectedIndex = 1;
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            nameHS = txt_tenhs.Text.Trim();
            gioitinhHS = cb_gioitinh.Text;
            diachiHS = txt_diachi.Text.Trim();
            lopHS = txt_lop.Text.Trim();
            emailHS = txt_email.Text.Trim();
            sdtHS = txt_sdt.Text.Trim();
            hokhauHS = txt_hokhau.Text.Trim();
            ngaysinhHS = dtp_ngaysinh.Value.ToString("MM/dd/yyyy");
            matruongHS = cb_matruong.Text;

            if (checkNullValidate())
            {
                Connect_DB.openConn();
                string lenh = @"insert into hocsinh(hoten, gioitinh, diachi, lop, email, sdt, hokhau, matruong, ngaysinh)
                            values(N'" + nameHS + "', N'" + gioitinhHS + "', '" + diachiHS + "', N'" + lopHS + "', N'" + emailHS + "', N'" + sdtHS + "', N'" + hokhauHS + "', " + matruongHS + ", '" + ngaysinhHS + "')";
                SqlCommand cmd = new SqlCommand(lenh, Connect_DB.conn);
                cmd.CommandType = CommandType.Text;
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                Connect_DB.closeConn();
            }
            else
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void tab_QLHS_Click(object sender, EventArgs e)
        {
            Connect_DB.openConn();
            SqlCommand cmd = new SqlCommand("Select * from hocsinh", Connect_DB.connect());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            DataTable dtb2 = new DataTable();
            adt.Fill(dtb);
            adt.Fill(dtb2);
            dgv_Capnhat.DataSource = dtb;
            dgv_XoaHS.DataSource = dtb2;
            Connect_DB.closeConn();
        }

        private void dgv_Capnhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.ColumnIndex == 0)
            {
                row = dgv_Capnhat.Rows[e.RowIndex];
                UpdateStudent updateForm = new UpdateStudent();
                updateForm.txt_mahs.Text = row.Cells[1].Value.ToString();
                updateForm.txt_hoten.Text = row.Cells[2].Value.ToString();
                updateForm.cb_gioitinh.Text = row.Cells[3].Value.ToString();
                updateForm.txt_diachi.Text = row.Cells[4].Value.ToString();
                updateForm.txt_lop.Text = row.Cells[5].Value.ToString();
                updateForm.txt_email.Text = row.Cells[6].Value.ToString();
                updateForm.txt_sdt.Text = row.Cells[7].Value.ToString();
                updateForm.txt_hokhau.Text = row.Cells[8].Value.ToString();
                updateForm.cb_matruong.Text = row.Cells[9].Value.ToString();
                string dateString = row.Cells[10].Value.ToString();
                DateTime dt = DateTime.Parse(dateString);
                updateForm.dtp_ngaysinh.Value = dt;

                updateForm.loadFromDelegate = tab_QLHS_Click;
                updateForm.Show();
                updateForm.MdiParent = this.MdiParent;
            }
        }

        private void dgv_XoaHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.ColumnIndex == 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    row = dgv_XoaHS.Rows[e.RowIndex];
                    string query = @"delete hocsinh where mahocsinh =" + row.Cells[1].Value.ToString();
                    Connect_DB.openConn();
                    SqlCommand cmd = new SqlCommand(query, Connect_DB.conn);
                    cmd.CommandType = CommandType.Text;
                    int a = cmd.ExecuteNonQuery();
                    Connect_DB.closeConn();
                    if (a > 0)
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        dgv_XoaHS.Rows.Remove(row);
                    }
                }
            }
        }

        public bool checkNullValidate()
        {
            DateTime dateNow = DateTime.Now;
            DateTime dt = dtp_ngaysinh.Value;
            double year = (dateNow - dt).Days / 365;

            // Check null
            if (nameHS == "" || diachiHS == "" || lopHS == "" || emailHS == "" || sdtHS == "" || hokhauHS == "")
            {
                mess = "Bạn nhập thiếu dữ liệu";
                return false;
            }
            else if (year < 14)
            {
                mess = "Ngày sinh phải lớn hơn 14";
                return false;
            }

            //Check email
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailHS);
            }
            catch
            {
                mess = "Email sai định dạng";
                return false;
            }
            // Check số điện thoại
            if(!Regex.Match(sdtHS, @"^[0-9]{10}$").Success)
            {
                mess = "Số điện thoại không hợp lệ";
                return false;
            }
            // Check chuỗi không được có 1 kí tự
            if (nameHS.Length < 2 || diachiHS.Length < 2 || lopHS.Length < 2 || hokhauHS.Length < 2)
            {
                mess = "Tên, địa chỉ, lớp, hộ khẩu không được để 1 kí tự!";
                return false;
            }
            return true;
        }
    }
}