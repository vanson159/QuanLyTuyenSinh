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
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            Load2Gv();
        }

        private void Load2Gv()
        {
            DataTable dt = Ecec.DB.ChucVu.ChucVu_GetAll();
            if (dt.Rows.Count > 0)
            {
                dgvChucVu.DataSource = dt;
            }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tbChucVu.Text = dgvChucVu.Rows[e.RowIndex].Cells["tenchucvu"].Value.ToString();
                tbMaChucVu.Text = dgvChucVu.Rows[e.RowIndex].Cells["machucvu"].Value.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbChucVu.Text.Trim().Length > 0)
            {
                int kq = Ecec.DB.ChucVu.ChucVu_Insert(tbChucVu.Text);
                if (kq > 0)
                {
                    Load2Gv();
                    tbChucVu.Text = string.Empty;
                    //tbChucVu.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm lỗi");
                }
            }
            else
            {
                MessageBox.Show("Nhập giá trị vào");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbChucVu.Text.Trim().Length>0)
            {
                int kq = Ecec.DB.ChucVu.ChucVu_Update(tbMaChucVu.Text, tbChucVu.Text);
                if (kq>0)
                {
                    tbMaChucVu.Text = string.Empty;
                    tbChucVu.Text = string.Empty;
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
            if (tbMaChucVu.Text.Trim().Length > 0)
            {
                int kq = Ecec.DB.ChucVu.ChucVu_Delete(tbMaChucVu.Text);
                if (kq > 0)
                {
                    tbMaChucVu.Text = string.Empty;
                    tbChucVu.Text = string.Empty;
                    Load2Gv();
                }
                else
                {
                    MessageBox.Show("Sửa lỗi");
                }
            }
        }
    }
}
