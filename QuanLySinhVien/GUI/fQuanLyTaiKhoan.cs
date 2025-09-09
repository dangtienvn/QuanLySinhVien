using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.BLL;

namespace QuanLySinhVien.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string tendangnhap = textBox_TenDangNhap.Text.Trim();
            string matkhau = textBox_MatKhau.Text.Trim();
            string loaitk = comboBox_LoaiTaiKhoan.SelectedItem.ToString();

            if(tendangnhap.Length > 0 && matkhau.Length >= 6 && loaitk.Length > 0)
            {
                if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaitk) == true)
                    button_LamMoi.PerformClick(); // load lại dữ liệu
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            dataGridView_SinhVien.DataSource = BLL.BLL_TaiKhoan.Instance.DanhSach();
        }
    }
}
