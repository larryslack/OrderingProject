using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;

namespace InterfaceLayer
{
    public partial class OrderingFormBrett : Form
    {
        string CustomerID;
        int EmployeeID;
        List<OrderDetail> DetailList = new List<OrderDetail>();

        public OrderingFormBrett(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblCustomerID.Text = CustomerID;
            lblEmployeeID.Text = EmployeeID.ToString();
        }

        private void OrderingFormBrett_Load(object sender, EventArgs e)
        {
        }

        private void btnRandomOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order NewOrder = new Order(0, CustomerID, EmployeeID, DateTime.Now, DateTime.Now + new TimeSpan(7, 0, 0, 0), null, null, null, CustomerID + "Name", "123 4 St", "Medicine Hat", "AB", "T1A 7A7", "Canada");
                Business.SaveOrder(NewOrder);
                ls.Items.Add("The new order number is " + NewOrder.OrderID.ToString());
                OrderDetail NewOrderDetail = new OrderDetail(NewOrder.OrderID, 22, 10.22m, 100, 0);
                DetailList.Add(NewOrderDetail);

                NewOrderDetail = new OrderDetail(NewOrder.OrderID, 33, 33.33m, 200, .2f);
                DetailList.Add(NewOrderDetail);
                Business.SaveDetails(NewOrder.OrderID, DetailList);
                ls.Items.Add("Order and 2 details were saved Yeah!!!!!!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
