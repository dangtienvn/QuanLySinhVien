namespace QLSV
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_MonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_TietThucHanh = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TietLyThuyet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SoTinChi = new System.Windows.Forms.NumericUpDown();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new QLSV.DataSetTableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietThucHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_MonHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 96);
            this.panel2.TabIndex = 5;
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
            this.Column8});
            this.dataGridView_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_MonHoc.MultiSelect = false;
            this.dataGridView_MonHoc.Name = "dataGridView_MonHoc";
            this.dataGridView_MonHoc.ReadOnly = true;
            this.dataGridView_MonHoc.RowHeadersVisible = false;
            this.dataGridView_MonHoc.RowTemplate.Height = 30;
            this.dataGridView_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MonHoc.Size = new System.Drawing.Size(1370, 96);
            this.dataGridView_MonHoc.TabIndex = 0;
            this.dataGridView_MonHoc.TabStop = false;
            this.dataGridView_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MonHoc_CellClick);
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
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "SỐ TÍN CHỈ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "TIẾT LÝ THUYẾT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "TIẾT THƯC HÀNH";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_TietThucHanh);
            this.panel1.Controls.Add(this.numericUpDown_TietLyThuyet);
            this.panel1.Controls.Add(this.numericUpDown_SoTinChi);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_TaiLai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_MaMonHoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_TenMonHoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 192);
            this.panel1.TabIndex = 4;
            // 
            // numericUpDown_TietThucHanh
            // 
            this.numericUpDown_TietThucHanh.Location = new System.Drawing.Point(748, 77);
            this.numericUpDown_TietThucHanh.Name = "numericUpDown_TietThucHanh";
            this.numericUpDown_TietThucHanh.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_TietThucHanh.TabIndex = 5;
            // 
            // numericUpDown_TietLyThuyet
            // 
            this.numericUpDown_TietLyThuyet.Location = new System.Drawing.Point(491, 75);
            this.numericUpDown_TietLyThuyet.Name = "numericUpDown_TietLyThuyet";
            this.numericUpDown_TietLyThuyet.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_TietLyThuyet.TabIndex = 4;
            // 
            // numericUpDown_SoTinChi
            // 
            this.numericUpDown_SoTinChi.Location = new System.Drawing.Point(230, 73);
            this.numericUpDown_SoTinChi.Name = "numericUpDown_SoTinChi";
            this.numericUpDown_SoTinChi.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_SoTinChi.TabIndex = 3;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(1052, 75);
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
            this.textBox_TimKiem.Location = new System.Drawing.Point(1055, 30);
            this.textBox_TimKiem.MaxLength = 255;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(167, 26);
            this.textBox_TimKiem.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(971, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tìm kiếm:";
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(679, 123);
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
            this.button_Xoa.Location = new System.Drawing.Point(506, 123);
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
            this.button_Sua.Location = new System.Drawing.Point(328, 123);
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
            this.button_Them.Location = new System.Drawing.Point(152, 123);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(140, 40);
            this.button_Them.TabIndex = 19;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiết thực hành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiết lý thuyết:";
            // 
            // textBox_MaMonHoc
            // 
            this.textBox_MaMonHoc.Location = new System.Drawing.Point(314, 32);
            this.textBox_MaMonHoc.MaxLength = 255;
            this.textBox_MaMonHoc.Name = "textBox_MaMonHoc";
            this.textBox_MaMonHoc.Size = new System.Drawing.Size(126, 26);
            this.textBox_MaMonHoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã môn học:";
            // 
            // textBox_TenMonHoc
            // 
            this.textBox_TenMonHoc.Location = new System.Drawing.Point(601, 32);
            this.textBox_TenMonHoc.MaxLength = 255;
            this.textBox_TenMonHoc.Name = "textBox_TenMonHoc";
            this.textBox_TenMonHoc.Size = new System.Drawing.Size(140, 26);
            this.textBox_TenMonHoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sô tín chỉ:";
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
            // fQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQuanLyMonHoc_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MonHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietThucHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TietLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTinChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_MonHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.NumericUpDown numericUpDown_TietThucHanh;
        private System.Windows.Forms.NumericUpDown numericUpDown_TietLyThuyet;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoTinChi;
    }
}