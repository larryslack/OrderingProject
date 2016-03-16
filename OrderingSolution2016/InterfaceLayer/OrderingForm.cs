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
        bool dontcheckcombobox = false;


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
            if (!dontcheckcombobox)
            {
                bool allUsed = true;
                foreach (ProductPanel item in listProductPanel)
                {
                    //item.txtPrice.Text = 
                    item.updatePrice();
                    if (item.comboProduct.SelectedItem == null)
                    {
                        allUsed = false;
                    }
                }
                if (allUsed)
                {
                    GenerateProductPanel();
                }
                updatecomboProducts();
            } 
        }

        private void updatecomboProducts()
        {
            dontcheckcombobox = true;
            foreach (ProductPanel itemupdating in listProductPanel)
            {
                itemupdating.productListInternal = new List<Product>(productList);
                Product tmpProduct = (Product)itemupdating.comboProduct.SelectedItem;

                foreach (ProductPanel item in listProductPanel)
                {
                    if (itemupdating != item && item.comboProduct.SelectedItem != null)
                    {
                        itemupdating.productListInternal.Remove((Product)item.comboProduct.SelectedItem);

                        itemupdating.comboProduct.DataSource = null;
                        itemupdating.comboProduct.DisplayMember = "ProductName";
                        itemupdating.comboProduct.ValueMember = "ProductID";
                        itemupdating.comboProduct.DataSource = itemupdating.productListInternal;

                        
                    }
                }

                itemupdating.comboProduct.SelectedItem = tmpProduct;
            }            
            dontcheckcombobox = false;
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

            foreach (ProductPanel item in listProductPanel)
            {
                if (item.comboProduct.SelectedItem != null)
                {
                    temp.productListInternal.Remove((Product)item.comboProduct.SelectedItem);
                }
            }
            temp.comboProduct.DataSource = temp.productListInternal;
            temp.comboProduct.SelectedItem = null;
            temp.comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            temp.updPrice += temp_updPrice;
            temp.updPercent += temp_updPercent;
            temp.btnDelete.Click += btnDelete_Click;
            updatepanelLocation();

        }

        void temp_updPercent()
        {
            foreach (ProductPanel item in listProductPanel)
            {
                string tmp = item.txtDiscount.Text;
                tmp = tmp.Replace("%", "");
                item.txtDiscount.Text = string.Format("{0}%", tmp);
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            ProductPanel item = (ProductPanel)((Button)sender).Parent;

            panelProducts.Controls.Remove(item);
            listProductPanel.Remove(item);
            updatepanelLocation();
            udpateprice();
            updatecomboProducts();
            //foreach (ProductPanel item in listProductPanel)
            //{
            //    if (item.comboProduct.SelectedItem == null)
            //    {                    
            //        panelProducts.Controls.Remove(item);
            //        listProductPanel.Remove(item);
            //        GenerateProductPanel();
            //        break;
            //    }
            //}
            
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
            foreach (ProductPanel item in listProductPanel)
            {
                if (item.comboProduct.SelectedItem == null)
                {
                    item.btnDelete.Visible = false;
                }
                else
                {
                    item.btnDelete.Visible = true;
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (ProductPanel item in listProductPanel)
            {
                
                
                break;
            }
            

        }
    }
}
