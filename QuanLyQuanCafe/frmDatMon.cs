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
    public partial class frmDatMon : Form
    {
        ThucDon_BLL td_bll = new ThucDon_BLL();
        CTHoaDon_BLL ct_bll = new CTHoaDon_BLL();
        HoaDon_BLL hd_bll = new HoaDon_BLL();
        KhachHang_BLL kh_bll = new KhachHang_BLL();
        Table_BLL b_bll = new Table_BLL();
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        bool add = false, update = false;
        public frmDatMon()
        {
            InitializeComponent();
        }

        private void frmDatMon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = hd_bll.getMaHoaDon();

            txtMaCTHD.Enabled = false;
            cboSoBan.DataSource = b_bll.loadBan();
            cboSoBan.DisplayMember = "TenBan";
            cboSoBan.ValueMember = "MaBan";
            txtDonGia.Enabled = false;

            cboMaMon.DataSource = td_bll.loadThucDon();
            cboMaMon.DisplayMember = "MaMon";
            cboMaMon.ValueMember = "MaMon";

            cboMaNV.DataSource = nv_bll.loadNhanVien();
            cboMaNV.ValueMember = "MaNV";

            cboMaKH.DataSource = kh_bll.loadKhachHang();
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";

            pbHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            dgvThucDon.DataSource = td_bll.loadThucDon();
            dgvThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCTHoaDon.DataSource = ct_bll.loadCTHoaDon();
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtThanhTien.Enabled = false;
            btnLuuCT.Enabled = false;
            btnSuaCT.Enabled = false;
            btnXoaCT.Enabled = false;
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                int numrow;
                numrow = e.RowIndex;
                cboMaMon.Text = dgvThucDon.Rows[numrow].Cells[0].Value.ToString();
                txtDonGia.Text=dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                //txtMaMon.Text = dgvThucDon.Rows[numrow].Cells[0].Value.ToString();
                //cboLoai.Text = dgvThucDon.Rows[numrow].Cells[1].Value.ToString();
                //cboLoai.Text = dgvThucDon.Rows[numrow].Cells[2].Value.ToString();
                //txtTenMon.Text = dgvThucDon.Rows[numrow].Cells[3].Value.ToString();
                //txtDonGia.Text = dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                cboMaMon.Text = dgvThucDon.Rows[numrow].Cells[0].Value.ToString();
                //txtHinhMon.Text = dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                //txtAnh.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();

                pbHinhSP.Image = Image.FromFile(@"..//..//Images//" + dgvThucDon.Rows[numrow].Cells[5].Value.ToString());
            }
            catch
            {
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            btnLuuCT.Enabled = true;
            txtMaCTHD.Text = txtMaHD.Text;
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            add = true;
            update = false;
        }

        private void dgvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaCT.Enabled = true;
            btnSuaCT.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaCTHD.Text = dgvCTHoaDon.Rows[numrow].Cells[0].Value.ToString();
                cboSoBan.Text= dgvCTHoaDon.Rows[numrow].Cells[1].Value.ToString();
                cboMaMon.Text = dgvCTHoaDon.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvCTHoaDon.Rows[numrow].Cells[3].Value.ToString();
                txtDonGia.Text = dgvCTHoaDon.Rows[numrow].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvCTHoaDon.Rows[numrow].Cells[5].Value.ToString();

            }
            catch
            {
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maCTHD = dgvCTHoaDon.CurrentRow.Cells[0].Value.ToString();
                string maMon = dgvCTHoaDon.CurrentRow.Cells[2].Value.ToString();

                hd_bll.xoa1CTHD(maCTHD, maMon);
                MessageBox.Show("Thành Công!");
                dgvCTHoaDon.DataSource = ct_bll.loadCTHoaDon();
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            btnLuuCT.Enabled = true;
            add = false;
            update = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            tinhTongTienHD();
            if (hd_bll.kTraKhoaChinhHD(txtMaHD.Text))
            {
                hd_bll.them1HoaDon(txtMaHD.Text, cboMaNV.SelectedValue.ToString(), DateTime.Now, Int32.Parse(txtTongTien.Text), cboMaKH.SelectedValue.ToString(), false);
            }
            else
            {
                hd_bll.sua1HoaDon(txtMaHD.Text, cboMaNV.SelectedValue.ToString(), DateTime.Now, Int32.Parse(txtTongTien.Text), cboMaKH.SelectedValue.ToString(), false);
            }

            if (hd_bll.kTraKhoaChinhCTHD(txtMaCTHD.Text, cboMaMon.SelectedValue.ToString()))
            {
                hd_bll.them1CTHD(txtMaCTHD.Text, int.Parse(cboSoBan.SelectedValue.ToString()), cboMaMon.SelectedValue.ToString(), Int32.Parse(txtSoLuong.Text), Int32.Parse(txtDonGia.Text), Int32.Parse(txtThanhTien.Text));
            }
            else
            {
                hd_bll.sua1CTHD(txtMaCTHD.Text, int.Parse(cboSoBan.SelectedValue.ToString()), cboMaMon.SelectedValue.ToString(), Int32.Parse(txtSoLuong.Text), Int32.Parse(txtDonGia.Text), Int32.Parse(txtThanhTien.Text));
            }

            dgvCTHoaDon.DataSource = ct_bll.loadCTHoaDon();
            tinhTongTienHD();
            hd_bll.sua1HoaDon(txtMaHD.Text, cboMaNV.SelectedValue.ToString(), DateTime.Now, Int32.Parse(txtTongTien.Text), cboMaKH.SelectedValue.ToString(), false);
            dgvCTHoaDon.DataSource = ct_bll.loadCTHoaDon();

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "0" && txtSoLuong.Text != string.Empty)
            {
                txtThanhTien.Text = (Int32.Parse(txtSoLuong.Text) * Int32.Parse(txtDonGia.Text)).ToString();
            }
            else
                txtThanhTien.Text = "0";
        }

        private void cboMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMon.SelectedIndex != td_bll.getSize())
            {
                try
                {
                    if (cboMaMon.SelectedValue != null)
                    {
                        string masp = cboMaMon.SelectedValue.ToString();
                        if (td_bll.getGiaBan(masp) > 0)
                        {
                            txtDonGia.Text = td_bll.getGiaBan(masp).ToString();
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        void tinhTongTienHD()
        {
            int tongTienHang = 0;
            for (int i = 0; i < dgvCTHoaDon.RowCount; i++)
            {
                tongTienHang += Int32.Parse(dgvCTHoaDon.Rows[i].Cells[5].Value.ToString());
            }
            txtTongTien.Text = tongTienHang.ToString();
            txtTongTienThanhToan.Text = txtTongTien.Text;
        }
    }
}
