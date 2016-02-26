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

        List<OrderDetail> DetailsList = new List<OrderDetail>();
        
        
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
    }
}
