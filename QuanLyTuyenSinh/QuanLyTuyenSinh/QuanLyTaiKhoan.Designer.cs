namespace QuanLyTuyenSinh
{
    partial class QuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenDN = new System.Windows.Forms.TextBox();
            this.tb_matk = new System.Windows.Forms.TextBox();
            this.tb_tengv = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_maGV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giáo viên";
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.mataikhoan,
            this.tentaikhoan,
            this.matkhau});
            this.dgv_taikhoan.Location = new System.Drawing.Point(12, 245);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.Size = new System.Drawing.Size(854, 211);
            this.dgv_taikhoan.TabIndex = 2;
            this.dgv_taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "magiaovien";
            this.Column1.HeaderText = "Mã giáo viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Tên giáo viên";
            this.Column2.Name = "Column2";
            // 
            // mataikhoan
            // 
            this.mataikhoan.DataPropertyName = "mataikhoan";
            this.mataikhoan.HeaderText = "Mã tài khoản";
            this.mataikhoan.Name = "mataikhoan";
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.DataPropertyName = "tentaikhoan";
            this.tentaikhoan.HeaderText = "Tên tài khoản";
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Width = 200;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // tb_tenDN
            // 
            this.tb_tenDN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenDN.Location = new System.Drawing.Point(546, 115);
            this.tb_tenDN.Name = "tb_tenDN";
            this.tb_tenDN.Size = new System.Drawing.Size(182, 22);
            this.tb_tenDN.TabIndex = 8;
            // 
            // tb_matk
            // 
            this.tb_matk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matk.Location = new System.Drawing.Point(546, 67);
            this.tb_matk.Name = "tb_matk";
            this.tb_matk.ReadOnly = true;
            this.tb_matk.Size = new System.Drawing.Size(182, 22);
            this.tb_matk.TabIndex = 9;
            // 
            // tb_tengv
            // 
            this.tb_tengv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tengv.Location = new System.Drawing.Point(216, 115);
            this.tb_tengv.Name = "tb_tengv";
            this.tb_tengv.ReadOnly = true;
            this.tb_tengv.Size = new System.Drawing.Size(168, 22);
            this.tb_tengv.TabIndex = 10;
            // 
            // tb_mk
            // 
            this.tb_mk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mk.Location = new System.Drawing.Point(546, 161);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(182, 22);
            this.tb_mk.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(241, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Thêm tài khoản";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(378, 205);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(106, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Cập nhật  TK";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(526, 205);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Xóa tài khoản";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_maGV
            // 
            this.cb_maGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maGV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maGV.FormattingEnabled = true;
            this.cb_maGV.Location = new System.Drawing.Point(216, 67);
            this.cb_maGV.Name = "cb_maGV";
            this.cb_maGV.Size = new System.Drawing.Size(121, 24);
            this.cb_maGV.TabIndex = 15;
            this.cb_maGV.SelectionChangeCommitted += new System.EventHandler(this.cb_maGV_SelectionChangeCommitted);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 468);
            this.Controls.Add(this.cb_maGV);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tengv);
            this.Controls.Add(this.tb_matk);
            this.Controls.Add(this.tb_tenDN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenDN;
        private System.Windows.Forms.TextBox tb_matk;
        private System.Windows.Forms.TextBox tb_tengv;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_maGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
    }
}