namespace QuanLySinhVien.GUI
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
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_TenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MaKhoa = new System.Windows.Forms.TextBox();
            this.dataGridView_Khoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khoa)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LamMoi.Location = new System.Drawing.Point(925, 56);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(120, 26);
            this.button_LamMoi.TabIndex = 31;
            this.button_LamMoi.TabStop = false;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(758, 56);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(120, 26);
            this.button_Xoa.TabIndex = 30;
            this.button_Xoa.TabStop = false;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(592, 56);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(120, 26);
            this.button_Sua.TabIndex = 29;
            this.button_Sua.TabStop = false;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(422, 56);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(120, 26);
            this.button_Them.TabIndex = 28;
            this.button_Them.TabStop = false;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // textBox_TenKhoa
            // 
            this.textBox_TenKhoa.Location = new System.Drawing.Point(837, 19);
            this.textBox_TenKhoa.MaxLength = 255;
            this.textBox_TenKhoa.Name = "textBox_TenKhoa";
            this.textBox_TenKhoa.Size = new System.Drawing.Size(325, 26);
            this.textBox_TenKhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(754, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khoa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MaKhoa
            // 
            this.textBox_MaKhoa.Location = new System.Drawing.Point(469, 19);
            this.textBox_MaKhoa.MaxLength = 255;
            this.textBox_MaKhoa.Name = "textBox_MaKhoa";
            this.textBox_MaKhoa.Size = new System.Drawing.Size(205, 26);
            this.textBox_MaKhoa.TabIndex = 1;
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
            this.dataGridView_Khoa.MultiSelect = false;
            this.dataGridView_Khoa.Name = "dataGridView_Khoa";
            this.dataGridView_Khoa.ReadOnly = true;
            this.dataGridView_Khoa.RowHeadersVisible = false;
            this.dataGridView_Khoa.RowTemplate.Height = 30;
            this.dataGridView_Khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Khoa.Size = new System.Drawing.Size(1370, 386);
            this.dataGridView_Khoa.TabIndex = 4;
            this.dataGridView_Khoa.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã khoa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(247, 19);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(57, 26);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Khoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 386);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_LamMoi);
            this.panel1.Controls.Add(this.button_Xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_Them);
            this.panel1.Controls.Add(this.textBox_TenKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_MaKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 100);
            this.panel1.TabIndex = 2;
            // 
            // fQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Khoa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_LamMoi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_TenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MaKhoa;
        private System.Windows.Forms.DataGridView dataGridView_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}