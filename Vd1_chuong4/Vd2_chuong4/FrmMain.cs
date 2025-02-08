using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vd2_chuong4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void txta_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(txtA.Text);
                float b = Convert.ToSingle(txtB.Text);
                float tong = a + b;
                lblTong.Text = "Tổng của 2 số trên là:" + tong.ToString();
            }
            catch(Exception ex)
            {
                lblTong.Text = ex.ToString();
            }
        }
        // chi cho phep nhap gia tri kieu so
        private void check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false; //khong nhan
            else e.Handled = true;
        }

        private void lblTong_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
