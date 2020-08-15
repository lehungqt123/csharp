using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace QuanLyQuanCafe
{
    public partial class frmQuanLy : Form
    {
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        NhaCungCap_BLL ncc_bll = new NhaCungCap_BLL();
        HoaDon_BLL hd_bll = new HoaDon_BLL();
        ThucDon_BLL td_bll = new ThucDon_BLL();
        LoaiTD_BLL ltd_bll = new LoaiTD_BLL();
        TaiKhoan_BLL tk_bll = new TaiKhoan_BLL();
        bool add = false, update = false;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            pbThucDon.SizeMode = PictureBoxSizeMode.StretchImage;

            //XỬ LÝ NHÂN VIÊN
            dgvNhanVien.DataSource = nv_bll.loadNhanVien();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtMaNV.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtTenNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtLuong.Enabled = false;

            btnLuu.Enabled = false;
            btnXoaNV.Enabled = false;
            btnSuaNV.Enabled = false;
            //XỬ LÝ HÓA ĐƠN
            //XỬ LÝ THỰC ĐƠN
            dgvThucDon.DataSource = td_bll.loadThucDon();
            dgvThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboLoai.DataSource = ltd_bll.loadLoaiTD();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";

            txtMaMon.Enabled = false;
            cboLoai.Enabled = false;
            txtTenMon.Enabled = false;
            txtDonGia.Enabled = false;
            txtHinhMon.Enabled = false;

            btnLuuTD.Enabled = false;
            btnXoaTD.Enabled = false;
            btnSuaTD.Enabled = false;
            //XỬ LÝ NHÀ CUNG CẤP
            dgvNhaCC.DataSource = ncc_bll.loadNhaCC();
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtMaNCC.Enabled = false;
            cboMaLoai.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

            btnLuuNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;

            cboMaLoai.DataSource = ltd_bll.loadLoaiTD();
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";

            //XỬ LÝ KHÁCH HÀNG
            //XỬ LÝ LOẠI THỰC ĐƠN
            dgvLoaiThucDon.DataSource = ltd_bll.loadLoaiTD();
            dgvLoaiThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtMaLoai.Enabled = false;

            btnLuuLoai.Enabled = false;
            btnXoaLoai.Enabled = false;
            btnSuaLoai.Enabled = false;

            //XỬ LÝ NGƯỜI DÙNG
            dgvNguoiDung.DataSource = tk_bll.loadTaiKhoan();
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboMaNVD.DataSource = nv_bll.loadNhanVien();
            cboMaNVD.DisplayMember = "TenNV";
            cboMaNVD.ValueMember = "MaNV";

            cboTrangThaiHD.DataSource = tk_bll.loadTaiKhoan();
            cboTrangThaiHD.DisplayMember = "HoatDong";


            txtTenDN.Enabled = false;
            txtMatKhau.Enabled = false;
            cboTrangThaiHD.Enabled = false;
            cboMaNVD.Enabled = false;

            btnLuuND.Enabled = false;
            btnSuaND.Enabled = false;
            btnXoaND.Enabled = false;
        }

       

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.Show();
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //XỬ LÝ QUẢN LÝ NHÂN VIÊN
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaNV.Enabled = true;
            btnSuaNV.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
                //txtAnh.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();

                //pbChanDung.Image = Image.FromFile(@"..//..//Images//" + dgvNhanVien.Rows[numrow].Cells[5].Value.ToString());
            }
            catch
            {
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txtTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtLuong.Enabled = true;
            btnLuu.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            if(dgvNhanVien.RowCount<=0)
            {
                txtMaNV.Text = "NV01";
            }
            else
            {
                txtMaNV.Text = nv_bll.getMaNhanVien();
            }
            add = true;
            update = false;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nv_bll.xoa1NhanVien(txtMaNV.Text);
                MessageBox.Show("Thành Công!");
                frmQuanLy_Load(sender, e);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtLuong.Enabled = true;
            add = false;
            update = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maNV = txtMaNV.Text;
                    string tenNV = txtTenNV.Text;
                    DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
                    string gioiTinh = cboGioiTinh.Text;
                    int luong = int.Parse(txtLuong.Text);
                    nv_bll.them1NhanVien(maNV, tenNV, ngaySinh, gioiTinh, luong, "");
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maNV = txtMaNV.Text;
                    string tenNV = txtTenNV.Text;
                    DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
                    string gioiTinh = cboGioiTinh.Text;
                    int luong = int.Parse(txtLuong.Text);
                    nv_bll.sua1NhanVien(maNV, tenNV, ngaySinh, gioiTinh, luong, null);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
        }



        //XỬ LÝ QUẢN LÝ THỰC ĐƠN
        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaTD.Enabled = true;
            btnSuaTD.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaMon.Text = dgvThucDon.Rows[numrow].Cells[0].Value.ToString();
                cboLoai.Text = dgvThucDon.Rows[numrow].Cells[1].Value.ToString();
                cboLoai.Text =dgvThucDon.Rows[numrow].Cells[2].Value.ToString();
                txtTenMon.Text = dgvThucDon.Rows[numrow].Cells[3].Value.ToString();
                txtDonGia.Text = dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                txtHinhMon.Text = dgvThucDon.Rows[numrow].Cells[5].Value.ToString();
                //txtAnh.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();

                pbThucDon.Image = Image.FromFile(@"..//..//Images//" + dgvThucDon.Rows[numrow].Cells[5].Value.ToString());
            }
            catch
            {
            }
        }
        private void btnThemTD_Click(object sender, EventArgs e)
        {
            cboLoai.Enabled = true;
            txtTenMon.Enabled = true;
            txtDonGia.Enabled = true;
            txtHinhMon.Enabled = true;
            btnLuuTD.Enabled = true;
            btnXoaTD.Enabled = false;
            btnSuaTD.Enabled = false;
            if (dgvThucDon.RowCount <= 0)
            {
                txtMaMon.Text = "M001";
            }
            else
            {
                txtMaMon.Text = td_bll.getMaThucDon();
            }
            add = true;
            update = false;
        }
        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                td_bll.xoa1ThucDon(txtMaMon.Text);
                MessageBox.Show("Thành Công!");
                frmQuanLy_Load(sender, e);
            }
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            btnLuuTD.Enabled = true;
            cboLoai.Enabled = true;
            txtTenMon.Enabled = true;
            txtDonGia.Enabled = true;
            txtHinhMon.Enabled = true;
            add = false;
            update = true;
        }

        private void btnLuuTD_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maMon = txtMaMon.Text;
                    string maLoai = cboLoai.SelectedValue.ToString();
                    string tenMon = txtTenMon.Text;
                    int donGia = int.Parse(txtDonGia.Text);
                    string hinhMon = txtHinhMon.Text;
                    td_bll.them1ThucDon(maMon, maLoai, tenMon, donGia, hinhMon);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maMon = txtMaMon.Text;
                    string maLoai = cboLoai.SelectedValue.ToString();
                    string tenMon = txtTenMon.Text;
                    int donGia = int.Parse(txtDonGia.Text);
                    string hinhMon = txtHinhMon.Text;
                    td_bll.sua1ThucDon(maMon, maLoai, tenMon, donGia, hinhMon);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
        }



        //XỬ LÝ QUẢN LÝ LOẠI THỰC ĐƠN
        private void dgvLoaiThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaLoai.Enabled = true;
            btnSuaLoai.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaLoai.Text = dgvLoaiThucDon.Rows[numrow].Cells[0].Value.ToString();
                txtTenLoai.Text = dgvLoaiThucDon.Rows[numrow].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            txtTenLoai.Enabled = true;
            btnLuuLoai.Enabled = true;
            btnSuaLoai.Enabled = false;
            btnXoaLoai.Enabled = false;
            if (dgvLoaiThucDon.RowCount <= 0)
            {
                txtMaLoai.Text = "L001";
            }
            else
            {
                txtMaLoai.Text = ltd_bll.getMaLoaiTD();
            }
            add = true;
            update = false;
        }
        private void btnXoaLoai_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ltd_bll.xoa1LoaiTD(txtMaLoai.Text);
                MessageBox.Show("Thành Công!");
                frmQuanLy_Load(sender, e);
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            btnLuuLoai.Enabled = true;
            txtTenLoai.Enabled = true;
            add = false;
            update = true;
        }

        private void btnLuuLoai_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maLoai = txtMaLoai.Text;
                    string tenLoai = txtTenLoai.Text;
                    ltd_bll.them1LoaiTD(maLoai, tenLoai);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maLoai = txtMaLoai.Text;
                    string tenLoai = txtTenLoai.Text;
                    ltd_bll.sua1LoaiTD(maLoai, tenLoai);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
        }
        //XỬ LÝ QUẢN LÝ NHÀ CUNG CẤP
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaNCC.Text = dgvNhaCC.Rows[numrow].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCC.Rows[numrow].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCC.Rows[numrow].Cells[2].Value.ToString();
                txtSDT.Text = dgvNhaCC.Rows[numrow].Cells[3].Value.ToString();
                cboMaLoai.Text = dgvNhaCC.Rows[numrow].Cells[5].Value.ToString();
            }
            catch
            {
            }
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();

            txtTenNCC.Enabled = true;
            cboMaLoai.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            btnLuuNCC.Enabled = true;
            btnXoaNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            if (dgvNhaCC.RowCount <= 0)
            {
                txtMaNCC.Text = "NCC01";
            }
            else
            {
                txtMaNCC.Text = ncc_bll.getMaNhaCungCap();
            }
            add = true;
            update = false;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ncc_bll.xoa1NhaCungCap(txtMaNCC.Text);
                MessageBox.Show("Thành Công!");
                frmQuanLy_Load(sender, e);
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            btnLuuNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            cboMaLoai.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            add = false;
            update = true;
        }


        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maNCC = txtMaNCC.Text;
                    string tenNCC = txtTenNCC.Text;
                    string diaChiNCC = txtDiaChi.Text;
                    string sdtNCC = txtSDT.Text;
                    string maLoai = cboMaLoai.SelectedValue.ToString();
                    ncc_bll.them1NhaCungCap(maNCC, tenNCC, diaChiNCC, sdtNCC, maLoai);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maNCC = txtMaNCC.Text;
                    string tenNCC = txtTenNCC.Text;
                    string diaChiNCC = txtDiaChi.Text;
                    string sdtNCC = txtSDT.Text;
                    string maLoai = cboMaLoai.SelectedValue.ToString();
                    ncc_bll.sua1NhaCungCap(maNCC, tenNCC, diaChiNCC, sdtNCC, maLoai);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
        }
       

        //XỬ LÝ QUẢN LÝ NGƯỜI DÙNG

        private void btnThemND_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();

            btnLuuND.Enabled = true;
            btnXoaND.Enabled = false;
            btnSuaND.Enabled = false;

            txtTenDN.Enabled = true;
            txtMatKhau.Enabled = true;
            cboTrangThaiHD.Enabled = true;
            cboMaNVD.Enabled = true;
            add = true;
            update = false;
        }
        private void btnXoaND_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tk_bll.xoa1TaiKhoan(txtTenDN.Text);
                MessageBox.Show("Thành Công!");
                frmQuanLy_Load(sender, e);
            }
        }

        private void btnSuaND_Click(object sender, EventArgs e)
        {
            btnLuuND.Enabled = true;
            txtTenDN.Enabled = true;
            txtMatKhau.Enabled = true;
            cboTrangThaiHD.Enabled = true;
            cboMaNVD.Enabled = true;
            add = false;
            update = true;
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaND.Enabled = true;
            btnSuaND.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtTenDN.Text = dgvNguoiDung.Rows[numrow].Cells[0].Value.ToString();
                txtMatKhau.Text = dgvNguoiDung.Rows[numrow].Cells[1].Value.ToString();
                cboTrangThaiHD.Text = dgvNguoiDung.Rows[numrow].Cells[2].Value.ToString();
                cboMaNVD.Text = dgvNguoiDung.Rows[numrow].Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        //CHỨC NĂNG IN 
        private void btnInNV_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "ERROR");
                return;
            }
            List<NhanVien> pList = new List<NhanVien>();
            foreach (DataGridViewRow item in dgvNhanVien.Rows)
            {
                NhanVien i = new NhanVien();
                //i.STT = int.Parse(item.Cells[0].Value.ToString());
                i.MaNV = item.Cells[0].Value.ToString();
                i.TenNV = item.Cells[1].Value.ToString();
                i.NgaySinh = DateTime.Parse(item.Cells[2].Value.ToString());
                i.GioiTinh = item.Cells[3].Value.ToString();
                i.Luong = Int32.Parse(item.Cells[4].Value.ToString());
                //i.HinhAnh = item.Cells[5].Value.ToString();
                pList.Add(i);
            }
            string path = string.Empty;
            excel.ExportNhanVien(pList, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void btnInNhaCC_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvNhaCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "ERROR");
                return;
            }
            List<NhaCungCap> pList = new List<NhaCungCap>();
            foreach (DataGridViewRow item in dgvNhaCC.Rows)
            {
                NhaCungCap i = new NhaCungCap();
                //i.STT = int.Parse(item.Cells[0].Value.ToString());
                i.MaNCC = item.Cells[0].Value.ToString();
                i.TenNCC = item.Cells[1].Value.ToString();
                i.DiaChi = item.Cells[2].Value.ToString();
                i.SDT = item.Cells[3].Value.ToString();
                i.MaLoai = item.Cells[4].Value.ToString();
                //i.HinhAnh = item.Cells[5].Value.ToString();
                pList.Add(i);
            }
            string path = string.Empty;
            excel.ExportNhaCungCap(pList, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvNguoiDung.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "ERROR");
                return;
            }
            List<QLNguoiDung> pList = new List<QLNguoiDung>();
            foreach (DataGridViewRow item in dgvNguoiDung.Rows)
            {
                QLNguoiDung i = new QLNguoiDung();
                //i.STT = int.Parse(item.Cells[0].Value.ToString());
                i.TenDangNhap = item.Cells[0].Value.ToString();
                i.MatKhau = item.Cells[1].Value.ToString();
                i.HoatDong = bool.Parse(item.Cells[2].Value.ToString());
                i.MaNV = item.Cells[3].Value.ToString();
                //i.HinhAnh = item.Cells[5].Value.ToString();
                pList.Add(i);
            }
            string path = string.Empty;
            excel.ExportNguoiDung(pList, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void btnInTD_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvThucDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "ERROR");
                return;
            }
            List<ChiTietThucDon> pList = new List<ChiTietThucDon>();
            foreach (DataGridViewRow item in dgvThucDon.Rows)
            {
                ChiTietThucDon i = new ChiTietThucDon();
                //i.STT = int.Parse(item.Cells[0].Value.ToString());
                i.MaMon = item.Cells[0].Value.ToString();
                i.MaLoai = item.Cells[1].Value.ToString();
                i.TenMon = item.Cells[3].Value.ToString();
                i.DonGia = Int32.Parse(item.Cells[4].Value.ToString());
                //i.HinhAnh = item.Cells[5].Value.ToString();
                pList.Add(i);
            }
            string path = string.Empty;
            excel.ExportThucDon(pList, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void btnInLoai_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvLoaiThucDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "ERROR");
                return;
            }
            List<LoaiThucDon> pList = new List<LoaiThucDon>();
            foreach (DataGridViewRow item in dgvLoaiThucDon.Rows)
            {
                LoaiThucDon i = new LoaiThucDon();
                i.MaLoai = item.Cells[0].Value.ToString();
                i.TenLoai = item.Cells[1].Value.ToString();
                //i.HinhAnh = item.Cells[5].Value.ToString();
                pList.Add(i);
            }
            string path = string.Empty;
            excel.ExportLoaiThucDon(pList, ref path, false);
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string imgLoca = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLoca = dialog.FileName.ToString();
                txtHinhMon.Text = imgLoca.ToString();
                pbThucDon.ImageLocation = imgLoca;
            }
        }

        private void btnLuuND_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tenDN = txtTenDN.Text;
                    string matKhau = txtMatKhau.Text;
                    bool trangThai = bool.Parse(cboTrangThaiHD.Text);
                    string maNV = cboMaNVD.SelectedValue.ToString();
                    tk_bll.them1TaiKhoan(tenDN, matKhau, trangThai, maNV);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tenDN = txtTenDN.Text;
                    string matKhau = txtMatKhau.Text;
                    bool trangThai = bool.Parse(cboTrangThaiHD.Text);
                    string maNV = cboMaNVD.SelectedValue.ToString();
                    tk_bll.sua1TaiKhoan(tenDN, matKhau, trangThai, maNV);
                    MessageBox.Show("Thành Công!");
                    frmQuanLy_Load(sender, e);
                }
            }
        }
    }
}
