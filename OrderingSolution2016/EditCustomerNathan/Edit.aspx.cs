using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseLayer;
using BusinessLayer;
using System.Data;

namespace EditCustomerNathan
{
    public partial class Edit : System.Web.UI.Page
    {
        List<Customer> Customers = new List<Customer>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customers = Business.CustomerList();
            foreach (Customer c in Customers) 
            {
                ddCust.Items.Add(c.CustomerID);
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void ddCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = Business.GetCustomer(ddCust.Text);
            txtAddress.Text = c.Address;
            txtCity.Text = c.City;
            txtContactName.Text = c.ContactName;
            txtCountry.Text = c.Country;
            txtFax.Text = c.Fax;
            txtID.Text = c.CustomerID;
            txtName.Text = c.CompanyName;
            txtPhone.Text = c.Phone;
            txtPostalCode.Text = c.PostalCode;
            txtRegion.Text = c.Region;
            txtTile.Text = c.ContactTitle;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtCity.Text == "" || txtContactName.Text == "" || txtCountry.Text == "" || txtFax.Text == "" || txtID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == "" || txtRegion.Text == "" || txtTile.Text == "")
            {
                lblError.Text = "Cannot have null values";
            }
            else 
            {
                Customer c = new Customer(txtID.Text, txtName.Text, txtContactName.Text, txtTile.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);
                Business.UpdateExistingCustomer(c);
            }
        }
    }
}