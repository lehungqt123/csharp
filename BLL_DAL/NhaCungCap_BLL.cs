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
                     };
            return ds;
        }
    }
}
