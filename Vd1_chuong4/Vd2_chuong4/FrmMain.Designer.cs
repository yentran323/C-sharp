
namespace Vd2_chuong4
{
    partial class FrmMain
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.bntTinhTong = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(51, 39);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 19);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a";
            this.lblA.Click += new System.EventHandler(this.txta_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(110, 38);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(307, 26);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_KeyPress);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(51, 85);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 19);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "b";
            this.lblB.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(112, 78);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(305, 26);
            this.txtB.TabIndex = 3;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_KeyPress);
            // 
            // bntTinhTong
            // 
            this.bntTinhTong.Location = new System.Drawing.Point(136, 126);
            this.bntTinhTong.Name = "bntTinhTong";
            this.bntTinhTong.Size = new System.Drawing.Size(85, 29);
            this.bntTinhTong.TabIndex = 4;
            this.bntTinhTong.Text = "Tính tổng";
            this.bntTinhTong.UseVisualStyleBackColor = true;
            this.bntTinhTong.Click += new System.EventHandler(this.bntTinhTong_Click);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(26, 174);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(0, 19);
            this.lblTong.TabIndex = 5;
            this.lblTong.Click += new System.EventHandler(this.lblTong_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 306);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.bntTinhTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button bntTinhTong;
        private System.Windows.Forms.Label lblTong;
    }
}

