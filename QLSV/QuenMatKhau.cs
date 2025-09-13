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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void button_LLMatKhau_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=Dell\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
            
            string tk = textBox_TenTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();

                // Lấy mật khẩu theo tên tài khoản
                string sql = "SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap=@tk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", tk);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Hiển thị mật khẩu tìm được
                    label_KetQua.Text = "Mật khẩu: " + result.ToString();
                }
                else
                {
                    label_KetQua.Text = "Không tìm thấy tài khoản!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex, "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form 
            DangNhap f = new DangNhap();
            f.ShowDialog();
            this.Close(); // Đóng hẳn 
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Tắt toàn bộ chương trình khi nhấn X
        }
    }
}
