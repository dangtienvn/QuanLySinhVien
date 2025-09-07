using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn đăng xuất không", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // Xóa form cũ trong panel
            panelContainer.Controls.Clear();

            // Cấu hình để form con nằm gọn trong panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm vào panel
            panelContainer.Controls.Add(childForm);
            childForm.Show();
        }


        private void khoaToolStripMenuItem_Click_(object sender, EventArgs e)
        {
            FormKhoa f = new FormKhoa();
            OpenChildForm(f);
        }
    }
}
