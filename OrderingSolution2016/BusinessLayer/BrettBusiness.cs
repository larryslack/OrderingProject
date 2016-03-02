using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using DatabaseLayer;

namespace BusinessLayer
{
    public class BrettBusiness
    {
        public static DataTable ShipperTable()
        {
            return DB.GetShipper();
        }
    }
}
