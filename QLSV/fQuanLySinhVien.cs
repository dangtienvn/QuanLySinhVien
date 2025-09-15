using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV
{
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;
        string Lenh = "";

        private void fQuanLySinhVien_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(connectionString);
            LoadComboBox();
            HienThi();
        }

        void LoadComboBox()
        {
            // Load MaLop
            SqlDataAdapter daLop = new SqlDataAdapter("SELECT MaLop FROM Lop", KetNoi);
            DataTable dtLop = new DataTable();
            daLop.Fill(dtLop);
            comboBox_MaLop.DataSource = dtLop;
            comboBox_MaLop.DisplayMember = "MaLop";
            comboBox_MaLop.ValueMember = "MaLop";

            // Load MaKhoa
            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa FROM Khoa", KetNoi);
            DataTable dtKhoa = new DataTable();
            daKhoa.Fill(dtKhoa);
            comboBox_MaKhoa.DataSource = dtKhoa;
            comboBox_MaKhoa.DisplayMember = "MaKhoa";
            comboBox_MaKhoa.ValueMember = "MaKhoa";

            // Load MaGiaoVien
            SqlDataAdapter daGV = new SqlDataAdapter("SELECT MaGiaoVien FROM GiaoVien", KetNoi);
            DataTable dtGV = new DataTable();
            daGV.Fill(dtGV);
            comboBox_MaGiaoVien.DataSource = dtGV;
            comboBox_MaGiaoVien.DisplayMember = "MaGiaoVien";
            comboBox_MaGiaoVien.ValueMember = "MaGiaoVien";
        }

        void HienThi()
        {
            dataGridView_SinhVien.Rows.Clear();
            Lenh = @"SELECT Id, MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaGiaoVien 
                     FROM SinhVien";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_SinhVien.Rows.Add();
                dataGridView_SinhVien.Rows[i].Cells[0].Value = Doc[0];  // Id
                dataGridView_SinhVien.Rows[i].Cells[1].Value = Doc[1];  // MaSV
                dataGridView_SinhVien.Rows[i].Cells[2].Value = Doc[2];  // TenSV
                dataGridView_SinhVien.Rows[i].Cells[3].Value = Doc[3];  // NgaySinh
                dataGridView_SinhVien.Rows[i].Cells[4].Value = Doc[4];  // GioiTinh
                dataGridView_SinhVien.Rows[i].Cells[5].Value = Doc[5];  // QueQuan
                dataGridView_SinhVien.Rows[i].Cells[6].Value = Doc[6];  // NgayNhapHoc
                dataGridView_SinhVien.Rows[i].Cells[7].Value = Doc[7];  // MaLop
                dataGridView_SinhVien.Rows[i].Cells[8].Value = Doc[8];  // MaKhoa
                dataGridView_SinhVien.Rows[i].Cells[9].Value = Doc[9];  // MaGiaoVien
                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string gioiTinh = radioButton_Nam.Checked ? "Nam" : "Nữ";

            Lenh = @"INSERT INTO SinhVien(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaGiaoVien)
                     VALUES(@MaSV, @TenSV, @NgaySinh, @GioiTinh, @QueQuan, @NgayNhapHoc, @MaLop, @MaKhoa, @MaGiaoVien)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@MaSV", textBox_MaSinhVien.Text);
            ThucHien.Parameters.AddWithValue("@TenSV", textBox_TenSinhVien.Text);
            ThucHien.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
            ThucHien.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            ThucHien.Parameters.AddWithValue("@QueQuan", textBox_QueQuan.Text);
            ThucHien.Parameters.AddWithValue("@NgayNhapHoc", dateTimePicker_NhapHoc.Value);
            ThucHien.Parameters.AddWithValue("@MaLop", comboBox_MaLop.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaKhoa", comboBox_MaKhoa.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaGiaoVien", comboBox_MaGiaoVien.SelectedValue);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string gioiTinh = radioButton_Nam.Checked ? "Nam" : "Nữ";

            Lenh = @"UPDATE SinhVien 
                     SET MaSV=@MaSV, TenSV=@TenSV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, QueQuan=@QueQuan, 
                         NgayNhapHoc=@NgayNhapHoc, MaLop=@MaLop, MaKhoa=@MaKhoa, MaGiaoVien=@MaGiaoVien
                     WHERE Id=@Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@MaSV", textBox_MaSinhVien.Text);
            ThucHien.Parameters.AddWithValue("@TenSV", textBox_TenSinhVien.Text);
            ThucHien.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
            ThucHien.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            ThucHien.Parameters.AddWithValue("@QueQuan", textBox_QueQuan.Text);
            ThucHien.Parameters.AddWithValue("@NgayNhapHoc", dateTimePicker_NhapHoc.Value);
            ThucHien.Parameters.AddWithValue("@MaLop", comboBox_MaLop.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaKhoa", comboBox_MaKhoa.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaGiaoVien", comboBox_MaGiaoVien.SelectedValue);
            ThucHien.Parameters.AddWithValue("@Id", dataGridView_SinhVien.CurrentRow.Cells[0].Value);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Lenh = @"DELETE FROM SinhVien WHERE Id=@Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.AddWithValue("@Id", dataGridView_SinhVien.CurrentRow.Cells[0].Value);

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();
                HienThi();
            }
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            textBox_MaSinhVien.Text = "";
            textBox_TenSinhVien.Text = "";
            textBox_QueQuan.Text = "";
            dateTimePicker_NgaySinh.Value = DateTime.Now;
            dateTimePicker_NhapHoc.Value = DateTime.Now;
            radioButton_Nam.Checked = true;
            comboBox_MaLop.SelectedIndex = 0;
            comboBox_MaKhoa.SelectedIndex = 0;
            comboBox_MaGiaoVien.SelectedIndex = 0;
        }

        private void dataGridView_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaSinhVien.Text = dataGridView_SinhVien.CurrentRow.Cells[1].Value.ToString();
            textBox_TenSinhVien.Text = dataGridView_SinhVien.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_NgaySinh.Value = Convert.ToDateTime(dataGridView_SinhVien.CurrentRow.Cells[3].Value);
            string gioiTinh = dataGridView_SinhVien.CurrentRow.Cells[4].Value.ToString();
            if (gioiTinh == "Nam")
                radioButton_Nam.Checked = true;
            else
                radioButton_Nu.Checked = true;
            textBox_QueQuan.Text = dataGridView_SinhVien.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker_NhapHoc.Value = Convert.ToDateTime(dataGridView_SinhVien.CurrentRow.Cells[6].Value);
            comboBox_MaLop.SelectedValue = dataGridView_SinhVien.CurrentRow.Cells[7].Value.ToString();
            comboBox_MaKhoa.SelectedValue = dataGridView_SinhVien.CurrentRow.Cells[8].Value.ToString();
            comboBox_MaGiaoVien.SelectedValue = dataGridView_SinhVien.CurrentRow.Cells[9].Value.ToString();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView_SinhVien.Rows.Clear();
            Lenh = @"SELECT Id, MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaGiaoVien 
                     FROM SinhVien WHERE TenSV LIKE @TenSV";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@TenSV", "%" + textBox_TimKiem.Text + "%");

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_SinhVien.Rows.Add();
                dataGridView_SinhVien.Rows[i].Cells[0].Value = Doc[0];
                dataGridView_SinhVien.Rows[i].Cells[1].Value = Doc[1];
                dataGridView_SinhVien.Rows[i].Cells[2].Value = Doc[2];
                dataGridView_SinhVien.Rows[i].Cells[3].Value = Doc[3];
                dataGridView_SinhVien.Rows[i].Cells[4].Value = Doc[4];
                dataGridView_SinhVien.Rows[i].Cells[5].Value = Doc[5];
                dataGridView_SinhVien.Rows[i].Cells[6].Value = Doc[6];
                dataGridView_SinhVien.Rows[i].Cells[7].Value = Doc[7];
                dataGridView_SinhVien.Rows[i].Cells[8].Value = Doc[8];
                dataGridView_SinhVien.Rows[i].Cells[9].Value = Doc[9];
                i++;
            }
            KetNoi.Close();
        }

        private void button_Xuat_Click(object sender, EventArgs e)
        {
            if (dataGridView_SinhVien.Rows.Count > 0)
            {
                try
                {
                    // Khởi tạo Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false; // ẩn khi chạy

                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    worksheet.Name = "SinhVien";

                    // Tiêu đề
                    Excel.Range titleRange = worksheet.Range[
                        worksheet.Cells[1, 1],
                        worksheet.Cells[1, dataGridView_SinhVien.Columns.Count]
                    ];
                    titleRange.Merge();
                    titleRange.Value = "DANH SÁCH SINH VIÊN";
                    titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    titleRange.Font.Bold = true;
                    titleRange.Font.Size = 16;

                    // Header
                    for (int i = 0; i < dataGridView_SinhVien.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i + 1] = dataGridView_SinhVien.Columns[i].HeaderText;
                        Excel.Range headerCell = (Excel.Range)worksheet.Cells[2, i + 1];
                        headerCell.Font.Bold = true;
                        headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                        headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }

                    // Data
                    for (int i = 0; i < dataGridView_SinhVien.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView_SinhVien.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = dataGridView_SinhVien.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // ===== Thêm border =====
                    Excel.Range usedRange = worksheet.Range[
                        worksheet.Cells[2, 1],
                        worksheet.Cells[dataGridView_SinhVien.Rows.Count + 2, dataGridView_SinhVien.Columns.Count]
                    ];
                    usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                    // Auto fit cột
                    worksheet.Columns.AutoFit();

                    // Hộp thoại lưu file
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Workbook|*.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    workbook.Close();
                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
