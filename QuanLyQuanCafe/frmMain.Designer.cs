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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnUser = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnChuyenGhepBan = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtKhachCanTra = new System.Windows.Forms.TextBox();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.pnHoaDon = new System.Windows.Forms.Panel();
            this.lstHoaDon = new System.Windows.Forms.ListView();
            this.pnHienThi = new System.Windows.Forms.Panel();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.pnUser.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.pnHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(789, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(91, 42);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.White;
            this.pnUser.Controls.Add(this.btnAdmin);
            this.pnUser.Controls.Add(this.btnUser);
            this.pnUser.Controls.Add(this.btnDangXuat);
            this.pnUser.Location = new System.Drawing.Point(918, 1);
            this.pnUser.MaximumSize = new System.Drawing.Size(91, 120);
            this.pnUser.MinimumSize = new System.Drawing.Size(91, 42);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(91, 43);
            this.pnUser.TabIndex = 19;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdmin.Location = new System.Drawing.Point(0, 41);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(87, 38);
            this.btnAdmin.TabIndex = 20;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUser.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.icons8_admin_settings_male_30;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(87, 42);
            this.btnUser.TabIndex = 18;
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 79);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(87, 38);
            this.btnDangXuat.TabIndex = 19;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.Location = new System.Drawing.Point(555, 368);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(82, 58);
            this.btnThongBao.TabIndex = 4;
            this.btnThongBao.Text = "Thông báo nhà bếp";
            this.btnThongBao.UseVisualStyleBackColor = true;
            // 
            // btnChuyenGhepBan
            // 
            this.btnChuyenGhepBan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChuyenGhepBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenGhepBan.Location = new System.Drawing.Point(640, 368);
            this.btnChuyenGhepBan.Name = "btnChuyenGhepBan";
            this.btnChuyenGhepBan.Size = new System.Drawing.Size(82, 58);
            this.btnChuyenGhepBan.TabIndex = 5;
            this.btnChuyenGhepBan.Text = "Chuyển/ Ghép bàn";
            this.btnChuyenGhepBan.UseVisualStyleBackColor = false;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.Chocolate;
            this.btnInHD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(555, 437);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(82, 54);
            this.btnInHD.TabIndex = 6;
            this.btnInHD.Text = "In";
            this.btnInHD.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(640, 437);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(82, 54);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khách cần trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiền thừa trả khách";
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Location = new System.Drawing.Point(853, 363);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.Size = new System.Drawing.Size(151, 26);
            this.txtTongTienHang.TabIndex = 13;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(853, 392);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(151, 26);
            this.txtGiamGia.TabIndex = 14;
            // 
            // txtKhachCanTra
            // 
            this.txtKhachCanTra.Location = new System.Drawing.Point(853, 422);
            this.txtKhachCanTra.Name = "txtKhachCanTra";
            this.txtKhachCanTra.Size = new System.Drawing.Size(151, 26);
            this.txtKhachCanTra.TabIndex = 15;
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(853, 452);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(151, 26);
            this.txtTienKhachDua.TabIndex = 16;
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(853, 482);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(151, 26);
            this.txtTienThua.TabIndex = 17;
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
            this.pnChucNang.Controls.Add(this.btnKhachhang);
            this.pnChucNang.Controls.Add(this.pnUser);
            this.pnChucNang.Controls.Add(this.btnThongBao);
            this.pnChucNang.Controls.Add(this.btnChuyenGhepBan);
            this.pnChucNang.Controls.Add(this.pnHoaDon);
            this.pnChucNang.Controls.Add(this.txtTienThua);
            this.pnChucNang.Controls.Add(this.pnHienThi);
            this.pnChucNang.Controls.Add(this.btnInHD);
            this.pnChucNang.Controls.Add(this.btnThucDon);
            this.pnChucNang.Controls.Add(this.txtTienKhachDua);
            this.pnChucNang.Controls.Add(this.btnBan);
            this.pnChucNang.Controls.Add(this.btnThanhToan);
            this.pnChucNang.Controls.Add(this.textBox1);
            this.pnChucNang.Controls.Add(this.txtKhachCanTra);
            this.pnChucNang.Controls.Add(this.btnTimKiem);
            this.pnChucNang.Controls.Add(this.label1);
            this.pnChucNang.Controls.Add(this.label4);
            this.pnChucNang.Controls.Add(this.txtGiamGia);
            this.pnChucNang.Controls.Add(this.label5);
            this.pnChucNang.Controls.Add(this.label2);
            this.pnChucNang.Controls.Add(this.label3);
            this.pnChucNang.Controls.Add(this.txtTongTienHang);
            this.pnChucNang.Location = new System.Drawing.Point(2, 0);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1010, 517);
            this.pnChucNang.TabIndex = 20;
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.Controls.Add(this.lstHoaDon);
            this.pnHoaDon.Location = new System.Drawing.Point(555, 49);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(452, 313);
            this.pnHoaDon.TabIndex = 22;
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.HideSelection = false;
            this.lstHoaDon.Location = new System.Drawing.Point(4, 4);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(445, 306);
            this.lstHoaDon.TabIndex = 0;
            this.lstHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // pnHienThi
            // 
            this.pnHienThi.Location = new System.Drawing.Point(0, 49);
            this.pnHienThi.Name = "pnHienThi";
            this.pnHienThi.Size = new System.Drawing.Size(548, 450);
            this.pnHienThi.TabIndex = 21;
            // 
            // btnThucDon
            // 
            this.btnThucDon.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThucDon.Location = new System.Drawing.Point(271, 3);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(125, 42);
            this.btnThucDon.TabIndex = 1;
            this.btnThucDon.Text = "THỰC ĐƠN";
            this.btnThucDon.UseVisualStyleBackColor = false;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBan.Location = new System.Drawing.Point(137, 3);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(125, 42);
            this.btnBan.TabIndex = 0;
            this.btnBan.Text = "BÀN";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKhachhang.Location = new System.Drawing.Point(3, 3);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(125, 42);
            this.btnKhachhang.TabIndex = 23;
            this.btnKhachhang.Text = "KHÁCH HÀNG";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 518);
            this.Controls.Add(this.pnChucNang);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnUser.ResumeLayout(false);
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.pnHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnChuyenGhepBan;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtKhachCanTra;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Panel pnHoaDon;
        private System.Windows.Forms.ListView lstHoaDon;
        private System.Windows.Forms.Panel pnHienThi;
        private System.Windows.Forms.Button btnKhachhang;
    }
        #endregion
}

