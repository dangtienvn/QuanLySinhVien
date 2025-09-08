namespace QuanLySinhVien.GUI
{
    partial class fThongTinChiTiet
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
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Enabled = false;
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(142, 62);
            this.textBox_TenDangNhap.MaxLength = 255;
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(119, 26);
            this.textBox_TenDangNhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Enabled = false;
            this.textBox_MatKhau.Location = new System.Drawing.Point(142, 115);
            this.textBox_MatKhau.MaxLength = 255;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(119, 26);
            this.textBox_MatKhau.TabIndex = 5;
            this.textBox_MatKhau.Text = "************";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_LoaiTaiKhoan
            // 
            this.textBox_LoaiTaiKhoan.Enabled = false;
            this.textBox_LoaiTaiKhoan.Location = new System.Drawing.Point(142, 172);
            this.textBox_LoaiTaiKhoan.MaxLength = 255;
            this.textBox_LoaiTaiKhoan.Name = "textBox_LoaiTaiKhoan";
            this.textBox_LoaiTaiKhoan.Size = new System.Drawing.Size(119, 26);
            this.textBox_LoaiTaiKhoan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại tài khoản:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_LoaiTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongTinChiTiet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chi Tiết";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LoaiTaiKhoan;
        private System.Windows.Forms.Label label3;
    }
}