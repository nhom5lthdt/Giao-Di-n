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
<<<<<<< HEAD
//<<<<<<< HEAD
=======
>>>>>>> 6aa8d23b5f00d57bc735f5c164d078d050a45aa4
        public static String connectionString = @"Provider=SQLNCLI11;Data Source=HUNGMAX\SQLLAST;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";

<<<<<<< HEAD
//>>>>>>> 5150963a88f656513a3b40051c69bc39a6010357
=======
        public static String connectionString = @"Provider=SQLNCLI11;Data Source=DESKTOP-8KP11NH\TAI;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
>>>>>>> parent of 8019177... Merge branch 'master' of https://github.com/nhom5lthdt/Giao-Di-n
=======
>>>>>>> 6aa8d23b5f00d57bc735f5c164d078d050a45aa4
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

        public static DataTable docDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.FillSchema(dt, SchemaType.Source);
            return dt;
        }
        public static void ghiDuLieu(String tenBang, DataTable dt)
        {
            String sql = "Select * from" + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}
