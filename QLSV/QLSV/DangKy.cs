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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void checkBox_HMK_CheckedChanged(object sender, EventArgs e)
        {
               if (checkBox_HMK.Checked)
            {
                textBox_MatKhau.UseSystemPasswordChar = false; // Hiện Mật Khẩu
                textBox_XNMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_MatKhau.UseSystemPasswordChar = true; // Ẩn Mật Khẩu
                textBox_XNMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            string tk = textBox_TenTaiKhoan.Text.Trim();
            string mk = textBox_MatKhau.Text;
            string xnmk = textBox_XNMatKhau.Text;

            // Kiểm tra dữ liệu trước khi insert
            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mk != xnmk)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trùng tên tài khoản
                    string checkSql = "SELECT COUNT(*) FROM DangNhap WHERE TenTaiKhoan=@TenTaiKhoan";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@TenTaiKhoan", tk);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm tài khoản mới
                    string sql = "INSERT INTO DangNhap (TenTaiKhoan, MatKhau)VALUES(@TenTaiKhoan,@MatKhau)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", tk);
                    cmd.Parameters.AddWithValue("@MatKhau", mk);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối" + ex, "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_TroLai_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn trở lại không", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
