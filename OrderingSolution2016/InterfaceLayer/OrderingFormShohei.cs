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
    
    public partial class OrderingFormShohei : Form
    {

        int n = 0;

        int t = 5;
        int l = 5;

        List<Product> ProductList = new List<Product>();
        public OrderingFormShohei(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            lblCust.Text = CustomerID;
            lblEmpl.Text = EmployeeID.ToString();
        }

        private void OrderingFormShohei_Load(object sender, EventArgs e)
        {
            ProductList = Business.ProductList();
        }

        private void btnNewP_Click(object sender, EventArgs e)
        {
            n++;
            ComboBox cmb = new ComboBox();
            pnlProducts.Controls.Add(cmb);
            cmb.Top = t;
            cmb.Left = l;
            cmb.Tag = n;
            cmb.DataSource = new List<Product>(ProductList);
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";

            TextBox p = new TextBox();
            p.Text = "Where Price";
            pnlProducts.Controls.Add(p);
            p.Top = t;
            p.Left = l + 100;
            p.Tag = n;

            TextBox q = new TextBox();
            q.Text = "Where quantity";
            pnlProducts.Controls.Add(q);
            q.Top = t;
            q.Left = l + 200;
            q.Tag = n;

            TextBox tot = new TextBox();
            tot.Text = "Where total";
            pnlProducts.Controls.Add(tot);
            tot.Top = t;
            tot.Left = l + 200;
            tot.Tag = n;

            Button b = new Button();
            b.Text = "Cancel Item";
            pnlProducts.Controls.Add(b);
            b.Top = t;
            b.Left = l + 300;
            b.Tag = n;
            b.Click += Cancel_Order;

            t += 30;
        }

        void Cancel_Order(object sender, EventArgs e)
        {
            
        }
    }
}
