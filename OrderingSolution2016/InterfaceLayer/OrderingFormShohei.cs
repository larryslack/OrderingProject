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
        int employeeID;
        Customer custerd;
        List<Product> ProductList = new List<Product>();
        List<OrderDetail> OrderList = new List<OrderDetail>();

        public OrderingFormShohei(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            lblCust.Text = CustomerID;
            employeeID = EmployeeID;
            lblEmpl.Text = employeeID.ToString();
            custerd = Business.GetCustomer(CustomerID);
            txtShipName.Text = custerd.CompanyName;
            txtAddress.Text = custerd.Address;
            txtCity.Text = custerd.City;
            txtCountry.Text = custerd.Country;
            txtPost.Text = custerd.PostalCode;
            txtRegion.Text = custerd.Region;
        }

        private void OrderingFormShohei_Load(object sender, EventArgs e)
        {
            ProductList = Business.ProductList();
            ShipList.DataSource = Business.ShipperTable();
            ShipList.DisplayMember = "CompanyName";
            ShipList.ValueMember = "ShipperID";

            
            
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
            cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;

            TextBox p = new TextBox();
            p.Text = "Where Price";
            pnlProducts.Controls.Add(p);
            p.Top = t;
            p.Left = l + 120;
            p.Tag = n;

            TextBox q = new TextBox();
            q.Text = "Where quantity";
            pnlProducts.Controls.Add(q);
            q.Top = t;
            q.Left = l + 220;
            q.Tag = n;

            TextBox tot = new TextBox();
            tot.Text = "Where total";
            pnlProducts.Controls.Add(tot);
            tot.Top = t;
            tot.Left = l + 320;
            tot.Tag = n;

            TextBox dis = new TextBox();
            dis.Text = "Discount";
            pnlProducts.Controls.Add(dis);
            dis.Top = t;
            dis.Left = l + 420;
            dis.Tag = n;

            Button b = new Button();
            b.Text = "Cancel Item";
            pnlProducts.Controls.Add(b);
            b.Top = t;
            p.Tag = n;
            b.Left = l + 520;
            b.Tag = n;
            b.Click += Cancel_Order;

            t += 30;
        }

        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Cancel_Order(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal? freight;
            try
            {
                if (txtFreight.Text == "")
                    freight = null;
                else
                    freight = Convert.ToDecimal(txtFreight);



                Order SHoheiOrder = new Order(0, lblCust.Text, employeeID, DateTime.Now, DTRequired.Value, null, (int?)ShipList.SelectedValue,
                     freight, txtShipName.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPost.Text, txtCountry.Text);

                Business.SaveOrder(SHoheiOrder);
                lblOrderID.Text = SHoheiOrder.OrderID.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
