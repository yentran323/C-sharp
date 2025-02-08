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
    public partial class SanPham : Form
    {
        bool cmbCanChange = false;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            cmbCanChange = false;
            DAO.setupConnection();
            try
            {
                DAO.openConnection();
                string sql;
                txtMaHang.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                sql = "SELECT Machatlieu,  Tenchatlieu from tblChatlieu";
                DAO.FillCombo(sql, cmbChatLieu, "Machatlieu", "Tenchatlieu");
                cmbChatLieu.SelectedIndex = -1;
                LoadDataGridView();
                //DAO.closeConnection();
                cmbCanChange = true;//khi load xong có thể thay đổi dữ liệu datagridview theo comboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT mahang, tenhang, machatlieu, soluong, gia, picture from tblHang";
            DataTable tblH = DAO.getdatatoTable(sql);
            // cau hinh bang
            dataGridViewHang.DataSource = tblH;
            
            dataGridViewHang.Columns[0].HeaderText = "Mã hàng";
            dataGridViewHang.Columns[1].HeaderText = "Tên hàng";
            dataGridViewHang.Columns[2].HeaderText = "Chất liệu";
            dataGridViewHang.Columns[3].HeaderText = "Số lượng";
            dataGridViewHang.Columns[4].HeaderText = "Đơn giá";
            dataGridViewHang.Columns[5].HeaderText = "Ảnh";
            dataGridViewHang.Columns[0].Width = 80;
            dataGridViewHang.Columns[1].Width = 140;
            dataGridViewHang.Columns[2].Width = 80;
            dataGridViewHang.Columns[3].Width = 100;
            dataGridViewHang.Columns[4].Width = 100;
            dataGridViewHang.Columns[5].Width = 100;
            
            dataGridViewHang.AllowUserToAddRows = false;
            dataGridViewHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            cmbCanChange = true;
        }
        private void dataGridViewHang_Click(object sender, EventArgs e)
        {
            string machatlieu;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (dataGridViewHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                //DAO.openConnection();
                txtMaHang.Text = dataGridViewHang.CurrentRow.Cells["mahang"].Value.ToString();
                txtTenHang.Text = dataGridViewHang.CurrentRow.Cells["tenhang"].Value.ToString();
                machatlieu = dataGridViewHang.CurrentRow.Cells["Machatlieu"].Value.ToString();
                txtAnh.Text = dataGridViewHang.CurrentRow.Cells["picture"].Value.ToString();
                sql = "SELECT tenchatlieu FROM tblChatlieu WHERE Machatlieu='" + machatlieu + "'";
                cmbChatLieu.Text = DAO.GetFieldValues(sql);
                txtSoLuong.Text = dataGridViewHang.CurrentRow.Cells["soluong"].Value.ToString();
                txtGia.Text = dataGridViewHang.CurrentRow.Cells["gia"].Value.ToString();
                picAnh.Image = Image.FromFile(txtAnh.Text);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                //DAO.closeConnection();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
        }
        private void cmbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCanChange)
            {
                try
                {
                    //DAO.openConnection();
                    string ma = cmbChatLieu.SelectedValue.ToString();
                    // MessageBox.Show(ma);
                    string sql = "SELECT mahang, tenhang, machatlieu, soluong, gia, picture from tblHang" +
                        " where machatlieu = '" + ma + "'";
                    // MessageBox.Show(sql);

                    DataTable mytable = DAO.getdatatoTable(sql);
                    dataGridViewHang.DataSource = mytable;
                    //DAO.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //  hien thi du lieu cac sp tuong ung vao datagridview
            }
            else
                return;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = "";
            txtMaHang.Enabled = true;
            txtAnh.Text = "";
            txtGia.Text = "";
            txtSoLuong.Clear();
            txtTenHang.Clear();
            btnLuu.Enabled = true;
            cmbCanChange = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim()=="")
            {
                MessageBox.Show("Không được để trống mã hàng");
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên hàng");
                txtTenHang.Focus();
                return;
            }
            if (txtGia.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống giá");
                txtGia.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống số lượng");
                txtSoLuong.Focus();
                return;
            }
            if (txtAnh.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống ảnh");
                txtAnh.Focus();
                return;
            }
            string sql_check_key = "select * from tblHang where mahang = '"
                + txtMaHang.Text.Trim() + "'";
            if (DAO.check_key_exit(sql_check_key)==true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
                txtMaHang.Focus();
                return;
            }    
            string macl = cmbChatLieu.SelectedValue.ToString();
            string sql = "Insert into tblHang values('" + txtMaHang.Text.Trim() 
                + "','" + macl + "', '" + txtAnh.Text + "'," + txtGia.Text.Trim()
                + ", " + txtSoLuong.Text.Trim() + ",N'" + txtTenHang.Text.Trim() + "')";
            MessageBox.Show(sql);
            try
            {
                //DAO.openConnection();
                DAO.executeQuery(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadDataGridView();
                //DAO.closeConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtAnh.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from tblHang where mahang=" + txtMaHang.Text;
            try
            {
                //DAO.openConnection();
                DAO.executeQuery(sql);
                MessageBox.Show("Xoá dữ liệu thành công");
                LoadDataGridView();
                //DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update tblHang set tenhang= N'" + txtTenHang.Text.Trim() +
                "', gia=" + txtGia.Text.Trim() + ", soluong=" + txtSoLuong.Text.Trim() 
                + ", picture='" + txtAnh.Text + "' where mahang =" + txtMaHang.Text;
            MessageBox.Show(sql);
            try
            {
                //DAO.openConnection();
                DAO.executeQuery(sql);
                MessageBox.Show("Sửa dữ liệu thành công");
                LoadDataGridView();
                //DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
