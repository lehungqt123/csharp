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
    public partial class frmMain : Form
    {
        int[,] vitri;
        int n;
        public frmMain()
        {
            InitializeComponent();
            loadBanT1();
            loadBanT2();
           
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.YellowGreen), e.Bounds);
            e.Graphics.DrawString(this.tabMain.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        
        public void loadBanT1()
        {
            n = 4;
            int soban=0;
            vitri = new int[n, n];
            for (int i = 0; i < n * 110; i += 110)
            {
                for (int j = 0; j < n * 140; j += 140)
                {
                    soban++;
                    Button btn = new Button();
                    btn.Size = new Size(90, 90);
                    btn.Text = "Bàn" + " " + soban.ToString();
                    btn.Image = QuanLyQuanCafe.Properties.Resources.iconban;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Name = "btn" + i.ToString() + j.ToString();
                    btn.Top = i;
                    btn.Left = j;
                    btn.BackColor = Color.White;
                    //btn.Click += new System.EventHandler(bt_Click);

                    //vitri[i, j] = Int16.Parse(btn.Tag.ToString());

                    tabTang1.Controls.Add(btn);
                }
            }
        }
        public void loadBanT2()
        {

            n = 4;
            vitri = new int[n, n];
            int soban = 0;
            for (int i = 0; i < n * 110; i += 110)
            {
                for (int j = 0; j < n * 140; j += 140)
                {
                    soban++;
                    Button btn = new Button();
                    btn.Text = "Bàn" + " " + soban.ToString();
                    btn.Image = QuanLyQuanCafe.Properties.Resources.iconban;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Size = new Size(90, 90);
                    btn.Name = "btn" + i.ToString() + j.ToString();                    
                    btn.Top = i;
                    btn.Left = j;
                    btn.BackColor = Color.White;
                    //btn.Click += new System.EventHandler(bt_Click);

                    //vitri[i, j] = Int16.Parse(btn.Tag.ToString());

                    tabTang2.Controls.Add(btn);
                }
            }
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
            e.Graphics.DrawString(this.tabSecond.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 1, e.Bounds.Top + 4);
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

    }
}
