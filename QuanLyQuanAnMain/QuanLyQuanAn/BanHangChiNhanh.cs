using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace QuanLyQuanAn
{
    public partial class BanHangChiNhanh : Form
    {
        DataTable dsBan;
        DataTable dsMonAn;
        DataTable dsDHMonAn;
        DataTable dsChiNhanh;
        int i = 0;
        public BanHangChiNhanh()
        {
            InitializeComponent();
        }

        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            dsChiNhanh = XuLyDuLieu.docBang("Select * from ChiNhanh");
            for (int i = 0; i < dsChiNhanh.Rows.Count; i++)
            {
                thôngTinToolStripMenuItem.DropDownItems.Add(dsChiNhanh.Rows[i]["MaCN"].ToString());
            }
            dsDHMonAn = XuLyDuLieu.docBang("Select * from MonAn");
            dgvDsMonAn.DataSource = dsDHMonAn;
        }

        private void LISTVIEW(string idChiNhanh)
        {

            dsBan = XuLyDuLieu.docBang("Select * from Ban where MaCN LIKE '" + idChiNhanh + "'");
            lvDsBan.Items.Clear();
            for (int i = 0; i < dsBan.Rows.Count; i++)
            {
                lvDsBan.Items.Add(dsBan.Rows[i]["MaBan"].ToString());
                //lvDsBan.Items[i].SubItems.Add(dsBan.Rows[i]["MaCN"].ToString());
                lvDsBan.Items[i].SubItems.Add(dsBan.Rows[i]["TinhTrang"].ToString());
                lvDsBan.Items[i].SubItems.Add(dsBan.Rows[i]["ThoiGian"].ToString());

            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            lvHoaDon.Items.Add(dgvDsMonAn.SelectedRows[0].Cells["TenMA"].Value.ToString());
            lvHoaDon.Items[i].SubItems.Add(dgvDsMonAn.SelectedRows[0].Cells["DonGia"].Value.ToString());
            lvHoaDon.Items[i].SubItems.Add(lvDsBan.SelectedItems[0].Text);

            i++;

            textBox1.Text = String.Format("{0,0:N0} {1}", TinhTien(), "VND");
        }

        public int TinhTien()
        {
            int g = 0;
            for (int i = 0; i < lvHoaDon.Items.Count; i++)
            {
                g = g + int.Parse(lvHoaDon.Items[i].SubItems[1].Text);
            }
            return g;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            while (lvHoaDon.SelectedItems.Count > 0)
            {
                lvHoaDon.SelectedItems[0].Remove();
                textBox1.Text = String.Format("{0,0:N0} {1}", TinhTien(), "VND");
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            lvHoaDon.Items.Clear();
            textBox1.Clear();
        }

        private void lvDsBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsBan.SelectedItems.Count > 0)
            {
                lvDsBan.SelectedItems[0].SubItems[2].Text = DtpBan.Text;
            }
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            lvDsBan.SelectedItems[0].SubItems[1].Text = "Đã chọn";
            MessageBox.Show("Đã chuyển xuống bếp !", "Thông Báo", MessageBoxButtons.OK);
            lvHoaDon.Items.Clear();
        }

        private void thôngTinToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String str = e.ClickedItem.ToString();
            LISTVIEW(str);
            thôngTinToolStripMenuItem.Text = str;
        }
    }
}
