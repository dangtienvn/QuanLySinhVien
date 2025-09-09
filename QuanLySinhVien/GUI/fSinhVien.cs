using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.GUI;

namespace QuanLySinhVien
{
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCoVanHocTap f = new fQuanLyCoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fThongTinChiTiet().ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuenMatKhau().ShowDialog();
        }
    }
}
