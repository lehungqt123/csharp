using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyQuanCafe
{
    class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.CafeConn == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.CafeConn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0; //Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2; //Chuỗi cấu hình không phù hợp
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM QL_NguoiDung WHERE TenDangNhap='" + pUser + "' AND MatKhau='" + pPass + "'", Properties.Settings.Default.CafeConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 9; //Không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 10; //Không hoạt động
            }
            return 11; //Đăng nhập thành công
        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd=" + pPass + "");
            da.Fill(dt);
            return dt;
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            QuanLyQuanCafe.Properties.Settings.Default.CafeConn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd=" + pPass + "";
            QuanLyQuanCafe.Properties.Settings.Default.Save();
        }
    }
}
