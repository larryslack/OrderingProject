using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using BaseLayer;

namespace DatabaseLayer
{
    public partial class DB
    {
        private const string PROC_CUS_TABLE = "CustomersTable";
        private const string PROC_CUS = "GetCustomer";
        private const string PROC_CUS_ORDER = "CustomerOrders";
        private const string PROC_EMP_TABLE = "EmployeeTable";
        private const string PROC_UPDATE_CUS = "UpdateCustomer";
        private const string PROC_COMMIT_ORDER = "CommitOrder";
        private const string PROC_SAVE_DETAILS = "SaveDetails";
        private const string PROC_DELETE_DETAILS = "DeleteDetails";
        private const string PROC_SHIPPER_LIST = "ShipperList";
        private const string PROC_UPDATE_ORDER = "UpdateOrder";
        private const string PROC_GET_ORDER_INFO = "GetOrderInfo";
        private static SqlConnection sqlCon;
        private static string connectionString = "Server=172.18.29.17\\PROG280; Database=nwindsql; user=sa; Password=SQL_2012;";
        //private static string connectionString = "Server=PROG280SERVER.itp.local\\PROG280; Database=nwindsql; user=sa; Password=SQL_2012;";

        //private static string connectionString = "Server=PROG280SERVER\\PROG280; Database=nwindsql; user=sa; Password=SQL_2012;";
        //private static string connectionString = "server=BrettsPCMasterR;database=NwindSQL;integrated security=true;Timeout=2"; // Bretts home comp

        public static Customer GetCustomer(string CustomerID)
        {

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_CUS, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            sqlCon.Close();

            if (dt.Rows.Count == 0)
                throw new Exception("DBLayer.GetCustomer: CustomerID " + CustomerID + " not found");
            DataRow row = dt.Rows[0];

            // Start: These will always have a value and will never equal a null.
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

            return c;

        }

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
                string ShipperName;

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

                if (row["ShipName"] == DBNull.Value)
                    ShipperName = null;
                else
                    ShipperName = (string)row["ShipName"];

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
                O.ShipperName = ShipperName;

                OrdList.Add(O);
            }

