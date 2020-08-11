using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;
using System.Data;

namespace BLL_DAL
{
    public class Table_BLL
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public Table_BLL()
        {

        }

        public List<Table> loadDSBan()
        {
            List<Table> table = new List<Table>();
            table.Select(k => k);
            return table;

        }
        
        public IQueryable<Ban> loadBan()
        {
            return qlcf.Bans.Select(k => k);
        }
    }
}
