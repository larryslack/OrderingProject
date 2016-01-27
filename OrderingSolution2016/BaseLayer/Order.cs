using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    class Order
    {
        #region Properties
        public int? OrderID { get; private set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }





        #endregion
    }
}
