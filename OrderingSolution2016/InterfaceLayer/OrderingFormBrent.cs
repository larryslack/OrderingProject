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
    public partial class OrderingFormBrent : Form
    {
        string CurrentCustomer;
        int CurrentEmployee;

        List<Product> fer = Business.ProductList();

        public OrderingFormBrent()
        {
            //List<Product> = 
            InitializeComponent();
            //ProductBox.Items = 
        }

        public OrderingFormBrent(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            CurrentCustomer = CustomerID;
            CurrentEmployee = EmployeeID;
            //ProductBox.Items
            foreach (Product er in fer)
            {
                ProductBox.Items.Add(er.ProductName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if ((ProductBox.SelectedIndex >= 0) == false) //weird way to do it but im too lazy to look it up
                return;
            string AddToOrder = "";
            AddToOrder += ProductBox.SelectedItem.ToString();
            AddToOrder += " (" + QuantityUpdown.Value + ") : ";
            //decimal DaPrice = fer[ProductBox.SelectedIndex].UnitPrice;
            //DaPrice = (DaPrice * QuantityUpdown.Value);
            //AddToOrder += DaPrice.ToString("c");
            AddToOrder += PriceBox.Text;
            listBox1.Items.Add(AddToOrder);
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string thing = fer.items
            QuantityUpdown.Value = 1;
            decimal IShouldRenameThat = fer[ProductBox.SelectedIndex].UnitPrice;
            PriceBox.Text = IShouldRenameThat.ToString("c");
        }

        private void QuantityUpdown_ValueChanged(object sender, EventArgs e)
        {
            decimal DaPrice = fer[ProductBox.SelectedIndex].UnitPrice;
            DaPrice = (DaPrice * QuantityUpdown.Value);
            PriceBox.Text = DaPrice.ToString("c");
        }

    }
}
