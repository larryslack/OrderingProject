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
        List<OrderDetail> DetailsList = new List<OrderDetail>();
        // Customer currentCustomer;
        List<Product> ProductList = new List<Product>();
        Order Test = new Order(50000);
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

        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            int ShipperNameID = (int)cbShipVia.SelectedValue;
            string shippername = Shippers[ShipperNameID].CompanyName.ToString();
            Order Commit = new Order(Test.OrderID, lblCustId.Text, Convert.ToInt32(lblEmID.Text), Convert.ToDateTime(lblTDate.Text), Convert.ToDateTime(txtRDate.Text), Convert.ToDateTime(txtSDate.Text), Convert.ToInt32(cbShipVia.SelectedValue.ToString()), Convert.ToDecimal(lblFin.Text), shippername.ToString(), txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostal.Text, txtCountry.Text);
            BusinessLayer.Business.SaveOrder(Commit);
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
            OrderDetail newDetail = new OrderDetail(Test.OrderID, tmp.ProductID, tmp.UnitPrice, Convert.ToInt16(txtQuantity.Text), Convert.ToInt32(txtDisc.Text));
            newDetail.ProductName = cbProducts.Text;
            DetailsList.Add(newDetail);
            cbProducts.SelectedValue = -1;
            lblFin.Text = (Convert.ToDecimal(lblFin.Text) + (tmp.UnitPrice * Convert.ToInt32(txtQuantity.Text))).ToString();
            lsDetails.Items.Add(newDetail.ProductName + " " + newDetail.UnitPrice.ToString("c"));
            txtDisc.Text = "0";
            txtQuantity.Text = "0";
        }

        private void OrderingFormNathan_FormClosing(object sender, FormClosingEventArgs e)
        {
            BusinessLayer.Business.SaveDetails(Test.OrderID, DetailsList);
        }
    }
}
