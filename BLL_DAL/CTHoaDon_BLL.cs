using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTHoaDon_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();

        public CTHoaDon_BLL()
        { 

        }

        public IQueryable loadCTHoaDon()
        {
            var ds = from k in qlcf.ChiTietHoaDons
                     select new
                     {
                         k.MaHD,
                         k.MaBan,
                         k.MaMon,
                         k.SoLuong,
                         k.DonGia,
                         k.ThanhTien,
                     };
            return ds;
        }

        public int getSize()
        {
            int size = 0;
            size = qlcf.ChiTietHoaDons.Select(b => b).Count();
            return size;
        }

        public string loadTenBan(int maBan)
        {
            ChiTietHoaDon cthd = qlcf.ChiTietHoaDons.Where(b => b.MaBan == maBan).FirstOrDefault();
            return cthd.Ban.TenBan;
        }
        public void them1CTHoaDon(string maHD, int maBan, string maMon, int soLuong, int donGia, int thanhTien)
        {
            ChiTietHoaDon hd = new ChiTietHoaDon();
            hd.MaHD = maHD;
            hd.MaBan = maBan;
            hd.MaMon = maMon;
            hd.SoLuong = soLuong;
            hd.DonGia = donGia;
            hd.ThanhTien = thanhTien;

            qlcf.ChiTietHoaDons.InsertOnSubmit(hd);
            qlcf.SubmitChanges();
        }

        public void sua1CTHoaDon(string maHD, int maBan, string maMon, int soLuong, int donGia, int thanhTien)
        {
            var queryCTHoaDons =
            from CTHoaDons in qlcf.ChiTietHoaDons
            where
            CTHoaDons.MaHD == maHD
            select CTHoaDons;
            foreach (var HoaDons in queryCTHoaDons)
            {
                HoaDons.MaBan = maBan;
                HoaDons.MaMon = maMon;
                HoaDons.SoLuong = soLuong;
                HoaDons.DonGia = donGia;
                HoaDons.ThanhTien = thanhTien;

            }
            qlcf.SubmitChanges();

        }

        public void xoa1CTHD(string maHD)
        {
            ChiTietHoaDon hd = qlcf.ChiTietHoaDons.Where(m => m.MaHD == maHD).FirstOrDefault();
            qlcf.ChiTietHoaDons.DeleteOnSubmit(hd);
            qlcf.SubmitChanges();
        }


    }
}
