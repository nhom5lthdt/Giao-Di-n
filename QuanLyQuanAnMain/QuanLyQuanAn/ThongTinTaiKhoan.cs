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
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {  
            if(BienToanCuc.t==0)
            {
                tbHoTen.Text = "Lữ Phước Hưng";
                tbTenDangNhap.Text = "GiamDoc";
                tbMatKhau.Text = "GiamDoc";
                tbQuyen.Text = "Giám Đốc";
            }
            else
            {
                if(BienToanCuc.t==1)
                {
                    tbHoTen.Text = "Đặng Thanh Thế";
                    tbTenDangNhap.Text = "QuanLyCN";
                    tbMatKhau.Text = "QuanLyCN";
                    tbQuyen.Text = "Quản Lý Chi Nhánh";
                }
            }
        }

      
    }
}
