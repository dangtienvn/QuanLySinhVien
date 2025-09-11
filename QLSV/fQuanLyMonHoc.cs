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
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        // Kết nối CSDL
        string Nguon = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        string Lenh = "";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThi();
        }

        private void HienThi()
        {
            dataGridView_MonHoc.Rows.Clear();
            Lenh = @"SELECT Id, MaMH, TenMH, SoTC, TietLT, TietTH FROM MonHoc";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_MonHoc.Rows.Add();
                dataGridView_MonHoc.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_MonHoc.Rows[i].Cells[1].Value = Doc["MaMH"];
                dataGridView_MonHoc.Rows[i].Cells[2].Value = Doc["TenMH"];
                dataGridView_MonHoc.Rows[i].Cells[3].Value = Doc["SoTC"];
                dataGridView_MonHoc.Rows[i].Cells[4].Value = Doc["TietLT"];
                dataGridView_MonHoc.Rows[i].Cells[5].Value = Doc["TietTH"];
                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO MonHoc (MaMH, TenMH, SoTC, TietLT, TietTH)
                     VALUES (@MaMH, @TenMH, @SoTC, @TietLT, @TietTH)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@MaMH", textBox_MaMonHoc.Text);
            ThucHien.Parameters.AddWithValue("@TenMH", textBox_TenMonHoc.Text);
            ThucHien.Parameters.AddWithValue("@SoTC", numericUpDown_SoTinChi.Value);
            ThucHien.Parameters.AddWithValue("@TietLT", numericUpDown_TietLyThuyet.Value);
            ThucHien.Parameters.AddWithValue("@TietTH", numericUpDown_TietThucHanh.Value);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_MonHoc.CurrentRow == null) return;

            Lenh = @"UPDATE MonHoc 
                     SET MaMH=@MaMH, TenMH=@TenMH, SoTC=@SoTC, TietLT=@TietLT, TietTH=@TietTH
                     WHERE Id=@Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@MaMH", textBox_MaMonHoc.Text);
            ThucHien.Parameters.AddWithValue("@TenMH", textBox_TenMonHoc.Text);
            ThucHien.Parameters.AddWithValue("@SoTC", numericUpDown_SoTinChi.Value);
            ThucHien.Parameters.AddWithValue("@TietLT", numericUpDown_TietLyThuyet.Value);
            ThucHien.Parameters.AddWithValue("@TietTH", numericUpDown_TietThucHanh.Value);
            ThucHien.Parameters.AddWithValue("@Id", dataGridView_MonHoc.CurrentRow.Cells[0].Value);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_MonHoc.CurrentRow == null) return;

            DialogResult d = MessageBox.Show("Bạn có muốn xóa môn học này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Lenh = @"DELETE FROM MonHoc WHERE Id=@Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.AddWithValue("@Id", dataGridView_MonHoc.CurrentRow.Cells[0].Value);

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                HienThi();
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView_MonHoc.Rows.Clear();

            Lenh = @"SELECT Id, MaMH, TenMH, SoTC, TietLT, TietTH 
             FROM MonHoc 
             WHERE MaMH LIKE @TuKhoa OR TenMH LIKE @TuKhoa";

            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@TuKhoa", "%" + textBox_TimKiem.Text.Trim() + "%");

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_MonHoc.Rows.Add();
                dataGridView_MonHoc.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_MonHoc.Rows[i].Cells[1].Value = Doc["MaMH"];
                dataGridView_MonHoc.Rows[i].Cells[2].Value = Doc["TenMH"];
                dataGridView_MonHoc.Rows[i].Cells[3].Value = Doc["SoTC"];
                dataGridView_MonHoc.Rows[i].Cells[4].Value = Doc["TietLT"];
                dataGridView_MonHoc.Rows[i].Cells[5].Value = Doc["TietTH"];
                i++;
            }
            KetNoi.Close();
        }

        private void dataGridView_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_MonHoc.CurrentRow == null) return;

            textBox_MaMonHoc.Text = dataGridView_MonHoc.CurrentRow.Cells[1].Value.ToString();
            textBox_TenMonHoc.Text = dataGridView_MonHoc.CurrentRow.Cells[2].Value.ToString();
            numericUpDown_SoTinChi.Value = Convert.ToDecimal(dataGridView_MonHoc.CurrentRow.Cells[3].Value);
            numericUpDown_TietLyThuyet.Value = Convert.ToDecimal(dataGridView_MonHoc.CurrentRow.Cells[4].Value);
            numericUpDown_TietThucHanh.Value = Convert.ToDecimal(dataGridView_MonHoc.CurrentRow.Cells[5].Value);
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            textBox_MaMonHoc.Text = "";
            textBox_TenMonHoc.Text = "";
            numericUpDown_SoTinChi.Value = 0;
            numericUpDown_TietLyThuyet.Value = 0;
            numericUpDown_TietThucHanh.Value = 0;
            HienThi();
        }

        // 🔹 Reset form
        void ResetForm()
        {
            textBox_MaMonHoc.Text = "";
            textBox_TenMonHoc.Text = "";
            numericUpDown_SoTinChi.Value = 0;
            numericUpDown_TietLyThuyet.Value = 0;
            numericUpDown_TietThucHanh.Value = 0;
            textBox_TimKiem.Text = "";
        }
        
    }
}
