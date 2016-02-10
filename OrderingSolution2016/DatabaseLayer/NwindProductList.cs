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
        private const string PROC_PROD_LIST = "ProductListAllRows";

        public static List<Product> ProductList()
        {
            //Copied code from Nwind.cs VVVV
            List<Product> ProdList = new List<Product>();

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_PROD_LIST, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@OrderID", OrderID));

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();
            //Copied code^^^^
            foreach (DataRow row in dt.Rows)
            {
                //Cant be Null
                int ProductID = (int)row["ProductID"];
                string ProductName = (string)row["ProductName"];
                decimal UnitPrice = (decimal)row["UnitPrice"];
                bool Discountinued = (bool)row["Discontinued"];
                //Nullable
                string QuantityPerUnit;
                if (row["QuantityPerUnit"] != DBNull.Value)
                    QuantityPerUnit = (string)row["QuantityPerUnit"];
                else
                    QuantityPerUnit = null;

                int? SupplierID;
                if (row["SupplierID"] != DBNull.Value)
                    SupplierID = (int)row["SupplierID"];
                else
                    SupplierID = null;

                int? CategoryID;
                if (row["CategoryID"] != DBNull.Value)
                    CategoryID = (int)row["CategoryID"];
                else
                    CategoryID = null;

                short? UnitInStock;
                if (row["UnitsInStock"] != DBNull.Value)
                    UnitInStock = (short)row["UnitsInStock"];
                else
                    UnitInStock = null;

                short? UnitOnOrder;
                if (row["UnitsOnOrder"] != DBNull.Value)
                    UnitOnOrder = (short)row["UnitsOnOrder"];
                else
                    UnitOnOrder = null;

                short? ReorderLevel;
                if (row["ReorderLevel"] != DBNull.Value)
                    ReorderLevel = (short)row["ReorderLevel"];
                else
                    ReorderLevel = null;

                Product Prod = new Product(ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitInStock, UnitOnOrder, ReorderLevel, Discountinued);
                ProdList.Add(Prod);
            }
            /*put code here */
            return ProdList;
        }
    }
}
