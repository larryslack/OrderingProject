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

        public static List<Order> OrderList()
        {
            string CustomerID ="";
            foreach (Customer tmp in CustomerList())
            {
                CustomerID = tmp.CustomerID;
               
            }
            return DB.CustomerOrders(CustomerID);
        }
    }
}
