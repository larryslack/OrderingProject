using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;

namespace InterfaceLayer
{
    public partial class OrderingFormNathan : Form
    {
        string CustomerID;
        int EmployeeID = 0;
        int OrderId = 2;
        bool Editing = false;
        List<OrderDetail> DetailsList = new List<OrderDetail>();
        // Customer currentCustomer;
        List<Product> ProductList = new List<Product>();
        Order Test = new Order(12012);
        List<Shipper> Shippers = new List<Shipper>();
        


        public OrderingFormNathan(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblEmID.Text = EmployeeID.ToString();
            lblCustId.Text = CustomerID;
            lblTDate.Text = DateTime.Now.ToShortDateString();
            txtSDate.Text = lblTDate.Text;
            txtRDate.Text = DateTime.Now.ToShortDateString();
            cbShipVia.DataSource = BusinessLayer.Business.ShipperTable();
            cbShipVia.DisplayMember = "CompanyName";
            cbShipVia.ValueMember = "ShipperID";
            cbProducts.DataSource = BusinessLayer.Business.ProductList();
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
            Order test = new Order(OrderId);
            Shippers = BusinessLayer.Business.ShipperTable();
        }


        public OrderingFormNathan(string CustomerId, int EmployeeID, int OrderID) 
        {
            InitializeComponent();
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeID;
            lblCustId.Text = CustomerID;
            lblEmID.Text = EmployeeID.ToString();
            Editing = true;
            OrderId = OrderID;
            lblorID.Text = OrderId.ToString();
            Order Get = Business.FindOrder(OrderId);
            Customer Cust = Business.GetCustomer((CustomerID));
            DetailsList = Business.OrderDetailList(OrderId);
            txtSDate.Text = Get.ShippedDate.ToString();
            txtRDate.Text = Get.RequiredDate.ToString();
            txtAddress.Text = Get.ShipAddress.ToString();
            txtCity.Text = Get.ShipCity.ToString();
            txtPostal.Text = Get.ShipPostalCode.ToString();
            lblFin.Text = Get.Freight.ToString();
            txtCountry.Text = Get.ShipCountry.ToString();
            txtRegion.Text = Get.ShipRegion.ToString();
            txtFax.Text = Cust.Fax.ToString();
            txtPhone.Text = Cust.Phone.ToString();
            Editing = true;
            ProductList = Business.ProductList();
            foreach (OrderDetail d in DetailsList) 
            {
                lsDetails.Items.Add(d.ProductName + " " + d.Quantity.ToString());
            }
            Test = Get;
        }


        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            if (Editing == false)
            {
                int ShipperNameID = (int)cbShipVia.SelectedValue;
                string shippername = Shippers[ShipperNameID].CompanyName.ToString();
                Test = new Order(Test.OrderID, lblCustId.Text, Convert.ToInt32(lblEmID.Text), Convert.ToDateTime(lblTDate.Text), Convert.ToDateTime(txtRDate.Text), Convert.ToDateTime(txtSDate.Text), Convert.ToInt32(cbShipVia.SelectedValue.ToString()), Convert.ToDecimal(lblFin.Text), shippername.ToString(), txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostal.Text, txtCountry.Text);
                Business.SaveDetails(Test.OrderID, DetailsList);
                lsDetails.Items.Clear();
                txtDisc.Text = "0";
                txtQuantity.Text = "0";
            }
            else 
            {
                Business.UpdateOrder(Test);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DetailsList.RemoveAt(cbProducts.SelectedIndex);
            cbProducts.SelectedIndex = -1;
            txtQuantity.Text = "0";
            txtDisc.Text = "0";

        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
          
          
                int ProductId = (int)cbProducts.SelectedValue;
                ProductList = Business.ProductList();
                Product tmp = ProductList[ProductId];
                OrderDetail Detail = new OrderDetail(Test.OrderID, tmp.ProductID, tmp.UnitPrice, Convert.ToInt16(txtQuantity.Text), Convert.ToInt32(txtDisc.Text));
                Detail.ProductName = cbProducts.Text;
                DetailsList.Add(Detail);
                cbProducts.SelectedValue = -1;
                lblFin.Text = (Convert.ToDecimal(lblFin.Text) + (tmp.UnitPrice * Convert.ToInt32(txtQuantity.Text))).ToString();
                lsDetails.Items.Add(Detail.ProductName + " " + Detail.UnitPrice.ToString("c"));
                txtDisc.Text = "0";
                txtQuantity.Text = "0";

        }

        

    }
}
