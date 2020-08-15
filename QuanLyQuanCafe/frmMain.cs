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
using QuanLyQuanCafe.Properties;

namespace QuanLyQuanCafe
{
    public partial class frmMain : Form
    {       
        int[,] vitri;
        int n;
        private bool isCollapsed;
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmChonBanKH frm = new frmChonBanKH();
            pnHienThi.Show();
            pnHienThi.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(frm);
            frm.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                pnUser.Height += 10;
                if(pnUser.Size==pnUser.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnUser.Height -= 10;
                if (pnUser.Size == pnUser.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            frm.Show();
            this.Hide();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            frmDatMon frm = new frmDatMon();
            pnHienThi.Show();
            pnHienThi.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(frm);
            frm.Show();            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmChonBanKH frm = new frmChonBanKH();
            pnHienThi.Show();
            pnHienThi.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(frm);
            frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmXuLyHoaDon frm = new frmXuLyHoaDon();
            pnHienThi.Show();
            pnHienThi.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(frm);
            frm.Show();
        }

        private void btnChonBan_Click(object sender, EventArgs e)
        {
            frmChonBanKH frm = new frmChonBanKH();
            pnHienThi.Show();
            pnHienThi.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(frm);
            frm.Show();
        }
    }
}
