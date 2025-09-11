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
    public partial class fQuanLyLop : Form
    {
        public fQuanLyLop()
        {
            InitializeComponent();
        }

        // 🔹 Kết nối CSDL
        string Nguon = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        string Lenh = "";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            LoadKhoa();   // nạp danh sách khoa vào ComboBox
            HienThi();    // hiển thị danh sách lớ;
        }

        // 🔹 Load Khoa vào ComboBox
        void LoadKhoa()
        {
            DataTable dt = new DataTable();
            Lenh = @"SELECT MaKhoa, TenKhoa FROM Khoa";
            SqlDataAdapter da = new SqlDataAdapter(Lenh, Nguon);
            da.Fill(dt);

            comboBox_MaKhoa.DataSource = dt;
            comboBox_MaKhoa.DisplayMember = "TenKhoa";
            comboBox_MaKhoa.ValueMember = "MaKhoa";
        }

        // 🔹 Hiển thị danh sách lớp
        void HienThi()
        {
            dataGridView_Lop.Rows.Clear();
            Lenh = @"SELECT Id, MaLop, TenLop, SoLuong, MaKhoa FROM Lop";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Lop.Rows.Add();
                dataGridView_Lop.Rows[i].Cells[0].Value = Doc[0]; // Id
                dataGridView_Lop.Rows[i].Cells[1].Value = Doc[1]; // MaLop
                dataGridView_Lop.Rows[i].Cells[2].Value = Doc[2]; // TenLop
                dataGridView_Lop.Rows[i].Cells[3].Value = Doc[3]; // SoLuong
                dataGridView_Lop.Rows[i].Cells[4].Value = Doc[4]; // MaKhoa
                i++;
            }
            KetNoi.Close();
        }

        // 🔹 Tìm kiếm lớp
        void TimKiem(string tuKhoa)
        {
            dataGridView_Lop.Rows.Clear();
            Lenh = @"SELECT Id, MaLop, TenLop, SoLuong, MaKhoa
                     FROM Lop
                     WHERE MaLop LIKE @TuKhoa OR TenLop LIKE @TuKhoa OR MaKhoa LIKE @TuKhoa";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = "%" + tuKhoa + "%";

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Lop.Rows.Add();
                dataGridView_Lop.Rows[i].Cells[0].Value = Doc[0];
                dataGridView_Lop.Rows[i].Cells[1].Value = Doc[1];
                dataGridView_Lop.Rows[i].Cells[2].Value = Doc[2];
                dataGridView_Lop.Rows[i].Cells[3].Value = Doc[3];
                dataGridView_Lop.Rows[i].Cells[4].Value = Doc[4];
                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO Lop(MaLop, TenLop, SoLuong, MaKhoa) 
                     VALUES(@MaLop,@TenLop,@SoLuong,@MaKhoa)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = textBox_MaLop.Text;
            ThucHien.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = textBox_TenLop.Text;
            ThucHien.Parameters.Add("@SoLuong", SqlDbType.Int).Value = numericUpDown_SoLuong.Value;
            ThucHien.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = comboBox_MaKhoa.SelectedValue;

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Lenh = @"UPDATE Lop
                     SET MaLop=@MaLop, TenLop=@TenLop, SoLuong=@SoLuong, MaKhoa=@MaKhoa
                     WHERE Id=@Original_Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = textBox_MaLop.Text;
            ThucHien.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = textBox_TenLop.Text;
            ThucHien.Parameters.Add("@SoLuong", SqlDbType.Int).Value = numericUpDown_SoLuong.Value;
            ThucHien.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = comboBox_MaKhoa.SelectedValue;
            ThucHien.Parameters.Add("@Original_Id", SqlDbType.Int).Value = dataGridView_Lop.CurrentRow.Cells[0].Value;

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn xóa lớp " + textBox_TenLop.Text + " ?",
                                             "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                Lenh = @"DELETE FROM Lop WHERE Id=@Original_Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.Add("@Original_Id", SqlDbType.Int).Value = dataGridView_Lop.CurrentRow.Cells[0].Value;

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();

                HienThi();
            }
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaLop.Text = dataGridView_Lop.CurrentRow.Cells[1].Value.ToString();
            textBox_TenLop.Text = dataGridView_Lop.CurrentRow.Cells[2].Value.ToString();
            numericUpDown_SoLuong.Value = Convert.ToDecimal(dataGridView_Lop.CurrentRow.Cells[3].Value);
            comboBox_MaKhoa.SelectedValue = dataGridView_Lop.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiem(textBox_TimKiem.Text);
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            // Load lại danh sách
            HienThi();

            // Xóa nội dung các ô nhập liệu
            textBox_MaLop.Text = "";
            textBox_TenLop.Text = "";
            textBox_TimKiem.Text = "";
            numericUpDown_SoLuong.Value = 0;

            // Reset ComboBox về vị trí đầu tiên
            if (comboBox_MaKhoa.Items.Count > 0)
                comboBox_MaKhoa.SelectedIndex = 0;
        }
    }
}
