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
        bool add = false, update = false;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            pbChanDung.SizeMode = PictureBoxSizeMode.StretchImage;
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
            //XỬ LÝ KHÁCH HÀNG
            //XỬ LÝ LOẠI THỰC ĐƠN
            dgvLoaiThucDon.DataSource = ltd_bll.loadLoaiTD();
            dgvLoaiThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtMaLoai.Enabled = false;

            btnLuuLoai.Enabled = false;
            btnXoaLoai.Enabled = false;
            btnSuaLoai.Enabled = false;
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
                //txtHinhMon.Text = dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                //txtAnh.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();

                //pbThucDon.Image = Image.FromFile(@"..//..//Images//" + dgvThucDon.Rows[numrow].Cells[5].Value.ToString());
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
    }
}
