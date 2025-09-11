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
    public partial class fQuenMatKhau : Form
    {
        public fQuenMatKhau()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";

        // Giữ lại tên đăng nhập của user đang đăng nhập
        public string TenDangNhapHienTai { get; set; }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            string matKhauCu = textBox_MatKhauCu.Text.Trim();
            string matKhauMoi = textBox_MatKhauMoi.Text.Trim();

            if (matKhauCu == "" || matKhauMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đủ mật khẩu cũ và mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Kiểm tra mật khẩu cũ có đúng không
                string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@tk AND MatKhau=@mk";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@tk", TenDangNhapHienTai);
                cmdCheck.Parameters.AddWithValue("@mk", matKhauCu);

                int count = (int)cmdCheck.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật mật khẩu mới
                string sqlUpdate = "UPDATE TaiKhoan SET MatKhau=@mkmoi WHERE TenDangNhap=@tk";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@mkmoi", matKhauMoi);
                cmdUpdate.Parameters.AddWithValue("@tk", TenDangNhapHienTai);

                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // đóng form sau khi đổi mật khẩu
            }
        }
    }
}
