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
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThi();
        }

        void HienThi()
        {
            dataGridView_TaiKhoan.Rows.Clear();
            string Lenh = @"SELECT Id, TenDangNhap, MatKhau, LoaiTaiKhoan FROM TaiKhoan";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_TaiKhoan.Rows.Add();
                dataGridView_TaiKhoan.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_TaiKhoan.Rows[i].Cells[1].Value = Doc["TenDangNhap"];
                dataGridView_TaiKhoan.Rows[i].Cells[2].Value = Doc["MatKhau"];
                dataGridView_TaiKhoan.Rows[i].Cells[3].Value = Doc["LoaiTaiKhoan"];
                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string Lenh = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan)
                            VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@TenDangNhap", textBox_TenDangNhap.Text);
            ThucHien.Parameters.AddWithValue("@MatKhau", textBox_MatKhau.Text);
            ThucHien.Parameters.AddWithValue("@LoaiTaiKhoan", comboBox_LoaiTaiKhoan.Text);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_TaiKhoan.CurrentRow == null) return;

            string Lenh = @"UPDATE TaiKhoan
                            SET TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, LoaiTaiKhoan=@LoaiTaiKhoan
                            WHERE Id=@Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@TenDangNhap", textBox_TenDangNhap.Text);
            ThucHien.Parameters.AddWithValue("@MatKhau", textBox_MatKhau.Text);
            ThucHien.Parameters.AddWithValue("@LoaiTaiKhoan", comboBox_LoaiTaiKhoan.Text);
            ThucHien.Parameters.AddWithValue("@Id", dataGridView_TaiKhoan.CurrentRow.Cells[0].Value);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_TaiKhoan.CurrentRow == null) return;

            DialogResult d = MessageBox.Show("Xóa tài khoản: " + dataGridView_TaiKhoan.CurrentRow.Cells[1].Value,
                                             "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                string Lenh = @"DELETE FROM TaiKhoan WHERE Id=@Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.AddWithValue("@Id", dataGridView_TaiKhoan.CurrentRow.Cells[0].Value);

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                HienThi();
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = textBox_TimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                HienThi();
                return;
            }

            dataGridView_TaiKhoan.Rows.Clear();
            string Lenh = @"SELECT Id, TenDangNhap, MatKhau, LoaiTaiKhoan 
                            FROM TaiKhoan
                            WHERE TenDangNhap LIKE @keyword OR LoaiTaiKhoan LIKE @keyword";

            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_TaiKhoan.Rows.Add();
                dataGridView_TaiKhoan.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_TaiKhoan.Rows[i].Cells[1].Value = Doc["TenDangNhap"];
                dataGridView_TaiKhoan.Rows[i].Cells[2].Value = Doc["MatKhau"];
                dataGridView_TaiKhoan.Rows[i].Cells[3].Value = Doc["LoaiTaiKhoan"];
                i++;
            }
            KetNoi.Close();
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            textBox_TenDangNhap.Text = "";
            textBox_MatKhau.Text = "";
            comboBox_LoaiTaiKhoan.SelectedIndex = -1;
            textBox_TimKiem.Text = "";
            HienThi();
        }

        private void dataGridView_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (dataGridView_TaiKhoan.CurrentRow == null) return;

            textBox_TenDangNhap.Text = dataGridView_TaiKhoan.CurrentRow.Cells[1].Value.ToString();
            textBox_MatKhau.Text = dataGridView_TaiKhoan.CurrentRow.Cells[2].Value.ToString();
            comboBox_LoaiTaiKhoan.Text = dataGridView_TaiKhoan.CurrentRow.Cells[3].Value.ToString();
        }

    }
}
