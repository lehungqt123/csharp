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
    public partial class frmCTHoaDon : Form
    {
        CTHoaDon_BLL cthd_bll = new CTHoaDon_BLL();
        bool add = false, update = false;
        public frmCTHoaDon()
        {
            InitializeComponent();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            cboSoBan.Enabled = true;
            cboMaMon.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            txtThanhTien.Enabled = true;
            btnLuuCT.Enabled = true;
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
                txtMaHD.Text = dgvCTHoaDon.Rows[numrow].Cells[0].Value.ToString();
                cboSoBan.Text = dgvCTHoaDon.Rows[numrow].Cells[1].Value.ToString();
                cboMaMon.Text = dgvCTHoaDon.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvCTHoaDon.Rows[numrow].Cells[3].Value.ToString();
                txtDonGia.Text = dgvCTHoaDon.Rows[numrow].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvCTHoaDon.Rows[numrow].Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {

        }

        private void frmCTHoaDon_Load(object sender, EventArgs e)
        {
            dgvCTHoaDon.DataSource = cthd_bll.loadCTHoaDon();

            
        }


    }
}
