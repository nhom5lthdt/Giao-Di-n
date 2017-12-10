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
        DataTable dsBan;
        DataTable dsMenu;
        DataView dsBanView;

        DataView dsMenuView;
       

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
            dgvcn.DataSource = dsChiNhanhView;
        
            //Doc du lieu danh sach mon an

            dsMonAn = XuLyDuLieu.docBang("Select *From MonAn");
            dsMonAnView = new DataView(dsMonAn);
            dgvmonan.DataSource = dsMonAnView;
            // Doc du lieu ban chi nhanh

            dsBan = XuLyDuLieu.docBang("Select *From Ban");
            dsBanView = new DataView(dsBan);
            dgvban.DataSource = dsBanView;
            // Doc du lieu monan
            
          
            dsMenuView = new DataView(bientoancuc.dsMn);
           
            dgvmenu.DataSource = dsMenuView;
            

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
            kh["SDT"] = tbsdtkhachhang.Text;
            kh["DiaChi"] = tbdiachikhachhang.Text;
            kh["MaLoaiKH"] = cbmaloaikhach.Text;
            dsKhachHang.Rows.Add(kh);
            XuLyDuLieu.ghiBang("KhachHang", dsKhachHang);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bttthemonan_Click(object sender, EventArgs e)
        {
            DataRow cn = dsMonAn.NewRow();
            cn["MaMA"] = tbidmonan.Text;
            cn["TenMA"] = tbtenmonan.Text;
            cn["MaLoaiMA"] = cbloaimonan.Text;
            cn["DonGia"] = tbgiamonan.Text;
            cn["MaDM"] = cbdanhmuc.Text;
            dsChiNhanh.Rows.Add(cn);
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

        private void dgvcn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow cn = dsChiNhanh.NewRow();
            cn["MaCN"]= tbid.Text;
            cn["TenCN"] = tbtencn.Text;
            cn["SDT"] = tbsdt.Text;
            cn["DiaChi"] = tbdiachi.Text;
            dsChiNhanh.Rows.Add(cn);
            XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
        }

        private void btxoachinanh_Click(object sender, EventArgs e)
        {
            if(dgvcn.SelectedRows.Count>0)
            {
                DataRow cn = ((DataRowView)dgvcn.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
                MessageBox.Show("Anh/ chi chua chon chi nhanh.", "ThongBao", MessageBoxButtons.OK);
        }

        private void btthemban_Click(object sender, EventArgs e)
        {
            if (dgvcn.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvcn.SelectedRows[0].DataBoundItem).Row;
                DataRow Ban = dsBan.NewRow();

                Ban["MaBan"] = tbidban.Text;
                
                Ban["MaCN"] = cn["MaCN"];

                dsBan.Rows.Add(Ban);
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
            else
            {
                MessageBox.Show("Anh/ chi chua chon chi nhanh.", "ThongBao", MessageBoxButtons.OK);
            }
        }

        private void btxoaban_Click(object sender, EventArgs e)
        {
            if (dgvban.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvban.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
            else
                MessageBox.Show("Anh/ chi chua chon ban.", "ThongBao", MessageBoxButtons.OK);
        }

        private void btxoakhachhang_Click(object sender, EventArgs e)
        {
            if (dgvdanhsachkhachhang.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvdanhsachkhachhang.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("KhanhHang", dsKhachHang);
            }
            else
                MessageBox.Show("Anh/ chi chua chon khach hang.", "ThongBao", MessageBoxButtons.OK);
        }

        private void btxoamonan_Click(object sender, EventArgs e)
        {
            if (dgvmonan.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvmonan.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("MonAn", dsMonAn);
            }
            else
                MessageBox.Show("Anh/ chi chua chon mon an.", "ThongBao", MessageBoxButtons.OK);
        }

        private void bttthemmenu_Click(object sender, EventArgs e)
        {
            if (dgvcn.SelectedRows.Count > 0)
            {
                fThemmenu frm = new fThemmenu();
                DataRow cn = ((DataRowView)dgvcn.SelectedRows[0].DataBoundItem).Row;
                bientoancuc.c = dgvcn.SelectedRows.Count;



                bientoancuc.masomn = dgvcn.SelectedRows[0].Cells["MaCN"].Value.ToString();
               
               
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Anh/ chi chua chon chi nhanh.", "ThongBao", MessageBoxButtons.OK);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbgiamonan_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

