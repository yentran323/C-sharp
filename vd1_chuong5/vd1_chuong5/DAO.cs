using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace vd1_chuong5
{
    class DAO
    {
        public static SqlConnection con;
        private static string connectionString = "Data Source=localhost\\SQLEXPRESS;" +
                "Initial Catalog=quanlybanhang;Integrated Security=True";
        public static void setupConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
        }
        public static void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public static void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //trường giá trị
            cbo.DisplayMember = ten; //trường hiển thị
        }
        public static DataTable getdatatoTable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            return mytable;
        }
        public static void executeQuery(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            mycommand.ExecuteNonQuery();
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static bool check_key_exit(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            if (mytable.Rows.Count >= 1)
                return true;
            else  return false;
        }
    }
}
