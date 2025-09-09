namespace QuanLySinhVien.GUI
{
    partial class fQuanLyMonHoc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown_SoTinChi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TietLyThuyet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_TietThucHanh = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietThucHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_MonHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 187);
            this.panel1.TabIndex = 5;
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
            this.Column6});
            this.dataGridView_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MonHoc.MultiSelect = false;
            this.dataGridView_MonHoc.Name = "dataGridView_MonHoc";
            this.dataGridView_MonHoc.ReadOnly = true;
            this.dataGridView_MonHoc.RowHeadersVisible = false;
            this.dataGridView_MonHoc.RowTemplate.Height = 30;
            this.dataGridView_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MonHoc.Size = new System.Drawing.Size(1370, 187);
            this.dataGridView_MonHoc.TabIndex = 4;
            this.dataGridView_MonHoc.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown_TietThucHanh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericUpDown_TietLyThuyet);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDown_SoTinChi);
            this.panel2.Controls.Add(this.button_TaiLai);
            this.panel2.Controls.Add(this.button_Xoa);
            this.panel2.Controls.Add(this.button_Sua);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_TenMonHoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_MaMonHoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 127);
            this.panel2.TabIndex = 4;
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(950, 87);
            this.button_TaiLai.Name = "button_TaiLai";
            this.button_TaiLai.Size = new System.Drawing.Size(109, 26);
            this.button_TaiLai.TabIndex = 27;
            this.button_TaiLai.TabStop = false;
            this.button_TaiLai.Text = "Tải lại";
            this.button_TaiLai.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(801, 87);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(109, 26);
            this.button_Xoa.TabIndex = 26;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(654, 87);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(109, 26);
            this.button_Sua.TabIndex = 25;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(517, 87);
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
            this.label4.Location = new System.Drawing.Point(311, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tín chỉ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_TenMonHoc
            // 
            this.textBox_TenMonHoc.Location = new System.Drawing.Point(765, 13);
            this.textBox_TenMonHoc.MaxLength = 255;
            this.textBox_TenMonHoc.Name = "textBox_TenMonHoc";
            this.textBox_TenMonHoc.Size = new System.Drawing.Size(294, 26);
            this.textBox_TenMonHoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên môn học:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaMonHoc
            // 
            this.textBox_MaMonHoc.Location = new System.Drawing.Point(525, 13);
            this.textBox_MaMonHoc.MaxLength = 255;
            this.textBox_MaMonHoc.Name = "textBox_MaMonHoc";
            this.textBox_MaMonHoc.Size = new System.Drawing.Size(100, 26);
            this.textBox_MaMonHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã môn học:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(349, 13);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(37, 26);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "TÊN MÔN HỌC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 45.91837F;
            this.Column4.HeaderText = "SỐ TÍN CHỈ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 45.91837F;
            this.Column5.HeaderText = "TIẾT LÝ THUYẾT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 45.91837F;
            this.Column6.HeaderText = "TIẾT THỰC HÀNH";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 170;
            // 
            // numericUpDown_SoTinChi
            // 
            this.numericUpDown_SoTinChi.Location = new System.Drawing.Point(392, 49);
            this.numericUpDown_SoTinChi.Name = "numericUpDown_SoTinChi";
            this.numericUpDown_SoTinChi.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_SoTinChi.TabIndex = 3;
            // 
            // numericUpDown_TietLyThuyet
            // 
            this.numericUpDown_TietLyThuyet.Location = new System.Drawing.Point(660, 49);
            this.numericUpDown_TietLyThuyet.Name = "numericUpDown_TietLyThuyet";
            this.numericUpDown_TietLyThuyet.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown_TietLyThuyet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tiết lý thuyết:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_TietThucHanh
            // 
            this.numericUpDown_TietThucHanh.Location = new System.Drawing.Point(939, 50);
            this.numericUpDown_TietThucHanh.Name = "numericUpDown_TietThucHanh";
            this.numericUpDown_TietThucHanh.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_TietThucHanh.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tiết thực hành:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fQuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietThucHanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_MonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MaMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown numericUpDown_TietThucHanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_TietLyThuyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoTinChi;
    }
}