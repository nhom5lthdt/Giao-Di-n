namespace QuanLyQuanAn
{
    partial class fThemmenu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel32 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvfood = new System.Windows.Forms.DataGridView();
            this.btadd = new System.Windows.Forms.Button();
            this.btremove = new System.Windows.Forms.Button();
            this.dgvaddmenu = new System.Windows.Forms.DataGridView();
            this.btxong = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.panel32.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaddmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel32);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(592, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 539);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.dgvaddmenu);
            this.panel32.Location = new System.Drawing.Point(6, 24);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(305, 498);
            this.panel32.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 539);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Món Ăn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvfood);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 498);
            this.panel1.TabIndex = 9;
            // 
            // dgvfood
            // 
            this.dgvfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfood.Location = new System.Drawing.Point(0, 0);
            this.dgvfood.Name = "dgvfood";
            this.dgvfood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfood.Size = new System.Drawing.Size(354, 495);
            this.dgvfood.TabIndex = 0;
            this.dgvfood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfood_CellContentClick);
            this.dgvfood.SelectionChanged += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(433, 209);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(115, 77);
            this.btadd.TabIndex = 46;
            this.btadd.Text = ">>";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btremove
            // 
            this.btremove.Location = new System.Drawing.Point(434, 380);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(114, 75);
            this.btremove.TabIndex = 47;
            this.btremove.Text = "<<";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // dgvaddmenu
            // 
            this.dgvaddmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaddmenu.Location = new System.Drawing.Point(3, 3);
            this.dgvaddmenu.Name = "dgvaddmenu";
            this.dgvaddmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvaddmenu.Size = new System.Drawing.Size(299, 495);
            this.dgvaddmenu.TabIndex = 0;
            this.dgvaddmenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfood_CellContentClick);
            this.dgvaddmenu.SelectionChanged += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btxong
            // 
            this.btxong.Location = new System.Drawing.Point(429, 528);
            this.btxong.Name = "btxong";
            this.btxong.Size = new System.Drawing.Size(132, 62);
            this.btxong.TabIndex = 48;
            this.btxong.Text = "Xong";
            this.btxong.UseVisualStyleBackColor = true;
            this.btxong.Click += new System.EventHandler(this.btxong_Click);
            // 
            // fThemmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 623);
            this.Controls.Add(this.btxong);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "fThemmenu";
            this.Text = "fThemmenu";
            this.Load += new System.EventHandler(this.fThemmenu_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaddmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btremove;
        public System.Windows.Forms.DataGridView dgvfood;
        public System.Windows.Forms.DataGridView dgvaddmenu;
        private System.Windows.Forms.Button btxong;
    }
}