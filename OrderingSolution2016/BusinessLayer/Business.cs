using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLayer;
using DatabaseLayer;
namespace BusinessLayer
{
    public class Business
    {
        public static  List<Customer>CustomerList()
        {
            return DB.CustomerList();
         }

        public static List<Order> OrderList(Customer c)
        {  
            return DB.CustomerOrders(c.CustomerID);
        }
        public static List<OrderDetail> OrderDetailList(int OrderID)
        {
            return DB.OrderDetailList(OrderID);
        }
        public static List<Product> ProductList(Product p)
        {
            return DB.ProductList(p);
        }

        public static void SaveOrder(Order o) // check to make sure customer ID, ship Name,PostalCode,address,city,order date, employee Id arent null
        {
            if (o.CustomerID != null && o.EmployeeID != null && o.OrderDate != null && o.ShipAddress != null && o.ShipName != null && o.ShipPostalCode != null && o.ShipCity != null)
           {
                DB.CommitOrder(o);
           }
        }  
    }
}
