using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramOfFont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbArial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbArial.Checked)
            {
                txtVanBan.Font = rdbArial.Font;
            }
            else return;
        }

        private void rdbCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCourierNew.Checked)
            {
                txtVanBan.Font = rdbCourierNew.Font;
            }
            else return;
        }

        private void rdbCooper_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCooper.Checked)
            {
                txtVanBan.Font = rdbCooper.Font;
            }
            else return;
        }

        private void rdbTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTahoma.Checked)
            {
                txtVanBan.Font = rdbTahoma.Font;
            }
            else return;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                txtVanBan.Font = new Font(txtVanBan.Font, txtVanBan.Font.Style ^ FontStyle.Bold);
            }
            else return;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                txtVanBan.Font = new Font(txtVanBan.Font, txtVanBan.Font.Style ^ FontStyle.Italic);
            }
            else return;
        }

        private void chkStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStrikeout.Checked)
            {
                txtVanBan.Font = new Font(txtVanBan.Font, txtVanBan.Font.Style ^ FontStyle.Strikeout);
            }
            else return;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked)
            {
                txtVanBan.Font = new Font(txtVanBan.Font, txtVanBan.Font.Style ^ FontStyle.Underline);
            }
            else return;
        }

        private void rdbXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXanh.Checked)
            {
                txtVanBan.ForeColor = Color.Blue;
            }
            else return;
        }

        private void rdbDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDo.Checked)
            {
                txtVanBan.ForeColor = Color.Red;
            }
            else return;
        }

        private void rdbVang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVang.Checked)
            {
                txtVanBan.ForeColor = Color.Yellow;
            }
            else return;
        }

        private void rdbTim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTim.Checked)
            {
                txtVanBan.ForeColor = Color.Violet;
            }
            else return;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rd in grbFont.Controls)
            {
                rd.Checked = false;
            }
            foreach(CheckBox ck in grbHieuUng.Controls)
            {
                ck.Checked = false;
            }
            foreach (RadioButton rd in grbMauChu.Controls)
            {
                rd.Checked = false;
            }
            txtVanBan.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
