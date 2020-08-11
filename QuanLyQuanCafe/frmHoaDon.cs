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
    public partial class frmHoaDon : Form
    {
        HoaDon_BLL hd_bll = new HoaDon_BLL();
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        bool add = false, update = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaHD.Enabled = true;
            btnSuaHD.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaHD.Text = dgvHoaDon.Rows[numrow].Cells[0].Value.ToString();
                cboMaNV.Text = dgvHoaDon.Rows[numrow].Cells[1].Value.ToString();
                dtpNgayLap.Text = dgvHoaDon.Rows[numrow].Cells[2].Value.ToString();
                txtTongTien.Text = dgvHoaDon.Rows[numrow].Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hd_bll.loadHoaDon();

            cboMaNV.DataSource = nv_bll.loadNhanVien();
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            cboMaNV.Enabled = true;
            dtpNgayLap.Enabled = true;
            txtTongTien.Enabled = true;
            btnLuuHD.Enabled = true;
            if (dgvHoaDon.RowCount <= 0)
            {
                txtMaHD.Text = "HD01";
            }
            else
            {
                txtMaHD.Text = hd_bll.getMaHoaDon("HD0");
            }
            add = true;
            update = false;
        }
    }
}
