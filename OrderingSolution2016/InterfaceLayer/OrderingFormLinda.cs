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
    public partial class OrderingFormLinda : Form
    {

        string CustomerID;
        int EmployeeID;
        Customer Cust;
        Product productItems;
        Order NewOrder;
        OrderDetail NewOrderDet;

        public OrderingFormLinda(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblCustomerID.Text = CustomerID;
            List<Customer> Clist = Business.CustomerList();
            foreach (Customer C in Clist)
            {
                if (C.CustomerID == CustomerID)
                    Cust = C;
            }
            lblCompanyName.Text = Cust.CompanyName;
            txtCustName.Text = Cust.CompanyName;
            txtPostCode.Text = Cust.PostalCode;
            txtShipAdd.Text = Cust.Address;
            txtShipCity.Text = Cust.City;
            txtshipCountry.Text = Cust.Country;
            lblEmpID.Text = EmployeeID.ToString();
            txtShipRegion.Text = Cust.Region;
            txtPhoneNum.Text = Cust.Phone;

            //  cbShipVia.DataSource = 
            cbSelectProduct.DataSource = Business.ProductList();
            cbSelectProduct.DisplayMember = "ProductName";
            cbSelectProduct.ValueMember = "ProductID";
            cbSelectProduct.SelectedIndex = -1;
        }

        private void OrderingFormLinda_Load(object sender, EventArgs e)
        {

        }

        void EditCustomerInfo()
        {

        }

        void PlacingOrder()
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtReqDate.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Cannot ship item today. Please choose a future required date.");
                    return;
                }
                else
                {
                    int? shipvia = null;

                    shipvia = (int?)cbShipVia.SelectedValue;
                    NewOrder = new Order(0, CustomerID, EmployeeID, DateTime.Now, dtReqDate.Value.Date, null, shipvia, null, txtCustName.Text,
                       txtShipAdd.Text, txtShipCity.Text, txtShipRegion.Text, txtPostCode.Text, txtshipCountry.Text);
                    Business.SaveOrder(NewOrder);
                    txtOrderId.Text = NewOrder.OrderID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSelectProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

               // NewOrder = new OrderDetail(0,prodID,, Quantity, null);
               // Business.SaveDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
