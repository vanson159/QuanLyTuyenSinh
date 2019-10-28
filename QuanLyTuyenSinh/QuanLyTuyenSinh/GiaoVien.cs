using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh
{
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            Load2Gv();
        }

        private void Load2Gv()
        {
            DataTable dt = Ecec.DB.GiaoVien.GiaoVien_GetAll();
            if (dt.Rows.Count > 0)
            {
                dgvGiaoVien.DataSource = dt;
            }
        }

        private void LoadChucVu()
        {
            DataTable dt = Ecec.DB.ChucVu.ChucVu_GetAll();
            if (dt.Rows.Count > 0)
            {
                cbChucVu.DataSource = dt;
                cbChucVu.DisplayMember = "tenchucvu";
                cbChucVu.ValueMember = "machucvu";
            }

        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tbMagv.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                tbHoten.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                dtNgaysinh.Value = Convert.ToDateTime(dgvGiaoVien.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString());
                tbEmail.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbSdt.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
                string gioitinh = dgvGiaoVien.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rdnam.Checked = true;
                }
                else
                {
                    rdnu.Checked = true;
                }
                cbChucVu.SelectedIndex = cbChucVu.FindStringExact(LayTenChucVu(dgvGiaoVien.Rows[e.RowIndex].Cells["machucvu"].Value.ToString()));
            }
        }

        private string LayTenChucVu(string id)
        {
            DataTable dt = Ecec.DB.ChucVu.ChucVu_GetName(id);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbHoten.Text.Trim().Length > 0)
            {
                string gt = rdnam.Checked ? "Nam" : "Nữ";
                int kq = Ecec.DB.GiaoVien.GiaoVien_Insert(tbHoten.Text, tbEmail.Text, dtNgaysinh.Value.ToString("yyyy-MM-dd"), tbSdt.Text, gt, cbChucVu.SelectedValue.ToString());
                if (kq > 0)
                {
                    tbMagv.Text = string.Empty;
                    tbHoten.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    tbSdt.Text = string.Empty;
                    Load2Gv();
                }
                else
                {
                    MessageBox.Show("Thêm lỗi");
                }
            }
            else
            {
                MessageBox.Show("Nhập họ tên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbHoten.Text.Trim().Length > 0)
            {
                string gt = rdnam.Checked ? "Nam" : "Nữ";
                int kq = Ecec.DB.GiaoVien.GiaoVien_Update(tbMagv.Text, tbHoten.Text, tbEmail.Text, dtNgaysinh.Value.ToString("yyyy-MM-dd"), tbSdt.Text, gt, cbChucVu.SelectedValue.ToString());
                if (kq >0 )
                {
                    tbMagv.Text = string.Empty;
                    tbHoten.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    tbSdt.Text = string.Empty;
                    Load2Gv();
                }
                else
                {
                    MessageBox.Show("Sửa lỗi");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbMagv.Text.Length>0)
            {
                int kq = Ecec.DB.GiaoVien.GiaoVien_Delete(tbMagv.Text);
                if (kq>0)
                {
                    Load2Gv();
                }
                else
                {
                    MessageBox.Show("Xóa lỗi");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 người");
            }
        }
    }
}
