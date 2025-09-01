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

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textBox_TenTaiKhoan.Text;
                string mk = textBox_MatKhau.Text;
                string sql = "SELECT * from DangNhap Where TenTaiKhoan = '" + tk + "'and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (textBox_MatKhau.Text == "" || textBox_TenTaiKhoan.Text == "")
                {
                    MessageBox.Show("Bạn điền tài khoản và mật khẩu để đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (DataReader.Read() == true)
                {
                    this.Hide();
                    TrangChu Home = new TrangChu();
                    Home.ShowDialog();
                    Home= null;
                    Home.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng? Vui lòng đăng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_MatKhau.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex, "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn Có Thoát Không", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
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
    }
}
