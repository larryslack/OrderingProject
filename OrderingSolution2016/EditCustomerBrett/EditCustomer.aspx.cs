using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseLayer;
using BusinessLayer;
using System.Data;

namespace EditCustomerBrett
{
    public partial class EditCustomer : System.Web.UI.Page
    {
        private const string CUSTOMER_TABLE = "CustomerTable";
        private const string CUSTOMER_LIST = "CustomerList";
        private const string CUR_CUSTOMER = "CurrentCustomer";
        private const int TABLE_BUTTON_INDEX = 11;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateGridRows();
            }
            else
            {
                BindGrid();
            }

            ResetForm();
        }

        private void CreateGridRows()
        {
            Session[CUSTOMER_LIST] = Business.CustomerList();
            setupGrid((List<Customer>)Session[CUSTOMER_LIST]);
        }

        private void BindGrid()
        {
            DataTable dt = (DataTable)Session[CUSTOMER_TABLE];
            gridCustomers.DataSource = dt;
            gridCustomers.DataBind();
            AddButtons((List<Customer>)Session[CUSTOMER_LIST]);
        }

        private void setupGrid(List<Customer> cusList)
        {
            Session[CUSTOMER_TABLE] = cusList;

            DataTable dt = new DataTable();
            dt.Columns.Add("Customer ID");
            dt.Columns.Add("Company Name");
            dt.Columns.Add("Contact Title");
            dt.Columns.Add("Contact Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("City");
            dt.Columns.Add("Region");
            dt.Columns.Add("Postal Code");
            dt.Columns.Add("Country");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Fax");
            dt.Columns.Add("Edit");

            foreach (Customer cus in cusList)
            {
                DataRow dr = dt.NewRow();

                dr["Customer ID"] = cus.CustomerID;
                dr["Company Name"] = cus.CompanyName;
                dr["Contact Title"] = cus.ContactTitle;
                dr["Contact Name"] = cus.ContactName;
                dr["Address"] = cus.Address;
                dr["City"] = cus.City;
                dr["Region"] = cus.Region;
                dr["Postal Code"] = cus.PostalCode;
                dr["Country"] = cus.Country;
                dr["Phone"] = cus.Phone;
                dr["Fax"] = cus.Fax;

                dt.Rows.Add(dr);
            }

            Session[CUSTOMER_TABLE] = dt;
            gridCustomers.DataSource = dt;
            gridCustomers.DataBind();
            AddButtons((List<Customer>)Session[CUSTOMER_LIST]);
        }

        private void AddButtons(List<Customer> cusList)
        {
            int index = 0;

            foreach (GridViewRow dvr in gridCustomers.Rows)
            {
                if (dvr.RowType == DataControlRowType.DataRow)
                {
                    Button dynButtRemove = new Button(); // Heh!
                    dynButtRemove.Text = "Edit";
                    dynButtRemove.ID = "btnSub" + index.ToString();
                    dynButtRemove.CssClass = "btnStyles btnEdit";
                    dvr.Cells[TABLE_BUTTON_INDEX].Controls.Add(dynButtRemove);

                    dynButtRemove.Click += DynButtRemove_Click;
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblCustomer.InnerText = "New Customer";
            HideTable();
        }

        private void DynButtRemove_Click(object sender, EventArgs e)
        {
            Customer curCustomer = ((List<Customer>)Session[CUSTOMER_LIST])[Convert.ToInt32(((Button)sender).ID.Substring(6))];
            Session[CUR_CUSTOMER] = curCustomer;

            lblCustomer.InnerText = "Edit Customer";
            txtCustomerID.Enabled = false;
            HideTable();

            txtCustomerID.Text = curCustomer.CustomerID;
            txtCompanyName.Text = curCustomer.CompanyName;
            txtContactName.Text = curCustomer.ContactName;
            txtContactTitle.Text = curCustomer.ContactTitle;
            txtAddress.Text = curCustomer.Address;
            txtCity.Text = curCustomer.City;
            txtRegion.Text = curCustomer.Region;
            txtPostalCode.Text = curCustomer.PostalCode;
            txtCountry.Text = curCustomer.Country;
            txtPhone.Text = curCustomer.Phone;
            txtFax.Text = curCustomer.Fax;
        }

        private void HideTable()
        {
            btnAdd.Visible = false;
            gridCustomers.Visible = false;
            customerFields.Attributes.Add("class", "show");
        }

        private void ResetForm()
        {
            btnAdd.Visible = true;
            gridCustomers.Visible = true;
            customerFields.Attributes.Add("class", "hidden");
            txtCustomerID.Enabled = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Customer cus;
            string customerID = txtCustomerID.Text;
            bool blnExists = false;

            if (((Button)sender) == btnAdd)
            {
                cus = new Customer(customerID);
            }
            else
            {
                cus = (Customer)Session[CUR_CUSTOMER];
                blnExists = true;
            }

            cus.CompanyName = txtCompanyName.Text;
            cus.ContactName = txtContactName.Text;
            cus.ContactTitle = txtContactTitle.Text;
            cus.Address = txtAddress.Text;
            cus.City = txtCity.Text;
            cus.Region = txtRegion.Text;
            cus.PostalCode = txtPostalCode.Text;
            cus.Country = txtCountry.Text;
            cus.Phone = txtPhone.Text;
            cus.Fax = txtFax.Text;

            if (blnExists)
                Business.UpdateExistingCustomer(cus);
            else
                Business.SaveNewCustomer(cus);

            CreateGridRows();
            BindGrid();
        }
    }
}