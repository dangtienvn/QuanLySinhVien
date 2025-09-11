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
    public partial class fQuanLyKhoa : Form
    {

        public fQuanLyKhoa()
        {
            InitializeComponent();
        }

        // Kết nối cơ sở dữ liệu
        string Nguon = @"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyKhoa_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThi();
        }

        // Khi click vào 1 dòng trong DataGridView
        private void dataGridView_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaKhoa.Text = dataGridView_Khoa.CurrentRow.Cells[1].Value.ToString();
            textBox_TenKhoa.Text = dataGridView_Khoa.CurrentRow.Cells[2].Value.ToString();
        }

        // Thêm khoa
        private void button_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO Khoa(MaKhoa, TenKhoa) VALUES(@MaKhoa,@TenKhoa)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@MaKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters.Add("@TenKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters["@MaKhoa"].Value = textBox_MaKhoa.Text;
            ThucHien.Parameters["@TenKhoa"].Value = textBox_TenKhoa.Text;

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        void HienThi()
        {
            dataGridView_Khoa.Rows.Clear();
            Lenh = @"SELECT Id, MaKhoa, TenKhoa FROM Khoa";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Khoa.Rows.Add();
                dataGridView_Khoa.Rows[i].Cells[0].Value = Doc[0]; // Id
                dataGridView_Khoa.Rows[i].Cells[1].Value = Doc[1]; // MaKhoa
                dataGridView_Khoa.Rows[i].Cells[2].Value = Doc[2]; // TenKhoa
                i++;
            }
            KetNoi.Close();
        }

        // Sửa khoa 
        private void button_Sua_Click(object sender, EventArgs e)
        {
            Lenh = @"UPDATE Khoa
                     SET MaKhoa = @MaKhoa, TenKhoa = @TenKhoa
                     WHERE Id = @Original_Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@MaKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters.Add("@TenKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters.Add("@Original_Id", SqlDbType.Int);

            ThucHien.Parameters["@MaKhoa"].Value = textBox_MaKhoa.Text;
            ThucHien.Parameters["@TenKhoa"].Value = textBox_TenKhoa.Text;
            ThucHien.Parameters["@Original_Id"].Value = dataGridView_Khoa.CurrentRow.Cells[0].Value;

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        // Xóa khoa 
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn xóa khoa " + textBox_TenKhoa.Text + " ?",
                                             "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                Lenh = @"DELETE FROM Khoa WHERE Id=@Original_Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.Add("@Original_Id", SqlDbType.Int);
                ThucHien.Parameters["@Original_Id"].Value = dataGridView_Khoa.CurrentRow.Cells[0].Value;

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();

                HienThi();
            }
        }

        // Tải lại form
        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            textBox_MaKhoa.Text = "";
            textBox_TenKhoa.Text = "";
            
        }

        // 🔹 Tìm kiếm
        void TimKiem(string tuKhoa)
        {
            dataGridView_Khoa.Rows.Clear();
            Lenh = @"SELECT Id, MaKhoa, TenKhoa 
                     FROM Khoa
                     WHERE MaKhoa LIKE @TuKhoa OR TenKhoa LIKE @TuKhoa";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@TuKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters["@TuKhoa"].Value = "%" + tuKhoa + "%";

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Khoa.Rows.Add();
                dataGridView_Khoa.Rows[i].Cells[0].Value = Doc[0];
                dataGridView_Khoa.Rows[i].Cells[1].Value = Doc[1];
                dataGridView_Khoa.Rows[i].Cells[2].Value = Doc[2];
                i++;
            }
            KetNoi.Close();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiem(textBox_TimKiem.Text);
        }
    }
}
