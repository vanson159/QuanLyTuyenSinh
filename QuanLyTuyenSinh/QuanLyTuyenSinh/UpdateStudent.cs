using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class UpdateStudent : Form
    {
        public string nameHS, gioitinhHS, diachiHS, lopHS, emailHS, sdtHS, hokhauHS, matruongHS, ngaysinhHS;
        public string mess;

        public delegate void LoadFormDelegate(object sender, EventArgs e);
        public LoadFormDelegate loadFromDelegate;

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
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
        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            nameHS = txt_hoten.Text.Trim();
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
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn thay đổi", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {

                    string ngaysinh = dtp_ngaysinh.Value.ToString("MM/dd/yyyy");
                    string query = @"update hocsinh set hoten = N'" + nameHS + "' , gioitinh=N'" + gioitinhHS + "', diachi=N'" + diachiHS + "', lop = N'" + lopHS + "', email=N'" + emailHS + "' , sdt=N'" + sdtHS + "',hokhau=N'" + hokhauHS + "',matruong = " + matruongHS + ", ngaysinh='" + ngaysinh + "'" +
                                    "where mahocsinh =" + txt_mahs.Text;
                    Connect_DB.openConn();
                    SqlCommand cmd = new SqlCommand(query, Connect_DB.conn);
                    cmd.CommandType = CommandType.Text;
                    int a = cmd.ExecuteNonQuery();
                    Connect_DB.closeConn();
                    if (a > 0)
                    {
                        MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadFromDelegate(this, EventArgs.Empty);
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
            if (!Regex.Match(sdtHS, @"^[0-9]{10}$").Success)
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
