using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Cafe_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public Cafe_BLL()
        {

        }

        public IQueryable<NhanVien> loadNhanVien()
        {
            return qlcf.NhanViens.Select(k => k);
        }

        public IQueryable<ChiTietThucDon> loadThucDon()
        {
            return qlcf.ChiTietThucDons.Select(k => k);
        }

        public IQueryable<ChiTietHoaDon> loadHoaDon()
        {
            return qlcf.ChiTietHoaDons.Select(k => k);
        }
    }
}
