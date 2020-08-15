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
                         k.KhachHang.TenKH,
                     };
            return ds;
        }

        public void them1HoaDon(string maHD, string maNV, DateTime ngayLap, int tongTien, string maKH, bool trangThai)
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = maHD;
            hd.MaNV = maNV;
            hd.NgayLap = ngayLap;
            hd.TongTien = tongTien;
            hd.MaKH = maKH;
            hd.TrangThai = trangThai;

            qlcf.HoaDons.InsertOnSubmit(hd);
            qlcf.SubmitChanges();
        }

        public void xoa1HD(string maHD)
        {
            HoaDon hd = qlcf.HoaDons.Where(m => m.MaHD == maHD).FirstOrDefault();
            qlcf.HoaDons.DeleteOnSubmit(hd);
            qlcf.SubmitChanges();
        }
        public void sua1HoaDon(string maHD, string maNV, DateTime ngayLap, int tongTien, string maKH, bool trangThai)
        {
            var queryHoaDons =
            from HoaDons in qlcf.HoaDons
            where
            HoaDons.MaHD == maHD
            select HoaDons;
            foreach (var HoaDons in queryHoaDons)
            {
                HoaDons.MaNV = maNV;
                HoaDons.NgayLap = ngayLap;
                HoaDons.TongTien = tongTien;
                HoaDons.MaKH = maKH;
                HoaDons.TrangThai = trangThai;
            }
            qlcf.SubmitChanges();

        }

        public string getMaHoaDon()
        {
            string x = qlcf.HoaDons.Max(t => t.MaHD);
            int size = qlcf.HoaDons.Select(hd => hd).Count();
            if (size == 0)
            {
                return "HD01";
            }
            try
            {
                if (x.Trim() != string.Empty)
                {
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
            catch (Exception)
            {

            }
            return "HD01";
        }

        public bool kTraKhoaChinhHD(string maHD)
        {
            int count = qlcf.ChiTietHoaDons.Where(kh => kh.MaHD == maHD).Count();
            if (count > 0)
                return false;
            return true;
        }

        public bool kTraKhoaChinhCTHD(string maHD, string maMon)
        {
            int count = qlcf.ChiTietHoaDons.Where(kh => kh.MaHD == maHD).Where(kh => kh.MaMon == maMon).Count();
            if (count > 0)
                return false;
            return true;
        }

        public void them1CTHD(string maHD, int maBan, string maMon, int soLuong, int donGia, int thanhTien)
        {
            ChiTietHoaDon chitiet = new ChiTietHoaDon();
            chitiet.MaHD = maHD;
            chitiet.MaBan = maBan;
            chitiet.MaMon = maMon;
            chitiet.SoLuong = soLuong;
            chitiet.DonGia = donGia;
            chitiet.ThanhTien = thanhTien;

            qlcf.ChiTietHoaDons.InsertOnSubmit(chitiet);
            qlcf.SubmitChanges();
        }

        public void sua1CTHD(string maHD, int maBan, string maMon, int soLuong, int donGia, int thanhTien)
        {
            ChiTietHoaDon chitiet = qlcf.ChiTietHoaDons.Where(hd => hd.MaHD == maHD).Where(hd => hd.MaMon == maMon).FirstOrDefault();
            chitiet.SoLuong = soLuong;
            chitiet.DonGia = donGia;
            chitiet.ThanhTien = thanhTien;

            qlcf.SubmitChanges();
        }

        public void xoa1CTHD(string maCTHD, string maMon)
        {
            ChiTietHoaDon chiTiet = qlcf.ChiTietHoaDons.Where(ct => ct.MaHD == maCTHD).Where(ct => ct.MaMon == maMon).FirstOrDefault();
            qlcf.ChiTietHoaDons.DeleteOnSubmit(chiTiet);
            qlcf.SubmitChanges();
        }

        public void xoaTatCaCTHD(string maHD)
        {
            foreach (var item in qlcf.ChiTietHoaDons.Where(ma => ma.MaHD == maHD))
            {
                qlcf.ChiTietHoaDons.DeleteOnSubmit(item);
                qlcf.SubmitChanges();
            }
        }

        public void xoaHD(string maHD)
        {
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHD == maHD).FirstOrDefault();
            qlcf.HoaDons.DeleteOnSubmit(hd);
            qlcf.SubmitChanges();
        }
    }
}
