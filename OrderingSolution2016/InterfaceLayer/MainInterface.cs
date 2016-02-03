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

        }
    }
}
