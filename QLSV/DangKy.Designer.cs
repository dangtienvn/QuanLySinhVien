namespace QLSV
{
    partial class DangKy
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
            this.checkBox_HMK = new System.Windows.Forms.CheckBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_XNMatKhau = new System.Windows.Forms.TextBox();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_HMK
            // 
            this.checkBox_HMK.AutoSize = true;
            this.checkBox_HMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_HMK.Location = new System.Drawing.Point(221, 296);
            this.checkBox_HMK.Name = "checkBox_HMK";
            this.checkBox_HMK.Size = new System.Drawing.Size(126, 17);
            this.checkBox_HMK.TabIndex = 20;
            this.checkBox_HMK.Text = "Hiện thị mật khẩu";
            this.checkBox_HMK.UseVisualStyleBackColor = true;
            this.checkBox_HMK.CheckedChanged += new System.EventHandler(this.checkBox_HMK_CheckedChanged);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.Location = new System.Drawing.Point(181, 212);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(166, 30);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(181, 165);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(166, 30);
            this.textBox_TenTaiKhoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.login_2385_256;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_XNMatKhau
            // 
            this.textBox_XNMatKhau.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_XNMatKhau.Location = new System.Drawing.Point(181, 258);
            this.textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            this.textBox_XNMatKhau.Size = new System.Drawing.Size(166, 30);
            this.textBox_XNMatKhau.TabIndex = 2;
            this.textBox_XNMatKhau.UseSystemPasswordChar = true;
            // 
            // button_DangKy
            // 
            this.button_DangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKy.Location = new System.Drawing.Point(141, 320);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(87, 29);
            this.button_DangKy.TabIndex = 3;
            this.button_DangKy.Text = "Đăng Ký";
            this.button_DangKy.UseVisualStyleBackColor = true;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mật khảu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // DangKy
            // 
            this.AcceptButton = this.button_DangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.textBox_XNMatKhau);
            this.Controls.Add(this.checkBox_HMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_HMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_XNMatKhau;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}