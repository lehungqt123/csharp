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
    public partial class frmMain : Form
    {
        int[,] vitri;
        int n;
        public frmMain()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.YellowGreen), e.Bounds);
            e.Graphics.DrawString(this.tabMain.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        

        private void tabSecond_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.YellowGreen), e.Bounds);
            e.Graphics.DrawString(this.tabSecond.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabSecond2_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.YellowGreen), e.Bounds);
            e.Graphics.DrawString(this.tabSecond2.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabCtrHD_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.YellowGreen), e.Bounds);
            e.Graphics.DrawString(this.tabCtrHD.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtTongTienHang.Enabled = false;
            txtGiamGia.Enabled = false;
            txtKhachCanTra.Enabled = false;
            txtTienKhachDua.Enabled = false;
            txtTienThua.Enabled = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
