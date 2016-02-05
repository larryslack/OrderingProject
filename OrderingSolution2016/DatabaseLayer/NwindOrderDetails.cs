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
        private const string PROC_ORD_DETAILS = "OrderDetails";

        public static List<OrderDetail> OrderDetailList(int OrderID)
        {
            //Copied code from Nwind.cs VVVV
            List<OrderDetail> OrdDetList = new List<OrderDetail>();

            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(PROC_ORD_DETAILS, sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", OrderID));

            da = new SqlDataAdapter(cmd);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            sqlCon.Close();
            //Copied code^^^^
            foreach (DataRow row in dt.Rows)
            {
                //int OrderID = (int)row["OrderID"];
                //string ProductName = (string)row["ProductName"];
                int ProductID = (int)row["ProductID"];
                decimal UnitPrice = (decimal)row["UnitPrice"];
                short Quantity = (short)row["Quantity"];
                float Discount = (float)row["Discount"];

                OrderDetail OrD = new OrderDetail(OrderID,ProductID,UnitPrice,Quantity,Discount);
                OrdDetList.Add(OrD);
            }
      /*put code here */
            return OrdDetList;
        }
    }
}
