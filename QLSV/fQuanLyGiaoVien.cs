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
    public partial class fQuanLyGiaoVien : Form
    {
        public fQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        // 🔹 Chuỗi kết nối CSDL
        string Nguon = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        string Lenh = "";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            LoadComboBox();
            HienThi();
        }

        // 🔹 Load dữ liệu combobox MaLop, MaKhoa
        void LoadComboBox()
        {
            // MaLop
            SqlDataAdapter daLop = new SqlDataAdapter("SELECT MaLop FROM Lop", KetNoi);
            DataTable dtLop = new DataTable();
            daLop.Fill(dtLop);
            comboBox_MaLop.DataSource = dtLop;
            comboBox_MaLop.DisplayMember = "MaLop";
            comboBox_MaLop.ValueMember = "MaLop";

            // MaKhoa
            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa FROM Khoa", KetNoi);
            DataTable dtKhoa = new DataTable();
            daKhoa.Fill(dtKhoa);
            comboBox_MaKhoa.DataSource = dtKhoa;
            comboBox_MaKhoa.DisplayMember = "MaKhoa";
            comboBox_MaKhoa.ValueMember = "MaKhoa";
        }

        // 🔹 Hiển thị danh sách giáo viên
        void HienThi()
        {
            dataGridView_GiaoVien.Rows.Clear();
            Lenh = @"SELECT Id, MaGiaoVien, TenGiaoVien, NgaySinh, GioiTinh, MaLop, MaKhoa FROM GiaoVien";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_GiaoVien.Rows.Add();
                dataGridView_GiaoVien.Rows[i].Cells[0].Value = Doc["Id"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[1].Value = Doc["MaGiaoVien"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[2].Value = Doc["TenGiaoVien"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[3].Value = Convert.ToDateTime(Doc["NgaySinh"]).ToShortDateString();
                dataGridView_GiaoVien.Rows[i].Cells[4].Value = Doc["GioiTinh"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[5].Value = Doc["MaLop"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[6].Value = Doc["MaKhoa"].ToString();
                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string gioiTinh = radioButton_Nam.Checked ? "Nam" : "Nữ";
            Lenh = @"INSERT INTO GiaoVien (MaGiaoVien, TenGiaoVien, NgaySinh, GioiTinh, MaLop, MaKhoa)
                     VALUES (@MaGV, @TenGV, @NgaySinh, @GioiTinh, @MaLop, @MaKhoa)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@MaGV", textBox_MaGiaoVien.Text);
            ThucHien.Parameters.AddWithValue("@TenGV", textBox_TenGiaoVien.Text);
            ThucHien.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
            ThucHien.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            ThucHien.Parameters.AddWithValue("@MaLop", comboBox_MaLop.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaKhoa", comboBox_MaKhoa.SelectedValue);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
            ResetForm();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string gioiTinh = radioButton_Nam.Checked ? "Nam" : "Nữ";
            int id = Convert.ToInt32(dataGridView_GiaoVien.CurrentRow.Cells[0].Value);

            Lenh = @"UPDATE GiaoVien
                     SET MaGiaoVien=@MaGV, TenGiaoVien=@TenGV, NgaySinh=@NgaySinh,
                         GioiTinh=@GioiTinh, MaLop=@MaLop, MaKhoa=@MaKhoa
                     WHERE Id=@Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@Id", id);
            ThucHien.Parameters.AddWithValue("@MaGV", textBox_MaGiaoVien.Text);
            ThucHien.Parameters.AddWithValue("@TenGV", textBox_TenGiaoVien.Text);
            ThucHien.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
            ThucHien.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            ThucHien.Parameters.AddWithValue("@MaLop", comboBox_MaLop.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaKhoa", comboBox_MaKhoa.SelectedValue);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
            ResetForm();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
             int id = Convert.ToInt32(dataGridView_GiaoVien.CurrentRow.Cells[0].Value);
            DialogResult d = MessageBox.Show("Bạn có chắc muốn xóa giáo viên " + textBox_TenGiaoVien.Text,
                "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                Lenh = "DELETE FROM GiaoVien WHERE Id=@Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.AddWithValue("@Id", id);

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                HienThi();
                ResetForm();
            }
        }

        private void dataGridView_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaGiaoVien.Text = dataGridView_GiaoVien.CurrentRow.Cells[1].Value.ToString();
            textBox_TenGiaoVien.Text = dataGridView_GiaoVien.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_NgaySinh.Value = Convert.ToDateTime(dataGridView_GiaoVien.CurrentRow.Cells[3].Value);
            string gioiTinh = dataGridView_GiaoVien.CurrentRow.Cells[4].Value.ToString();
            radioButton_Nam.Checked = (gioiTinh == "Nam");
            radioButton_Nu.Checked = (gioiTinh != "Nam");
            comboBox_MaLop.SelectedValue = dataGridView_GiaoVien.CurrentRow.Cells[5].Value.ToString();
            comboBox_MaKhoa.SelectedValue = dataGridView_GiaoVien.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView_GiaoVien.Rows.Clear();
            Lenh = @"SELECT Id, MaGiaoVien, TenGiaoVien, NgaySinh, GioiTinh, MaLop, MaKhoa
                     FROM GiaoVien
                     WHERE MaGiaoVien LIKE @TuKhoa OR TenGiaoVien LIKE @TuKhoa";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = "%" + textBox_TimKiem.Text + "%";

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_GiaoVien.Rows.Add();
                dataGridView_GiaoVien.Rows[i].Cells[0].Value = Doc["Id"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[1].Value = Doc["MaGiaoVien"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[2].Value = Doc["TenGiaoVien"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[3].Value = Convert.ToDateTime(Doc["NgaySinh"]).ToShortDateString();
                dataGridView_GiaoVien.Rows[i].Cells[4].Value = Doc["GioiTinh"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[5].Value = Doc["MaLop"].ToString();
                dataGridView_GiaoVien.Rows[i].Cells[6].Value = Doc["MaKhoa"].ToString();
                i++;
            }
            KetNoi.Close();
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            HienThi();
            ResetForm();
        }

        // 🔹 Reset form nhập liệu
        void ResetForm()
        {
            textBox_MaGiaoVien.Text = "";
            textBox_TenGiaoVien.Text = "";
            dateTimePicker_NgaySinh.Value = DateTime.Now;
            radioButton_Nam.Checked = true;
            if (comboBox_MaLop.Items.Count > 0) comboBox_MaLop.SelectedIndex = 0;
            if (comboBox_MaKhoa.Items.Count > 0) comboBox_MaKhoa.SelectedIndex = 0;
            textBox_TimKiem.Text = "";
        }


    }
}
