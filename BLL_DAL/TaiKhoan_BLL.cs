using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class TaiKhoan_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();

        public TaiKhoan_BLL()
        {

        }
        public IQueryable loadTaiKhoan()
        {
            var ds = from k in qlcf.QLNguoiDungs
                     select new
                     {
                         k.TenDangNhap,
                         k.MatKhau,
                         k.HoatDong,
                         k.MaNV,
                         k.NhanVien.TenNV,
                     };
            return ds;
        }

        public void them1TaiKhoan(string tenDN, string mk, bool hoatDong, string maNV)
        {
            QLNguoiDung kh = new QLNguoiDung();
            kh.TenDangNhap = tenDN;
            kh.MatKhau = mk;
            kh.HoatDong = hoatDong;
            kh.MaNV = maNV;

            qlcf.QLNguoiDungs.InsertOnSubmit(kh);
            qlcf.SubmitChanges();
        }

        public void sua1TaiKhoan(string tenDN, string mk, bool hoatDong, string maNV)
        {
            var queryQLNguoiDung = from QL_NguoiDungs in qlcf.QLNguoiDungs 
                                   where QL_NguoiDungs.TenDangNhap == tenDN
                                   select QL_NguoiDungs;
            foreach (var QL_NguoiDungs in queryQLNguoiDung)
            {
                QL_NguoiDungs.TenDangNhap = tenDN;
                QL_NguoiDungs.MatKhau = mk;
                QL_NguoiDungs.HoatDong = hoatDong;
                QL_NguoiDungs.MaNV = maNV;
            }
            qlcf.SubmitChanges();

        }

        public void xoa1TaiKhoan(string tenDN)
        {
            QLNguoiDung nd = qlcf.QLNguoiDungs.Where(m => m.TenDangNhap == tenDN).FirstOrDefault();
            qlcf.QLNguoiDungs.DeleteOnSubmit(nd);
            qlcf.SubmitChanges();
        }

    }
}
