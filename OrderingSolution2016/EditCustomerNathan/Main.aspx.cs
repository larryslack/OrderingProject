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
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string FrickenFrick = "";
            if (txtAddress.Text == "" || txtCity.Text == "" || txtContactName.Text == "" || txtCountry.Text == "" || txtFax.Text == "" || txtID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtPostalCode.Text == "" || txtRegion.Text == "" || txtTile.Text == "")
            {
                lblError.Text = "Cannot have null values";
            }
            else 
            {
                if(Business.CustomerIDAvailableAndSuitable(txtID.Text, ref FrickenFrick) == false)
                {
                    lblError.Text = FrickenFrick;
                }
                else
                {
                    Customer c = new Customer(txtID.Text, txtName.Text, txtContactName.Text, txtTile.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);
                    Business.SaveNewCustomer(c);
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
    }
}