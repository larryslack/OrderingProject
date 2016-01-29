using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    class OrderDetail
    {
        #region Propertise
        public int OrderID { get; private set; }
        public int ProductID { get; private set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount {get;set;}


        #endregion
        #region Construction
        public OrderDetail(int OrderID,int ProductID,decimal UnitPrice,short Quantity,float Discount)
        {
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.Discount = Discount;
        }
        #endregion
    }
}
