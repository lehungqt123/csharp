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
    public partial class frmDangNhap : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Không được để trống " + lblUser.Text.ToLower());
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Không được để trống " + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                ProcessLogin();
            }
            if (CauHinh.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (CauHinh.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        public void ProcessConfig()
        {
            
        }

        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtUser.Text, txtPassword.Text);
            if (result == 9)
            {
                MessageBox.Show("Sai " + lblUser.Text + " Hoặc " + lblPassword.Text);
                return;
            }
            else if (result == 10)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            this.Visible = false;
            Program.mainForm.Show();
        }

    }
}
