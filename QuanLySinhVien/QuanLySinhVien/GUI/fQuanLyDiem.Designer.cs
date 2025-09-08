namespace QuanLySinhVien.GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_MonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_Loai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_DiemTrungBinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DiemThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_DiemLop = new System.Windows.Forms.TextBox();
            this.comboBox_MaMonHoc = new System.Windows.Forms.ComboBox();
            this.comboBox_MaSinhVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_PhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_PhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_MonHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 164);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView_MonHoc
            // 
            this.dataGridView_MonHoc.AllowUserToAddRows = false;
            this.dataGridView_MonHoc.AllowUserToDeleteRows = false;
            this.dataGridView_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MonHoc.MultiSelect = false;
            this.dataGridView_MonHoc.Name = "dataGridView_MonHoc";
            this.dataGridView_MonHoc.ReadOnly = true;
            this.dataGridView_MonHoc.RowHeadersVisible = false;
            this.dataGridView_MonHoc.RowTemplate.Height = 30;
            this.dataGridView_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MonHoc.Size = new System.Drawing.Size(1370, 164);
            this.dataGridView_MonHoc.TabIndex = 4;
            this.dataGridView_MonHoc.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 532.6531F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 45.91837F;
            this.Column2.HeaderText = "MÃ SINH VIÊN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MÃ MÔN HỌC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 45.91837F;
            this.Column4.HeaderText = "PHẦN TRĂM LỚP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 45.91837F;
            this.Column5.HeaderText = "PHẦN TRĂM THI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 45.91837F;
            this.Column6.HeaderText = "ĐIỂM LỚP";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ĐIỂM THI";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ĐIỂM TRUNG BÌNH";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "LOẠI";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_Loai);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox_DiemTrungBinh);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_DiemThi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_DiemLop);
            this.panel2.Controls.Add(this.comboBox_MaMonHoc);
            this.panel2.Controls.Add(this.comboBox_MaSinhVien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericUpDown_PhanTramThi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDown_PhanTramLop);
            this.panel2.Controls.Add(this.button_TaiLai);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Sua);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 127);
            this.panel2.TabIndex = 6;
            // 
            // comboBox_Loai
            // 
            this.comboBox_Loai.FormattingEnabled = true;
            this.comboBox_Loai.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_Loai.Location = new System.Drawing.Point(1129, 54);
            this.comboBox_Loai.Name = "comboBox_Loai";
            this.comboBox_Loai.Size = new System.Drawing.Size(100, 27);
            this.comboBox_Loai.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1079, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Loại:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DiemTrungBinh
            // 
            this.textBox_DiemTrungBinh.Location = new System.Drawing.Point(824, 52);
            this.textBox_DiemTrungBinh.Name = "textBox_DiemTrungBinh";
            this.textBox_DiemTrungBinh.Size = new System.Drawing.Size(154, 26);
            this.textBox_DiemTrungBinh.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(697, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Điểm trung bình:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DiemThi
            // 
            this.textBox_DiemThi.Location = new System.Drawing.Point(494, 51);
            this.textBox_DiemThi.Name = "textBox_DiemThi";
            this.textBox_DiemThi.Size = new System.Drawing.Size(119, 26);
            this.textBox_DiemThi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Điểm thi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_DiemLop
            // 
            this.textBox_DiemLop.Location = new System.Drawing.Point(222, 55);
            this.textBox_DiemLop.Name = "textBox_DiemLop";
            this.textBox_DiemLop.Size = new System.Drawing.Size(100, 26);
            this.textBox_DiemLop.TabIndex = 5;
            // 
            // comboBox_MaMonHoc
            // 
            this.comboBox_MaMonHoc.FormattingEnabled = true;
            this.comboBox_MaMonHoc.Location = new System.Drawing.Point(593, 13);
            this.comboBox_MaMonHoc.Name = "comboBox_MaMonHoc";
            this.comboBox_MaMonHoc.Size = new System.Drawing.Size(121, 27);
            this.comboBox_MaMonHoc.TabIndex = 2;
            // 
            // comboBox_MaSinhVien
            // 
            this.comboBox_MaSinhVien.FormattingEnabled = true;
            this.comboBox_MaSinhVien.Location = new System.Drawing.Point(347, 13);
            this.comboBox_MaSinhVien.Name = "comboBox_MaSinhVien";
            this.comboBox_MaSinhVien.Size = new System.Drawing.Size(121, 27);
            this.comboBox_MaSinhVien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Điểm lớp:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_PhanTramThi
            // 
            this.numericUpDown_PhanTramThi.Location = new System.Drawing.Point(1122, 13);
            this.numericUpDown_PhanTramThi.Name = "numericUpDown_PhanTramThi";
            this.numericUpDown_PhanTramThi.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown_PhanTramThi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1013, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phần trăm thi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_PhanTramLop
            // 
            this.numericUpDown_PhanTramLop.Location = new System.Drawing.Point(858, 12);
            this.numericUpDown_PhanTramLop.Name = "numericUpDown_PhanTramLop";
            this.numericUpDown_PhanTramLop.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_PhanTramLop.TabIndex = 3;
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(863, 88);
            this.button_TaiLai.Name = "button_TaiLai";
            this.button_TaiLai.Size = new System.Drawing.Size(109, 26);
            this.button_TaiLai.TabIndex = 27;
            this.button_TaiLai.TabStop = false;
            this.button_TaiLai.Text = "Tải lại";
            this.button_TaiLai.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(714, 88);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(109, 26);
            this.button_Xoa.TabIndex = 26;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(567, 88);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(109, 26);
            this.button_Sua.TabIndex = 25;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(430, 88);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(109, 26);
            this.button_Them.TabIndex = 24;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phần trăm lớp:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(179, 13);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(37, 26);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PhanTramLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_MonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_PhanTramThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_PhanTramLop;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox textBox_DiemThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_DiemLop;
        private System.Windows.Forms.ComboBox comboBox_MaMonHoc;
        private System.Windows.Forms.ComboBox comboBox_MaSinhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_DiemTrungBinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Loai;
    }
}