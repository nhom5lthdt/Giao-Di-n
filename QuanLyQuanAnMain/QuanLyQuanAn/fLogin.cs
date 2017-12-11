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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (tbtendangnhap.Text == "GiamDoc" && tbmatkhau.Text == "GiamDoc")
                {
                    GiamDoc gd = new GiamDoc();
                    this.Hide();
                    gd.ShowDialog();
                    this.Show();
                }
            else
            {
                if(tbtendangnhap.Text=="QuanLyCN" && tbmatkhau.Text=="QuanLyCN")
                {
                    QuanLyChiNhanh gd = new QuanLyChiNhanh();
                    this.Hide();
                    gd.ShowDialog();
                    this.Show();
                }
            }
            
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông Báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
        }

        private void tbtendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbmatkhau.Select();
        }

        private void tbmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btdangnhap.Select();
        }
    }
}
