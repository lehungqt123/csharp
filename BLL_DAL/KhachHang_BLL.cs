using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhachHang_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public KhachHang_BLL()
        {

        }

        public IQueryable loadKhachHang()
        {
            var ds = from k in qlcf.KhachHangs
                     select new
                     {
                         k.MaKH,
                         k.TenKH,
                     };
            return ds;
        }

        public void them1KhachHang(string maKH, string tenKH)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = maKH;
            kh.TenKH = tenKH;

            qlcf.KhachHangs.InsertOnSubmit(kh);
            qlcf.SubmitChanges();
        }

        public void sua1KhachHang(string maKH, string tenKH)
        {
            var queryKhachHangs =
            from KhachHangs in qlcf.KhachHangs
            where
            KhachHangs.MaKH == maKH
            select KhachHangs;
            foreach (var KhachHangs in queryKhachHangs)
            {
                KhachHangs.MaKH = maKH;
                KhachHangs.TenKH = tenKH;
            }
            qlcf.SubmitChanges();

        }

        public void xoa1KhachHang(string maKH)
        {
            KhachHang kh = qlcf.KhachHangs.Where(m => m.MaKH == maKH).FirstOrDefault();
            qlcf.KhachHangs.DeleteOnSubmit(kh);
            qlcf.SubmitChanges();
        }

        public string getMaKhachHang()
        {
            string x = qlcf.KhachHangs.Max(t => t.MaKH);
            int ma = int.Parse(x.Substring(x.Length - 3, 3));

            if (ma >= 0 && ma < 9)
            {
                return "KH0" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "KH" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
