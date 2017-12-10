using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace QuanLyQuanAn
{
    class XuLyDuLieu
    {
<<<<<<< HEAD
        public static String connectionString = @"Provider=SQLNCLI11;Data Source=DESKTOP-8KP11NH\TAI;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
=======
        public static String connectionString = @"Provider=SQLOLEDB;Data Source=DESKTOP-NMEJ4QV\MON;Initial Catalog=QuanLyQuanAn;Integrated Security=SSPI";

>>>>>>> 5150963a88f656513a3b40051c69bc39a6010357
        public static DataTable docBang(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from" + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connectionString);
        }
    }
}
