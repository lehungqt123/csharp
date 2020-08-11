namespace QuanLyQuanCafe
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnInCT = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(668, 200);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(135, 20);
            this.txtTongTien.TabIndex = 95;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(552, 202);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 94;
            this.label20.Text = "Tổng tiền";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(668, 85);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(135, 21);
            this.cboMaNV.TabIndex = 93;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(552, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 92;
            this.label19.Text = "Tên nhân viên";
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuuHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHD.Image")));
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(786, 267);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(74, 41);
            this.btnLuuHD.TabIndex = 91;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnInCT
            // 
            this.btnInCT.Image = ((System.Drawing.Image)(resources.GetObject("btnInCT.Image")));
            this.btnInCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCT.Location = new System.Drawing.Point(787, 332);
            this.btnInCT.Name = "btnInCT";
            this.btnInCT.Size = new System.Drawing.Size(73, 38);
            this.btnInCT.TabIndex = 90;
            this.btnInCT.Text = "In";
            this.btnInCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInCT.UseVisualStyleBackColor = true;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHD.Image")));
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(702, 267);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(74, 41);
            this.btnSuaHD.TabIndex = 89;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHD.Image")));
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(618, 267);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(74, 41);
            this.btnXoaHD.TabIndex = 88;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHD.Image")));
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(534, 267);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(74, 41);
            this.btnThemHD.TabIndex = 87;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(552, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "Ngày lập";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(552, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(668, 28);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(135, 20);
            this.txtMaHD.TabIndex = 84;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 1);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(501, 369);
            this.dgvHoaDon.TabIndex = 83;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(668, 143);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(135, 20);
            this.dtpNgayLap.TabIndex = 96;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 391);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.btnInCT);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnInCT;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}