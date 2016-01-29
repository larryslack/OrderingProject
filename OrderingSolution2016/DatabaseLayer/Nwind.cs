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
    public class Nwind
    {
        private static SqlConnection sqlCon;
        private static string connectionString = "Server=B231WIN7-INST; Database=nwindsql; user=sa; Password=SQL_2012; Timeout=2";

        public static List<Customer> CustomerList()
        {
            List<Customer> CusList = new List<Customer>();
            string Procedure = "CustomersTable";

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Procedure, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();


            foreach (DataRow row in dt.Rows)
            {
                string CustomerID = (string)row["CustomerID"];
                string CompanyName = (string)row["CompanyName"];
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
