namespace QLSV
{
    partial class QuenMatKhau
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
            this.button_LLMatKhau = new System.Windows.Forms.Button();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LLMatKhau
            // 
            this.button_LLMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LLMatKhau.Location = new System.Drawing.Point(107, 295);
            this.button_LLMatKhau.Name = "button_LLMatKhau";
            this.button_LLMatKhau.Size = new System.Drawing.Size(142, 29);
            this.button_LLMatKhau.TabIndex = 1;
            this.button_LLMatKhau.Text = "Lấy Lại Mật Khẩu";
            this.button_LLMatKhau.UseVisualStyleBackColor = true;
            this.button_LLMatKhau.Click += new System.EventHandler(this.button_LLMatKhau_Click);
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(38, 245);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(69, 17);
            this.label_KetQua.TabIndex = 36;
            this.label_KetQua.Text = "Kết Quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.login_2385_256;
            this.pictureBox1.Location = new System.Drawing.Point(93, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(181, 191);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(166, 30);
            this.textBox_TenTaiKhoan.TabIndex = 0;
            // 
            // QuenMatKhau
            // 
            this.AcceptButton = this.button_LLMatKhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_LLMatKhau);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LLMatKhau;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;

    }
}