namespace QuanLySinhVien.GUI
{
    partial class fQuenMatKhau
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
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(142, 121);
            this.textBox_MatKhauMoi.MaxLength = 255;
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(119, 26);
            this.textBox_MatKhauMoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật khẩu mới:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MatKhauCu
            // 
            this.textBox_MatKhauCu.Location = new System.Drawing.Point(142, 68);
            this.textBox_MatKhauCu.MaxLength = 255;
            this.textBox_MatKhauCu.Name = "textBox_MatKhauCu";
            this.textBox_MatKhauCu.Size = new System.Drawing.Size(119, 26);
            this.textBox_MatKhauCu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu cũ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Location = new System.Drawing.Point(92, 164);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(85, 29);
            this.button_CapNhat.TabIndex = 2;
            this.button_CapNhat.TabStop = false;
            this.button_CapNhat.Text = "Cập Nhật";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            // 
            // fQuenMatKhau
            // 
            this.AcceptButton = this.button_CapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MatKhauCu);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuenMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mât Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MatKhauCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CapNhat;
    }
}