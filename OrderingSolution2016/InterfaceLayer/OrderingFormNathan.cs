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
    public partial class OrderingFormNathan : Form
    {
        string CustomerID;
        int EmployeeID = 0;

        List<OrderDetail> DetailsList;
        Customer currentCustomer;
        List<Product> ProductList;
        
        
        public OrderingFormNathan(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblEmID.Text = EmployeeID.ToString();
            lblCustId.Text = CustomerID;
            cbProducts.DataSource = BusinessLayer.Business.ProductList();
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
            
        }

        private void btnAddOrd_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DetailsList.RemoveAt(cbProducts.SelectedIndex);
            cbProducts.SelectedIndex = -1;
            txtQuantity.Text = "0";
            lblBaseCost.Text = "";
            txtDisc.Text = "0";
            txtfUnitPrice.Text = "";
            
        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            //DetailsList.Add(new OrderDetail())
        }
    }
}
