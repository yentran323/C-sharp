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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            ChatLieu chatlieu = new ChatLieu();
            chatlieu.ShowDialog();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DAO.setupConnection();
            DAO.openConnection();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DAO.closeConnection();
            this.Close();
        }
    }
}
