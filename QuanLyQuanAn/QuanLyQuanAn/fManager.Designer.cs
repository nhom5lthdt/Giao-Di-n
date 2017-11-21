namespace QuanLyQuanAn
{
    partial class fManager
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
            this.bquanlychinhanh = new System.Windows.Forms.Button();
            this.bdanhmucmonan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bbaocao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTInTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bquanlychinhanh
            // 
            this.bquanlychinhanh.Location = new System.Drawing.Point(44, 91);
            this.bquanlychinhanh.Name = "bquanlychinhanh";
            this.bquanlychinhanh.Size = new System.Drawing.Size(231, 118);
            this.bquanlychinhanh.TabIndex = 0;
            this.bquanlychinhanh.Text = "Quản Lý Chi Nhánh";
            this.bquanlychinhanh.UseVisualStyleBackColor = true;
            this.bquanlychinhanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdanhmucmonan
            // 
            this.bdanhmucmonan.Location = new System.Drawing.Point(385, 91);
            this.bdanhmucmonan.Name = "bdanhmucmonan";
            this.bdanhmucmonan.Size = new System.Drawing.Size(231, 118);
            this.bdanhmucmonan.TabIndex = 1;
            this.bdanhmucmonan.Text = "Quản Lý Món Ăn";
            this.bdanhmucmonan.UseVisualStyleBackColor = true;
            this.bdanhmucmonan.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quản Lý";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bbaocao
            // 
            this.bbaocao.Location = new System.Drawing.Point(222, 261);
            this.bbaocao.Name = "bbaocao";
            this.bbaocao.Size = new System.Drawing.Size(231, 118);
            this.bbaocao.TabIndex = 4;
            this.bbaocao.Text = "Báo Cáo";
            this.bbaocao.UseVisualStyleBackColor = true;
            this.bbaocao.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTInTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTInTàiKhoảnToolStripMenuItem
            // 
            this.thôngTInTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTInTàiKhoảnToolStripMenuItem.Name = "thôngTInTàiKhoảnToolStripMenuItem";
            this.thôngTInTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.thôngTInTàiKhoảnToolStripMenuItem.Text = "Thông TIn Tài Khoản";
            this.thôngTInTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTInTàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.bbaocao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bdanhmucmonan);
            this.Controls.Add(this.bquanlychinhanh);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.Text = "Phần Mềm Quản Lý Quán Ăn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bquanlychinhanh;
        private System.Windows.Forms.Button bdanhmucmonan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bbaocao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTInTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}