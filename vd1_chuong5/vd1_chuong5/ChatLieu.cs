using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd1_chuong5
{
    public partial class ChatLieu : Form
    {
        public ChatLieu()
        {
            InitializeComponent();
        }
        private void dataGridViewChatLieu_click(object sender, EventArgs e)
        {
            txtMacl.Text = dataGridViewChatLieu.CurrentRow.Cells["machatlieu"].Value.ToString();
            txtTencl.Text = dataGridViewChatLieu.CurrentRow.Cells["tenchatlieu"].Value.ToString();
            txtMacl.Enabled = false;
        }
        private void ChatLieu_Load(object sender, EventArgs e)
        {
            //DAO.setupConnection();
            try
            {
                //DAO.openConnection();
                LoadDatatoGridView();
                //DAO.closeConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadDatatoGridView()
        {
            string sql = "select * from tblChatlieu";
            DataTable datachatlieu = DAO.getdatatoTable(sql);
            dataGridViewChatLieu.DataSource = datachatlieu;
        }

        private void dataGridViewChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macl = txtMacl.Text;
            string tencl = txtTencl.Text.Trim();
            string sql = "Update tblChatlieu set tenchatlieu = N'" +
                tencl + "' " + "where machatlieu ='" + macl + "'";
            if(tencl == "")
            {
                MessageBox.Show("Ten chat lieu khong duoc de trong");
                txtTencl.Focus();
                return;
            }
            else
            {
                try
                {
                    //DAO.openConnection();
                    DAO.executeQuery(sql);
                    LoadDatatoGridView();
                    //DAO.closeConnection();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macl = txtMacl.Text;
            string tencl = txtTencl.Text;
            string sql = "Insert Into tblChatlieu values ('" + macl + "',N'" +
                tencl + "')";
            MessageBox.Show(sql);
            try
            {
                //DAO.openConnection();
                DAO.executeQuery(sql);
                LoadDatatoGridView();
                //DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
