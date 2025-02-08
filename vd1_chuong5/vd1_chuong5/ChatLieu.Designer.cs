
namespace vd1_chuong5
{
    partial class ChatLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMacl = new System.Windows.Forms.Label();
            this.lblTencl = new System.Windows.Forms.Label();
            this.txtMacl = new System.Windows.Forms.TextBox();
            this.txtTencl = new System.Windows.Forms.TextBox();
            this.dataGridViewChatLieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMacl
            // 
            this.lblMacl.AutoSize = true;
            this.lblMacl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacl.Location = new System.Drawing.Point(46, 42);
            this.lblMacl.Name = "lblMacl";
            this.lblMacl.Size = new System.Drawing.Size(83, 19);
            this.lblMacl.TabIndex = 2;
            this.lblMacl.Text = "Mã chất liệu";
            // 
            // lblTencl
            // 
            this.lblTencl.AutoSize = true;
            this.lblTencl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTencl.Location = new System.Drawing.Point(46, 96);
            this.lblTencl.Name = "lblTencl";
            this.lblTencl.Size = new System.Drawing.Size(85, 19);
            this.lblTencl.TabIndex = 3;
            this.lblTencl.Text = "Tên chất liệu";
            // 
            // txtMacl
            // 
            this.txtMacl.Location = new System.Drawing.Point(160, 43);
            this.txtMacl.Name = "txtMacl";
            this.txtMacl.Size = new System.Drawing.Size(270, 20);
            this.txtMacl.TabIndex = 4;
            // 
            // txtTencl
            // 
            this.txtTencl.Location = new System.Drawing.Point(160, 97);
            this.txtTencl.Name = "txtTencl";
            this.txtTencl.Size = new System.Drawing.Size(270, 20);
            this.txtTencl.TabIndex = 5;
            // 
            // dataGridViewChatLieu
            // 
            this.dataGridViewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatLieu.Location = new System.Drawing.Point(50, 148);
            this.dataGridViewChatLieu.Name = "dataGridViewChatLieu";
            this.dataGridViewChatLieu.Size = new System.Drawing.Size(525, 153);
            this.dataGridViewChatLieu.TabIndex = 6;
            this.dataGridViewChatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatLieu_CellClick);
            this.dataGridViewChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatLieu_CellContentClick);
            this.dataGridViewChatLieu.Click += new System.EventHandler(this.dataGridViewChatLieu_click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(140, 327);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(232, 327);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(322, 327);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(499, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 30);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(462, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 30);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(410, 327);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(76, 30);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(50, 327);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(76, 30);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewChatLieu);
            this.Controls.Add(this.txtTencl);
            this.Controls.Add(this.txtMacl);
            this.Controls.Add(this.lblTencl);
            this.Controls.Add(this.lblMacl);
            this.Name = "ChatLieu";
            this.Text = "Chất Liệu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMacl;
        private System.Windows.Forms.Label lblTencl;
        private System.Windows.Forms.TextBox txtMacl;
        private System.Windows.Forms.TextBox txtTencl;
        private System.Windows.Forms.DataGridView dataGridViewChatLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
    }
}