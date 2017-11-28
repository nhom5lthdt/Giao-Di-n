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
        DataTable ChiTietHoaDon;
        DataView ChiTietView;
        DataTable LichSuHoaDon;
        public TongDai()
        {
            InitializeComponent();
        }

        private void TongDai_Load(object sender, EventArgs e)
        {
            ChiTietHoaDon = XuLyDuLieu.docBang("Select * from HoaDon");
            ChiTietView = new DataView(ChiTietHoaDon);
            dgvHoaDon.DataSource = ChiTietView;

            LichSuHoaDon = XuLyDuLieu.docBang("Select * from HoaDon");
            ChiTietView = new DataView(LichSuHoaDon);
            dgvLichSu.DataSource = ChiTietView;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ChiTietHoaDon.NewRow();

                cn["idHoaDon"] = tbMaHoaDon.Text;
                cn["idBan"] = tbMaBan.Text;
                cn["Món Ăn"] = tbTenMonAn.Text;
                cn["Số Lượng"] = tbSoLuong.Text;
                cn["Tổng Tiền"] = tbTongTien.Text;

                ChiTietHoaDon.Rows.Add(cn);

                XuLyDuLieu.ghiBang("HoaDon", ChiTietHoaDon);
            }
            else
            {
                MessageBox.Show("Anh/chi chua nhap du thong tin.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvHoaDon.SelectedRows[0].DataBoundItem).Row;
                DialogResult dr =
                    MessageBox.Show("Anh/chi co muon xoa hoa don " + cn["Món Ăn"] + " khong?",
                    "Thong bao",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cn.Delete();
                    XuLyDuLieu.ghiBang("HoaDon", ChiTietHoaDon);
                }
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon ten mon an.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvHoaDon.SelectedRows[0].DataBoundItem).Row;
                cn["idHoaDon"] = tbMaHoaDon.Text;
                cn["idBan"] = tbMaBan.Text;
                cn["Món Ăn"] = tbTenMonAn.Text;
                cn["Số Lượng"] = tbSoLuong.Text;
                cn["Tổng Tiền"] = tbTongTien.Text;
                XuLyDuLieu.ghiBang("HoaDon", ChiTietHoaDon);
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon ten mon an.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
            tbTimKiem.ForeColor = Color.Black;
        }

        private void tbTimKiem_Leave(object sender, EventArgs e)
        {
            if (tbTimKiem.Text == "")
            {
                tbTimKiem.Text = "Số Điện Thoại";
                tbTimKiem.ForeColor = Color.Gray;
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
