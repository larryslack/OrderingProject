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

        public OrderingFormKate(string CustomerID, int EmployeeID)
        {
            this.CompanyName = "lkjlkj";
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
            txtCustomerName.Text = Cust.ContactName;
        }

        private void OrderingFormKate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