            return OrdList;
        }

        public static void CommitOrder(Order newOrder)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            object obj;
            SqlCommand cmd = new SqlCommand(PROC_COMMIT_ORDER, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter();
            p.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(new SqlParameter("@CustomerID", newOrder.CustomerID));
            obj = newOrder.EmployeeID;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", newOrder.EmployeeID != null ? obj : DBNull.Value));
            obj = newOrder.OrderDate;
            cmd.Parameters.Add(new SqlParameter("@OrderDate", newOrder.OrderDate != null ? obj : DBNull.Value));
            obj = newOrder.RequiredDate;
            cmd.Parameters.Add(new SqlParameter("@RequiredDate", newOrder.RequiredDate != null ? obj : DBNull.Value));
            obj = newOrder.ShippedDate;
            cmd.Parameters.Add(new SqlParameter("@ShippedDate", newOrder.ShippedDate != null ? obj : DBNull.Value));
            obj = newOrder.ShipVia;
            cmd.Parameters.Add(new SqlParameter("@ShipVia", newOrder.ShipVia != null ? obj : DBNull.Value));
            obj = newOrder.Freight;
            cmd.Parameters.Add(new SqlParameter("@Freight", newOrder.Freight != null ? obj : DBNull.Value));
            //Business Layer does not allow these last ones to be null
            cmd.Parameters.Add(new SqlParameter("@ShipName", newOrder.ShipName));
            cmd.Parameters.Add(new SqlParameter("@ShipAddress", newOrder.ShipAddress));
            cmd.Parameters.Add(new SqlParameter("@ShipCity", newOrder.ShipCity));
            cmd.Parameters.Add(new SqlParameter("@ShipRegion", newOrder.ShipRegion));
            cmd.Parameters.Add(new SqlParameter("@ShipPostalCode", newOrder.ShipPostalCode));
            cmd.Parameters.Add(new SqlParameter("@ShipCountry", newOrder.ShipCountry));

            cmd.ExecuteNonQuery();
            // Change the OrderID of the order that is passed in to its new ID

            newOrder.OrderID = (int)p.Value;
            sqlCon.Close();
        }
        public static void UpdateOrder(Order OrderToUpdate)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            object obj;
            SqlCommand cmd = new SqlCommand(PROC_UPDATE_ORDER, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@OrderID", OrderToUpdate.OrderID));
            cmd.Parameters.Add(new SqlParameter("@CustomerID", OrderToUpdate.CustomerID));
            obj = OrderToUpdate.EmployeeID;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", OrderToUpdate.EmployeeID != null ? obj : DBNull.Value));
            obj = OrderToUpdate.OrderDate;
            cmd.Parameters.Add(new SqlParameter("@OrderDate", OrderToUpdate.OrderDate != null ? obj : DBNull.Value));
            obj = OrderToUpdate.RequiredDate;
            cmd.Parameters.Add(new SqlParameter("@RequiredDate", OrderToUpdate.RequiredDate != null ? obj : DBNull.Value));
            obj = OrderToUpdate.ShippedDate;
            cmd.Parameters.Add(new SqlParameter("@ShippedDate", OrderToUpdate.ShippedDate != null ? obj : DBNull.Value));
            obj = OrderToUpdate.ShipVia;
            cmd.Parameters.Add(new SqlParameter("@ShipVia", OrderToUpdate.ShipVia != null ? obj : DBNull.Value));
            obj = OrderToUpdate.Freight;
            cmd.Parameters.Add(new SqlParameter("@Freight", OrderToUpdate.Freight != null ? obj : DBNull.Value));
            //Business Layer does not allow these last ones to be null
            cmd.Parameters.Add(new SqlParameter("@ShipName", OrderToUpdate.ShipName));
            cmd.Parameters.Add(new SqlParameter("@ShipAddress", OrderToUpdate.ShipAddress));
            cmd.Parameters.Add(new SqlParameter("@ShipCity", OrderToUpdate.ShipCity));
            cmd.Parameters.Add(new SqlParameter("@ShipRegion", OrderToUpdate.ShipRegion));
            cmd.Parameters.Add(new SqlParameter("@ShipPostalCode", OrderToUpdate.ShipPostalCode));
            cmd.Parameters.Add(new SqlParameter("@ShipCountry", OrderToUpdate.ShipCountry));

            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public static List<Employee> getCustomers()
        {
            List<Employee> EmployList = new List<Employee>();

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_EMP_TABLE, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();

            // Modify
            foreach (DataRow row in dt.Rows)
            {
                // Start: These will always have a value and will never equal a null.
                int EmployeeID = (int)row["EmployeeID"];
                // End.

                string FirstName;
                string LastName;
                string Title;
                string TitleOfCourtesy;
                DateTime? BirthDate;
                DateTime? HireDate;
                string Address;
                string City;
                string Region;
                string PostalCode;
                string Country;
                string HomePhone;
                string Extension;

                if (row["FirstName"] == DBNull.Value)
                    FirstName = null;
                else
                    FirstName = (string)row["FirstName"];

                if (row["LastName"] == DBNull.Value)
                    LastName = null;
                else
                    LastName = (string)row["LastName"];

                if (row["Title"] == DBNull.Value)
                    Title = null;
                else
                    Title = (string)row["Title"];

                if (row["TitleOfCourtesy"] == DBNull.Value)
                    TitleOfCourtesy = null;
                else
                    TitleOfCourtesy = (string)row["TitleOfCourtesy"];

                if (row["BirthDate"] == DBNull.Value)
                    BirthDate = null;
                else
                    BirthDate = (DateTime)row["BirthDate"];

                if (row["HireDate"] == DBNull.Value)
                    HireDate = null;
                else
                    HireDate = (DateTime)row["HireDate"];

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

                if (row["HomePhone"] == DBNull.Value)
                    HomePhone = null;
                else
                    HomePhone = (string)row["HomePhone"];

                if (row["Extension"] == DBNull.Value)
                    Extension = null;
                else
                    Extension = (string)row["Extension"];

                Employee E = new Employee(EmployeeID);

                E.FirstName = FirstName;
                E.LastName = LastName;
                E.Title = Title;
                E.TitleOfCourtesy = TitleOfCourtesy;
                E.BirthDate = BirthDate;
                E.HireDate = HireDate;
                E.PostalCode = PostalCode;
                E.Address = Address;
                E.City = City;
                E.Region = Region;
                E.PostalCode = PostalCode;
                E.Country = Country;
                E.HomePhone = HomePhone;
                E.Extension = Extension;

                EmployList.Add(E);
            }

            return EmployList;
        }

        public static Order GetOrder(int orderID)
        {
            Order order = new Order(orderID);

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_GET_ORDER_INFO, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();
            
            DataRow row = dt.Rows[0];

            // Start: These will always have a value and will never equal a null.
            string CustomerID = (string)row["CustomerID"];
            // End.

            int? EmployeeID = null;
            DateTime? OrderDate = null;
            DateTime? RequiredDate = null;
            DateTime? ShippedDate = null;
            int? ShipVia = null;
            decimal? Freight = null;
            string ShipName = null;
            string ShipAddress = null;
            string ShipCity = null;
            string ShipRegion = null;
            string ShipPostalCode = null;
            string ShipCountry = null;
            string ShipperName = null;

            if (row["EmployeeID"] != DBNull.Value)
                EmployeeID = (int)row["EmployeeID"];

            if (row["OrderDate"] != DBNull.Value)
                OrderDate = (DateTime)row["OrderDate"];

            if (row["RequiredDate"] != DBNull.Value)
                RequiredDate = (DateTime)row["RequiredDate"];

            if (row["ShippedDate"] != DBNull.Value)
                ShippedDate = (DateTime)row["ShippedDate"];

            if (row["ShipVia"] != DBNull.Value)
                ShipVia = (int)row["ShipVia"];

            if (row["Freight"] != DBNull.Value)
                Freight = (decimal)row["Freight"];

            if (row["ShipName"] != DBNull.Value)
                ShipName = (string)row["ShipName"];

            if (row["ShipAddress"] != DBNull.Value)
                ShipAddress = (string)row["ShipAddress"];

            if (row["ShipCity"] != DBNull.Value)
                ShipCity = (string)row["ShipCity"];

            if (row["ShipRegion"] != DBNull.Value)
                ShipRegion = (string)row["ShipRegion"];

            if (row["ShipPostalCode"] != DBNull.Value)
                ShipPostalCode = (string)row["ShipPostalCode"];

            if (row["ShipCountry"] != DBNull.Value)
                ShipCountry = (string)row["ShipCountry"];

            if (row["ShipName"] != DBNull.Value)
                ShipperName = (string)row["ShipName"];

            order.CustomerID = CustomerID;
            order.EmployeeID = EmployeeID;
            order.OrderDate = OrderDate;
            order.RequiredDate = RequiredDate;
            order.ShippedDate = ShippedDate;
            order.ShipVia = ShipVia;
            order.Freight = Freight;
            order.ShipName = ShipName;
            order.ShipAddress = ShipAddress;
            order.ShipCity = ShipCity;
            order.ShipRegion = ShipRegion;
            order.ShipPostalCode = ShipPostalCode;
            order.ShipCountry = ShipCountry;
            order.ShipperName = ShipperName;

            return order;
        }

    public static void ReplaceDetails(int OrderID, List<OrderDetail> ordDetailsList)
    {

        SqlTransaction trans = null;
        try
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            trans = sqlCon.BeginTransaction(); //create new transaction
                                               //first remove all previous details for this order
            SqlCommand cmdA = new SqlCommand(PROC_DELETE_DETAILS, sqlCon);
            cmdA.CommandType = CommandType.StoredProcedure;
            cmdA.Parameters.Add(new SqlParameter("@OrderID", OrderID));
            cmdA.Transaction = trans; //this command will be part of the transaction
            cmdA.ExecuteNonQuery();

            //and replace them with ones from the list supplied
            foreach (OrderDetail od in ordDetailsList)
            {
                SqlCommand cmd = new SqlCommand(PROC_SAVE_DETAILS, sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@OrderID", OrderID)); //safer to take from OrderID
                cmd.Parameters.Add(new SqlParameter("@ProductID", od.ProductID));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", od.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", od.Quantity));
                cmd.Parameters.Add(new SqlParameter("@Discount", od.Discount));
                cmd.Transaction = trans;// also each of these commands in the transaction
                cmd.ExecuteNonQuery();
            }
            trans.Commit(); // the changes were successful so commit this transaction to the database
            sqlCon.Close();

        }
        catch (Exception ex)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
            {
                trans.Rollback();
                sqlCon.Close();
            }
            throw ex;
        }
    }

    public static List<Shipper> GetShipper()
    {
        List<Shipper> shipperList = new List<Shipper>();

        sqlCon = new SqlConnection(connectionString);
        sqlCon.Open();

        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand(PROC_SHIPPER_LIST, sqlCon);
        cmd.CommandType = CommandType.StoredProcedure;
        da = new SqlDataAdapter(cmd);
        da.FillSchema(dt, SchemaType.Source);
        da.Fill(dt);

        sqlCon.Close();

        foreach (DataRow row in dt.Rows)
        {
            int shipperID = -1;
            string companyName = null;
            string phone = "";

            shipperID = (int)row["ShipperID"];

            if (!(row["CompanyName"] == DBNull.Value))
                companyName = (string)row["CompanyName"];

            if (!(row["Phone"] == DBNull.Value))
                phone = (string)row["Phone"];

            shipperList.Add(new Shipper(shipperID, companyName, phone));
        }

        return shipperList;
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
