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
    public partial class fThemmenu : Form
    {
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable menu;
        DataView menuview;
        Admin f = new Admin();
        bool da= false;
        int i = 0;
        public fThemmenu()
        {
            InitializeComponent();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //for (int j = 0; j < dgvaddmenu.Rows.Count - 1; j++)
            //{
            //    if (dgvfood.SelectedRows[0] == dgvaddmenu.Rows[j])
            //    {
            //        da = true;
            //    }
            //    else
            //        da = false;
            //}

            //if ((bientoancuc.c>0)&&(dgvfood.SelectedRows.Count > 0) && da==false)
            //{


                
                DataRow cn = ((DataRowView)dgvfood.SelectedRows[0].DataBoundItem).Row;
                DataRow mn = bientoancuc.dsMn.NewRow();
                mn["MaMA"] = cn["MaMA"];
                mn["TenMAmenu"] = cn["TenMA"];
                mn["MaDM"] = cn["MaDM"];
                mn["MaCN"] = bientoancuc.masomn;
                mn["MaMN"] =  bientoancuc.masomn;
                mn["Gia"] = cn["DonGia"];
                bientoancuc.dsMn.Rows.Add(mn);
                XuLyDuLieu.ghiBang("Menu", bientoancuc.dsMn);



            //}
            //else
            //{
            //    MessageBox.Show("Mon da co roi moi chon mon khac/ hoac chua chon mon.", "ThongBao", MessageBoxButtons.OK);
            //}
        }
       







        private void dgvfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fThemmenu_Load(object sender, EventArgs e)
        {
            dsMonAn = XuLyDuLieu.docBang("Select *From MonAn");
            dsMonAnView = new DataView(dsMonAn);
            dgvfood.DataSource = dsMonAnView;

            
            menuview = new DataView(bientoancuc.dsMn);
            dgvaddmenu.DataSource = menuview;

        }

        private void btremove_Click(object sender, EventArgs e)
        {
            while (dgvaddmenu.SelectedRows.Count > 0)
            {


                DataRow cn = ((DataRowView)dgvaddmenu.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("Menu", menu);


            }
        }

        private void btxong_Click(object sender, EventArgs e)
        {

            bientoancuc.dsMn = this.dsMonAn;
            this.Hide();
            
            
        }
    }
}
