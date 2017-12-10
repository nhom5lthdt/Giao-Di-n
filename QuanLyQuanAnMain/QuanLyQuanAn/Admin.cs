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
    public partial class Admin : Form
    {
        DataTable dsChiNhanh;
        DataView dsChiNhanhView;
       
        DataTable dsMonAn;
        DataView dsKhachHangView;
        DataTable dsKhachHang;
        DataView dsMonAnView;

        public Admin()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            //Doc du lieu danh sach khach hang
            dsKhachHang = XuLyDuLieu.docBang("Select *From KhachHang");
            dsKhachHangView = new DataView(dsKhachHang);
            dgvdanhsachkhachhang.DataSource = dsKhachHangView;
        
            //Doc du lieu danh sach chi nhanh
            dsChiNhanh = XuLyDuLieu.docBang("Select *From ChiNhanh");
            dsChiNhanhView = new DataView(dsChiNhanh);
            dgvchinhanh.DataSource = dsChiNhanhView;
        
            //Doc du lieu danh sach mon an

            dsMonAn = XuLyDuLieu.docBang("Select *From MonAn");
            dsMonAnView = new DataView(dsMonAn);
            dgvmonan.DataSource = dsMonAnView;
        

    }
    

        private void tCatllogy_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvdoanhthutukhitao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tchinhanh_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataRow kh = dsKhachHang.NewRow();
            kh["MaKH"] = tbidkhachhang.Text;
            kh["TenKH"] = tbtenkhachhang.Text;
            kh["SdtKH"] = tbsdtkhachhang.Text;
            kh["DiaChiKH"] = tbdiachikhachhang.Text;
            dsKhachHang.Rows.Add(kh);
            XuLyDuLieu.ghiBang("KhachHang", dsKhachHang);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bttthemonan_Click(object sender, EventArgs e)
        {
            DataRow cn = dsMonAn.NewRow();
            //cn["Mama"] = tbMaCN.Text;
            //cn["CNTen"] = tbTenChiNhanh.Text;
            //cn["CNDienThoai"] = tbDienThoaiChiNhanh.Text;
            //cn["CNDiaChi"] = tbDiaChiChiNhanh.Text;
            //dsChiNhanh.Rows.Add(cn);
            XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
        }

        private void bthongke_Click(object sender, EventArgs e)
        {
            HoaDon d = new HoaDon();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TongDai d = new TongDai();
            d.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
