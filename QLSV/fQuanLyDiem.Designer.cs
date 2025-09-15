namespace QLSV
{
    partial class fQuanLyDiem
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
            this.label11 = new System.Windows.Forms.Label();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_DiemTrungBinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_DiemThi = new System.Windows.Forms.TextBox();
            this.dataGridView_Diem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DiemLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new QLSV.DataSetTableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_PhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.comboBox_MaMonHoc = new System.Windows.Forms.ComboBox();
            this.comboBox_MaSinhVien = new System.Windows.Forms.ComboBox();
            this.comboBox_Loai = new System.Windows.Forms.ComboBox();
            this.button_Xuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(751, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Phần trăm thi:";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(1105, 78);
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
            this.textBox_TimKiem.Location = new System.Drawing.Point(1124, 32);
            this.textBox_TimKiem.MaxLength = 255;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(167, 26);
            this.textBox_TimKiem.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1040, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tìm kiếm:";
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(607, 123);
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
            this.button_Xoa.Location = new System.Drawing.Point(434, 123);
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
            this.button_Sua.Location = new System.Drawing.Point(256, 123);
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
            this.button_Them.Location = new System.Drawing.Point(80, 123);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(140, 40);
            this.button_Them.TabIndex = 19;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_DiemTrungBinh
            // 
            this.textBox_DiemTrungBinh.Enabled = false;
            this.textBox_DiemTrungBinh.Location = new System.Drawing.Point(630, 78);
            this.textBox_DiemTrungBinh.MaxLength = 255;
            this.textBox_DiemTrungBinh.Name = "textBox_DiemTrungBinh";
            this.textBox_DiemTrungBinh.Size = new System.Drawing.Size(94, 26);
            this.textBox_DiemTrungBinh.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Điểm trung bình:";
            // 
            // textBox_DiemThi
            // 
            this.textBox_DiemThi.Location = new System.Drawing.Point(384, 77);
            this.textBox_DiemThi.MaxLength = 255;
            this.textBox_DiemThi.Name = "textBox_DiemThi";
            this.textBox_DiemThi.Size = new System.Drawing.Size(92, 26);
            this.textBox_DiemThi.TabIndex = 6;
            // 
            // dataGridView_Diem
            // 
            this.dataGridView_Diem.AllowUserToAddRows = false;
            this.dataGridView_Diem.AllowUserToDeleteRows = false;
            this.dataGridView_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Diem.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Diem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Diem.MultiSelect = false;
            this.dataGridView_Diem.Name = "dataGridView_Diem";
            this.dataGridView_Diem.ReadOnly = true;
            this.dataGridView_Diem.RowHeadersVisible = false;
            this.dataGridView_Diem.RowTemplate.Height = 30;
            this.dataGridView_Diem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Diem.Size = new System.Drawing.Size(1370, 96);
            this.dataGridView_Diem.TabIndex = 0;
            this.dataGridView_Diem.TabStop = false;
            this.dataGridView_Diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Diem_CellClick);
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
            this.Column2.FillWeight = 27.21089F;
            this.Column2.HeaderText = "MÃ SINH VIÊN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 27.21089F;
            this.Column3.HeaderText = "MÃ MÔN HỌC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 27.21089F;
            this.Column4.HeaderText = "PHẦN TRĂM LỚP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 27.21089F;
            this.Column5.HeaderText = "PHẦN TRĂM THI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 27.21089F;
            this.Column6.HeaderText = "ĐIỂM LỚP";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 170;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 27.21089F;
            this.Column7.HeaderText = "ĐIỂM THI";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 609.5238F;
            this.Column8.HeaderText = "ĐIÊM TRUNG BÌNH";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 190;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 27.21089F;
            this.Column9.HeaderText = "LOẠI";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Điểm thi:";
            // 
            // textBox_DiemLop
            // 
            this.textBox_DiemLop.Location = new System.Drawing.Point(186, 77);
            this.textBox_DiemLop.MaxLength = 255;
            this.textBox_DiemLop.Name = "textBox_DiemLop";
            this.textBox_DiemLop.Size = new System.Drawing.Size(92, 26);
            this.textBox_DiemLop.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm lớp:";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DiemTableAdapter = null;
            this.tableAdapterManager1.GiaoVienTableAdapter = null;
            this.tableAdapterManager1.KhoaTableAdapter = null;
            this.tableAdapterManager1.LopTableAdapter = null;
            this.tableAdapterManager1.MonHocTableAdapter = null;
            this.tableAdapterManager1.SinhVienTableAdapter = null;
            this.tableAdapterManager1.TaiKhoanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLSV.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phần trăm lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Diem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 96);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Xuat);
            this.panel1.Controls.Add(this.numericUpDown_PhanTramThi);
            this.panel1.Controls.Add(this.numericUpDown_PhanTramLop);
            this.panel1.Controls.Add(this.comboBox_MaMonHoc);
            this.panel1.Controls.Add(this.comboBox_MaSinhVien);
            this.panel1.Controls.Add(this.comboBox_Loai);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_TaiLai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.textBox_DiemTrungBinh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_DiemThi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_DiemLop);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 192);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDown_PhanTramThi
            // 
            this.numericUpDown_PhanTramThi.Location = new System.Drawing.Point(861, 31);
            this.numericUpDown_PhanTramThi.Name = "numericUpDown_PhanTramThi";
            this.numericUpDown_PhanTramThi.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_PhanTramThi.TabIndex = 4;
            // 
            // numericUpDown_PhanTramLop
            // 
            this.numericUpDown_PhanTramLop.Location = new System.Drawing.Point(682, 30);
            this.numericUpDown_PhanTramLop.Name = "numericUpDown_PhanTramLop";
            this.numericUpDown_PhanTramLop.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown_PhanTramLop.TabIndex = 3;
            // 
            // comboBox_MaMonHoc
            // 
            this.comboBox_MaMonHoc.FormattingEnabled = true;
            this.comboBox_MaMonHoc.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_MaMonHoc.Location = new System.Drawing.Point(416, 31);
            this.comboBox_MaMonHoc.Name = "comboBox_MaMonHoc";
            this.comboBox_MaMonHoc.Size = new System.Drawing.Size(128, 27);
            this.comboBox_MaMonHoc.TabIndex = 2;
            // 
            // comboBox_MaSinhVien
            // 
            this.comboBox_MaSinhVien.FormattingEnabled = true;
            this.comboBox_MaSinhVien.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_MaSinhVien.Location = new System.Drawing.Point(158, 29);
            this.comboBox_MaSinhVien.Name = "comboBox_MaSinhVien";
            this.comboBox_MaSinhVien.Size = new System.Drawing.Size(128, 27);
            this.comboBox_MaSinhVien.TabIndex = 1;
            // 
            // comboBox_Loai
            // 
            this.comboBox_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Loai.Enabled = false;
            this.comboBox_Loai.FormattingEnabled = true;
            this.comboBox_Loai.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_Loai.Location = new System.Drawing.Point(801, 77);
            this.comboBox_Loai.Name = "comboBox_Loai";
            this.comboBox_Loai.Size = new System.Drawing.Size(60, 27);
            this.comboBox_Loai.TabIndex = 8;
            // 
            // button_Xuat
            // 
            this.button_Xuat.Location = new System.Drawing.Point(782, 123);
            this.button_Xuat.Name = "button_Xuat";
            this.button_Xuat.Size = new System.Drawing.Size(140, 40);
            this.button_Xuat.TabIndex = 31;
            this.button_Xuat.TabStop = false;
            this.button_Xuat.Text = "Xuất Excel";
            this.button_Xuat.UseVisualStyleBackColor = true;
            this.button_Xuat.Click += new System.EventHandler(this.button_Xuat_Click);
            // 
            // fQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_DiemTrungBinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_DiemThi;
        private System.Windows.Forms.DataGridView dataGridView_Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DiemLop;
        private System.Windows.Forms.Label label7;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_PhanTramThi;
        private System.Windows.Forms.NumericUpDown numericUpDown_PhanTramLop;
        private System.Windows.Forms.ComboBox comboBox_MaMonHoc;
        private System.Windows.Forms.ComboBox comboBox_MaSinhVien;
        private System.Windows.Forms.ComboBox comboBox_Loai;
        private System.Windows.Forms.Button button_Xuat;
    }
}