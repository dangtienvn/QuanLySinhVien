namespace QLSV
{
    partial class fQuanLyTaiKhoan
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
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(1128, 77);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(109, 37);
            this.button_TimKiem.TabIndex = 25;
            this.button_TimKiem.TabStop = false;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(1147, 31);
            this.textBox_TimKiem.MaxLength = 255;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(167, 26);
            this.textBox_TimKiem.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1063, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tìm kiếm:";
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(662, 82);
            this.button_TaiLai.Name = "button_TaiLai";
            this.button_TaiLai.Size = new System.Drawing.Size(140, 40);
            this.button_TaiLai.TabIndex = 22;
            this.button_TaiLai.TabStop = false;
            this.button_TaiLai.Text = "Tải Lại";
            this.button_TaiLai.UseVisualStyleBackColor = true;
            this.button_TaiLai.Click += new System.EventHandler(this.button_TaiLai_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(489, 82);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(140, 40);
            this.button_Xoa.TabIndex = 21;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(311, 82);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(140, 40);
            this.button_Sua.TabIndex = 20;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(135, 82);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(140, 40);
            this.button_Them.TabIndex = 19;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_LoaiTaiKhoan);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_TaiLai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.textBox_MatKhau);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_TenDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 150);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_LoaiTaiKhoan
            // 
            this.comboBox_LoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoaiTaiKhoan.FormattingEnabled = true;
            this.comboBox_LoaiTaiKhoan.Items.AddRange(new object[] {
            "Quản lí",
            "Giáo Viên"});
            this.comboBox_LoaiTaiKhoan.Location = new System.Drawing.Point(758, 29);
            this.comboBox_LoaiTaiKhoan.Name = "comboBox_LoaiTaiKhoan";
            this.comboBox_LoaiTaiKhoan.Size = new System.Drawing.Size(146, 27);
            this.comboBox_LoaiTaiKhoan.TabIndex = 3;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(439, 30);
            this.textBox_MatKhau.MaxLength = 255;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(165, 26);
            this.textBox_MatKhau.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại tài khoản:";
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(175, 30);
            this.textBox_TenDangNhap.MaxLength = 255;
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(137, 26);
            this.textBox_TenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.AllowUserToAddRows = false;
            this.dataGridView_TaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_TaiKhoan.MultiSelect = false;
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.ReadOnly = true;
            this.dataGridView_TaiKhoan.RowHeadersVisible = false;
            this.dataGridView_TaiKhoan.RowTemplate.Height = 30;
            this.dataGridView_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(1370, 204);
            this.dataGridView_TaiKhoan.TabIndex = 1;
            this.dataGridView_TaiKhoan.TabStop = false;
            this.dataGridView_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TaiKhoan_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "TÊN ĐĂNG NHẬP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "MẬT KHẨU";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "LOẠI TÀI KHOẢN";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_TaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 204);
            this.panel2.TabIndex = 3;
            // 
            // fQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQuanLyTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_TaiKhoan;
        private System.Windows.Forms.ComboBox comboBox_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
    }
}