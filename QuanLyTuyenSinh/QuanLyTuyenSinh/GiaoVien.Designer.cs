namespace QuanLyTuyenSinh
{
    partial class GiaoVien
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
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbMagv = new System.Windows.Forms.TextBox();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(98, 48);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(100, 22);
            this.tbHoten.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(98, 98);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 22);
            this.tbEmail.TabIndex = 2;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(326, 101);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(100, 22);
            this.tbSdt.TabIndex = 3;
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(530, 103);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(178, 24);
            this.cbChucVu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnu);
            this.groupBox1.Controls.Add(this.rdnam);
            this.groupBox1.Location = new System.Drawing.Point(455, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(159, 21);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(47, 21);
            this.rdnu.TabIndex = 1;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Checked = true;
            this.rdnam.Location = new System.Drawing.Point(20, 24);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(58, 21);
            this.rdnam.TabIndex = 0;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chức vụ";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovien,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.email,
            this.sdt,
            this.machucvu});
            this.dgvGiaoVien.Location = new System.Drawing.Point(12, 203);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(776, 235);
            this.dgvGiaoVien.TabIndex = 11;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbMagv
            // 
            this.tbMagv.Enabled = false;
            this.tbMagv.Location = new System.Drawing.Point(98, 3);
            this.tbMagv.Name = "tbMagv";
            this.tbMagv.Size = new System.Drawing.Size(100, 22);
            this.tbMagv.TabIndex = 15;
            this.tbMagv.Visible = false;
            // 
            // magiaovien
            // 
            this.magiaovien.DataPropertyName = "magiaovien";
            this.magiaovien.HeaderText = "Mã giáo viên";
            this.magiaovien.MinimumWidth = 6;
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.ReadOnly = true;
            this.magiaovien.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // machucvu
            // 
            this.machucvu.DataPropertyName = "machucvu";
            this.machucvu.HeaderText = "Chức vụ";
            this.machucvu.MinimumWidth = 6;
            this.machucvu.Name = "machucvu";
            this.machucvu.ReadOnly = true;
            this.machucvu.Width = 125;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaysinh.Location = new System.Drawing.Point(326, 42);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(100, 22);
            this.dtNgaysinh.TabIndex = 16;
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.tbMagv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbHoten);
            this.Name = "GiaoVien";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbMagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn machucvu;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
    }
}