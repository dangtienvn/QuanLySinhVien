namespace QLSV
{
    partial class fQuanLyKhoa
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
            this.dataGridView_Khoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_TaiLai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_TenKhoa = new System.Windows.Forms.TextBox();
            this.textBox_MaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khoa)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Khoa
            // 
            this.dataGridView_Khoa.AllowUserToAddRows = false;
            this.dataGridView_Khoa.AllowUserToDeleteRows = false;
            this.dataGridView_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_Khoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Khoa.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Khoa.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Khoa.MultiSelect = false;
            this.dataGridView_Khoa.Name = "dataGridView_Khoa";
            this.dataGridView_Khoa.ReadOnly = true;
            this.dataGridView_Khoa.RowHeadersVisible = false;
            this.dataGridView_Khoa.RowTemplate.Height = 30;
            this.dataGridView_Khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Khoa.Size = new System.Drawing.Size(1370, 230);
            this.dataGridView_Khoa.TabIndex = 1;
            this.dataGridView_Khoa.TabStop = false;
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
            this.Column2.HeaderText = "MÃ KHOA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "TÊN KHOA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Khoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 230);
            this.panel2.TabIndex = 5;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(1102, 84);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(109, 37);
            this.button_TimKiem.TabIndex = 25;
            this.button_TimKiem.TabStop = false;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(1102, 40);
            this.textBox_TimKiem.MaxLength = 255;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(167, 26);
            this.textBox_TimKiem.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1018, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tìm kiếm:";
            // 
            // button_TaiLai
            // 
            this.button_TaiLai.Location = new System.Drawing.Point(705, 89);
            this.button_TaiLai.Name = "button_TaiLai";
            this.button_TaiLai.Size = new System.Drawing.Size(140, 40);
            this.button_TaiLai.TabIndex = 22;
            this.button_TaiLai.TabStop = false;
            this.button_TaiLai.Text = "Tải Lại";
            this.button_TaiLai.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(532, 89);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(140, 40);
            this.button_Xoa.TabIndex = 21;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(354, 89);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(140, 40);
            this.button_Sua.TabIndex = 20;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(178, 89);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(140, 40);
            this.button_Them.TabIndex = 19;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // textBox_TenKhoa
            // 
            this.textBox_TenKhoa.Location = new System.Drawing.Point(680, 40);
            this.textBox_TenKhoa.MaxLength = 255;
            this.textBox_TenKhoa.Name = "textBox_TenKhoa";
            this.textBox_TenKhoa.Size = new System.Drawing.Size(165, 26);
            this.textBox_TenKhoa.TabIndex = 2;
            // 
            // textBox_MaKhoa
            // 
            this.textBox_MaKhoa.Location = new System.Drawing.Point(382, 41);
            this.textBox_MaKhoa.MaxLength = 255;
            this.textBox_MaKhoa.Name = "textBox_MaKhoa";
            this.textBox_MaKhoa.Size = new System.Drawing.Size(171, 26);
            this.textBox_MaKhoa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khoa:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(213, 41);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(41, 26);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_TimKiem);
            this.panel1.Controls.Add(this.textBox_TimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_TaiLai);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.textBox_TenKhoa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_MaKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 381);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên khoa:";
            // 
            // fQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khoa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_TaiLai;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_TenKhoa;
        private System.Windows.Forms.TextBox textBox_MaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;

    }
}