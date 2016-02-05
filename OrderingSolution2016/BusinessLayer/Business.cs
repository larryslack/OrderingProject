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
    }
}
