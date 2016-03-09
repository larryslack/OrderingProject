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
    }
}
