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
    public partial class OrderingFormShohei : Form
    {

        int n = 0;

        int t = 0;
        int l = 0;
        public OrderingFormShohei(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            lblCust.Text = CustomerID;
            lblEmpl.Text = EmployeeID.ToString();
        }

        private void OrderingFormShohei_Load(object sender, EventArgs e)
        {

        }

        private void btnNewP_Click(object sender, EventArgs e)
        {
            n++;
            TextBox p = new TextBox();
            p.Text = "test " + n.ToString();
            pnlProducts.Controls.Add(p);
            p.Top = t;
            p.Left = l;
            p.Tag = n;
        }
    }
}
