using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace vd1_chuong5
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // kết nối cơ sở dữ liệu
            //SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;" +
                "Initial Catalog=quanlybanhang;Integrated Security=True";
            try
            {
                con.Open();
                // thiết lập cầu nối tới csdl
                string sql = "SELECT *  FROM tblChatlieu";
                SqlDataAdapter mydata = new SqlDataAdapter(sql,con);
                DataTable mytable = new DataTable();
                mydata.Fill(mytable);
                dataGridChatLieu.DataSource = mytable;
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macl = txtMaChatLieu.Text;
            string tencl = txtTenChatLieu.Text;
            string sql = "Insert Into tblChatlieu values ('" + macl + "',N'" +
                tencl + "')";
            MessageBox.Show(sql);
            try
            {
                // thực hiện cập nhật dữ liệu

                con.Open();
                SqlCommand mycommand = new SqlCommand(sql, con);
                mycommand.ExecuteNonQuery();

                //thực hiện việc lấy dữ liệu ra
                sql = "Select * from tblChatlieu";
                SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
                DataTable mytable = new DataTable();
                myadapter.Fill(mytable);
                dataGridChatLieu.DataSource = mytable;
                //if (con.State == ConnectionState.Open) 
                    con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
