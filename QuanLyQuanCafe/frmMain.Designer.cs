namespace QuanLyQuanCafe
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnUser = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnChonBan = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.pnHienThi = new System.Windows.Forms.Panel();
            this.pnUser.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.White;
            this.pnUser.Controls.Add(this.btnAdmin);
            this.pnUser.Controls.Add(this.btnUser);
            this.pnUser.Controls.Add(this.btnDangXuat);
            this.pnUser.Location = new System.Drawing.Point(880, 9);
            this.pnUser.MaximumSize = new System.Drawing.Size(125, 127);
            this.pnUser.MinimumSize = new System.Drawing.Size(125, 42);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(125, 42);
            this.pnUser.TabIndex = 19;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdmin.FlatAppearance.BorderSize = 2;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(0, 42);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(125, 42);
            this.btnAdmin.TabIndex = 20;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnUser.FlatAppearance.BorderSize = 2;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::QuanLyQuanCafe.Properties.Resources.icons8_admin_settings_male_30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(125, 42);
            this.btnUser.TabIndex = 18;
            this.btnUser.Text = "Quản lý";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnDangXuat.FlatAppearance.BorderSize = 2;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 84);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(125, 42);
            this.btnDangXuat.TabIndex = 19;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.White;
            this.pnChucNang.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.background1;
            this.pnChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnChucNang.Controls.Add(this.btnChonBan);
            this.pnChucNang.Controls.Add(this.btnHoaDon);
            this.pnChucNang.Controls.Add(this.btnHome);
            this.pnChucNang.Controls.Add(this.btnDatMon);
            this.pnChucNang.Controls.Add(this.pnUser);
            this.pnChucNang.Controls.Add(this.pnHienThi);
            this.pnChucNang.Location = new System.Drawing.Point(2, 0);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1010, 541);
            this.pnChucNang.TabIndex = 20;
            // 
            // btnChonBan
            // 
            this.btnChonBan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChonBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonBan.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnChonBan.FlatAppearance.BorderSize = 2;
            this.btnChonBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonBan.Image = ((System.Drawing.Image)(resources.GetObject("btnChonBan.Image")));
            this.btnChonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonBan.Location = new System.Drawing.Point(92, 9);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(130, 42);
            this.btnChonBan.TabIndex = 26;
            this.btnChonBan.Text = "CHỌN BÀN";
            this.btnChonBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonBan.UseVisualStyleBackColor = false;
            this.btnChonBan.Click += new System.EventHandler(this.btnChonBan_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnHoaDon.FlatAppearance.BorderSize = 2;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(347, 9);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(125, 42);
            this.btnHoaDon.TabIndex = 25;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.background1;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(10, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 51);
            this.btnHome.TabIndex = 24;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDatMon
            // 
            this.btnDatMon.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDatMon.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnDatMon.FlatAppearance.BorderSize = 2;
            this.btnDatMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDatMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatMon.Image = ((System.Drawing.Image)(resources.GetObject("btnDatMon.Image")));
            this.btnDatMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatMon.Location = new System.Drawing.Point(222, 9);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(125, 42);
            this.btnDatMon.TabIndex = 23;
            this.btnDatMon.Text = "ĐẶT MÓN";
            this.btnDatMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatMon.UseVisualStyleBackColor = false;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // pnHienThi
            // 
            this.pnHienThi.AutoSize = true;
            this.pnHienThi.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.background1;
            this.pnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnHienThi.Location = new System.Drawing.Point(3, 61);
            this.pnHienThi.Name = "pnHienThi";
            this.pnHienThi.Size = new System.Drawing.Size(1002, 478);
            this.pnHienThi.TabIndex = 21;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 540);
            this.Controls.Add(this.pnChucNang);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnUser.ResumeLayout(false);
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Panel pnHienThi;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnChonBan;
    }
        #endregion
}

