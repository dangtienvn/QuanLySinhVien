using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string tk = textBox_TenTaiKhoan.Text.Trim();
                    string mk = textBox_MatKhau.Text.Trim();

                    if (tk == "" || mk == "")
                    {
                        MessageBox.Show("Bạn phải điền tài khoản và mật khẩu!", "Thông Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@tk AND MatKhau=@mk";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Đúng tài khoản
                        this.Hide();
                        TrangChu home = new TrangChu();
                        home.TenDangNhapHienTai = tk; // ✅ truyền sang TrangChu
                        home.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_MatKhau.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn thoát không", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox_HMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HMK.Checked)
            {
                textBox_MatKhau.UseSystemPasswordChar = false; // Hiện Mật Khẩu
            }
            else
            {
                textBox_MatKhau.UseSystemPasswordChar = true; // Ẩn Mật Khẩu
            }

        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // ẩn form đăng nhập
            DangKy DK = new DangKy();
            DK.ShowDialog();
            this.Show(); // hiện lại khi đóng form đăng ký
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau QMK = new QuenMatKhau();
            QMK.ShowDialog();
            this.Show(); // hiện lại khi đóng form quen MK
        }
    }
}
