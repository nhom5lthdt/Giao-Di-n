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
    public partial class TongDai : Form
    {
        DataView ThongTinView;
        DataTable LichSu;
        DataTable ThongTinMonAn;
        DataTable ThongTinHoaDon;
        DataTable ThongTinChiNhanh;
        DataView LichSuView;
        float tien = 0;
        float giamgia = 0;
        DataRow KH;

        public TongDai()
        {
            InitializeComponent();
        }

        private void TongDai_Load(object sender, EventArgs e)
        {

            ThongTinMonAn = XuLyDuLieu.docBang("Select MaMA,TenMA,TenLoaiMA,DonGia from MonAn,LoaiMonAn where MonAn.MaLoaiMA = LoaiMonAn.MaLoaiMA");
            ThongTinView = new DataView(ThongTinMonAn);
            dgvDSMonAn.DataSource = ThongTinView;

            ThongTinHoaDon = XuLyDuLieu.docBang("select * from Rong");
            dgvDSHoaDon.DataSource = ThongTinHoaDon;

            LichSu = XuLyDuLieu.docBang("Select TenCN,TenKH,DiaChi,SDT,ThoiGian,TongTien from LichSuMua");
            LichSuView = new DataView(LichSu);
            dgvLichSu.DataSource = LichSuView;

            ThongTinChiNhanh = XuLyDuLieu.docBang("Select TenCN,SDT,DiaChi  from ChiNhanh");
            dgvChiNhanh.DataSource = ThongTinChiNhanh;

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btThem_Click_1(object sender, EventArgs e)
        {

            int i;
            if (dgvDSMonAn.SelectedRows.Count > 0)
            {
                for (i = 0; i < dgvDSMonAn.SelectedRows.Count; i++)
                {
                    DataRow ma = ThongTinMonAn.Rows[dgvDSMonAn.SelectedRows[i].Index];
                    int chiso = TimMATrongDSDHMA(((string)ma["TenMA"]));
                    if (chiso == -1)
                    {
                        DataRow dhma = ThongTinHoaDon.NewRow();
                        dhma["MaMonAn"] = ma["MaMA"];
                        dhma["TenMonAn"] = ma["TenMA"];
                        dhma["LoaiMonAn"] = ma["TenLoaiMA"];
                        dhma["SoLuong"] = 1;
                        dhma["Gia"] = ma["DonGia"];
                        ThongTinHoaDon.Rows.Add(dhma);
                    }
                    else
                    {
                        ThongTinHoaDon.Rows[chiso]["SoLuong"] = (int)ThongTinHoaDon.Rows[chiso]["SoLuong"] + 1;
                    }

                    float thanhtien = 0;
                    float tongtien = 0;
                    for (i = 0; i < dgvDSHoaDon.Rows.Count; i++)
                    {
                        thanhtien = float.Parse(dgvDSHoaDon.Rows[i].Cells["Gia"].Value.ToString()) * int.Parse(dgvDSHoaDon.Rows[i].Cells["SoLuong"].Value.ToString());
                        tongtien += thanhtien;
                    }
                    tbTongTien.Text = tongtien.ToString();
                    giamgia = tongtien;
                    tien = tongtien;
                    tien = tien + (tien * 10 / 100);
                    tbThanhTien.Text = tien.ToString();
                }
            }
            else
            {
                MessageBox.Show("Anh/Chị chưa chọn món ăn", "Thong bao");
            }
            XuLyDuLieu.ghiBang("Rong", ThongTinHoaDon);
        }
        int TimMATrongDSDHMA(string ma)
        {
            int kq = -1;
            for (int i = 0; i < ThongTinHoaDon.Rows.Count; i++)
            {
                if ((string)ThongTinHoaDon.Rows[i]["TenMonAn"] == ma)
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }

        private void btBot_Click(object sender, EventArgs e)
        {
            int i;
            int chiso;
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                for (i = 0; i < dgvDSHoaDon.SelectedRows.Count; i++)
                {
                    DataRow ma = ThongTinHoaDon.Rows[dgvDSHoaDon.SelectedRows[i].Index];

                    chiso = TimMATrongDSDHMA(((string)ma["TenMonAn"]));
                    if (chiso != -1)
                    {
                        int t = (int)ThongTinHoaDon.Rows[chiso]["SoLuong"];
                        if (t > 1)
                        {
                            ThongTinHoaDon.Rows[chiso]["SoLuong"] = (int)ThongTinHoaDon.Rows[chiso]["SoLuong"] - 1;
                        }
                        else
                        {
                            //ThongTinHoaDon.Rows.RemoveAt(chiso);
                            ma.Delete();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không Còn Món Để Bớt.", "Thong bao", MessageBoxButtons.OK);
            }
            float thanhtien = 0;
            float tongtien = 0;
            for (i = 0; i < dgvDSHoaDon.Rows.Count; i++)
            {
                thanhtien = float.Parse(dgvDSHoaDon.Rows[i].Cells["Gia"].Value.ToString()) * int.Parse(dgvDSHoaDon.Rows[i].Cells["SoLuong"].Value.ToString());
                tongtien += thanhtien;
            }
            tbTongTien.Text = tongtien.ToString();
            giamgia = tongtien;
            tien = tongtien;
            tien = tien + (tien * 10 / 100);
            tbThanhTien.Text = tien.ToString();
            XuLyDuLieu.ghiBang("Rong", ThongTinHoaDon);
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvDSHoaDon.SelectedRows[0].DataBoundItem).Row;
                DialogResult dr =
                    MessageBox.Show("Anh/Chị có muốn xóa món " + cn["TenMonAn"] + " khong?",
                    "Thong bao",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cn.Delete();
                    //XuLyDuLieu.ghiBang("Rong", ThongTinHoaDon);
                }
                float thanhtien = 0;
                float tongtien = 0;
                for (int i = 0; i < dgvDSHoaDon.Rows.Count; i++)
                {
                    thanhtien = float.Parse(dgvDSHoaDon.Rows[i].Cells["Gia"].Value.ToString()) * int.Parse(dgvDSHoaDon.Rows[i].Cells["SoLuong"].Value.ToString());
                    tongtien += thanhtien;
                }
                tbTongTien.Text = tongtien.ToString();
                giamgia = tongtien;
                tien = tongtien;
                tien = tien + (tien * 10 / 100);
                tbThanhTien.Text = tien.ToString();
                XuLyDuLieu.ghiBang("Rong", ThongTinHoaDon);
            }
            else
            {
                MessageBox.Show("Anh/Chị chưa chọn tên món ăn.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void nbudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            int k = int.Parse(nbudGiamGia.Value.ToString());
            if (k >= 0)
            {
                float thanhtien = tien - (giamgia * k / 100);
                tbThanhTien.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Mời Nhập");
            }
        }


        private void btChon_Click_1(object sender, EventArgs e)
        {
            KH = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
            DialogResult dr =
                MessageBox.Show("Anh/Chị đã chọn Chi Nhánh  " + KH["TenCN"]);
        }

        private void btXacNhanKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKhachHang.Text)  || string.IsNullOrEmpty(tbSDT.Text) || string.IsNullOrEmpty(tbbDiaChi.Text))
                MessageBox.Show("Anh/Chị chưa nhập đủ thông tin ");
            else
                MessageBox.Show(" Xác nhận thành công  KH : " + tbKhachHang.Text);
        }

        private void btXacNhanHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKhachHang.Text) || string.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Anh/Chị chưa nhập đủ thông tin");
            }
            else
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow dhma = LichSu.NewRow();
                dhma["TenCN"] = cn["TenCN"];
                dhma["TenKH"] = tbKhachHang.Text;
                dhma["DiaChi"] = tbbDiaChi.Text;
                dhma["SDT"] = tbSDT.Text;
                dhma["ThoiGian"] = dtpNgayTao.Text;
                dhma["TongTien"] = tbThanhTien.Text;
                LichSu.Rows.Add(dhma);
                XuLyDuLieu.ghiBang("LichSuMua", LichSu);
                MessageBox.Show("Giao dịch thành công");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvLichSu.SelectedRows[0].DataBoundItem).Row;
                DialogResult dr =
                    MessageBox.Show("Anh/Chị có muốn hủy đơn hàng " + " khong?",
                    "Thong bao",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cn.Delete();
                }
                
            }
        }

        private void tbTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "")
            {
                LichSuView.RowFilter = "";
            }
            else
            {
                   string str = String.Format("SDT Like  '%{0}%' ", tbTimKiemSDT.Text);
                LichSuView.RowFilter = str;

            }

        }


        private void tbKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbbDiaChi.Select();
            }
        }

        private void tbbDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSDT.Select();
            }
        }

        private void tbSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btXacNhanKH.Select();
            }
        }

        private void tbTaoMoiKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKhachHang.Text) || string.IsNullOrEmpty(tbSDT.Text) || string.IsNullOrEmpty(tbbDiaChi.Text))
                MessageBox.Show("Anh/Chị chưa nhập thông tin ");
            else
            {
                tbKhachHang.Clear();
                tbSDT.Clear();
                tbbDiaChi.Clear();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon.Clear();
            tbThanhTien.Clear();
            tbTongTien.Clear();
            tbKhachHang.Clear();
            tbSDT.Clear();
            tbbDiaChi.Clear();
        }

        private void tbTimKiemMonAn_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemMonAn.Text == "")
            {
                ThongTinView.RowFilter = "";
            }
            else
            {
                string str = String.Format("TenMA Like  '%{0}%' ", tbTimKiemMonAn.Text);
                ThongTinView.RowFilter = str;

            }
        }
    }
}
    

