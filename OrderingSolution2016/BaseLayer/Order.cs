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
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public object ShipRegion { get; set; }//could be null
        public int ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        //public List<OrderDetail> OrderDetails(){get; set;}

        #endregion
        #region Construction
        public Order(int?OrderID,string CustomerID,int?EmployeeID,DateTime OrderDate,DateTime RequiredDate,DateTime         ShippedDate,int ShipVia,decimal Freight,string ShipName,string ShipAddress,string ShipCity,string                    ShipRegion,int ShipPostalCode,string ShipCountry )
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.OrderDate=OrderDate;
            this.RequiredDate = RequiredDate;
            this.ShippedDate = ShippedDate;
            this.ShipVia = ShipVia;
            this.Freight = Freight;
            this.ShipName = ShipName;
            this.ShipAddress = ShipAddress;
            this.ShipCity = ShipCity;
            this.ShipRegion = ShipRegion;
            this.ShipPostalCode = ShipPostalCode;
            this.ShipCountry = ShipCountry;

        }

        #endregion
    }
}
