using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class frmXuLyHoaDon : Form
    {
        HoaDon_BLL hd_bll = new HoaDon_BLL();
        CTHoaDon_BLL cthd_bll = new CTHoaDon_BLL();
        KhachHang_BLL kh_bll = new KhachHang_BLL();
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        Table_BLL b_bll = new Table_BLL();
        bool add = false, update = false;
        public frmXuLyHoaDon()
        {
            InitializeComponent();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            cboMaNV.Enabled = true;
            btnLuuHD.Enabled = true;

            int sum = 0;
            for (int i = 0; i < dgvCTHoaDon.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvCTHoaDon.Rows[i].Cells[5].Value);
            }
            txtTongTien.Text = sum.ToString();

            add = true;
            update = false;
        }

        private void frmXuLyHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Enabled = false;
            dtpNgayLap.Enabled = false;
            txtTongTien.Enabled = false;

            btnLuuHD.Enabled = false;
            btnSuaHD.Enabled = false;

            //cboBan.DataSource = b_bll.loadBan();
            //cboBan.DisplayMember = "TenBan";
            //cboBan.ValueMember = "MaBan";

            cboMaNV.DataSource = nv_bll.loadNhanVien();
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";

            cboMaKH.DataSource = kh_bll.loadKhachHang();
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";

            dgvHoaDon.DataSource = hd_bll.loadHoaDon();
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCTHoaDon.DataSource = cthd_bll.loadCTHoaDon();
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maHD = txtMaHD.Text;
                    string maNV = cboMaNV.SelectedValue.ToString();
                    DateTime ngayLap = DateTime.Today;
                    int tongTien = int.Parse(txtTongTien.Text);
                    string maKH = cboMaKH.SelectedValue.ToString();
                    hd_bll.sua1HoaDon(maHD, maNV, ngayLap, tongTien, maKH, false);
                    MessageBox.Show("Thành Công!");
                    dgvHoaDon.DataSource = hd_bll.loadHoaDon();
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maHD = txtMaHD.Text;
                    string maNV = cboMaNV.SelectedValue.ToString();
                    DateTime ngayLap = DateTime.Today;
                    int tongTien = int.Parse(txtTongTien.Text);
                    string maKH = cboMaKH.SelectedValue.ToString();
                    hd_bll.sua1HoaDon(maHD, maNV, ngayLap, tongTien, maKH, false);
                    MessageBox.Show("Thành Công!");
                    dgvHoaDon.DataSource = hd_bll.loadHoaDon();
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaHD.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaHD.Text = dgvHoaDon.Rows[numrow].Cells[0].Value.ToString();
                cboMaNV.Text = dgvHoaDon.Rows[numrow].Cells[2].Value.ToString();
                dtpNgayLap.Text = dgvHoaDon.Rows[numrow].Cells[3].Value.ToString();
                txtTongTien.Text = dgvHoaDon.Rows[numrow].Cells[4].Value.ToString();
                cboMaKH.Text = dgvHoaDon.Rows[numrow].Cells[5].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            btnLuuHD.Enabled = true;
            add = false;
            update = true;
            int sum = 0;
            for (int i = 0; i < dgvCTHoaDon.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvCTHoaDon.Rows[i].Cells[5].Value);
            }
            txtTongTien.Text = sum.ToString();
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaKH.SelectedIndex != b_bll.getSize())
            //{
            //    string maBan = cboBan.SelectedValue.ToString();
            //    try
            //    {
            //        cboBan.Text = cthd_bll.loadTenBan(int.Parse(maBan));
            //    }
            //    catch (Exception)
            //    {


            //    }

            //}
            //else
            //    cboBan.Text = "";
        }

        private void dgvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int numrow;
            //    numrow = e.RowIndex;
            //    cboBan.Text = dgvCTHoaDon.Rows[numrow].Cells[1].Value.ToString();
            //    cboBan.Text = cboBan.SelectedValue.ToString();
            //}
            //catch
            //{
            //}
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string maHD = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hd_bll.xoaTatCaCTHD(maHD);
                hd_bll.xoaHD(maHD);
                MessageBox.Show("Thành công!");
            }
            dgvCTHoaDon.DataSource = cthd_bll.loadCTHoaDon();
            dgvHoaDon.DataSource = hd_bll.loadHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực hiện thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //int maBan = int.Parse(cboBan.SelectedValue.ToString());
                //string tenBan = cboBan.Text;
                string maHD = txtMaHD.Text;
                string maNV = cboMaNV.SelectedValue.ToString();
                DateTime ngayLap = DateTime.Today;
                int tongTien = int.Parse(txtTongTien.Text);
                string maKH = null;
                bool thanhtoan = true;
                hd_bll.sua1HoaDon(maHD, maNV, ngayLap, tongTien, maKH, thanhtoan);
                MessageBox.Show("Thanh toán thành công!");
                dgvHoaDon.DataSource = hd_bll.loadHoaDon();
                //b_bll.sua1Ban(maBan, tenBan, "Trống", maKH);
            }
        }

    }
}
