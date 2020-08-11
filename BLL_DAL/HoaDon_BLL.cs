using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDon_BLL
    {
        QLCFDataContext qlcf=new QLCFDataContext();

        public HoaDon_BLL()
        {

        }

        public IQueryable loadHoaDon()
        {
            var ds = from k in qlcf.HoaDons
                     select new
                     {
                         k.MaHD,
                         k.MaNV,
                         k.NhanVien.TenNV,
                         k.NgayLap,
                         k.TongTien,
                     };
            return ds;
        }

        public string getMaHoaDon(string y)
        {
            string x = qlcf.HoaDons.Max(t => t.MaHD);
            int ma = int.Parse(x.Substring(x.Length - 3, 3));

            if (ma >= 0 && ma < 9)
            {
                return "HD0" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "HD" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
