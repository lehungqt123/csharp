using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LoaiTD_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();

        public LoaiTD_BLL()
        {

        }

        public IQueryable loadLoaiTD()
        {
            var ds = from k in qlcf.LoaiThucDons
                     select new
                     {
                         k.MaLoai,
                         k.TenLoai,
                     };
            return ds;
        }

        public void them1LoaiTD(string maLoai, string tenLoai)
        {
            LoaiThucDon ltd = new LoaiThucDon();
            ltd.MaLoai = maLoai;
            ltd.TenLoai = tenLoai;
            
            qlcf.LoaiThucDons.InsertOnSubmit(ltd);
            qlcf.SubmitChanges();
        }

        public void sua1LoaiTD(string maLoai, string tenLoai)
        {
            var queryLoaiTDs =
            from LoaiTDs in qlcf.LoaiThucDons
            where
            LoaiTDs.MaLoai == maLoai
            select LoaiTDs;
            foreach (var LoaiTDs in queryLoaiTDs)
            {
                LoaiTDs.TenLoai = tenLoai;
            }
            qlcf.SubmitChanges();

        }

        public void xoa1LoaiTD(string maLoai)
        {
            LoaiThucDon ltd = qlcf.LoaiThucDons.Where(m => m.MaLoai == maLoai).FirstOrDefault();
            qlcf.LoaiThucDons.DeleteOnSubmit(ltd);
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
