using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BaseLayer;

namespace CustomerManager
{
    public partial class CustomerManager : System.Web.UI.Page
    {
        private const string CUST_LIST = "CUST_LIST";
        private const string CUR_CUST = "CUR_CUST";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getDBCustomers();
            }

            refreshCompanyName();
        }

        private void getDBCustomers()
        {
            Session[CUST_LIST] = Business.CustomerList();
        }

        private void refreshCompanyName()
        {
            List<Customer> custList = (List<Customer>)Session[CUST_LIST];
            foreach(Customer cust in custList)
            {
                ddCompanyName.Items.Add(new ListItem(cust.CompanyName, cust.CustomerID));
            }
            ddCompanyName_SelectedIndexChanged(null, null);
        }

        private void updateCustControls()   // Does not include ddCompanyName
        {
            Customer cust = (Customer)Session[CUR_CUST];

            txtAddress.Text = cust.Address;
            txtCity.Text = cust.City;
            txtCompanyName.Text = cust.CompanyName;
            txtConName.Text = cust.ContactName;
            txtCountry.Text = cust.Country;
            txtCustID.Text = cust.CustomerID;
            txtFax.Text = cust.Fax;
            txtPCode.Text = cust.PostalCode;
            txtPhone.Text = cust.Phone;
            txtRegion.Text = cust.Region;
        }

        private void clearCustControls()    // Includes ddCompanyName
        {
            Session[CUR_CUST] = null;
            ddCompanyName.ClearSelection();
            ddCompanyName.Items.Clear();
            ddCompanyName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCompanyName.Text = "";
            txtConName.Text = "";
            txtCountry.Text = "";
            txtCustID.Text = "";
            txtFax.Text = "";
            txtPCode.Text = "";
            txtPhone.Text = "";
            txtRegion.Text = "";
        }

        protected void ddCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> custList = (List<Customer>)Session[CUST_LIST];
            string custID = ddCompanyName.SelectedValue;
            Customer curCust = null;

            foreach(Customer cust in custList)
            {
                if(custID == cust.CustomerID)
                {
                    curCust = cust;
                    break;
                }
            }

            if (curCust != null)
            {
                Session[CUR_CUST] = curCust;
                updateCustControls();
            }
            else
                throw new Exception("Customer ID mismatch between ddCompanyName and Customer List.");   // This shouldn't happen, but in case it does...
        }

        protected void rbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curVal = rbList.SelectedValue;

            if (curVal == "Edit")
            {
                refreshCompanyName();
                txtCustID.ReadOnly = true;
            }
            else if (curVal == "Create")
            {
                clearCustControls();    // Will this trigger a selected index change?
                txtCustID.ReadOnly = false;
            }
            else
                throw new Exception("Operation mode not recognized on index change."); // This also shouldn't happen.
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string curVal = rbList.SelectedValue;

            if (curVal == "Edit")
            {
                Customer cust = (Customer)Session[CUR_CUST];

                cust.Address = txtAddress.Text;
                cust.City = txtCity.Text;
                cust.CompanyName = txtCompanyName.Text;
                cust.ContactName = txtConName.Text;
                cust.Country = txtCountry.Text;
                cust.CustomerID = txtCustID.Text;
                cust.Fax = txtFax.Text;
                cust.PostalCode = txtPCode.Text;
                cust.Phone = txtPhone.Text;
                cust.Region = txtRegion.Text;

                Business.UpdateExistingCustomer(cust);
            }
            else if (curVal == "Create")
            {
                if(txtCustID.Text.Length == 5)
                {
                    if(txtAddress.Text.Length > 0 && txtCity.Text.Length > 0 && txtConName.Text.Length > 0 && txtCountry.Text.Length > 0 && txtFax.Text.Length > 0 && txtPCode.Text.Length > 0
                        && txtPhone.Text.Length > 0 && txtRegion.Text.Length > 0 && txtCompanyName.Text.Length > 0)
                    {
                        Customer cust = new Customer(txtCustID.Text, txtCompanyName.Text, txtConName.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);
                        Business.SaveNewCustomer(cust);
                    }
                }
            }
            else
                throw new Exception("Operation mode not recognized on save.");

            getDBCustomers();
        }
    }
}