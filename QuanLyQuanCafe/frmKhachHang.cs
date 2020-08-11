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
    public partial class frmKhachHang : Form
    {
        KhachHang_BLL kh_bll = new KhachHang_BLL();
        bool add = false, update = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = kh_bll.loadKhachHang();

            txtMaKH.Enabled = false;
            txtMaKH.Enabled = false;

            btnLuuKH.Enabled = false;
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            btnLuuKH.Enabled = true;
            txtTenKH.Enabled = true;
            if (dgvKhachHang.RowCount <= 0)
            {
                txtMaKH.Text = "KH01";
            }
            else
            {
                txtMaKH.Text = kh_bll.getMaKhachHang();
            }
            add = true;
            update = false;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kh_bll.xoa1KhachHang(txtMaKH.Text);
                MessageBox.Show("Thành Công!");
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            btnLuuKH.Enabled = true;
            txtTenKH.Enabled = true;
            add = false;
            update = true;
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maKH = txtMaKH.Text;
                    string tenKH = txtTenKH.Text;
                    kh_bll.them1KhachHang(maKH, tenKH);
                    MessageBox.Show("Thành Công!");
                    frmKhachHang_Load(sender, e);
                }
            }
            if (update)
            {
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maKH = txtMaKH.Text;
                    string tenKH = txtTenKH.Text;
                    kh_bll.sua1KhachHang(maKH, tenKH);
                    MessageBox.Show("Thành Công!");
                    frmKhachHang_Load(sender, e);
                }
            }
        }
    }
}
