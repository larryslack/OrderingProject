using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BaseLayer;

namespace DatabaseLayer
{
    public partial class DB
    {
        private const string PROC_CUS_TABLE = "CustomersTable";
        private const string PROC_CUS_ORDER = "CustomerOrders";
        private const string PROC_UPDATE_CUS = "UpdateCustomer";
        private const string PROC_MAKE_ORDER = "MakeOrder";

        private static SqlConnection sqlCon;
        private static string connectionString = "Server=Win7B228-INST; Database=nwindsql; user=sa; Password=SQL_2012; Timeout=2";

        public static List<Customer> CustomerList()
        {
            List<Customer> CusList = new List<Customer>();

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_CUS_TABLE, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();


            foreach (DataRow row in dt.Rows)
            {
                // Start: These will always have a value and will never equal a null.
                string CustomerID = (string)row["CustomerID"];
                string CompanyName = (string)row["CompanyName"];
                // End

                string ContactName;
                string ContactTitle;
                string Address;
                string City;
                string Region;
                string PostalCode;
                string Country;
                string Phone;
                string Fax;

                if (row["ContactName"] == DBNull.Value)
                    ContactName = null;
                else
                    ContactName = (string)row["ContactName"];

                if (row["ContactTitle"] == DBNull.Value)
                    ContactTitle = null;
                else
                    ContactTitle = (string)row["ContactTitle"];

                if (row["Address"] == DBNull.Value)
                    Address = null;
                else
                    Address = (string)row["Address"];

                if (row["City"] == DBNull.Value)
                    City = null;
                else
                    City = (string)row["City"];

                if (row["Region"] == DBNull.Value)
                    Region = null;
                else
                    Region = (string)row["Region"];

                if (row["PostalCode"] == DBNull.Value)
                    PostalCode = null;
                else
                    PostalCode = (string)row["PostalCode"];

                if (row["Country"] == DBNull.Value)
                    Country = null;
                else
                    Country = (string)row["Country"];

                if (row["Phone"] == DBNull.Value)
                    Phone = null;
                else
                    Phone = (string)row["Phone"];

                if (row["Fax"] == DBNull.Value)
                    Fax = null;
                else
                    Fax = (string)row["Fax"];

                Customer c = new Customer(CustomerID);

                c.CompanyName = CompanyName;
                c.ContactName = ContactName;
                c.ContactTitle = ContactTitle;
                c.Address = Address;
                c.City = City;
                c.Region = Region;
                c.PostalCode = PostalCode;
                c.Country = Country;
                c.Phone = Phone;
                c.Fax = Fax;

                CusList.Add(c);
            }

            return CusList;
        }
        public static List<Order> CustomerOrders(string CusID)
        {
            List<Order> OrdList = new List<Order>();

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_CUS_ORDER, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", CusID));

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();

            // Modify
            foreach (DataRow row in dt.Rows)
            {
                // Start: These will always have a value and will never equal a null.
                int OrderID = (int)row["OrderID"];
                string CustomerID = (string)row["CustomerID"];
                // End.

                int? EmployeeID;
                DateTime? OrderDate;
                DateTime? RequiredDate;
                DateTime? ShippedDate;
                int? ShipVia;
                decimal? Freight;
                string ShipName;
                string ShipAddress;
                string ShipCity;
                string ShipRegion;
                string ShipPostalCode;
                string ShipCountry;

                if (row["EmployeeID"] == DBNull.Value)
                    EmployeeID = null;
                else
                    EmployeeID = (int)row["EmployeeID"];

                if (row["OrderDate"] == DBNull.Value)
                    OrderDate = null;
                else
                    OrderDate = (DateTime)row["OrderDate"];

                if (row["RequiredDate"] == DBNull.Value)
                    RequiredDate = null;
                else
                    RequiredDate = (DateTime)row["RequiredDate"];

                if (row["ShippedDate"] == DBNull.Value)
                    ShippedDate = null;
                else
                    ShippedDate = (DateTime)row["ShippedDate"];

                if (row["ShipVia"] == DBNull.Value)
                    ShipVia = null;
                else
                    ShipVia = (int)row["ShipVia"];

                if (row["Freight"] == DBNull.Value)
                    Freight = null;
                else
                    Freight = (decimal)row["Freight"];

                if (row["ShipName"] == DBNull.Value)
                    ShipName = null;
                else
                    ShipName = (string)row["ShipName"];

                if (row["ShipAddress"] == DBNull.Value)
                    ShipAddress = null;
                else
                    ShipAddress = (string)row["ShipAddress"];

                if (row["ShipCity"] == DBNull.Value)
                    ShipCity = null;
                else
                    ShipCity = (string)row["ShipCity"];

                if (row["ShipRegion"] == DBNull.Value)
                    ShipRegion = null;
                else
                    ShipRegion = (string)row["ShipRegion"];

                if (row["ShipPostalCode"] == DBNull.Value)
                    ShipPostalCode = null;
                else
                    ShipPostalCode = (string)row["ShipPostalCode"];

                if (row["ShipCountry"] == DBNull.Value)
                    ShipCountry = null;
                else
                    ShipCountry = (string)row["ShipCountry"];

                Order O = new Order(OrderID);

                O.CustomerID = CustomerID;
                O.EmployeeID = EmployeeID;
                O.OrderDate = OrderDate;
                O.RequiredDate = RequiredDate;
                O.ShippedDate = ShippedDate;
                O.ShipVia = ShipVia;
                O.Freight = Freight;
                O.ShipName = ShipName;
                O.ShipAddress = ShipAddress;
                O.ShipCity = ShipCity;
                O.ShipRegion = ShipRegion;
                O.ShipPostalCode = ShipPostalCode;
                O.ShipCountry = ShipCountry;

                OrdList.Add(O);
            }

            return OrdList;
        }

        public static void MakeOrder(Order newOrder)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(PROC_MAKE_ORDER, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", newOrder.CustomerID));
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", newOrder.EmployeeID));
            cmd.Parameters.Add(new SqlParameter("@OrderDate", newOrder.OrderDate));
            cmd.Parameters.Add(new SqlParameter("@RequiredDate", newOrder.RequiredDate));
            cmd.Parameters.Add(new SqlParameter("@ShippedDate", newOrder.ShippedDate));
            cmd.Parameters.Add(new SqlParameter("@ShipVia", newOrder.ShipVia));
            cmd.Parameters.Add(new SqlParameter("@Freight", newOrder.Freight));
            cmd.Parameters.Add(new SqlParameter("@ShipName", newOrder.ShipName));
            cmd.Parameters.Add(new SqlParameter("@ShipAddress", newOrder.ShipAddress));
            cmd.Parameters.Add(new SqlParameter("@ShipCity", newOrder.ShipCity));
            cmd.Parameters.Add(new SqlParameter("@ShipRegion", newOrder.ShipRegion));
            cmd.Parameters.Add(new SqlParameter("@ShipPostalCode", newOrder.ShipPostalCode));
            cmd.Parameters.Add(new SqlParameter("@ShipCountry", newOrder.ShipCountry));

            cmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        public static void UpdateCustomer(string EmployeeID)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(PROC_UPDATE_CUS, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add();
            

            sqlCon.Close();
        }
    }
}
