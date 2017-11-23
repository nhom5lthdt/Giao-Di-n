using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Quan_Ly_Quan_An
{
    class XuLyDuLieu
    {
        public static String connecionString = @"Provider=SQLNCLI11;Data Source=HUNGMAX\SQLLAST;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";

        public static DataTable docBang(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connecionString);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from " + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connecionString);
        }
    }
}
