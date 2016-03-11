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

    public partial class btnProSave : Form
    {

        int n = 0;

        int l = 3;
        int employeeID;
        Customer custerd;
        List<Product> ProductList = new List<Product>();

        List<Panel> pnlList = new List<Panel>();
        List<ComboBox> cmbList = new List<ComboBox>();
        List<TextBox> txtPriceList = new List<TextBox>();
        List<TextBox> txtQuantityList = new List<TextBox>();
        List<TextBox> txtDiscountList = new List<TextBox>();
        List<Button> btnRemoveList = new List<Button>();
        



        public btnProSave(string CustomerID, int EmployeeID)
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
            
            Panel ProductPanel = new Panel();
            ProductPanel.Height = 30;
            ProductPanel.Width = 500;
            pnlProducts.Controls.Add(ProductPanel);
            ProductPanel.BorderStyle = BorderStyle.FixedSingle;
            pnlList.Add(ProductPanel);

            ComboBox cmb = new ComboBox();
            ProductPanel.Controls.Add(cmb);
            cmb.Left = l;
            cmb.Tag = n;
            cmb.DataSource = new List<Product>(ProductList);
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
            cmbList.Add(cmb);

            TextBox p = new TextBox();
            p.Text = "Where Price";
            ProductPanel.Controls.Add(p);
            p.Left = l + 120;
            p.Tag = n;
            txtPriceList.Add(p);

            TextBox q = new TextBox();
            q.Text = "Where quantity";
            ProductPanel.Controls.Add(q);
            q.Left = l + 220;
            q.Tag = n;
            txtQuantityList.Add(q);

            TextBox dis = new TextBox();
            dis.Text = "Discount";
            ProductPanel.Controls.Add(dis);
            dis.Left = l + 320;
            dis.Tag = n;
            txtDiscountList.Add(dis);

            Button b = new Button();
            b.Text = "Remove";
            ProductPanel.Controls.Add(b);
            p.Tag = n;
            b.Left = l + 420;
            b.Tag = n;
            b.Click += Remove_Order;
            btnRemoveList.Add(b);

            n++;
            sortPanel();
        }

        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thiscmb = (ComboBox)sender;
            int index;
            if (thiscmb.SelectedIndex >= 0)
            {
                index = cmbList.IndexOf(thiscmb);
                txtPriceList[index].Text = ProductList[thiscmb.SelectedIndex].UnitPrice.ToString();
                txtQuantityList[index].Text = ProductList[thiscmb.SelectedIndex].QuantityPerUnit.ToString();
                
            }
        }

        void Remove_Order(object sender, EventArgs e)
        {
            Button thisbtn = (Button)sender;
            int index;
            index = btnRemoveList.IndexOf(thisbtn);
            cmbList.RemoveAt(index);
            txtPriceList.RemoveAt(index);
            txtQuantityList.RemoveAt(index);
            txtDiscountList.RemoveAt(index);
            btnRemoveList.RemoveAt(index);

            pnlProducts.Controls.Remove(pnlList[index]);
            pnlList.RemoveAt(index);

            sortPanel();
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

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnlList.Count; i++)
            {

            }
        }

        private void sortPanel()
        {
            int t = 0;
            foreach (Panel tmp in pnlList)
            {
                tmp.Top = t;
                tmp.Left = 0;
                t += 30;
            }
        }
    }
}
