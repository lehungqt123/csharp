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
        Cafe_BLL cf_bll = new Cafe_BLL();
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = cf_bll.loadNhanVien();

            pbChanDung.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
                mtbNgaySinh.Text = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
                //txtAnh.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();

                pbChanDung.Image = Image.FromFile(@"..//..//Images//" + dgvNhanVien.Rows[numrow].Cells[5].Value.ToString());
            }
            catch
            {
            }
        }
    }
}
