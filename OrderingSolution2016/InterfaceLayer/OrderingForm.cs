using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BaseLayer;

namespace InterfaceLayer
{
    public partial class OrderingForm : Form
    {

        string CustomerID;
        int EmployeeID;
        List<ProductPanel> listProductPanel = new List<ProductPanel>();
        List<Product> productList = Business.ProductList();
        Customer CustomerActive;

        public OrderingForm(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblCustomerID.Text = CustomerID;
            lblEmployeeID.Text = EmployeeID.ToString();
            
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {
            GenerateProductPanel();
            DateMethod();
            CustomerActive = Business.GetCustomer(CustomerID);

            decimal zero = 0;
            txtTotalCost.Text = zero.ToString("C");
            txtTotalQuantity.Text = zero.ToString();
            txtTotalDiscount.Text = zero.ToString("C");
            
            cmbShipVia.DataSource = Business.ShipperTable();
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShipVia.SelectedIndex = -1;

            txtPostalCode.Text = CustomerActive.PostalCode;
            txtRegion.Text = CustomerActive.Region;
            txtAddress.Text = CustomerActive.Address;
            txtCity.Text = CustomerActive.City;
            txtCountry.Text = CustomerActive.Country;
            txtRegion.Text = CustomerActive.Region;
            txtFax.Text = CustomerActive.Fax;
            txtPhone.Text = CustomerActive.Phone;
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {            
            bool allUsed = true;
            foreach (ProductPanel item in listProductPanel)
            {
                //item.txtPrice.Text = 
                item.updatePrice();
                if (item.comboProduct.SelectedIndex == null)
                {
                    allUsed = false;
                }
            }
            if (allUsed)
            {
                GenerateProductPanel();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateProductPanel();
        }

        public void udpateprice()
        {
            decimal totalLineItem = 0;

            foreach (ProductPanel item in listProductPanel)
            {
                try
                {
                    totalLineItem += (decimal.Parse(item.txtPrice.Text.Replace("$", "")) * decimal.Parse(item.txtQuantity.Text)) -
                    (decimal.Parse(item.txtPrice.Text.Replace("$", "")) * decimal.Parse(item.txtQuantity.Text) *
                    (decimal.Parse(item.txtDiscount.Text.Replace("%", "")) / 100));
                }
                catch (Exception)
                {
                }
                
            }
            txtTotalCost.Text = totalLineItem.ToString("C");
        }
        public void DateMethod()
        {
            txtDate.Enter += (sender, e) =>
            {
                if (txtDate.Text == "DD/MM/YYYY")
                {
                    txtDate.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                    txtDate.Text = "";
                }
            };

            txtDate.Leave += (sender, e) =>
            {
                if (txtDate.Text == "")
                {
                    txtDate.ForeColor = Color.Gray;
                    txtDate.Text = "DD/MM/YYYY";
                }
            };
        }
        public void GenerateProductPanel()
        {
            ProductPanel temp = new ProductPanel(panelProducts, 4, productList);
            temp.BringToFront();
            listProductPanel.Add(temp);
            temp.comboProduct.SelectedItem = null;
            temp.comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            temp.updPrice += temp_updPrice;
            temp.btnDelete.Click += (sender, e) =>
            {
                panelProducts.Controls.Remove(temp);
                listProductPanel.Remove(temp);
                updatepanelLocation();
            };
            updatepanelLocation();
        }

        void temp_updPrice()
        {
            udpateprice();
        }

        private void updatepanelLocation()
        {
            int ylocation = 4;
            foreach (ProductPanel item in listProductPanel)
            {
                item.Location = new System.Drawing.Point(4, ylocation);
                ylocation += 28;
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
