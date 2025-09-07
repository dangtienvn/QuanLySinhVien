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
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        // Kết nối cơ sở dữ liệu
        string Nguon = @"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void button_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO Khoa (TenKhoa)
                     VALUES (@TenKhoa)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@TenKhoa", SqlDbType.NVarChar);
            ThucHien.Parameters["@TenKhoa"].Value = textBox_TenKhoa.Text;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        void HienThi()
        {
            dataGridView.Rows.Clear();
            Lenh = @"SELECT MaKhoa, TenKhoa
                     FROM Khoa";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = Doc[0];
                dataGridView.Rows[i].Cells[1].Value = Doc[1];
                i++;
            }
            KetNoi.Close();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_TenKhoa.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
