using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NMEJ4QV\MON;Initial Catalog=QuanLyQuanAn;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "SELECT HoaDon.MaHD,MaCN,MaBan,Datein,Dateout,MaMA,SLMA,TongTien FROM HoaDon, ChiTietHoaDon WHERE TrangThai = '1' AND HoaDon.MaHD = ChiTietHoaDon.MaHD";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
