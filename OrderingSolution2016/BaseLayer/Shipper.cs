using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    #region Properties
    public class Shipper
    {
        public int ShipperID { get;private set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }


    #endregion
        #region Construction
        public Shipper(int ShipperID)
        {
            this.ShipperID = ShipperID;
        }
        public Shipper(int ShipperID, string CompanyName, string Phone)
        {
            this.ShipperID = ShipperID;
            this.CompanyName = CompanyName;
            this.Phone = Phone;
        }
        #endregion
    }
}