namespace QLSV
{
    partial class fQuanLyLop
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
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_TenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_MaKHoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.AllowUserToAddRows = false;
            this.dataGridView_Lop.AllowUserToDeleteRows = false;
            this.dataGridView_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lop.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Lop.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Lop.MultiSelect = false;
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.ReadOnly = true;
            this.dataGridView_Lop.RowHeadersVisible = false;
            this.dataGridView_Lop.RowTemplate.Height = 30;
            this.dataGridView_Lop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lop.Size = new System.Drawing.Size(1370, 182);
            this.dataGridView_Lop.TabIndex = 1;
            this.dataGridView_Lop.TabStop = false;
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
            this.Column2.HeaderText = "MÃ LỚP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "TÊN LỚP";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "SỐ LƯỢNG";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "MÃ KHOA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Lop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 182);
            this.panel2.TabIndex = 5;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(1171, 84);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(109, 37);
            this.button_TimKiem.TabIndex = 25;
            this.button_TimKiem.TabStop = false;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(1190, 38);
            this.textBox_TimKiem.MaxLength = 255;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(167, 26);
            this.textBox_TimKiem.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1106, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tìm kiếm:";
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(692, 82);
            this.button_TaiLai.Name = "button_TaiLai";
            this.button_TaiLai.Size = new System.Drawing.Size(140, 40);
            this.button_TaiLai.TabIndex = 22;
            this.button_TaiLai.TabStop = false;
            this.button_TaiLai.Text = "Tải Lại";
            this.button_TaiLai.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(519, 82);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(140, 40);
            this.button_Xoa.TabIndex = 21;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(341, 82);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(140, 40);
            this.button_Sua.TabIndex = 20;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(165, 82);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(140, 40);
            this.button_Them.TabIndex = 19;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // textBox_TenLop
            // 
            this.textBox_TenLop.Location = new System.Drawing.Point(414, 33);
            this.textBox_TenLop.MaxLength = 255;
            this.textBox_TenLop.Name = "textBox_TenLop";
            this.textBox_TenLop.Size = new System.Drawing.Size(165, 26);
            this.textBox_TenLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Só lượng:";
            // 
            // textBox_MaLop
            // 
            this.textBox_MaLop.Location = new System.Drawing.Point(243, 31);
            this.textBox_MaLop.MaxLength = 255;
            this.textBox_MaLop.Name = "textBox_MaLop";
            this.textBox_MaLop.Size = new System.Drawing.Size(71, 26);
            this.textBox_MaLop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã lớp:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(100, 31);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(41, 26);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_MaKHoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown_SoLuong);
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_TaiLai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.textBox_TenLop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_MaLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 327);
            this.panel1.TabIndex = 4;
            // 
            // comboBox_MaKHoa
            // 
            this.comboBox_MaKHoa.FormattingEnabled = true;
            this.comboBox_MaKHoa.Location = new System.Drawing.Point(874, 34);
            this.comboBox_MaKHoa.Name = "comboBox_MaKHoa";
            this.comboBox_MaKHoa.Size = new System.Drawing.Size(121, 27);
            this.comboBox_MaKHoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã khoa:";
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(689, 34);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(62, 26);
            this.numericUpDown_SoLuong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên lớp:";
            // 
            // fQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_TenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.ComboBox comboBox_MaKHoa;
    }
}