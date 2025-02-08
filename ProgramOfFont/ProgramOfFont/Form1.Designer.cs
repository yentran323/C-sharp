
namespace ProgramOfFont
{
    partial class Form1
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
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.rdbTahoma = new System.Windows.Forms.RadioButton();
            this.rdbCooper = new System.Windows.Forms.RadioButton();
            this.rdbCourierNew = new System.Windows.Forms.RadioButton();
            this.rdbArial = new System.Windows.Forms.RadioButton();
            this.grbHieuUng = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.grbMauChu = new System.Windows.Forms.GroupBox();
            this.rdbTim = new System.Windows.Forms.RadioButton();
            this.rdbVang = new System.Windows.Forms.RadioButton();
            this.rdbDo = new System.Windows.Forms.RadioButton();
            this.rdbXanh = new System.Windows.Forms.RadioButton();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtVanBan = new System.Windows.Forms.TextBox();
            this.grbFont.SuspendLayout();
            this.grbHieuUng.SuspendLayout();
            this.grbMauChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFont
            // 
            this.grbFont.Controls.Add(this.rdbTahoma);
            this.grbFont.Controls.Add(this.rdbCooper);
            this.grbFont.Controls.Add(this.rdbCourierNew);
            this.grbFont.Controls.Add(this.rdbArial);
            this.grbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFont.Location = new System.Drawing.Point(26, 80);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(168, 186);
            this.grbFont.TabIndex = 1;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Kiểu Font";
            // 
            // rdbTahoma
            // 
            this.rdbTahoma.AutoSize = true;
            this.rdbTahoma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTahoma.Location = new System.Drawing.Point(15, 149);
            this.rdbTahoma.Name = "rdbTahoma";
            this.rdbTahoma.Size = new System.Drawing.Size(85, 23);
            this.rdbTahoma.TabIndex = 3;
            this.rdbTahoma.TabStop = true;
            this.rdbTahoma.Text = "Tahoma";
            this.rdbTahoma.UseVisualStyleBackColor = true;
            this.rdbTahoma.CheckedChanged += new System.EventHandler(this.rdbTahoma_CheckedChanged);
            // 
            // rdbCooper
            // 
            this.rdbCooper.AutoSize = true;
            this.rdbCooper.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCooper.Location = new System.Drawing.Point(15, 111);
            this.rdbCooper.Name = "rdbCooper";
            this.rdbCooper.Size = new System.Drawing.Size(87, 23);
            this.rdbCooper.TabIndex = 2;
            this.rdbCooper.TabStop = true;
            this.rdbCooper.Text = "Cooper";
            this.rdbCooper.UseVisualStyleBackColor = true;
            this.rdbCooper.CheckedChanged += new System.EventHandler(this.rdbCooper_CheckedChanged);
            // 
            // rdbCourierNew
            // 
            this.rdbCourierNew.AutoSize = true;
            this.rdbCourierNew.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCourierNew.Location = new System.Drawing.Point(15, 72);
            this.rdbCourierNew.Name = "rdbCourierNew";
            this.rdbCourierNew.Size = new System.Drawing.Size(137, 23);
            this.rdbCourierNew.TabIndex = 1;
            this.rdbCourierNew.TabStop = true;
            this.rdbCourierNew.Text = "Courier New";
            this.rdbCourierNew.UseVisualStyleBackColor = true;
            this.rdbCourierNew.CheckedChanged += new System.EventHandler(this.rdbCourierNew_CheckedChanged);
            // 
            // rdbArial
            // 
            this.rdbArial.AutoSize = true;
            this.rdbArial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbArial.Location = new System.Drawing.Point(15, 33);
            this.rdbArial.Name = "rdbArial";
            this.rdbArial.Size = new System.Drawing.Size(58, 22);
            this.rdbArial.TabIndex = 0;
            this.rdbArial.TabStop = true;
            this.rdbArial.Text = "Arial";
            this.rdbArial.UseVisualStyleBackColor = true;
            this.rdbArial.CheckedChanged += new System.EventHandler(this.rdbArial_CheckedChanged);
            // 
            // grbHieuUng
            // 
            this.grbHieuUng.Controls.Add(this.chkUnderline);
            this.grbHieuUng.Controls.Add(this.chkStrikeout);
            this.grbHieuUng.Controls.Add(this.chkItalic);
            this.grbHieuUng.Controls.Add(this.chkBold);
            this.grbHieuUng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHieuUng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbHieuUng.Location = new System.Drawing.Point(207, 80);
            this.grbHieuUng.Name = "grbHieuUng";
            this.grbHieuUng.Size = new System.Drawing.Size(149, 186);
            this.grbHieuUng.TabIndex = 2;
            this.grbHieuUng.TabStop = false;
            this.grbHieuUng.Text = "Hiệu ứng";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(16, 149);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(92, 23);
            this.chkUnderline.TabIndex = 3;
            this.chkUnderline.Text = "UnderLine";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrikeout.Location = new System.Drawing.Point(16, 111);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(83, 23);
            this.chkStrikeout.TabIndex = 2;
            this.chkStrikeout.Text = "Strikeout";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            this.chkStrikeout.CheckedChanged += new System.EventHandler(this.chkStrikeout_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(16, 72);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(61, 23);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(16, 34);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(59, 23);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // grbMauChu
            // 
            this.grbMauChu.Controls.Add(this.rdbTim);
            this.grbMauChu.Controls.Add(this.rdbVang);
            this.grbMauChu.Controls.Add(this.rdbDo);
            this.grbMauChu.Controls.Add(this.rdbXanh);
            this.grbMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMauChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbMauChu.Location = new System.Drawing.Point(371, 79);
            this.grbMauChu.Name = "grbMauChu";
            this.grbMauChu.Size = new System.Drawing.Size(140, 187);
            this.grbMauChu.TabIndex = 2;
            this.grbMauChu.TabStop = false;
            this.grbMauChu.Text = "Màu chữ";
            // 
            // rdbTim
            // 
            this.rdbTim.AutoSize = true;
            this.rdbTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTim.ForeColor = System.Drawing.Color.Violet;
            this.rdbTim.Location = new System.Drawing.Point(15, 149);
            this.rdbTim.Name = "rdbTim";
            this.rdbTim.Size = new System.Drawing.Size(50, 23);
            this.rdbTim.TabIndex = 4;
            this.rdbTim.TabStop = true;
            this.rdbTim.Text = "Tím";
            this.rdbTim.UseVisualStyleBackColor = true;
            this.rdbTim.CheckedChanged += new System.EventHandler(this.rdbTim_CheckedChanged);
            // 
            // rdbVang
            // 
            this.rdbVang.AutoSize = true;
            this.rdbVang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVang.ForeColor = System.Drawing.Color.Yellow;
            this.rdbVang.Location = new System.Drawing.Point(15, 112);
            this.rdbVang.Name = "rdbVang";
            this.rdbVang.Size = new System.Drawing.Size(59, 23);
            this.rdbVang.TabIndex = 3;
            this.rdbVang.TabStop = true;
            this.rdbVang.Text = "Vàng";
            this.rdbVang.UseVisualStyleBackColor = true;
            this.rdbVang.CheckedChanged += new System.EventHandler(this.rdbVang_CheckedChanged);
            // 
            // rdbDo
            // 
            this.rdbDo.AutoSize = true;
            this.rdbDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDo.ForeColor = System.Drawing.Color.Red;
            this.rdbDo.Location = new System.Drawing.Point(15, 73);
            this.rdbDo.Name = "rdbDo";
            this.rdbDo.Size = new System.Drawing.Size(46, 23);
            this.rdbDo.TabIndex = 2;
            this.rdbDo.TabStop = true;
            this.rdbDo.Text = "Đỏ";
            this.rdbDo.UseVisualStyleBackColor = true;
            this.rdbDo.CheckedChanged += new System.EventHandler(this.rdbDo_CheckedChanged);
            // 
            // rdbXanh
            // 
            this.rdbXanh.AutoSize = true;
            this.rdbXanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXanh.ForeColor = System.Drawing.Color.Blue;
            this.rdbXanh.Location = new System.Drawing.Point(15, 33);
            this.rdbXanh.Name = "rdbXanh";
            this.rdbXanh.Size = new System.Drawing.Size(59, 23);
            this.rdbXanh.TabIndex = 1;
            this.rdbXanh.TabStop = true;
            this.rdbXanh.Text = "Xanh";
            this.rdbXanh.UseVisualStyleBackColor = true;
            this.rdbXanh.CheckedChanged += new System.EventHandler(this.rdbXanh_CheckedChanged);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(152, 285);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(100, 33);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(281, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtVanBan
            // 
            this.txtVanBan.Location = new System.Drawing.Point(28, 15);
            this.txtVanBan.Multiline = true;
            this.txtVanBan.Name = "txtVanBan";
            this.txtVanBan.Size = new System.Drawing.Size(482, 53);
            this.txtVanBan.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 339);
            this.Controls.Add(this.txtVanBan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.grbMauChu);
            this.Controls.Add(this.grbHieuUng);
            this.Controls.Add(this.grbFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.grbHieuUng.ResumeLayout(false);
            this.grbHieuUng.PerformLayout();
            this.grbMauChu.ResumeLayout(false);
            this.grbMauChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.RadioButton rdbTahoma;
        private System.Windows.Forms.RadioButton rdbCooper;
        private System.Windows.Forms.RadioButton rdbCourierNew;
        private System.Windows.Forms.RadioButton rdbArial;
        private System.Windows.Forms.GroupBox grbHieuUng;
        private System.Windows.Forms.GroupBox grbMauChu;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.RadioButton rdbTim;
        private System.Windows.Forms.RadioButton rdbVang;
        private System.Windows.Forms.RadioButton rdbDo;
        private System.Windows.Forms.RadioButton rdbXanh;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtVanBan;
    }
}

