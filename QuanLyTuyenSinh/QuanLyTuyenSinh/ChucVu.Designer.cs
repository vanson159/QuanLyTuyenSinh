namespace QuanLyTuyenSinh
{
    partial class ChucVu
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
            this.tbChucVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.machucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbMaChucVu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbChucVu
            // 
            this.tbChucVu.Location = new System.Drawing.Point(131, 30);
            this.tbChucVu.Name = "tbChucVu";
            this.tbChucVu.Size = new System.Drawing.Size(203, 22);
            this.tbChucVu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên chức vụ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machucvu,
            this.tenchucvu});
            this.dgvChucVu.Location = new System.Drawing.Point(2, 116);
            this.dgvChucVu.MultiSelect = false;
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersWidth = 51;
            this.dgvChucVu.RowTemplate.Height = 24;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(516, 177);
            this.dgvChucVu.TabIndex = 2;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            // 
            // machucvu
            // 
            this.machucvu.DataPropertyName = "machucvu";
            this.machucvu.HeaderText = "Mã chức vụ";
            this.machucvu.MinimumWidth = 6;
            this.machucvu.Name = "machucvu";
            this.machucvu.ReadOnly = true;
            this.machucvu.Width = 125;
            // 
            // tenchucvu
            // 
            this.tenchucvu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchucvu.DataPropertyName = "tenchucvu";
            this.tenchucvu.HeaderText = "Tên chức vụ";
            this.tenchucvu.MinimumWidth = 6;
            this.tenchucvu.Name = "tenchucvu";
            this.tenchucvu.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbMaChucVu
            // 
            this.tbMaChucVu.Enabled = false;
            this.tbMaChucVu.Location = new System.Drawing.Point(434, 1);
            this.tbMaChucVu.Name = "tbMaChucVu";
            this.tbMaChucVu.Size = new System.Drawing.Size(84, 22);
            this.tbMaChucVu.TabIndex = 6;
            this.tbMaChucVu.Visible = false;
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 296);
            this.Controls.Add(this.tbMaChucVu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChucVu);
            this.Name = "ChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChucVu";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn machucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchucvu;
        private System.Windows.Forms.TextBox tbMaChucVu;
    }
}