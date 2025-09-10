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

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // Xóa nội dung cũ
            // Nếu muốn có màn hình mặc định thì add lại UserControl mặc định ở đây

        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLySinhVien f = new fQuanLySinhVien();
            OpenChildForm(f);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            OpenChildForm(f);
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            OpenChildForm(f);
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            OpenChildForm(f);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyGiaoVien f = new fQuanLyGiaoVien();
            OpenChildForm(f);
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            OpenChildForm(f);
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            OpenChildForm(f);
        }

        private void thôngTtinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinChiTiet f = new fThongTinChiTiet();
            f.ShowDialog();
        }

        private void quênMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuenMatKhau f = new fQuenMatKhau();
            f.ShowDialog();
        }
    }
}
