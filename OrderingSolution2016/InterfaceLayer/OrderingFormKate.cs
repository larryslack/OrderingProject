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
    public partial class OrderingFormKate : Form
    {

        string CustomerID;
        string CompanyName;
        int EmployeeID;
        Customer Cust;
        int NewOrderID;
        int DetailCount = 0;
        int OrderDiscount;
        Order NewOrder;
        List<OrderDetail> DetailList;

        public OrderingFormKate(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            Cust = BusinessLayer.Business.GetCustomer(CustomerID);
            txtName.Text = Cust.CompanyName;
            txtAddress.Text = Cust.Address;
            txtCountry.Text = Cust.Country;
            txtCity.Text = Cust.City;
            txtPostalCode.Text = Cust.PostalCode;
            txtRegion.Text = Cust.Region;
            txtCustomerID.Text = Cust.CustomerID;
            txtContactName.Text = Cust.ContactName;
            txtCustomerName.Text = Cust.CompanyName;
            dtpOrderDate.Value = DateTime.Now;
            dtpRequiredDate.Value = DateTime.Now + new TimeSpan(7, 0, 0, 0);
        }

        private void OrderingFormKate_Load(object sender, EventArgs e) 
        {
            List<Product> ProductList = Business.ProductList();
            // KateDetailPanel pp = new KateDetailPanel(pnlDetails, 5, NewOrderID, ProductList);
            cmbShipVia.DataSource =Business.ShipperTable();
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShipVia.SelectedIndex = -1;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<Product> ProductList = Business.ProductList();
            KateDetailPanel pp = new KateDetailPanel(pnlDetails, 5 + 30 * DetailCount, NewOrderID, ProductList);
           DetailCount += 1;
 
        }

        private void btnSaveNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                NewOrder = new Order(0, CustomerID, EmployeeID, dtpOrderDate.Value, dtpRequiredDate.Value, null, (int?)cmbShipVia.SelectedValue, null,
                 txtName.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text);
                Business.SaveOrder(NewOrder);
                NewOrderID = NewOrder.OrderID;
                lblNewOrderID.Text = NewOrderID.ToString();
                btnNew.Enabled = true;
                btnSaveNewOrder.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            // make sure the information is okay 

            // create the details list
            DetailList = new List<OrderDetail>();
            try
            {
                foreach (KateDetailPanel panel in pnlDetails.Controls)
                {
                    if (panel.OD.ProductID > 0)
                    DetailList.Add(panel.OD);
                }

                Business.SaveDetails(NewOrderID, DetailList);

                MessageBox.Show("Your order has been saved!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbShipVia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
