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
    public partial class TrangChu : Form
    {
        
        public TrangChu()
        {
            InitializeComponent();
            //ShowLogin();
        }

        private void ShowLogin()
        {
            bool exits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "DangNhap")
                {
                    f.Activate();
                    exits = true;
                    break;
                }
            }
            if (!exits)
            {
                DangNhap dn = new DangNhap();
                dn.MdiParent = this;
                dn.Show();
            }
        }

       

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogin();
            
        }

        

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool exits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "GiaoVien")
                {
                    f.Activate();
                    exits = true;
                    break;
                }
            }
            if (!exits)
            {
                
                GiaoVien gv = new GiaoVien();
                gv.MdiParent = this;
                gv.Show();
            }
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool exits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ChucVu")
                {
                    f.Activate();
                    exits = true;
                    break;
                }
            }
            if (!exits)
            {

                ChucVu gv = new ChucVu();
                gv.MdiParent = this;
                gv.Show();
            }
        }
    }
}
