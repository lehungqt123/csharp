using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhaCungCap_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        
        public NhaCungCap_BLL()
        {

        }

        public IQueryable loadNhaCC()
        {
            var ds = from k in qlcf.NhaCungCaps
                     select new
                     {
                         k.MaNCC,
                         k.TenNCC,
                         k.DiaChi,
                         k.SDT,
                         k.MaLoai,
                         k.LoaiThucDon.TenLoai,
                     };
            return ds;
        }

        public void them1NhaCungCap(string maNCC, string tenNCC, string diaChi, string sDT, string maLoai)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = maNCC;
            ncc.TenNCC = tenNCC;
            ncc.DiaChi = diaChi;
            ncc.SDT = sDT;
            ncc.MaLoai = maLoai;

            qlcf.NhaCungCaps.InsertOnSubmit(ncc);
            qlcf.SubmitChanges();
        }

        public void sua1NhaCungCap(string maNCC, string tenNCC, string diaChi, string sDT, string maLoai)
        {
            var queryNhaCungCaps =
            from NhaCungCaps in qlcf.NhaCungCaps
            where
            NhaCungCaps.MaNCC == maNCC
            select NhaCungCaps;
            foreach (var NhaCungCaps in queryNhaCungCaps)
            {
                NhaCungCaps.TenNCC = tenNCC;
                NhaCungCaps.DiaChi = diaChi;
                NhaCungCaps.SDT = sDT;
                NhaCungCaps.MaLoai = maLoai;

            }
            qlcf.SubmitChanges();

        }

        public void xoa1NhaCungCap(string maNCC)
        {
            NhaCungCap ncc = qlcf.NhaCungCaps.Where(m => m.MaNCC == maNCC).FirstOrDefault();
            qlcf.NhaCungCaps.DeleteOnSubmit(ncc);
            qlcf.SubmitChanges();
        }

        public string getMaNhaCungCap()
        {
            string x = qlcf.NhaCungCaps.Max(t => t.MaNCC);
            int ma = int.Parse(x.Substring(x.Length - 2, 2));

            if (ma >= 0 && ma < 9)
            {
                return "NCC0" + (ma + 1).ToString();
            }
            else if (ma >= 9)
            {
                return "NCC" + (ma + 1).ToString();
            }
            else
                return "";

        }
    }
}
