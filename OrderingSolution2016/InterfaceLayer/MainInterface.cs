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
    public partial class MainInterface : Form
    {
        AddingForm ad = new AddingForm();
        Customer CurCustomer;
        List<Customer> CustomerList;
        List<Order> CustomerOrderList;

        public MainInterface()
        {
            InitializeComponent();
            FillCombos();
        }
        void FillCombos()
        {
            CustomerList = Business.CustomerList();
            cmbCustomers.DataSource = CustomerList;
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CustomerID";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompNameChange_Click(object sender, EventArgs e)
        {
            
            ad.ShowDialog();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurCustomer = CustomerList[cmbCustomers.SelectedIndex];
            txtCompID.Text = CurCustomer.ContactName;
            txtCompPhone.Text = CurCustomer.Phone;
            txtCompID.Text = CurCustomer.CustomerID;
            txtCompFax.Text = CurCustomer.Fax;
            txtCompMail.Text = CurCustomer.PostalCode;
            
            //get the orders for this customer and display in the grid
            CustomerOrderList = Business.OrderList(CurCustomer);
            OrderGrid.DataSource = CustomerOrderList;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnReOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
