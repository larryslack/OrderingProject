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

            decimal zero = 0;
            txtTotalCost.Text = zero.ToString("C");
            txtTotalQuantity.Text = zero.ToString();
            txtTotalDiscount.Text = zero.ToString("C");
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool allUsed = true;
            foreach (ProductPanel item in listProductPanel)
            {
                if (item.comboProduct.SelectedIndex == 0)
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
         

        public void GenerateProductPanel()
        {
            ProductPanel temp = new ProductPanel(panelProducts, 4, productList);
            temp.BringToFront();
            listProductPanel.Add(temp);
            temp.comboProduct.SelectedItem = null;
            temp.comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            temp.btnDelete.Click += (sender, e) =>
            {
                panelProducts.Controls.Remove(temp);
                listProductPanel.Remove(temp);
                updatepanelLocation();
            };
            updatepanelLocation();
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
