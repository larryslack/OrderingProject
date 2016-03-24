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
        EditingForm ad = new EditingForm();
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
            txtCustomerID.Text = CurCustomer.CustomerID;
            txtContactName.Text = CurCustomer.ContactName;
            txtCompPhone.Text = CurCustomer.Phone;
            txtContactName.Text = CurCustomer.ContactName;
            txtCompFax.Text = CurCustomer.Fax;
            txtCompMail.Text = CurCustomer.PostalCode;
            
            
            //get the orders for this customer and display in the grid
            CustomerOrderList = Business.OrderList(CurCustomer);
           // OrderGrid.DataSource = CustomerOrderList;

            //Where to look for way to choose columns
            //http://stackoverflow.com/questions/14793990/how-to-show-only-certain-columns-in-a-datagridview-with-custom-objects

            OrderGrid.DataSource = CustomerOrderList.Select(ord => new 
            {   OrderID = ord.OrderID, 
                Employee = ord.EmployeeName, 
                OrderDate = ord.OrderDate,
                RequiredDate = ord.RequiredDate,
                ShippedDate = ord.ShippedDate,
                ShipperName = ord.ShipperName,
                ShipName = ord.ShipName,
                ShipAddress = ord.ShipAddress,
                ShipCity = ord.ShipCity,
                ShipRegion = ord.ShipRegion,
                ShipPostalCode = ord.ShipPostalCode,
                ShipCountry = ord.ShipCountry,
                Freight = ord.Freight                
            }).ToList();

            OrderGrid.Columns[0].Width = 50;
            OrderGrid.Columns[1].Width = 50;
            OrderGrid.Columns[2].Width = 70;
            OrderGrid.Columns[3].Width = 90;
            OrderGrid.Columns[4].Width = 80;
            OrderGrid.Columns[5].Width = 50;
            OrderGrid.Columns[7].Width = 70;
            OrderGrid.Columns[8].Width = 60;
            OrderGrid.Columns[9].Width = 50;
            OrderGrid.Columns[10].Width = 50;
            OrderGrid.Columns[11].Width = 60;
            OrderGrid.Columns[12].Width = 50;
            
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            OrderingFormPicker OFP = new OrderingFormPicker(CurCustomer.CustomerID, 11, 10643);
            OFP.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrderingFormPicker OFP = new OrderingFormPicker(CurCustomer.CustomerID, 11);
            OFP.Show();
        }

        private void btnReOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
