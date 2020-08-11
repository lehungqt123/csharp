using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Table
    {
        int maBan, order;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        String tenBan, trangThai;

        public String TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public String TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }

        public Table()
        {

        }

        public Table(int id, string ten, string tt)
        {
            this.maBan = id;
            this.tenBan = ten;
            this.trangThai = tt;
        }

        public Table(DataRow rows)
        {
            this.MaBan = (int)rows["MaBan"];
            this.TenBan = rows["TenBan"].ToString();
            this.TrangThai = rows["TrangThai"].ToString();
        }
    }
}
