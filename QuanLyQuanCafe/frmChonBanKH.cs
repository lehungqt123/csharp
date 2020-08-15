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
    public partial class frmChonBanKH : Form
    {
        KhachHang_BLL kh_bll = new KhachHang_BLL();
        Table_BLL b_bll = new Table_BLL();
        bool add = false, update = false;
        public frmChonBanKH()
        {
            InitializeComponent();
        }

        private void frmChonBanKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnLuuKH.Enabled = false;
            btnSuaKH.Enabled = false;
            //btnXoaKH.Enabled = false;
            txtMaKH1.Enabled = false;
            txtTenKH.Enabled = false;


            cboBan.DataSource = b_bll.loadBan();
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";

            cboTrangThai.DataSource = b_bll.loadBan();
            cboTrangThai.DisplayMember = "TrangThai";

            dgvKhachHang.DataSource = kh_bll.loadKhachHang();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnChonBan_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maBan = int.Parse(cboBan.SelectedValue.ToString());
                    string maKH1 = txtMaKH1.Text;
                    string tenBan = cboBan.Text;
                    string trangThai = "Có người";
                    b_bll.sua1Ban(maBan,tenBan, trangThai, maKH1);
                    MessageBox.Show("Thành Công!");
                    frmChonBanKH_Load(sender, e);
                }
        }

        private void cboBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex != b_bll.getSize())
            {
                string maBan = cboBan.SelectedValue.ToString();
                try
                {
                    cboTrangThai.Text = b_bll.loadTTBan(Int32.Parse(maBan));
                }
                catch (Exception)
                {

                    
                }

            }
            else
                cboTrangThai.Text = "";


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
                    frmChonBanKH_Load(sender, e);
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
                    frmChonBanKH_Load(sender, e);
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    kh_bll.xoa1KhachHang(txtMaKH.Text);
            //    MessageBox.Show("Thành Công!");
            //    frmChonBanKH_Load(sender, e);
            //}
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnXoaKH.Enabled = true;
            btnSuaKH.Enabled = true;
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMaKH.Text = dgvKhachHang.Rows[numrow].Cells[0].Value.ToString();
                txtMaKH1.Text = dgvKhachHang.Rows[numrow].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();               
            }
            catch
            {
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            txtTenKH.Enabled = true;
            btnLuuKH.Enabled = true;
            btnSuaKH.Enabled = false;
            //btnXoaKH.Enabled = false;
            
            if (dgvKhachHang.RowCount <= 0)
            {
                txtMaKH.Text = "KH01";
                txtMaKH1.Text = "KH01";
            }
            else
            {
                txtMaKH.Text = kh_bll.getMaKhachHang();
                txtMaKH1.Text = kh_bll.getMaKhachHang();
            }
            add = true;
            update = false;
        }
    }
}
