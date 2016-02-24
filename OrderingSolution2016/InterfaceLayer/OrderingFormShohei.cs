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

        int t = 5;
        int l = 5;
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

            Button b = new Button();
            b.Text = "Cancel order";
            pnlProducts.Controls.Add(b);
            b.Top = t;
            b.Left = l + 100;
            p.Tag = n;
            b.Click += Cancel_Order;

            t += 30;
        }

        void Cancel_Order(object sender, EventArgs e)
        {
            
        }
    }
}
