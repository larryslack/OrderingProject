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
    public partial class OrderingFormDaylend : Form
    {
        Customer CurCust;
        public OrderingFormDaylend(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            CurCust = Business.GetCustomer(CustomerID);
            lblCustomerName.Text = CurCust.CompanyName;
        }

        private void OrderingFormDaylend_Load(object sender, EventArgs e)
        {

        }
    }
}
