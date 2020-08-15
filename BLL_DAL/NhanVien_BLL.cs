using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVien_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();       
        public NhanVien_BLL()
        {

        }

        public IQueryable loadNhanVien()
        {
            var ds = from k in qlcf.NhanViens
                     select new
                     {
                         k.MaNV,
                         k.TenNV,
                         k.NgaySinh,
                         k.GioiTinh,
                         k.Luong,
                     };
            return ds;
        }

        public void them1NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, int luong, string hinhAnh)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = maNV;
            nv.TenNV = tenNV;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.Luong = luong;

            qlcf.NhanViens.InsertOnSubmit(nv);
            qlcf.SubmitChanges();
        }

        public void sua1NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, int luong, string hinhAnh)
        {
            var queryNhanViens =
            from NhanViens in qlcf.NhanViens
            where
            NhanViens.MaNV == maNV
            select NhanViens;
            foreach (var NhanViens in queryNhanViens)
            {
                NhanViens.TenNV = tenNV;
                NhanViens.NgaySinh = ngaySinh;
                NhanViens.GioiTinh = gioiTinh;
                NhanViens.Luong = luong;

            }
            qlcf.SubmitChanges();

        }

        public void xoa1NhanVien(string maNV)
        {
            NhanVien nv = qlcf.NhanViens.Where(m => m.MaNV == maNV).FirstOrDefault();
            qlcf.NhanViens.DeleteOnSubmit(nv);
            qlcf.SubmitChanges();
        }

        public string getMaNhanVien()
        {
            string x = qlcf.NhanViens.Max(t => t.MaNV);
            int ma = int.Parse(x.Substring(x.Length - 3, 3));

            if (ma >= 0 && ma < 9)
            {
                return "NV0" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "NV" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
