using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL_DAL
{
    public class Table_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        Ban ban;
        public Table_BLL()
        {

        }

        public int getSize()
        {
            int size = 0;
            size = qlcf.Bans.Select(b => b).Count();
            return size;
        }
        public IQueryable loadBan()
        {
            var ds = from k in qlcf.Bans
                     select new
                     {
                         k.MaBan,
                         k.TenBan,
                         k.TrangThai,
                         k.MaKH,
                     };
            return ds;
        }

        public string loadTTBan(int maBan)
        {
            Ban ban = qlcf.Bans.Where(b => b.MaBan == maBan).FirstOrDefault();
            return ban.TrangThai;
        }

        

        public void them1Ban(int maBan, string tenBan, string trangThai, string maKH)
        {
            Ban ban = new Ban();
            ban.MaBan = maBan;
            ban.TenBan = tenBan;
            ban.TrangThai = trangThai;
            ban.MaKH = maKH;

            qlcf.Bans.InsertOnSubmit(ban);
            qlcf.SubmitChanges();
        }

        public void sua1Ban(int maBan, string tenBan, string trangThai, string maKH)
        {
            var queryBans =
            from Bans in qlcf.Bans
            where
            Bans.MaBan == maBan
            select Bans;
            foreach (var Bans in queryBans)
            {
                Bans.TenBan = tenBan;
                Bans.TrangThai = trangThai;
                Bans.MaKH = maKH;
            }
            qlcf.SubmitChanges();

        }

        public void xoa1Ban(int maBan)
        {
            Ban ban = qlcf.Bans.Where(m => m.MaBan == maBan).FirstOrDefault();
            qlcf.Bans.DeleteOnSubmit(ban);
            qlcf.SubmitChanges();
        }

        public string getMaLoaiTD()
        {
            string x = qlcf.LoaiThucDons.Max(t => t.MaLoai);
            int ma = int.Parse(x.Substring(x.Length - 3, 3));

            if (ma >= 0 && ma < 9)
            {
                return "L00" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "L0" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
