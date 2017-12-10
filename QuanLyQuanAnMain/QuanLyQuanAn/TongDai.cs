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
        DataTable ThongTinHoaDon ;
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

            //LichSu = XuLyDuLieu.docBang("Select * from HoaDon");
            //ThongTinView = new DataView(LichSu);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ThongTinMonAn.NewRow();



                ThongTinMonAn.Rows.Add(cn);

                XuLyDuLieu.ghiBang("HoaDon", ThongTinMonAn);
            }
            else
            {
                MessageBox.Show("Anh/chi chua nhap du thong tin.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvDSHoaDon.SelectedRows[0].DataBoundItem).Row;
                DialogResult dr =
                    MessageBox.Show("Anh/chi co muon xoa hoa don " + cn["Món Ăn"] + " khong?",
                    "Thong bao",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cn.Delete();
                    XuLyDuLieu.ghiBang("HoaDon", ThongTinMonAn);
                }
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon ten mon an.", "Thong bao", MessageBoxButtons.OK);
            }
        }

        

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTimKiemSDT_Click(object sender, EventArgs e)
        {
            tbTimKiemSDT.Clear();
            tbTimKiemSDT.ForeColor = Color.Black;
        }

        private void tbTimKiemSDT_Leave(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "")
            {
                tbTimKiemSDT.Text = "Số Điện Thoại";
                tbTimKiemSDT.ForeColor = Color.Gray;
            }
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            float thanhtien=0;
            int i;
            int sl=ThongTinHoaDon.Rows.Count;
            if (dgvDSMonAn.SelectedRows.Count > 0)
            {
                for (i = 0; i < dgvDSMonAn.SelectedRows.Count; i++)
                {
                    DataRow ma = ThongTinMonAn.Rows[dgvDSMonAn.SelectedRows[i].Index];
                    int chiso = TimMATrongDSDHMA(((string)ma["TenMA"]));
                    if (chiso == -1)
                    {
                        DataRow dhma = ThongTinHoaDon.NewRow();
                        dhma["Mã Món Ăn"] = ma["MaMA"];
                        dhma["Tên Món Ăn"] = ma["TenMA"];
                        dhma["Loại Món Ăn"] = ma["TenLoaiMA"];
                        dhma["Số Lượng"] = 1;
                        dhma["Giá"] = ma["DonGia"];
                        ThongTinHoaDon.Rows.Add(dhma);
                        for (i = 0; i < sl - 1; i++)
                            thanhtien += int.Parse(dgvDSHoaDon.Rows[i].Cells["Số Lượng"].Value.ToString())*float.Parse(dgvDSHoaDon.Rows[i].Cells["Giá"].Value.ToString());
                        tbTongTien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        ThongTinHoaDon.Rows[chiso]["Số Lượng"] = (int)ThongTinHoaDon.Rows[chiso]["Số Lượng"] + 1;
                        for(i = 0; i < sl - 1; i++)
                            thanhtien += int.Parse(dgvDSHoaDon.Rows[i].Cells["Số Lượng"].Value.ToString()) * float.Parse(dgvDSHoaDon.Rows[i].Cells["Giá"].Value.ToString());
                        tbTongTien.Text = thanhtien.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon mon an", "Thong bao");
            }
        }
        int TimMATrongDSDHMA(string ma)
        {
            int kq = -1;
            for (int i = 0; i < ThongTinHoaDon.Rows.Count; i++)
            {
                if ((string)ThongTinHoaDon.Rows[i]["Tên Món Ăn"] == ma)
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }

        private void btBot_Click(object sender, EventArgs e)
        {
            if (dgvDSMonAn.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvDSMonAn.SelectedRows.Count; i++)
                {
                    DataRow ma = ThongTinMonAn.Rows[dgvDSMonAn.SelectedRows[i].Index];
                    int chiso = TimMATrongDSDHMA(((string)ma["TenMA"]));
                    if (chiso == -1)
                    {
                        DataRow dhma = ThongTinHoaDon.NewRow();
                        dhma["Mã Món Ăn"] = ma["MaMA"];
                        dhma["Tên Món Ăn"] = ma["TenMA"];
                        dhma["Loại Món Ăn"] = ma["TenLoaiMA"];
                        dhma["Số Lượng"] = 1;
                        dhma["Giá"] = ma["DonGia"];
                        ThongTinHoaDon.Rows.Add(dhma);
                    }
                    else
                    {
                        ThongTinHoaDon.Rows[chiso]["Số Lượng"] = (int)ThongTinHoaDon.Rows[chiso]["Số Lượng"] - 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon mon an", "Thong bao");
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvDSHoaDon.SelectedRows[0].DataBoundItem).Row;
                DialogResult dr =
                    MessageBox.Show("Anh/chi co muon xoa hoa don " + cn["Tên Món Ăn"] + " khong?",
                    "Thong bao",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cn.Delete();
                    XuLyDuLieu.ghiBang("Rong", ThongTinMonAn);
                }
            }
            else
            {
                MessageBox.Show("Anh/chi chua chon ten mon an.", "Thong bao", MessageBoxButtons.OK);
            }
        }
        private void TinhTien()
        {

        }
    }
    }

