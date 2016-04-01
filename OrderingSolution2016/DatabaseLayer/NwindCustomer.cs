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

        public static bool CustomerIDExists(string CustomerID)
        {

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(PROC_CUSTOMERCOUNT, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            object result = cmd.ExecuteScalar();
            sqlCon.Close();
            int count = (int)result;
            if (count == 0) //no customers with this id
                return false;
            else
                return true;
        }

        public static void SaveNewCustomer(Customer NewCust)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            object obj;
            SqlCommand cmd = new SqlCommand(PROC_CREATE_CUSTOMER, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@CustomerID", NewCust.CustomerID));
            cmd.Parameters.Add(new SqlParameter("@CompanyName", NewCust.CompanyName));
            obj = NewCust.ContactName;
            cmd.Parameters.Add(new SqlParameter("@ContactName", NewCust.ContactName != null ? obj : DBNull.Value));
            obj = NewCust.ContactTitle;
            cmd.Parameters.Add(new SqlParameter("@ContactTitle", NewCust.ContactTitle != null ? obj : DBNull.Value));
            obj = NewCust.Address;
            cmd.Parameters.Add(new SqlParameter("@Address", NewCust.Address != null ? obj : DBNull.Value));
            obj = NewCust.City;
            cmd.Parameters.Add(new SqlParameter("@City", NewCust.City != null ? obj : DBNull.Value));
            obj = NewCust.Region;
            cmd.Parameters.Add(new SqlParameter("@Region", NewCust.Region != null ? obj : DBNull.Value));
            obj = NewCust.PostalCode;
            cmd.Parameters.Add(new SqlParameter("@PostalCode", NewCust.PostalCode != null ? obj : DBNull.Value));
            obj = NewCust.Country;
            cmd.Parameters.Add(new SqlParameter("@Country", NewCust.Country != null ? obj : DBNull.Value));
            obj = NewCust.Phone;
            cmd.Parameters.Add(new SqlParameter("@Phone", NewCust.Phone != null ? obj : DBNull.Value));
            obj = NewCust.Fax;
            cmd.Parameters.Add(new SqlParameter("@Fax", NewCust.Fax != null ? obj : DBNull.Value));

            cmd.ExecuteNonQuery();
            sqlCon.Close();


        }
        public static void UpdateCustomer(Customer Cust)
        {
            object obj;
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(PROC_UPDATE_CUS, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", Cust.CustomerID));
            cmd.Parameters.Add(new SqlParameter("@CompanyName", Cust.CompanyName));
            obj = Cust.ContactName;
            cmd.Parameters.Add(new SqlParameter("@ContactName", Cust.ContactName != null ? obj : DBNull.Value));
            obj = Cust.ContactTitle;
            cmd.Parameters.Add(new SqlParameter("@ContactTitle", Cust.ContactTitle != null ? obj : DBNull.Value));
            obj = Cust.Address;
            cmd.Parameters.Add(new SqlParameter("@Address", Cust.Address != null ? obj : DBNull.Value));
            obj = Cust.City;
            cmd.Parameters.Add(new SqlParameter("@City", Cust.City != null ? obj : DBNull.Value));
            obj = Cust.Region;
            cmd.Parameters.Add(new SqlParameter("@Region", Cust.Region != null ? obj : DBNull.Value));
            obj = Cust.PostalCode;
            cmd.Parameters.Add(new SqlParameter("@PostalCode", Cust.PostalCode != null ? obj : DBNull.Value));
            obj = Cust.Country;
            cmd.Parameters.Add(new SqlParameter("@Country", Cust.Country != null ? obj : DBNull.Value));
            obj = Cust.Phone;
            cmd.Parameters.Add(new SqlParameter("@Phone", Cust.Phone != null ? obj : DBNull.Value));
            obj = Cust.Fax;
            cmd.Parameters.Add(new SqlParameter("@Fax", Cust.Fax != null ? obj : DBNull.Value));

            cmd.ExecuteNonQuery();
 

            sqlCon.Close();
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



    }
}
