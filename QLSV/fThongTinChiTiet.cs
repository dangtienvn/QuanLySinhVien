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
    public partial class fThongTinChiTiet : Form
    {
        public fThongTinChiTiet()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        public string TenDangNhapHienTai { get; set; }

        private void fThongTinChiTiet_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);

            // Khi load form => lấy thông tin tài khoản hiện tại
            if (!string.IsNullOrEmpty(TenDangNhapHienTai))
            {
                HienThiThongTin();
            }
        }

        void HienThiThongTin()
        {
            string Lenh = "SELECT TenDangNhap, LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@TenDangNhap", TenDangNhapHienTai);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            if (Doc.Read())
            {
                textBox_TenDangNhap.Text = Doc["TenDangNhap"].ToString();
                textBox_LoaiTaiKhoan.Text = Doc["LoaiTaiKhoan"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản: " + TenDangNhapHienTai,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            KetNoi.Close();
        }


    }
}
