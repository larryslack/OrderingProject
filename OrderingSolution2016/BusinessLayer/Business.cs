using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLayer;
using DatabaseLayer;
using System.Data;
using System.Data.Sql;
namespace BusinessLayer
{
    public class Business
    {
        public static List<Customer> CustomerList()
        {
            return DB.CustomerList();
        }
        public static Customer GetCustomer(string CustomerID)
        {
            return DB.GetCustomer(CustomerID);
        }

        public static List<Order> OrderList(Customer c)
        {
            return DB.CustomerOrders(c.CustomerID);
        }
        public static List<OrderDetail> OrderDetailList(int OrderID)
        {
            return DB.OrderDetailList(OrderID);
        }
        public static List<Product> ProductList()
        {
            return DB.ProductList();
        }

        public static Order FindOrder(int OrderID)
        {
            return DB.GetOrder(OrderID);
        }

        public static void SaveOrder(Order o) // check to make sure customer ID, ship Name,PostalCode,address,city,order date, employee Id arent null
        {
            if (o.CustomerID != null && o.EmployeeID != null && o.OrderDate != null && o.ShipAddress != null && o.ShipName != null && o.ShipPostalCode != null && o.ShipCity != null)
            {
                DB.CommitOrder(o);
            }
            else
            {
                throw new Exception("Order is missing vital information - please make sure all fields are filled in");
            }
        }

        public static void UpdateOrder(Order o) // check to make sure Order ID, customer ID, ship Name,PostalCode,address,city,order date, employee Id arent null
        {
            if (o.OrderID != null && o.CustomerID != null && o.EmployeeID != null && o.OrderDate != null && o.ShipAddress != null && o.ShipName != null && o.ShipPostalCode != null && o.ShipCity != null)
            {
                DB.UpdateOrder(o);
            }
        }

        public static void SaveDetails(int OrderID, List<OrderDetail> ordDetailList)
        {
            DB.ReplaceDetails(OrderID, ordDetailList);
        }

        public static List<Shipper> ShipperTable()
        {
            return DB.GetShipper();
        }

        public static bool CustomerIDAvailableAndSuitable(string CandidateID, ref string Message)
        {
            bool KeyOK = true;
            Message = "New CustomerID is available and OK";
            bool CustomerIDExists = DB.CustomerIDExists(CandidateID);
            if (CustomerIDExists)
            {
                KeyOK = false;
                Message = "Sorry " + CandidateID + " is already used by an existing customer";
            }
            else
            {
                if (CandidateID.Length != 5)
                {
                    Message = "Customer ID needs to be exactly 5 characters long";
                    KeyOK = false;
                }
            }
            return KeyOK;
        }
        public static void SaveNewCustomer(Customer C)
        {
            DB.SaveNewCustomer(C);
        }

        public static void UpdateExistingCustomer(Customer C)
        {
            DB.UpdateCustomer(C);
        }
    }
}
