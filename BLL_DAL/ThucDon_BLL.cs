using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThucDon_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();

        public ThucDon_BLL()
        {

        }
        public IQueryable loadThucDon()
        {
            var ds = from k in qlcf.ChiTietThucDons
                     select new
                     {
                         k.MaMon,
                         k.MaLoai,
                         k.LoaiThucDon.TenLoai,
                         k.TenMon,
                         k.DonGia,
                         k.HinhMon,
                     };
            return ds;
        }

        public void them1ThucDon(string maMon, string maLoai, string tenMon, int donGia, string hinhMon)
        {
            ChiTietThucDon td = new ChiTietThucDon();
            td.MaMon = maMon;
            td.MaLoai = maLoai;
            td.TenMon = tenMon;
            td.DonGia = donGia;
            td.HinhMon = hinhMon;

            qlcf.ChiTietThucDons.InsertOnSubmit(td);
            qlcf.SubmitChanges();
        }

        public void sua1ThucDon(string maMon, string maLoai, string tenMon, int donGia, string hinhMon)
        {
            var queryThucDons =
            from ThucDons in qlcf.ChiTietThucDons
            where
            ThucDons.MaMon == maMon
            select ThucDons;
            foreach (var ThucDons in queryThucDons)
            {
                ThucDons.TenMon = tenMon;
                ThucDons.DonGia = donGia;
                ThucDons.HinhMon = hinhMon;

            }
            qlcf.SubmitChanges();

        }

        public void xoa1ThucDon(string maTD)
        {
            ChiTietThucDon td = qlcf.ChiTietThucDons.Where(m => m.MaMon == maTD).FirstOrDefault();
            qlcf.ChiTietThucDons.DeleteOnSubmit(td);
            qlcf.SubmitChanges();
        }

        public string getMaThucDon()
        {
            string x = qlcf.ChiTietThucDons.Max(t => t.MaMon);
            int ma = int.Parse(x.Substring(x.Length - 3, 3));

            if (ma >= 0 && ma < 9)
            {
                return "M00" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "M0" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
