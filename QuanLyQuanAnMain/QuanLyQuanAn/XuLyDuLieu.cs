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
        public static String connectionString = @"Provider=SQLNCLI11;Data Source=HUNGMAX\SQLLAST;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";

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
