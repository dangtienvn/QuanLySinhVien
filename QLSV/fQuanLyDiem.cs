using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV
{
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=DESKTOP-LTL2CL3\SQLEXPRESS;Initial Catalog=db_QLSV;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            LoadComboBox();
            HienThi();

        }

        // Load dữ liệu cho ComboBox MaSV, MaMH
        void LoadComboBox()
        {
            // Load SinhVien
            SqlDataAdapter daSV = new SqlDataAdapter("SELECT MaSV FROM SinhVien", KetNoi);
            DataTable dtSV = new DataTable();
            daSV.Fill(dtSV);
            comboBox_MaSinhVien.DataSource = dtSV;
            comboBox_MaSinhVien.DisplayMember = "MaSV";
            comboBox_MaSinhVien.ValueMember = "MaSV";

            // Load MonHoc
            SqlDataAdapter daMH = new SqlDataAdapter("SELECT MaMH FROM MonHoc", KetNoi);
            DataTable dtMH = new DataTable();
            daMH.Fill(dtMH);
            comboBox_MaMonHoc.DataSource = dtMH;
            comboBox_MaMonHoc.DisplayMember = "MaMH";
            comboBox_MaMonHoc.ValueMember = "MaMH";
        }

        // Hiển thị dữ liệu
        void HienThi()
        {
            dataGridView_Diem.Rows.Clear();
            Lenh = @"SELECT Id, MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB 
             FROM Diem";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Diem.Rows.Add();
                dataGridView_Diem.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_Diem.Rows[i].Cells[1].Value = Doc["MaSV"];
                dataGridView_Diem.Rows[i].Cells[2].Value = Doc["MaMH"];
                dataGridView_Diem.Rows[i].Cells[3].Value = Doc["PhanTramTrenLop"];
                dataGridView_Diem.Rows[i].Cells[4].Value = Doc["PhanTramThi"];
                dataGridView_Diem.Rows[i].Cells[5].Value = Doc["DiemTrenLop"];
                dataGridView_Diem.Rows[i].Cells[6].Value = Doc["DiemThi"];
                dataGridView_Diem.Rows[i].Cells[7].Value = Doc["DiemTB"];

                // Tính Loại dựa trên DiemTB
                double diemTB = Convert.ToDouble(Doc["DiemTB"]);
                string loai = "";
                if (diemTB >= 8) loai = "A";
                else if (diemTB >= 6.5) loai = "B";
                else loai = "C";

                dataGridView_Diem.Rows[i].Cells[8].Value = loai;

                i++;
            }
            KetNoi.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            double diemTrenLop = double.Parse(textBox_DiemLop.Text);
            double diemThi = double.Parse(textBox_DiemThi.Text);
            double ptLop = (double)numericUpDown_PhanTramLop.Value;
            double ptThi = (double)numericUpDown_PhanTramThi.Value;

            double diemTB = (diemTrenLop * ptLop / 100.0) + (diemThi * ptThi / 100.0);
            textBox_DiemTrungBinh.Text = diemTB.ToString("0.00");

            string Lenh = @"INSERT INTO Diem (MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB)
                            VALUES (@MaSV, @MaMH, @PTLop, @PTThi, @DiemLop, @DiemThi, @DiemTB)";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            ThucHien.Parameters.AddWithValue("@MaSV", comboBox_MaSinhVien.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaMH", comboBox_MaMonHoc.SelectedValue);
            ThucHien.Parameters.AddWithValue("@PTLop", ptLop);
            ThucHien.Parameters.AddWithValue("@PTThi", ptThi);
            ThucHien.Parameters.AddWithValue("@DiemLop", diemTrenLop);
            ThucHien.Parameters.AddWithValue("@DiemThi", diemThi);
            ThucHien.Parameters.AddWithValue("@DiemTB", diemTB);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_Diem.CurrentRow == null) return;

            double diemTrenLop = double.Parse(textBox_DiemLop.Text);
            double diemThi = double.Parse(textBox_DiemThi.Text);
            double ptLop = (double)numericUpDown_PhanTramLop.Value;
            double ptThi = (double)numericUpDown_PhanTramThi.Value;
            double diemTB = (diemTrenLop * ptLop / 100.0) + (diemThi * ptThi / 100.0);
            textBox_DiemTrungBinh.Text = diemTB.ToString("0.00");

            string Lenh = @"UPDATE Diem
                            SET MaSV=@MaSV, MaMH=@MaMH, PhanTramTrenLop=@PTLop,
                                PhanTramThi=@PTThi, DiemTrenLop=@DiemLop,
                                DiemThi=@DiemThi, DiemTB=@DiemTB
                            WHERE Id=@Id";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            ThucHien.Parameters.AddWithValue("@MaSV", comboBox_MaSinhVien.SelectedValue);
            ThucHien.Parameters.AddWithValue("@MaMH", comboBox_MaMonHoc.SelectedValue);
            ThucHien.Parameters.AddWithValue("@PTLop", ptLop);
            ThucHien.Parameters.AddWithValue("@PTThi", ptThi);
            ThucHien.Parameters.AddWithValue("@DiemLop", diemTrenLop);
            ThucHien.Parameters.AddWithValue("@DiemThi", diemThi);
            ThucHien.Parameters.AddWithValue("@DiemTB", diemTB);
            ThucHien.Parameters.AddWithValue("@Id", dataGridView_Diem.CurrentRow.Cells[0].Value);

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();

            HienThi();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_Diem.CurrentRow == null) return;

            DialogResult d = MessageBox.Show("Xóa điểm của Sinh Viên có Mã Sinh Viên: "
                                             + dataGridView_Diem.CurrentRow.Cells[1].Value,
                                             "Xác nhận",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                string Lenh = "DELETE FROM Diem WHERE Id=@Id";
                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.AddWithValue("@Id", dataGridView_Diem.CurrentRow.Cells[0].Value);

                KetNoi.Open();
                ThucHien.ExecuteNonQuery();
                KetNoi.Close();

                HienThi();
            }
        }

        private void button_TaiLai_Click(object sender, EventArgs e)
        {
            comboBox_MaSinhVien.SelectedIndex = -1;
            comboBox_MaMonHoc.SelectedIndex = -1;
            numericUpDown_PhanTramLop.Value = 0;
            numericUpDown_PhanTramThi.Value = 0;
            textBox_DiemLop.Clear();
            textBox_DiemThi.Clear();
            textBox_DiemTrungBinh.Clear();
            comboBox_Loai.SelectedIndex = -1;
            HienThi();
        }

        private void dataGridView_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Diem.CurrentRow != null)
            {
                comboBox_MaSinhVien.Text = dataGridView_Diem.CurrentRow.Cells[1].Value.ToString();
                comboBox_MaMonHoc.Text = dataGridView_Diem.CurrentRow.Cells[2].Value.ToString();
                numericUpDown_PhanTramLop.Value = Convert.ToDecimal(dataGridView_Diem.CurrentRow.Cells[3].Value);
                numericUpDown_PhanTramThi.Value = Convert.ToDecimal(dataGridView_Diem.CurrentRow.Cells[4].Value);
                textBox_DiemLop.Text = dataGridView_Diem.CurrentRow.Cells[5].Value.ToString();
                textBox_DiemThi.Text = dataGridView_Diem.CurrentRow.Cells[6].Value.ToString();
                textBox_DiemTrungBinh.Text = dataGridView_Diem.CurrentRow.Cells[7].Value.ToString();

                if (dataGridView_Diem.CurrentRow.Cells[8].Value != null)
                    comboBox_Loai.Text = dataGridView_Diem.CurrentRow.Cells[8].Value.ToString();
                else
                    comboBox_Loai.Text = "";
            }

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = textBox_TimKiem.Text.Trim();

            // 👉 Nếu không nhập gì thì tải lại toàn bộ danh sách
            if (string.IsNullOrWhiteSpace(keyword))
            {
                HienThi();
                return;
            }

            // 👉 Nếu có nhập thì tìm kiếm
            dataGridView_Diem.Rows.Clear();
            string Lenh = @"SELECT Id, MaSV, MaMH, PhanTramTrenLop, PhanTramThi, 
                           DiemTrenLop, DiemThi, DiemTB
                    FROM Diem
                    WHERE MaSV LIKE @keyword OR MaMH LIKE @keyword";

            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridView_Diem.Rows.Add();
                dataGridView_Diem.Rows[i].Cells[0].Value = Doc["Id"];
                dataGridView_Diem.Rows[i].Cells[1].Value = Doc["MaSV"];
                dataGridView_Diem.Rows[i].Cells[2].Value = Doc["MaMH"];
                dataGridView_Diem.Rows[i].Cells[3].Value = Doc["PhanTramTrenLop"];
                dataGridView_Diem.Rows[i].Cells[4].Value = Doc["PhanTramThi"];
                dataGridView_Diem.Rows[i].Cells[5].Value = Doc["DiemTrenLop"];
                dataGridView_Diem.Rows[i].Cells[6].Value = Doc["DiemThi"];
                dataGridView_Diem.Rows[i].Cells[7].Value = Doc["DiemTB"];

                // 👉 Tính Loại dựa vào DiemTB
                double diemTB = Convert.ToDouble(Doc["DiemTB"]);
                string loai = "";
                if (diemTB >= 8) loai = "A";
                else if (diemTB >= 6.5) loai = "B";
                else loai = "C";

                dataGridView_Diem.Rows[i].Cells[8].Value = loai;
                i++;
            }
            KetNoi.Close();
        }

        private void button_Xuat_Click(object sender, EventArgs e)
        {
            if (dataGridView_Diem.Rows.Count > 0)
            {
                try
                {
                    // Khởi tạo Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;

                    Excel.Workbook workbook = excelApp.Workbooks.Add(Missing.Value);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                    worksheet.Name = "BangDiem";

                    // Thêm tiêu đề
                    int colCount = dataGridView_Diem.Columns.Count;
                    Excel.Range title = worksheet.Range[
                        worksheet.Cells[1, 1],
                        worksheet.Cells[1, colCount]
                    ];
                    title.Merge();
                    title.Value = "Điểm trung bình môn học";
                    title.Font.Size = 16;
                    title.Font.Bold = true;
                    title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Ghi header DataGridView (hàng 2)
                    for (int i = 0; i < colCount; i++)
                    {
                        worksheet.Cells[2, i + 1] = dataGridView_Diem.Columns[i].HeaderText;
                    }

                    // Format header
                    Excel.Range headerRange = worksheet.Range[
                        worksheet.Cells[2, 1],
                        worksheet.Cells[2, colCount]
                    ];
                    headerRange.Font.Bold = true;
                    headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // ===== Ghi dữ liệu DataGridView (từ hàng 3) =====
                    for (int i = 0; i < dataGridView_Diem.Rows.Count; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = dataGridView_Diem.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Tạo border cho toàn bộ bảng
                    int rowCount = dataGridView_Diem.Rows.Count + 2; // header + data
                    Excel.Range usedRange = worksheet.Range[
                        worksheet.Cells[2, 1],
                        worksheet.Cells[rowCount, colCount]
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
                        workbook.Close();
                        excelApp.Quit();

                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        workbook.Close(false);
                        excelApp.Quit();
                    }
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
