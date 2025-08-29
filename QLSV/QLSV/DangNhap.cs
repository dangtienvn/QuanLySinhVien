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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textBoxTK.Text;
                string mk = textBoxMK.Text;
                string sql = "SELECT * from DangNhap Where TenTaiKhoan = '" + tk + "'and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (textBoxMK.Text == "" || textBoxTK.Text == "")
                {
                    MessageBox.Show("Bạn Điền Tài Khoản Và Mật Khẩu Để Đăng Nhập","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else if (DataReader.Read() == true)
                {
                    this.Hide();
                    TrangChu TC = new TrangChu();
                    TC.ShowDialog();
                    TC = null;
                    textBoxMK.Text = "";
                    this.Show();
                }
                else
                { 
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng? Vui Lòng Đăng Nhập Lại","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBoxMK.Text = "";
                }
             }
             catch (Exception ex)
             {
                MessageBox.Show("Lỗi Kết Nối"+ ex ,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void checkBoxHMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHMK.Checked)
            {
                textBoxMK.UseSystemPasswordChar = false; // Hiện Mật Khẩu
            }
            else 
            {
                textBoxMK.UseSystemPasswordChar = true; // Ẩn Mật Khẩu
            }
        }
    }
}