using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vd1_chuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            float SoThuNhat = Convert.ToSingle(txtSoThuNhat.Text);
            float SoThuHai = Convert.ToSingle(txtSoThuHai.Text);
            float tong = SoThuNhat + SoThuHai;
            label3.Text = "Tổng của hai số trên là:" + tong.ToString();
        }
    }
}
