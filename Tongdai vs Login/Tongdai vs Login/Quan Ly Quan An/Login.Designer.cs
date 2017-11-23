namespace Quan_Ly_Quan_An
{
    partial class DangNhap
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
            this.nhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.TaiKhoan = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nhap
            // 
            this.nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhap.ForeColor = System.Drawing.Color.Black;
            this.nhap.Location = new System.Drawing.Point(249, 236);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(94, 44);
            this.nhap.TabIndex = 3;
            this.nhap.Text = "Đăng Nhập";
            this.nhap.UseVisualStyleBackColor = false;
            this.nhap.Click += new System.EventHandler(this.nhap_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(385, 236);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(94, 44);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSize = true;
            this.TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaiKhoan.Location = new System.Drawing.Point(58, 90);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(77, 19);
            this.TaiKhoan.TabIndex = 2;
            this.TaiKhoan.Text = "Username";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(63, 159);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(72, 19);
            this.MatKhau.TabIndex = 3;
            this.MatKhau.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(174, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quan_Ly_Quan_An.Properties.Resources.do_uong_ngon_nhat_the_gioi41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.thoat);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nhap;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label TaiKhoan;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

