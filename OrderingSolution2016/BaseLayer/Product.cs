using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    public class Product
    {
        #region properties

        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short? UnitInStock { get; set; }
        public short? UnitOnOrder { get; set; }
        public int? ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
        #endregion

        #region Constrction

        public Product(int ProductID, string ProductName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal UnitPrice, short? UnitInStock, short? UnitOnOrder,
            int? ReOrderLevel, bool Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.CategoryID = CategoryID;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitInStock = UnitInStock;
            this.UnitOnOrder = UnitOnOrder;
            this.ReOrderLevel = ReOrderLevel;
            this.Discontinued = Discontinued;
        }





        #endregion

    }
}
