using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLayer
{
    public partial class OrderingFormPicker : Form
    {
        string CustomerID = null;
        int EmployeeID = 0;

        public OrderingFormPicker(string CustomerID, int EmployeeID)
        {
            InitializeComponent();

            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
        }

        private void btnBrett_Click(object sender, EventArgs e)
        {
            OrderingFormBrett OFB = new OrderingFormBrett(CustomerID, EmployeeID);
            OFB.Show();
        }

        private void btnMatt_Click(object sender, EventArgs e)
        {
            OrderingForm OFM = new OrderingForm(CustomerID, EmployeeID);
            OFM.Show();
        }
    }
}
