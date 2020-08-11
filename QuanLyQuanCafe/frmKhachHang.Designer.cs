namespace QuanLyQuanCafe
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.label19 = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 105;
            this.label19.Text = "Tên khách hàng";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuKH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKH.Image")));
            this.btnLuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuKH.Location = new System.Drawing.Point(271, 89);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(74, 41);
            this.btnLuuKH.TabIndex = 104;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKH.Image")));
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKH.Location = new System.Drawing.Point(187, 89);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(74, 41);
            this.btnSuaKH.TabIndex = 103;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.Image")));
            this.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKH.Location = new System.Drawing.Point(103, 89);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(74, 41);
            this.btnXoaKH.TabIndex = 102;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKH.Location = new System.Drawing.Point(19, 89);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(74, 41);
            this.btnThemKH.TabIndex = 101;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 99;
            this.label18.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(162, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(135, 20);
            this.txtMaKH.TabIndex = 98;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 149);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(338, 239);
            this.dgvKhachHang.TabIndex = 97;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(162, 56);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(135, 20);
            this.txtTenKH.TabIndex = 106;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 404);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnLuuKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
    }
}