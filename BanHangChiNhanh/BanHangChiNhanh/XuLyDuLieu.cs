using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace BanHangChiNhanh
{
    class XuLyDuLieu
    {
        
        public static String connectionString = @"Provider=SQLNCLI11;Data Source=HUNGMAX\SQLLAST;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
       
        public static DataTable docDulieu(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
            adapter.Fill(dt);
            return dt;
        }
      
        public static DataTable docBang(string sql)
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
