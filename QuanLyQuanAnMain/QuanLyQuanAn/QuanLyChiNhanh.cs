using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class QuanLyChiNhanh : Form
    {
        public QuanLyChiNhanh()
        {
            InitializeComponent();
        }

        private void thôngTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BienToanCuc.t = 1;
            ThongTinTaiKhoan tt = new ThongTinTaiKhoan();
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChiNhanh_Click(object sender, EventArgs e)
        {
            BanHangChiNhanh td = new BanHangChiNhanh();
            this.Hide();
            td.ShowDialog();
            this.Show();
        }
    }
}
