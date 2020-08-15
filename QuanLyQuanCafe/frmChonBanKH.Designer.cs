namespace QuanLyQuanCafe
{
    partial class frmChonBanKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonBanKH));
            this.pnHienThi = new System.Windows.Forms.Panel();
            this.grbThemKH = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChonBan = new System.Windows.Forms.GroupBox();
            this.txtMaKH1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChonBan = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHienThi.SuspendLayout();
            this.grbThemKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grbChonBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHienThi
            // 
            this.pnHienThi.AutoSize = true;
            this.pnHienThi.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.background1;
            this.pnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHienThi.Controls.Add(this.grbThemKH);
            this.pnHienThi.Controls.Add(this.grbChonBan);
            this.pnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnHienThi.Location = new System.Drawing.Point(0, 3);
            this.pnHienThi.Name = "pnHienThi";
            this.pnHienThi.Size = new System.Drawing.Size(1000, 477);
            this.pnHienThi.TabIndex = 22;
            // 
            // grbThemKH
            // 
            this.grbThemKH.BackColor = System.Drawing.Color.MintCream;
            this.grbThemKH.Controls.Add(this.txtTenKH);
            this.grbThemKH.Controls.Add(this.label19);
            this.grbThemKH.Controls.Add(this.btnLuuKH);
            this.grbThemKH.Controls.Add(this.btnSuaKH);
            this.grbThemKH.Controls.Add(this.btnThemKH);
            this.grbThemKH.Controls.Add(this.label18);
            this.grbThemKH.Controls.Add(this.txtMaKH);
            this.grbThemKH.Controls.Add(this.dgvKhachHang);
            this.grbThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThemKH.Location = new System.Drawing.Point(7, 8);
            this.grbThemKH.Name = "grbThemKH";
            this.grbThemKH.Size = new System.Drawing.Size(495, 466);
            this.grbThemKH.TabIndex = 1;
            this.grbThemKH.TabStop = false;
            this.grbThemKH.Text = "Thêm khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(192, 101);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(226, 22);
            this.txtTenKH.TabIndex = 115;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 114;
            this.label19.Text = "Tên khách hàng";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuKH.Location = new System.Drawing.Point(287, 146);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(80, 41);
            this.btnLuuKH.TabIndex = 113;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.Image")));
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKH.Location = new System.Drawing.Point(188, 147);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(80, 41);
            this.btnSuaKH.TabIndex = 112;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaKH.UseVisualStyleBackColor = true;
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKH.Location = new System.Drawing.Point(89, 146);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(80, 41);
            this.btnThemKH.TabIndex = 110;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 109;
            this.label18.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(192, 42);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(226, 22);
            this.txtMaKH.TabIndex = 108;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.tenKH});
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 202);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(472, 246);
            this.dgvKhachHang.TabIndex = 107;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "MaKH";
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.Name = "maKH";
            this.maKH.Width = 150;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "TenKH";
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.Name = "tenKH";
            this.tenKH.Width = 150;
            // 
            // grbChonBan
            // 
            this.grbChonBan.BackColor = System.Drawing.Color.MintCream;
            this.grbChonBan.Controls.Add(this.txtMaKH1);
            this.grbChonBan.Controls.Add(this.label3);
            this.grbChonBan.Controls.Add(this.btnChonBan);
            this.grbChonBan.Controls.Add(this.cboTrangThai);
            this.grbChonBan.Controls.Add(this.label2);
            this.grbChonBan.Controls.Add(this.cboBan);
            this.grbChonBan.Controls.Add(this.label1);
            this.grbChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonBan.Location = new System.Drawing.Point(519, 8);
            this.grbChonBan.Name = "grbChonBan";
            this.grbChonBan.Size = new System.Drawing.Size(478, 206);
            this.grbChonBan.TabIndex = 0;
            this.grbChonBan.TabStop = false;
            this.grbChonBan.Text = "Chọn bàn";
            // 
            // txtMaKH1
            // 
            this.txtMaKH1.Location = new System.Drawing.Point(122, 164);
            this.txtMaKH1.Name = "txtMaKH1";
            this.txtMaKH1.Size = new System.Drawing.Size(222, 24);
            this.txtMaKH1.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Mã khách hàng";
            // 
            // btnChonBan
            // 
            this.btnChonBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBan.Image = ((System.Drawing.Image)(resources.GetObject("btnChonBan.Image")));
            this.btnChonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonBan.Location = new System.Drawing.Point(375, 89);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(86, 47);
            this.btnChonBan.TabIndex = 93;
            this.btnChonBan.Text = "Thêm";
            this.btnChonBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonBan.UseVisualStyleBackColor = true;
            this.btnChonBan.Click += new System.EventHandler(this.btnChonBan_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(122, 103);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(222, 24);
            this.cboTrangThai.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Trạng thái";
            // 
            // cboBan
            // 
            this.cboBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(122, 42);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(222, 24);
            this.cboBan.TabIndex = 90;
            this.cboBan.SelectedIndexChanged += new System.EventHandler(this.cboBan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Số bàn";
            // 
            // frmChonBanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 488);
            this.Controls.Add(this.pnHienThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonBanKH";
            this.Text = "frmChonBanKH";
            this.Load += new System.EventHandler(this.frmChonBanKH_Load);
            this.pnHienThi.ResumeLayout(false);
            this.grbThemKH.ResumeLayout(false);
            this.grbThemKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grbChonBan.ResumeLayout(false);
            this.grbChonBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHienThi;
        private System.Windows.Forms.GroupBox grbThemKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grbChonBan;
        private System.Windows.Forms.Button btnChonBan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH1;
    }
}